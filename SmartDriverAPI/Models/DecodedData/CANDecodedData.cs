using SmartDriverAPI.Interfaces;
using System.Collections.Generic;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
    /// <summary>
    /// 
    /// </summary>
    public class DTC:IDTC
    {
        /// <summary>
        /// 
        /// </summary>
        public uint SPN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint FMI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint OC { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class LambStatus:ILambStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public LambStatus()
        {
            DTCs = new List<IDTC>();
        }
        /// <summary>
        /// 
        /// </summary>
        public string MIL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RSL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AWL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<IDTC> DTCs { get; set; }
      

    }
    /// <summary>
    /// 
    /// </summary>
    public class CANDecodedData : IDecodedData
    {
        /// <summary>
        /// 
        /// </summary>
        public CANDecodedData()
        {
            DecoderType = DecoderType.CAN;
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
        public double Engine_Speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Vehicle_Speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Engine_Coolant_Temperature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Fuel_Consumption { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Accelerator_Pedal_Position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ILambStatus Active_DTCs_Lamp_Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ILambStatus Previously_Active_DTCs_Lamp_Status { get; set; }
       
    }
}
