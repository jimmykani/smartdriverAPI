using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models.Events
{
    /// <summary>
    /// vent class for status change
    /// </summary>
    public class Device_Status_Changed : IBiotecEvent
    {
        /// <summary>
        /// constructor
        /// </summary>
        public Device_Status_Changed()
        {
            EventName = "Device Status Changed";
        }
        /// <summary>
        /// Name of the event
        /// </summary>
        public string EventName { get; private set; }
        /// <summary>
        /// event source
        /// </summary>
        public string EventSource { get; set; }
        /// <summary>
        /// return 1 when Power off
        /// </summary>
        public int Power_cut { get; set; }
        /// <summary>
        /// return 1 when the vehile is in moving status
        /// </summary>
        public int Moving { get; set; }
        /// <summary>
        /// return 1 when over speed
        /// 
        /// </summary>
        public int Over_speed { get; set; }
        /// <summary>
        /// return 1 when jamming
        /// </summary>
        public int Jamming { get; set; }
        /// <summary>
        /// return 1 when Geo fence active
        /// </summary>
        public int Geo_fence { get; set; }
        /// <summary>
        /// return 1 when in Immobolizer status
        /// </summary>
        public int Immobolizer { get; set; }
        /// <summary>
        /// return 1 in acc 
        /// </summary>
        public int ACC { get; set; }
        /// <summary>
        /// return 1 in high level input
        /// 
        /// </summary>
        public int Input_high_level { get; set; }
        /// <summary>
        /// return 1 in mid level input
        /// </summary>
        public int Input_mid_level { get; set; }
        /// <summary>
        /// return 1 in engine on
        /// 
        /// </summary>
        public int Engine { get; set; }
        /// <summary>
        /// return 1 when panic button on
        /// </summary>
        public int Panic { get; set; }
        /// <summary>
        /// return 1 on obd data
        /// </summary>
        public int OBD { get; set; }
        /// <summary>
        /// retirn 1 on Course rapid change
        /// </summary>
        public int Course_rapid_change { get; set; }
        /// <summary>
        /// retirn 1 on Speed rapid change
        /// </summary>
        public int Speed_rapid_change { get; set; }
        /// <summary>
        ///  retirn 1 on Roaming change
        /// </summary>
        public int Roaming { get; set; }
        /// <summary>
        ///  retirn 1 on Inter roaming change
        /// </summary>
        public int Inter_roaming { get; set; }
    }
}
