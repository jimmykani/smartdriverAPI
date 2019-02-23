using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class HVDDecoders : IDecoder
	{
		private HVDDecodedData hdvdata;

		public IDecodedData Decode(string str)
		{
			try
			{
				if (str.Length % 2 != 0)
					return null;
				hdvdata = new HVDDecodedData();

				return hdvdata;
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
				hdvdata = new HVDDecodedData();
				return hdvdata;
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
		/// <param name="hvddata"></param>
		private void J1708DataDecode(byte[] hvddata)
		{
			int pos = 0;
			while (pos < hvddata.Length)
			{
				int len = (int)(hvddata[pos] & 0x3F);
				int paratype = (int)((hvddata[pos] >> 6) & 0x03);
				if (len + pos > hvddata.Length)
					break;
				if (len < 2 || len > 22 || paratype == 0)
				{
					pos += len + 1;
					continue;
				}
				if (paratype == 1)//MID data
				{
					byte[] Value = new byte[len];
					Array.Copy(hvddata, pos + 1, Value, 0, Value.Length);
					J1708MidDecode(Value);
				}
				else
				{
					int j1587pid = hvddata[pos + 1];
					if (paratype == 3)
					{
						j1587pid += 256;
					}
					byte[] Value = new byte[len - 1];
					Array.Copy(hvddata, pos + 2, Value, 0, Value.Length);
					J1587PidDecode(Value, j1587pid);
				}
				pos += len + 1;
			}
		}
		private void J1708MidDecode(byte[] value)
		{
			string hex = "";
			for (int i = 1; i < value.Length; i++)
			{
				hex += String.Format("{0:X2} ", value[i]);
			}
			hdvdata.MID = hex;
		}

		private void J1587PidDecode(byte[] value, int pid)
		{
			switch (pid)
			{
				case 84://Road speed
					hdvdata.Road_speed = Utility.ReadUnsignedByte(value, 0) * 0.805;

					break;
				case 96://Fuel level
					hdvdata.Fuel_level = (double)Utility.ReadUnsignedByte(value, 0) * 0.5;
					break;
				case 110://Engine Coolant Temperature
					hdvdata.Engine_Coolant_Temperature = Utility.ReadUnsignedByte(value, 0);
					break;
				case 190://Engine speed
					hdvdata.Engine_speed = (double)Utility.ReadUint16(value, 0) * 0.25;
					break;
				case 245://Total Vehicle Distance
					hdvdata.Total_Vehicle_Distance = (double)Utility.ReadUint32(value, 0) * 0.161;
					break;
				default:
					string hex = "";
					for (int i = 0; i < value.Length; i++)
					{
						hex += String.Format("{0:X2} ", value[i]);
					}
					hdvdata.PID = hex;
					break;
			}
		}
	}
}
