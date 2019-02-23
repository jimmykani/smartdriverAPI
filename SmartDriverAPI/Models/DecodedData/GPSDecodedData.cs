using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;
namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class GPSDecodedData : GPSBaseDecodedData,IDecodedData
      {  /// <summary>
        /// 
        /// </summary>
        public GPSDecodedData()
        {
            DecoderType = DecoderType.GPS;
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
     //   public string Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
     //   public string Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// /
        /// </summary>
        public int Course { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double HDOP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Status { get; internal set; }
    }
}
