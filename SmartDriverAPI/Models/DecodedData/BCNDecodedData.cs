using SmartDriverAPI.Interfaces;
using System;
using System.Collections.Generic;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class BeaconData
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint Major { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint Minor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Byte Power { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public Byte RSSI { get; set; }


    }
    /// <summary>
    /// 
    /// </summary>
    public class BCNDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public BCNDecodedData() {
            DecoderType = DecoderType.BCN;
            iBeacon = new List<BeaconData>();
        }
        /// <summary>
        /// 
        /// </summary>
        public DecoderType DecoderType { get; private set; }
      

        //public string DeviceId { get; set; }

        //public DateTime PacketDate { get; set; }
        //public int SeqNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<BeaconData> iBeacon { get; set; }

        
    }
}
