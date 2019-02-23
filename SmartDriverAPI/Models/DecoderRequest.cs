using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DecoderRequest: IDecoderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string StringData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] BinaryData { get; set; }
    }
}
