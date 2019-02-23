using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class LBSDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public LBSDecodedData()
        {
            DecoderType = DecoderType.LBS;
        }
        /// <summary>
        /// 
        /// </summary>
        public DecoderType DecoderType { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        //public string DeviceId { get; set; }

        //public DateTime PacketDate { get; set; }
        //public int SeqNo { get; set; }
        public int MCC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MNC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int LAC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte dbm { get; set; }
    }
}
