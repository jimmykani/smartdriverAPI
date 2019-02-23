using SmartDriverAPI.Interfaces;
using System;
using static SmartDriverAPI.Models.enums;
namespace SmartDriverAPI.Models.DecodedData
{
    public class TRPDecodedData : IDecodedData
    {
        public TRPDecodedData()
        {
            DecoderType = DecoderType.TRP;
            Start_Position = new GPSBaseDecodedData();
            End_Position = new GPSBaseDecodedData();
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
        /// 
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public GPSBaseDecodedData Start_Position { get; set; }
        public GPSBaseDecodedData End_Position { get; set; }
        public uint Start_Mileage { get; set; }
        public uint End_Mileage { get; set; }
        public double Start_Fuel_Consumption { get; set; }
        public double End_Fuel_Consumption { get; set; }
        public int Idle_Time { get; set; }
        public int Max_Speed { get; set; }
        public double Max_RPM { get; set; }


    }
}
