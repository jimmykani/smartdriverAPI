using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class STTDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public STTDecodedData()
        {
            DecoderType = DecoderType.STT;
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
        public int Power_cut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Moving { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Over_speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Jamming { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Geo_fence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Immobolizer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ACC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Input_high_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Input_mid_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Engine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Panic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OBD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Course_rapid_change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Speed_rapid_change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Roaming { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Inter_roaming { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Power_cut_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Moving_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Over_speed_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Jamming_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Geo_fence_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Towing_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reserved_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Input_Low_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Input_High_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reserved1_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Panic_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OBD_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reserved2_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reserved3_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Accident_alaram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Battery_low_alaram { get; set; }

    }
}
