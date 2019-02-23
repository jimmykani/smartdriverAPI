using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class HDBDecoders : IDecoder
	{
		private HDBDecodedData hdbdata;

		public IDecodedData Decode(string str)
		{
			try
			{
				hdbdata = new HDBDecodedData();
				return hdbdata;
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
				hdbdata = new HDBDecodedData();
				return hdbdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
		private void ParseBits(byte hdb)
		{

			hdbdata = new HDBDecodedData();
			//hdbdata.SeqNo = SeqNo;
			//hdbdata.DeviceId = DeviceId;
			//hdbdata.PacketDate = PacketDate;
			int i = 0;
			UInt16 bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.Rapid_Acceleration = 0;
			else
				hdbdata.Rapid_Acceleration = 1;
			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.Rough_Braking = 0;
			else
				hdbdata.Rough_Braking = 1;

			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.Harsh_Course = 0;
			else
				hdbdata.Harsh_Course = 1;
			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.No_Warmup = 0;
			else
				hdbdata.No_Warmup = 1;
			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.Long_Idle = 0;
			else
				hdbdata.Long_Idle = 1;
			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.Fatigue_Driving = 0;
			else
				hdbdata.Fatigue_Driving = 1;
			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.Rough_Terrain = 0;
			else
				hdbdata.Rough_Terrain = 1;
			i++;
			bitMask = (UInt16)(0x0001 << i);
			if ((hdb & bitMask) == 0)
				hdbdata.High_RPM = 0;
			else
				hdbdata.High_RPM = 1;


		}
	}
}
