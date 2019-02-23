using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models.Events
{
    /// <summary>
    /// class for showing Geo Fence change event
    /// </summary>
    public class GeoFence_Changed : IBiotecEvent
    {
        /// <summary>
        /// constructor
        /// </summary>
        public GeoFence_Changed()
        {
            EventName = "GeoFence Changed";
        }
        /// <summary>
        /// name of the event return the name of the event
        /// </summary>
        public string EventName { get; private set; }

        /// <summary>
        /// return the source of event
        /// </summary>
        public string EventSource { get; set; }
        /// <summary>
        /// return the details of event 
        /// </summary>
        public string EventString { get; set; }
    }
}
