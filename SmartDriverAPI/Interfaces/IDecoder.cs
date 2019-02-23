using System;

namespace SmartDriverAPI.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDecoder 
    {
        //string DeviceId { get; set; }
        //DateTime PacketDate { get; set; }
        //int SeqNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dat"></param>
        /// <param name="b3d"></param>
        /// <returns></returns>
        IDecodedData Decode(byte[] dat,bool b3d=false);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        IDecodedData Decode(String str);
    }
   

   

}
