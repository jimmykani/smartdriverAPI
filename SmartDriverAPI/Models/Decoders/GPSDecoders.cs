using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class GPSDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				string[] gps = str.Split(';');
				if (gps.GetLength(0) != 6)
					return null;
				var gpsdata = new GPSDecodedData();

				gpsdata.Status = (gps[0] == "3" ? "3D" : (gps[0] == "2" ? "2D" : "No fixed"));
				gpsdata.Latitude = (gps[1].Substring(0, 1) == "S" ? "-" : "") + gps[1].Substring(1);
				gpsdata.Longitude = (gps[2].Substring(0, 1) == "W" ? "-" : "") + gps[2].Substring(1);
				gpsdata.Speed = int.Parse(gps[3]);
				gpsdata.Course = int.Parse(gps[4]);
				gpsdata.HDOP = double.Parse(gps[5]);

				return gpsdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dat"></param>
		/// <param name="b3d"></param>
		/// <returns></returns>
		public IDecodedData Decode(byte[] dat, bool b3d = false)
		{
			try
			{
				if (dat.Length != 14)
					return null;

				string gpsfixed;
				if (Utility.ReadInt32(dat, 0) == 0 && Utility.ReadInt32(dat, 4) == 0)//Latitude and Longitude all zero
					gpsfixed = "NoFix";
				else
					gpsfixed = b3d ? "3D" : "2D";
				double lat = (double)Utility.ReadInt32(dat, 0) / 1000000;
				double log = (double)Utility.ReadInt32(dat, 4) / 1000000;


				var gpsdata = new GPSDecodedData();
				//gpsdata.SeqNo = SeqNo;
				//gpsdata.DeviceId = DeviceId;
				//gpsdata.PacketDate = PacketDate;
				//gpsdata.SeqNo = SeqNo;
				gpsdata.Status = gpsfixed;
				gpsdata.Latitude = lat.ToString();
				gpsdata.Longitude = log.ToString();
				gpsdata.Speed = Utility.ReadUint16(dat, 8);
				gpsdata.Course = Utility.ReadUint16(dat, 10);
				gpsdata.HDOP = (double)Utility.ReadUint16(dat, 10) / 100;

				return gpsdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}

		}
	}

}
