using System.ComponentModel;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class enums
    {/// <summary>
    /// 
    /// </summary>
        public enum eventInfo0
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("None")]
            None,
            /// <summary>
            /// 
            /// </summary>
            [Description("Interval upload")]
            Interval_upload,
            /// <summary>
            /// 
            /// </summary>
            [Description("Angle change upload")]
            Angle_Change_upload,
            /// <summary>
            /// 
            /// </summary>
            [Description("Distance upload")]
            Distance_upload,
            /// <summary>
            /// 
            /// </summary>
            [Description("Request upload")]
            Reques_upload,
        }
        /// <summary>
        /// 
        /// </summary>
        public enum eventInfo1
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("Rfid reader")]
            Rfid_reader,
            /// <summary>
            /// 
            /// </summary>
            [Description("iBeacon")]
            iBeacon,
        }
        /// <summary>
        /// 
        /// </summary>
        public enum infoStatus
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("Power cut")]
            Power_cut,
            /// <summary>
            /// 
            /// </summary>
            [Description("Moving")]
            Moving,
            /// <summary>
            /// 
            /// </summary>
            [Description("Over speed")]
            Over_speed,
            /// <summary>
            /// 
            /// </summary>
            [Description("Jamming")]
            Jamming,
            /// <summary>
            /// 
            /// </summary>
            [Description("Geo-fence alarming")]
            Geo_fence_alarming,
            /// <summary>
            /// 
            /// </summary>
            [Description("Immobolizer")]
            Immobolizer,
            /// <summary>
            /// 
            /// </summary>
            [Description("ACC")]
            ACC,
            /// <summary>
            /// 
            /// </summary>
            [Description("Input high level")]
            Input_high_level,
            /// <summary>
            /// 
            /// </summary>
            [Description("Input mid level")]
            Input_mid_level,
            /// <summary>
            /// 
            /// </summary>
            [Description("Engine")]
            Engine,
            /// <summary>
            /// 
            /// </summary>
            [Description("Panic")]
            Panic,
            /// <summary>
            /// 
            /// </summary>
            [Description("OBD alarm")]
            OBD_alarm,
            /// <summary>
            /// 
            /// </summary>
            [Description("Course rapid change")]
            Course_rapid_change,
            /// <summary>
            /// 
            /// </summary>
            [Description("Speed rapid change")]
            Speed_rapid_change,
            /// <summary>
            /// 
            /// </summary>
            [Description("Roaming")]
            Roaming,
            /// <summary>
            /// 
            /// </summary>
            [Description("Inter roaming")]
            Inter_roaming,

        }
        /// <summary>
        /// 
        /// </summary>
        public enum infoAlarm
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("Power cut")]
            Power_cut,
            /// <summary>
            /// 
            /// </summary>
            [Description("Moving")]
            Moving,
            /// <summary>
            /// 
            /// </summary>
            [Description("Over speed")]
            Over_speed,
            /// <summary>
            /// 
            /// </summary>
            [Description("Jamming")]
            Jamming,
            /// <summary>
            /// 
            /// </summary>
            [Description("Geo-fence")]
            Geo_fence,
            /// <summary>
            /// 
            /// </summary>
            [Description("Towing")]
            Towing,
            /// <summary>
            /// 
            /// </summary>
            [Description("Reserved")]
            Reserved,
            /// <summary>
            /// 
            /// </summary>
            [Description("Input Low")]
            Input_Low,
            /// <summary>
            /// 
            /// </summary>
            [Description("Input High")]
            Input_High,
            /// <summary>
            /// not used
            /// </summary>
            [Description("Reserved")]
            Reserved1,
            /// <summary>
            /// 
            /// </summary>
            [Description("Panic")]
            Panic,
            /// <summary>
            /// 
            /// </summary>
            [Description("OBD")]
            OBD,
            /// <summary>
            /// 
            /// </summary>
            [Description("Reserved")]
            Reserved2,
            /// <summary>
            /// not used
            /// </summary>
            [Description("Reserved")]
            Reserved3,
            /// <summary>
            /// 
            /// </summary>
            [Description("Accident")]
            Accident,
            /// <summary>
            /// 
            /// </summary>
            [Description("Battery low")]
            Battery_low,

        }
        /// <summary>
        /// 
        /// </summary>
        public enum infoAdc
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("Car Battery")]
            Car_Battery,
            /// <summary>
            /// 
            /// </summary>
            [Description("Device Temp")]
            Device_Temp,
            /// <summary>
            /// 
            /// </summary>
            [Description("Inner Battery")]
            Inner_Battery,
            /// <summary>
            /// 
            /// </summary>
            [Description("Input voltage")]
            Input_voltage,

        }
        /// <summary>
        /// 
        /// </summary>
        public enum infoUnit
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("(V)")]
            Volts,
            /// <summary>
            /// 
            /// </summary>
            [Description("Celsius")]
            Celsius,
            /// <summary>
            /// 
            /// </summary>
            [Description("(V)")]
            Volts1,
            /// <summary>
            /// 
            /// </summary>
            [Description("(V)")]
            Volts2,
 

        }
        /// <summary>
        /// 
        /// </summary>
        public enum infoBehavior
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("Rapid acceleration")]
            Rapid_acceleration,
            /// <summary>
            /// 
            /// </summary>
            [Description("Rough braking")]
            Rough_braking,
            /// <summary>
            /// 
            /// </summary>
            [Description("Harsh course")]
            Harsh_course,
            /// <summary>
            /// 
            /// </summary>
            [Description("No warmup")]
            No_warmup,
            /// <summary>
            /// 
            /// </summary>
            [Description("Long idle")]
            Long_idle,
            /// <summary>
            /// 
            /// </summary>
            [Description("Fatigue driving")]
            Fatigue_driving,
            /// <summary>
            /// 
            /// </summary>
            [Description("Rough terrain")]
            Rough_terrain,
            /// <summary>
            /// 
            /// </summary>
            [Description("High RPM")]
            High_RPM,

        }
        /// <summary>
        /// 
        /// </summary>
        public enum FileType
        {
            /// <summary>
            /// 
            /// </summary>
            Binary,
            /// <summary>
            /// 
            /// </summary>
            Text
        }
        /// <summary>
        /// 
        /// </summary>
        public enum DecoderType
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("LBS")]
            LBS,
            /// <summary>
            /// 
            /// </summary>
            [Description("GPS")]
            GPS,
            /// <summary>
            /// 
            /// </summary>
            [Description("STT")]
            STT,
            /// <summary>
            /// 
            /// </summary>
            [Description("MGR")]
            MGR,
            /// <summary>
            /// 
            /// </summary>
            [Description("ADC")]
            ADC,
            /// <summary>
            /// 
            /// </summary>
            [Description("GFS")]
            GFS,
            /// <summary>
            /// 
            /// </summary>
            [Description("OBD")]
            OBD,
            /// <summary>
            /// 
            /// </summary>
            [Description("OAL")]
            OAL,
            /// <summary>
            /// 
            /// </summary>
            [Description("FUL")]
            FUL1,
            /// <summary>
            /// 
            /// </summary>
            [Description("HDB")]
            HDB,
            /// <summary>
            /// 
            /// </summary>
            [Description("CAN")]
            CAN,
            /// <summary>
            /// 
            /// </summary>
            [Description("HVD")]
            HVD,
            /// <summary>
            /// 
            /// </summary>
            [Description("VIN")]
            VIN,
            /// <summary>
            /// 
            /// </summary>
            [Description("RFI")]
            RFI,
            /// <summary>
            /// 
            /// </summary>
            [Description("EVT")]
            EVT,
            /// <summary>
            /// 
            /// </summary>
            [Description("BCN")]
            BCN,
            /// <summary>
            /// 
            /// </summary>
            [Description("EGT")]
            EGT,

            /// <summary>
            /// 
            /// </summary>
            [Description("TRP")]
            TRP
        }
    }
}
