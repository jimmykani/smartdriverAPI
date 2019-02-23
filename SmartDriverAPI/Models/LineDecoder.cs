using System;
using System.Collections.Generic;
using System.Diagnostics;
using SmartDriverAPI.Helper;
using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;
using System.Text;
using System.Threading.Tasks;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class LineDecoder
    {
     
      //  private static ILogger Logger { get; } =   ApplicationLogging.CreateLogger<Program>();
        private DateTime packetdate =DateTime.MinValue;
        private string deviceid=null;
        /// <summary>
        /// 
        /// </summary>
        protected List<IDecodedDataResponse> _dataRepository;
        /// <summary>
        /// 
        /// </summary>
        public List<IDecodedDataResponse> DecodedData { get { return _dataRepository; } }
        public DateTime PacketDate
        {
            get
            { return packetdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeviceId { get { return deviceid; } }
        /// <summary>
        /// 
        /// </summary>
        public LineDecoder()
        {
            _dataRepository = new List<IDecodedDataResponse>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>

        public async Task<int> DecodeDataLine(string input)
        {
           
            var res = new DecoderResponse();

            byte[] buffer = Encoding.ASCII.GetBytes(input);
            if (buffer.Length == 0)
            {
                //OutputText("Empty data!");
                return 0;
            }
            int Offset = 0;
            while (Offset + Utility.MinPacketLen < buffer.Length)
            {
                if (buffer[Offset] == Utility.txtStartChar)//Text frame start flag
                {
                    int endPos = Array.IndexOf(buffer, System.Convert.ToByte(Utility.txtEndChar), Offset + 1);//Get Text frame end flag position
                    if (endPos == -1 || (endPos - Offset) < 20 || !Utility.TextFrameFormatCheck(buffer, Offset, endPos))//Check Text frame format
                    {
                        Offset++;
                        continue;
                    }

                    String strFrame = System.Text.Encoding.ASCII.GetString(buffer, Offset, endPos - Offset + 1);
                    
                    var reData =  TextFrameDecode(strFrame);
                    _dataRepository.Add((IDecodedDataResponse)DataResponseCreater.CreateDataResponse(reData.Result, packetdate, deviceid));
                    Offset = endPos + 1;
                }
                else if (buffer[Offset] == Utility.binFlagChar)//Binary packet flag
                {
                    int endPos = Array.IndexOf(buffer, System.Convert.ToByte(Utility.binFlagChar), Offset + 1);//Get binary frame end flag position
                    if (endPos == -1 || (endPos - Offset) < 12)
                    {
                        Offset++;
                        continue;
                    }

                    String strHexFrame = "";
                    for (int i = Offset; i < endPos + 1; i++)
                    {
                        strHexFrame += String.Format("{0:X2} ", buffer[i]);
                    }
                  //  OutputText(String.Format("BIN frame: {0}\r\n", strHexFrame));

                    byte[] binFrame = new byte[endPos - Offset - 1];
                    Array.Copy(buffer, Offset + 1, binFrame, 0, binFrame.Length);
                    int datalen = Utility.BinFrameFormatCheck(binFrame);
                    if (datalen <= 0)
                    {
                       // OutputText("    CRC check error\r\n");
                        Offset++;
                        continue;
                    }
                    
                    var reData = BinFrameDecode(binFrame, datalen);
                     
                    _dataRepository.Add((IDecodedDataResponse)DataResponseCreater.CreateDataResponse(reData.Result, packetdate, deviceid));
                    Offset = endPos + 1;
                }
                else
                {
                    Offset++;
                }
            }
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataline"></param>
        /// <returns></returns>
        public async Task<List<IDecodedData>> TextFrameDecode(string dataline)
        {



            var result = new List<IDecodedData>();
            //   string[] infoKeyWords = { "GPS", "LBS", "STT", "MGR", "ADC", "GFS", "OBD", "OAL", "FUL", "HDB", "CAN", "HVD", "VIN", "RFI", "EVT", "BCN", "EGT" };
            //OutputText(String.Format("TXT frame: {0}\r\n", str));
            dataline = dataline.Substring(0, dataline.Length - 1);
            string[] info = dataline.Split(',');
            if (info.GetLength(0) < 4 || info[0] != String.Format("*TS{0:d2}", Utility.ProtocolVersion))
            {
                // OutputText(String.Format("{0}Frame error!\r\n", TabChars));
                // OutputText("\r\n");
                return result;
            }
            deviceid = info[1];
            // OutputText(String.Format("{0}Device ID: {1}\r\n", TabChars, info[1]));

            if (info[2].Length != 12 || info[2] == "000000000000")
            {
                // OutputText(String.Format("{0}Time stamp: {1}\r\n", TabChars, "Unknown"));
            }
            else
            {
               // if (packetdate==DateTime.MinValue)
                packetdate = Utility.GetDateTimeFromString(info[2]);
               
                // OutputText(String.Format("{0}Time stamp: {1}\r\n", TabChars, GetDateTimeFromString(info[2])));
            }

            for (int i = 3; i < info.GetLength(0); i++)
            {
                int keyIndex;
                string shadeName = "";
                bool ItemFind=false;
                string ItemData="";
                for (keyIndex = 0; keyIndex < Enum.GetValues(typeof(DecoderType)).Length; keyIndex++)
                {
                     string[] head = info[i].Split(':');
                    shadeName = ((DecoderType)keyIndex).ToString();
                    if (shadeName == head[0]){
                        ItemFind=true;
                        ItemData=info[i].Substring(head[0].Length+1);// head[1];
                        break;
                    }           
                }
                if (!ItemFind)
                    continue;
                Debug.WriteLine(packetdate);
                IDecoder datadecoder = DecoderFactory.GetDecoder(FileType.Text, (DecoderType)keyIndex);
                var IDecodedData = datadecoder.Decode(ItemData);
                result.Add(IDecodedData);
            }
            return await Task.FromResult(result); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dat"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public async Task<List<IDecodedData>>  BinFrameDecode(byte[] dat, int len)
        {
            var result = new List<IDecodedData>();

            if (len < 10)
                return result;
            int pos = 0;
            if (dat[pos] != Utility.ProtocolVersion)
            {
                // OutputText(String.Format("    Can not support protocol version: {0:X2}", dat[pos]));
                return result;
            }
            pos++;
            if (dat[pos] != 0x01)
            {
                // OutputText(String.Format("    Can not support frame NO: {0:X2}", dat[pos]));
                return result;
            }

            pos++;
            deviceid = "";
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                    deviceid += dat[pos++].ToString("X");
                else
                    deviceid += dat[pos++].ToString("X2");
            }
          //  string TabChars = "    ";
           // OutputText(String.Format("{0}Device ID: {1}\r\n", TabChars, DeviceID));

            UInt32 timeSeconds = Utility.ReadUint32(dat, pos);
            pos += 4; ;
            DateTime packetdate = DateTime.MinValue;

            bool Fix3D = (timeSeconds & 0x80000000) != 0;
            timeSeconds &= 0x7FFFFFFF;
            if (timeSeconds == 0)
            {
               // OutputText(String.Format("{0}Time stamp: {1}\r\n", TabChars, "Unknown"));
            }
            else
            {
                DateTime dtOffset = new DateTime(2000, 1, 1, 0, 0, 0);
                packetdate = new DateTime(dtOffset.Ticks + (long)timeSeconds * 10000000);
               // OutputText(String.Format("{0}Time stamp: {1}\r\n", TabChars, dt));
            }

            while (pos < len - 2)
            {
                byte infoId = dat[pos++];
                int _seqNo=1;
                int infoLen;
                switch (infoId)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9://GPS
                    case 0x0A://HDB
                    case 0x0C://HVD--J1708 data
                    case 0x0D://VIN
                    case 0x0E://RFI
                    case 0x0F://EGT
                    case 0x10://EVT
                        {
                            infoLen = dat[pos++];
                            byte[] infoData = new byte[infoLen];
                            Array.Copy(dat, pos, infoData, 0, infoLen);
                            IDecoder datadecoder = DecoderFactory.GetDecoder(FileType.Binary, (DecoderType)infoId);
                            var IDecodedData = datadecoder.Decode(infoData, Fix3D);
                            result.Add(IDecodedData);
                            break;
                        }
                    case 0x0B://CAN--J1939 data
                    case 0x3F://BCN--iBeacon info data

                        {
                            infoLen = dat[pos++];
                            infoLen = infoLen * 256 + dat[pos++];
                            byte[] infoData = new byte[infoLen];
                            Array.Copy(dat, pos, infoData, 0, infoLen);
                            IDecoder datadecoder = DecoderFactory.GetDecoder(FileType.Binary, (DecoderType)infoId);
                            var IDecodedData = datadecoder.Decode(infoData, Fix3D);
                            result.Add(IDecodedData);
                            break;
                        }
                    default:
                        infoLen = dat[pos++];
                        break;
                }
                pos += infoLen;
                _seqNo++;
            }
            return await Task.FromResult(result); ;
        }
    }
}
