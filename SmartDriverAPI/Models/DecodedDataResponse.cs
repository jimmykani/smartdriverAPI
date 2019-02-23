using SmartDriverAPI.Interfaces;
using System;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DecodedDataResponse : IDecodedDataResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceid"></param>
        /// <param name="packetdate"></param>
        public DecodedDataResponse(string deviceid, DateTime packetdate)
        {
            DeviceId = deviceid;
            PacketDate = packetdate;
         }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PacketDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData ADC { get; set; }
        /// <summary>
        /// 
        /// </summary>
       
        public IDecodedData BCN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData CAN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData EGT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData EVT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData FUL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData GFS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData GPS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData HDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData HVD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData LBS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData MGR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData OAL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData OBD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData RFI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData STT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IDecodedData VIN { get; set; }

        public IDecodedData TRP { get; set; }
    }
}
