using SmartDriverAPI.Helper;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using System;

namespace SmartDriverAPI.Models.Decoders
{
    public class TRPDecoders : IDecoder
    {
        public IDecodedData Decode(string str)
        {
            try
            {

                string[] trip = str.Split(';');
                //if (trip.GetLength(0) != 2)
                //   return null;
                var trpdecoder = new TRPDecodedData();
                trpdecoder.Start_Time = Utility.GetDateTimeFromString(trip[0]);
                trpdecoder.End_Time = Utility.GetDateTimeFromString(trip[1]);
                trpdecoder.Start_Position.Latitude = trip[2];
                trpdecoder.Start_Position.Longitude = trip[3];
                trpdecoder.End_Position.Latitude = trip[4];
                trpdecoder.End_Position.Longitude = trip[5];
                uint Mileage;
                trpdecoder.Start_Mileage = uint.TryParse(trip[6], out Mileage) ? Mileage : 0;
                trpdecoder.End_Mileage = uint.TryParse(trip[7], out Mileage) ? Mileage : 0;
                double Fuel_Consumption;
                trpdecoder.Start_Fuel_Consumption = double.TryParse(trip[9], out Fuel_Consumption) ? Fuel_Consumption : 0; 
                trpdecoder.End_Fuel_Consumption = double.TryParse(trip[10], out Fuel_Consumption) ? Fuel_Consumption : 0;
                int tmpint;
                trpdecoder.Idle_Time = int.TryParse(trip[11], out tmpint) ? tmpint : 0;
                trpdecoder.Max_RPM = int.TryParse(trip[13], out tmpint) ? tmpint : 0;
                int Max_Speed;
                trpdecoder.Max_Speed =  int.TryParse(trip[12], out Max_Speed)? Max_Speed:0;
                return trpdecoder;


            }
            catch(Exception e) { Console.WriteLine(e.Message); return null; }
        }

        public IDecodedData Decode(byte[] dat, bool b3d = false)
        {
            try
            {
                if (dat.Length != 0x31)
                    return null;
                var trpdecoder = new TRPDecodedData();
                int pos = 0;

                UInt32 startTime = Utility.ReadUint32(dat, pos);
                pos += 4;
                DateTime timeOffset = new DateTime(2000, 1, 1, 0, 0, 0);
                DateTime sTime = new DateTime(timeOffset.Ticks + (long)startTime * 10000000);
                trpdecoder.Start_Time = sTime;

                UInt32 endTime = Utility.ReadUint32(dat, pos);
                pos += 4;
                DateTime eTime = new DateTime(timeOffset.Ticks + (long)endTime * 10000000);
                trpdecoder.End_Time = eTime;
                trpdecoder.Start_Position.Latitude = Utility.ReadInt32(dat, pos).ToString();
                pos += 4;
                trpdecoder.Start_Position.Longitude = Utility.ReadInt32(dat, pos).ToString();
                pos += 4;

                trpdecoder.End_Position.Latitude = Utility.ReadUint32(dat, pos).ToString();
                pos += 4;
                trpdecoder.End_Position.Longitude = Utility.ReadUint32(dat, pos).ToString();
                pos += 4;

                trpdecoder.Start_Mileage = Utility.ReadUint32(dat, pos);
                pos += 4;

                trpdecoder.End_Mileage = Utility.ReadUint32(dat, pos);
                pos += 4;

                byte fuelCalId = Utility.ReadUnsignedByte(dat, pos);
                pos += 1;

                trpdecoder.Start_Fuel_Consumption = Utility.ReadUint32(dat, pos);
                pos += 4;
                trpdecoder.End_Fuel_Consumption = Utility.ReadUint32(dat, pos);
                pos += 4;

                trpdecoder.Idle_Time = Utility.ReadInt32(dat, pos);
                pos += 4;

                trpdecoder.Max_Speed = Utility.ReadUint16(dat, pos);
                pos += 2;

                trpdecoder.Max_RPM = Utility.ReadUint16(dat, pos);
                pos += 2;

                return trpdecoder;
            }
            catch { return null; }
        }
    }
}
