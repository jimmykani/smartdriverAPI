using System.Collections.Generic;

namespace SmartDriverAPI.Interfaces
{
    /// <summary>
    /// interface for Idecoder 
    /// </summary>
    public interface IDecoderResponse
    {
        /// <summary>
        /// response data for decoded data
        /// </summary>
        List<IDecodedDataResponse> Data { get; set; }
        /// <summary>
        /// status of resonse
        /// </summary>
        bool Status { get; set; }
        /// <summary>
        /// error message . this will return error message if any error occerd during the decode process
        /// </summary>
        string ErrorMessage { get; set; }
    }
}
