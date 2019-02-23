using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class MGRDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public MGRDecodedData()
        {
            DecoderType = DecoderType.MGR;
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
        public uint Mileage { get; set; }

    }
}
