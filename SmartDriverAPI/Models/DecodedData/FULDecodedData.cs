using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class FULDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public FULDecodedData()
        {
            DecoderType = DecoderType.FUL1;
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
        public double Fuel_Consumed{ get; set; }
}
}
