namespace SmartDriverAPI.Interfaces
{
    /// <summary>
    /// decoder request object. user can send the data line in string or binary format
    /// </summary>
    public interface IDecoderRequest
    {
        /// <summary>
        /// decoder data in string format
        /// </summary>
        string StringData { get; set; }
        /// <summary>
        /// binary data 
        /// </summary>
        byte[] BinaryData { get; set; }
     
    }
}
