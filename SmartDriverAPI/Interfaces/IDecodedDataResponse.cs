namespace SmartDriverAPI.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDecodedDataResponse
    {
        /// <summary>
        /// 
        /// </summary>
        IDecodedData LBS {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData GPS {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData STT {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData MGR {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData ADC {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData GFS {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData OBD {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData OAL {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData FUL {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData HDB {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData CAN {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData HVD {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData VIN {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData RFI {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData EVT {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData BCN {get; set;}
        /// <summary>
        /// 
        /// </summary>
        IDecodedData EGT {get; set;}
        IDecodedData TRP { get; set; }
    }
}
