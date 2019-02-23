using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class OBDDecodedData: IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public OBDDecodedData()
        {
            DecoderType = DecoderType.OBD;
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
         public int DTC_CNT{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string MIL{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string MIS_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string FUEL_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string CCM_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string MIS_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string FUEL_RDY{ get; set; } 
        /// <summary>
        /// 
        /// </summary>
         public string CCM_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string CAT_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string HCAT_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string EVAP_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string AIR_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string ACRF_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string O2S_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string HTR_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string EGR_SUP{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string CAT_RDY{ get; set; } 
        /// <summary>
        /// 
        /// </summary>
         public string HCAT_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string EVAP_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string AIR_RDY{ get; set; } 
        /// <summary>
        /// 
        /// </summary>
         public string ACRF_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string O2S_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string HTR_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public string EGR_RDY{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double LOAD_Value{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Engine_Coolant_Temperature { get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Short_Term_Fuel_Trim_Bank1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Short_Term_Fuel_Trim_Bank2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Long_Term_Fuel_Trim_Bank1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Long_Term_Fuel_Trim_Bank2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Fuel_Rail_Pressure { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Intake_Manifold_Absolute_Pressure { get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double  Engine_RPM{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public int Vehicle_Speed{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Ignition_Timing_Advance { get; set; }
        /// <summary>
        /// 
        /// </summary>
         public int Intake_Air_Temperature{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Flow_Rate_Mass_Air_Flow_Sensor{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Absolute_Throttle_Position{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public int Distance_Travelled_MIL_Activated{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Fuel_level{ get; set; }
        /// <summary>
        /// 
        /// </summary>
         public double Distance_traveled{ get; set; }
        /// <summary>
        /// /
        /// </summary>
         public string Dtcs { get; set; }

    }
}
