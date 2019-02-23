using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models.Events
{
    /// <summary>
    /// harsh driving bhavior
    /// </summary>
    public class HashDriving: IBiotecEvent
    {
        /// <summary>
        /// constructor
        /// </summary>
        public HashDriving()
        {
            EventName = "Hash Driving";
        }
        /// <summary>
        /// name of event 
        /// </summary>
        public string EventName { get; private set; }
        /// <summary>
        /// source of event
        /// </summary>
        public string EventSource { get; set; }
        /// <summary>
        /// Rapid Acceleration event return 1 when Rapid_Acceleration occered
        /// 
        /// </summary>
        public int Rapid_Acceleration { get; set; }
        /// <summary>
        /// return 1 when Rough Braking 
        /// </summary>
        public int Rough_Braking { get; set; }
        /// <summary>
        /// return when Harsh Course occered
        /// </summary>
        public int Harsh_Course { get; set; }
        /// <summary>
        /// return 1 when now Warmup
        /// </summary>
        public int No_Warmup { get; set; }
        /// <summary>
        /// return 1 when the vehile is in idle for long time
        /// </summary>
        public int Long_Idle { get; set; }
        /// <summary>
        /// return 1 on Fatigue Driving behavior
        /// </summary>
        public int Fatigue_Driving { get; set; }
        /// <summary>
        /// return 1 on Rough Terrain
        /// </summary>
        public int Rough_Terrain { get; set; }
        /// <summary>
        /// return 1 on High RPM
        /// </summary>
        public int High_RPM { get; set; }
    }
}
