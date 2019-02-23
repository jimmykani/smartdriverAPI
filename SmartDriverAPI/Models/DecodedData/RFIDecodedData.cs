using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class RFIDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public RFIDecodedData()
        {
            DecoderType = DecoderType.RFI;
        }
        /// <summary>
        /// 
        /// </summary>
        public DecoderType DecoderType { get; private set; }
        //public string DeviceId { get; set; }

        //public DateTime PacketDate { get; set; }
        //public int SeqNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RFID { get; set; }

    }
}
