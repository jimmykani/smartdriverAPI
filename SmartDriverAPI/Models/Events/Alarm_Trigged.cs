using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models.Events
{
    /// <summary>
    /// 
    /// </summary>
    public class Alarm_Trigged : IBiotecEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public Alarm_Trigged()
        {
            EventName = "Alarm Trigged";
        }
        /// <summary>
        /// 
        /// </summary>
        public string EventName { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string EventSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Power_cut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Moved { get; set; }
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
        public int Towing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reserved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Input_Low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Input_High { get; set; }
        /// <summary>
        /// not used
        /// </summary>
        public int Reserved1 { get; set; }
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
        public int Reserved2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reserved3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Accident { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Battery_low { get; set; }

       
    }
}
