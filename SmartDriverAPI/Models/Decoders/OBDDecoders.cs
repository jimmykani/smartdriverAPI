using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class OBDDecoders : IDecoder
	{
		private OBDDecodedData obddecoder;

		public IDecodedData Decode(string str)
		{
			try
			{
				if (str.Length % 2 != 0)
					return null;
				byte[] obddata = new byte[str.Length / 2];
				for (int i = 0; i < str.Length / 2; i++)
				{
					obddata[i] = System.Convert.ToByte(str.Substring(2 * i, 2), 16);
				}
				ObdDataDecode(obddata);
				return obddecoder;
			}
			catch (Exception e)
			{
				Console.Write(e.Message);
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
				ObdDataDecode(dat);
				return obddecoder;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}

		}

		private void ObdDataDecode(byte[] obddata)
		{

			int pos = 0;
			while (pos < obddata.Length)
			{
				int len = (int)((obddata[pos] >> 4) & 0x0F);
				if (len + pos > obddata.Length)
					break;
				if (len < 3 || len > 8)
				{
					pos += len;
					continue;
				}
				int service = (int)(obddata[pos] & 0x0f);
				switch (service)
				{
					case 1:
					case 2:
						{
							int pid = obddata[pos + 1];
							byte[] pidValue = new byte[len - 2];
							Array.Copy(obddata, pos + 2, pidValue, 0, pidValue.Length);
							ObdService0102Decode(pidValue, service, pid);
							break;
						}
					case 3:
						{
							byte[] Value = new byte[len - 1];
							Array.Copy(obddata, pos + 1, Value, 0, Value.Length);
							ObdService03Decode(Value);
							break;
						}
					case 4:
						break;
					case 5:
						break;
					case 6:
						break;
					case 7:
						break;
					case 8:
						break;
					case 9:
						break;
					case 10:
						break;
					default:
						break;
				}
				pos += len;
			}
		}
		void ObdService0102Decode(byte[] value, int service, int pid)
		{
			if (obddecoder == null)
				obddecoder = new OBDDecodedData();
			//obddecoder.SeqNo = SeqNo;
			//obddecoder.DeviceId = DeviceId;
			//obddecoder.PacketDate = PacketDate;
			String str;
			switch (pid)
			{
				case 0x01:
					{
						if (value.Length != 4)
							return;
						obddecoder.DTC_CNT = value[0] & 0x7F;
						obddecoder.MIL = (value[0] & 0x80) != 0 ? "ON" : "OFF";
						obddecoder.MIS_SUP = (value[1] & 0x01) != 0 ? "YES" : "NO";
						obddecoder.FUEL_SUP = (value[1] & 0x02) != 0 ? "YES" : "NO";
						obddecoder.CCM_SUP = (value[1] & 0x04) != 0 ? "YES" : "NO";
						obddecoder.MIS_RDY = (value[1] & 0x10) != 0 ? "YES" : "NO";
						obddecoder.FUEL_RDY = (value[1] & 0x20) != 0 ? "YES" : "NO";
						obddecoder.CCM_RDY = (value[1] & 0x40) != 0 ? "YES" : "NO";

						obddecoder.CAT_SUP = (value[2] & 0x01) != 0 ? "YES" : "NO";
						obddecoder.HCAT_SUP = (value[2] & 0x02) != 0 ? "YES" : "NO";
						obddecoder.EVAP_SUP = (value[2] & 0x04) != 0 ? "YES" : "NO";
						obddecoder.AIR_SUP = (value[2] & 0x08) != 0 ? "YES" : "NO";
						obddecoder.ACRF_SUP = (value[2] & 0x10) != 0 ? "YES" : "NO";
						obddecoder.O2S_SUP = (value[2] & 0x20) != 0 ? "YES" : "NO";
						obddecoder.HTR_SUP = (value[2] & 0x40) != 0 ? "YES" : "NO";
						obddecoder.EGR_SUP = (value[2] & 0x80) != 0 ? "YES" : "NO";

						obddecoder.CAT_RDY = (value[3] & 0x01) != 0 ? "YES" : "NO";
						obddecoder.HCAT_RDY = (value[3] & 0x02) != 0 ? "YES" : "NO";
						obddecoder.EVAP_RDY = (value[3] & 0x04) != 0 ? "YES" : "NO";
						obddecoder.AIR_RDY = (value[3] & 0x08) != 0 ? "YES" : "NO";
						obddecoder.ACRF_RDY = (value[3] & 0x10) != 0 ? "YES" : "NO";
						obddecoder.O2S_RDY = (value[3] & 0x20) != 0 ? "YES" : "NO";
						obddecoder.HTR_RDY = (value[3] & 0x40) != 0 ? "YES" : "NO";
						obddecoder.EGR_RDY = (value[3] & 0x80) != 0 ? "YES" : "NO";
						break;
					}
				case 0x04:
					{
						if (value.Length != 1)
							return;
						double clv = ((double)value[0]) * 100 / 255;
						obddecoder.LOAD_Value = clv;

						break;
					}
				case 0x05:
					{
						if (value.Length != 1)
							return;
						int ect = value[0];
						ect -= 40;
						obddecoder.Engine_Coolant_Temperature = ect;
						break;
					}
				case 0x06:
					{
						if (value.Length == 1)
						{
							obddecoder.Short_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
						}
						else if (value.Length == 2)
						{
							obddecoder.Short_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
							obddecoder.Short_Term_Fuel_Trim_Bank2 = (((double)value[1] - 128) / 128) * 100;

						}
						else
							return;
						break;
					}
				case 0x07:
					{
						if (value.Length == 1)
						{
							obddecoder.Long_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
						}
						else if (value.Length == 2)
						{
							obddecoder.Long_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
							obddecoder.Long_Term_Fuel_Trim_Bank1 = (((double)value[1] - 128) / 128) * 100;
						}
						else
							return;
						break;
					}
				case 0x08:
					{

						if (value.Length == 1)
						{
							obddecoder.Short_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
						}
						else if (value.Length == 2)
						{
							obddecoder.Short_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
							obddecoder.Short_Term_Fuel_Trim_Bank2 = (((double)value[1] - 128) / 128) * 100;
						}
						else
							return;
						break;
					}
				case 0x09:
					{
						if (value.Length == 1)
						{
							obddecoder.Long_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
						}
						else if (value.Length == 2)
						{
							obddecoder.Long_Term_Fuel_Trim_Bank1 = (((double)value[0] - 128) / 128) * 100;
							obddecoder.Long_Term_Fuel_Trim_Bank1 = (((double)value[1] - 128) / 128) * 100;
						}
						else
							return;
						break;
					}
				case 0x0A:
					{
						if (value.Length != 1)
							return;
						str = String.Format("        [{0:X2}][{1:X2}]: {2}kPa--Fuel Rail Pressure\r\n",
										service,
										pid,
										(int)value[0] * 3);
						break;
					}
				case 0x0B:
					{
						if (value.Length != 1)
							return;
						obddecoder.Intake_Manifold_Absolute_Pressure = value[0];
						break;
					}
				case 0x0C:
					{
						if (value.Length != 2)
							return;
						obddecoder.Engine_RPM = ((double)(value[0] * 256 + value[1])) / 4;
						break;
					}
				case 0x0D:
					{
						if (value.Length != 1)
							return;
						obddecoder.Vehicle_Speed = value[0];
						break;
					}
				case 0x0E:
					{
						if (value.Length != 1)
							return;
						obddecoder.Ignition_Timing_Advance = ((double)value[0] - 128) / 2;
						break;
					}
				case 0x0F:
					{
						if (value.Length != 1)
							return;
						int iat = value[0];
						iat -= 40;
						obddecoder.Intake_Air_Temperature = iat;
						break;
					}
				case 0x10:
					{
						if (value.Length != 2)
							return;
						obddecoder.Flow_Rate_Mass_Air_Flow_Sensor = ((double)(value[0] * 256 + value[1])) / 100;
						break;
					}
				case 0x11:
					{
						if (value.Length != 1)
							return;
						obddecoder.Absolute_Throttle_Position = ((double)value[0]) * 100 / 255;
						break;
					}
				case 0x21:
					{

						if (value.Length != 2)
							return;
						obddecoder.Distance_Travelled_MIL_Activated = 256 * value[0] + value[1];
						break;
					}
				case 0x2F:
					{
						if (value.Length != 1)
							return;
						obddecoder.Fuel_level = ((double)value[0]) * 100 / 255;
						break;
					}
				case 0x31:
					{
						if (value.Length != 2)
							return;
						obddecoder.Distance_traveled = 256 * value[0] + value[1];
						break;
					}
				default:
					{
						//string hex = "";
						//for (int i = 0; i < value.Length; i++)
						//{
						//    hex += String.Format("{0:X2} ", value[i]);
						//}
						//str = String.Format("        [{0:X2}][{1:X2}]: {2}\r\n",
						//                service,
						//                pid,
						//                hex);
						break;
					}
			}
		}
		void ObdService03Decode(byte[] value)
		{
			int offset;
			if (value.Length % 2 != 0)
				offset = 1;
			else
				offset = 0;
			string strDtcs = "";
			string[] dtcChars = { "P", "C", "B", "U" };
			for (int i = 0; i < value.Length / 2; i++)
			{
				byte dtcA = value[2 * i + offset];
				byte dtcB = value[2 * i + offset + 1];
				if (dtcA == 0 && dtcB == 0)
					continue;
				strDtcs += string.Format("{0}{1:X2}{2:X2}/",
						  dtcChars[((dtcA >> 6) & 0x03)],
						  (dtcA & 0x3F),
						  dtcB);

			}

			strDtcs = strDtcs.Substring(0, strDtcs.Length - 1);
			strDtcs = String.Format("        [03]: {0}\r\n",
										strDtcs);
			if (obddecoder == null)
				obddecoder = new OBDDecodedData();
			obddecoder.Dtcs = strDtcs;

		}

	}



}
