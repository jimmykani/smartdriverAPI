using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class GFSDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public GFSDecodedData()
        {
            DecoderType = DecoderType.GFS;
        }
        /// <summary>
        /// 
        /// </summary>
        public DecoderType DecoderType { get; private set; }
        //public string DeviceId { get; set; }

        //public DateTime PacketDate { get; set; }
        //public int SeqNo { get; set; }

    }
}
