using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class HVDDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public HVDDecodedData()
        {
            DecoderType = DecoderType.HVD;
        }
        /// <summary>
        /// 
        /// </summary>
        public DecoderType DecoderType { get; private set; }
        //public string DeviceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public DateTime PacketDate { get; set; }
        //public int SeqNo { get; set; }
        public string MID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Road_speed { get; set; }
        /// <summary>
        /// /
        /// </summary>
        public double Fuel_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte Engine_Coolant_Temperature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Engine_speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Total_Vehicle_Distance { get; set; }
    }
}
