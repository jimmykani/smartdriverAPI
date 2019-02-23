using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        DecoderType DecoderType { get;  }
        //string DeviceId { get; set; }
        //DateTime PacketDate { get; set; }
        //int SeqNo { get; set; }
    }
}
