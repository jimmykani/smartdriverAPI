using SmartDriverAPI.Interfaces;
using System.Collections.Generic;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class EVTDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public EVTDecodedData()
        {
            DecoderType = DecoderType.EVT;
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
        public List<IBiotecEvent> Events
        { get; set; }

                

           
      

    }
}
