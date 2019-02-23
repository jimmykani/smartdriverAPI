namespace SmartDriverAPI.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBiotecEvent
    {
        /// <summary>
        /// 
        /// </summary>
        string EventName { get; }
        /// <summary>
        /// 
        /// </summary>
        string EventSource { get; set; }
    }
}
