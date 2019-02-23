using SmartDriverAPI.Interfaces;
using System.Collections.Generic;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DecoderResponse: IDecoderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<IDecodedDataResponse> Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
