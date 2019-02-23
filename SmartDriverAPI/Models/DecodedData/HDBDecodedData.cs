using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class HDBDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public HDBDecodedData()
        {
            DecoderType = DecoderType.HDB;
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
        public int Rapid_Acceleration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Rough_Braking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Harsh_Course { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int No_Warmup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Long_Idle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Fatigue_Driving { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Rough_Terrain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int High_RPM { get; set; }

    }
}
