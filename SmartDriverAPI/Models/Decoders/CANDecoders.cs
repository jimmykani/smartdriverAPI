using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class CANDecoders : IDecoder
	{
		private CANDecodedData candata;

		public IDecodedData Decode(string str)
		{
			try
			{
				if (str.Length % 2 != 0)
					return null;
				byte[] j1939data = new byte[str.Length / 2];

				for (int i = 0; i < str.Length / 2; i++)
				{
					j1939data[i] = System.Convert.ToByte(str.Substring(2 * i, 2), 16);
				}
				J1939DataDecode(j1939data);
				// candata.Engine_Seconds = uint.Parse(str);
				return candata;
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
				J1939DataDecode(dat);
				return candata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
		private void J1939DataDecode(byte[] candata)
		{
			int pos = 0;
			while (pos < candata.Length)
			{
				int len = candata[pos];
				if (len + pos + 1 > candata.Length)
					break;
				if (len < 4 || candata[pos + 1] != 0)
				{
					pos += len + 1;
					continue;
				}

				int pgn = Utility.ReadUint16(candata, pos + 2);
				byte[] value = new byte[len - 3];
				Array.Copy(candata, pos + 4, value, 0, value.Length);
				J1939PgnDecode(value, pgn);
				pos += len + 1;
			}
		}

		void J1939PgnDecode(byte[] value, int pgn)
		{
			candata = new CANDecodedData();
			//candata.SeqNo = SeqNo;
			//candata.DeviceId = DeviceId;
			//candata.PacketDate = PacketDate;
			//string strCan;
			switch (pgn)
			{
				case 61444://(0x00F004)Engine speed
					candata.Engine_Speed = (double)Utility.ReadUint16(value, 3) * 0.125;
					break;
				case 65132://(0x00FE6C)Vehicle speed
					candata.Vehicle_Speed = (double)Utility.ReadUint16(value, 6) / 256;
					break;
				case 65262://(0x00FEEE)Engine Coolant Temperature
					candata.Engine_Coolant_Temperature = (double)Utility.ReadUnsignedByte(value, 0) - 40;
					break;
				case 65257://(0x00FEE9)Fuel consumption
					candata.Fuel_Consumption = (double)Utility.ReadUint16(value, 4) * 0.5;
					break;
				case 61443://(0x00F003)Accelerator Pedal Position
					candata.Accelerator_Pedal_Position = (double)Utility.ReadUnsignedByte(value, 1) * 0.4;
					break;
				case 65226://(DM1)Active DTCs and lamp status information
					candata.Active_DTCs_Lamp_Status = J1939DtcsDecode(value);
					break;
				case 65227://(DM2)Previously active DTCs and lamp status information
					candata.Previously_Active_DTCs_Lamp_Status = J1939DtcsDecode(value);

					break;

			}
		}

		private ILambStatus J1939DtcsDecode(byte[] value)
		{
			var lambstatus = new LambStatus();
			if (value.Length < 7)
				return null;
			String[] LampStatus = { "OFF", "ON", "Unknown", "Unknown" };
			lambstatus.MIL = LampStatus[(value[0] >> 6) & 0x03];
			lambstatus.RSL = LampStatus[(value[0] >> 4) & 0x03];
			lambstatus.AWL = LampStatus[(value[0] >> 2) & 0x03];
			lambstatus.PL = LampStatus[value[0] & 0x03];
			for (int i = 0; i < (value.Length - 2) / 4; i++)
			{
				var dtc = new DTC();
				UInt32 Dtc = Utility.ReadUint32(value, i * 4 + 2);
				dtc.SPN = (Dtc >> 13) & 0x7FFFF;
				dtc.FMI = (Dtc >> 8) & 0x1F;
				dtc.OC = Dtc & 0x7F;
				lambstatus.DTCs.Add(dtc);
			}
			return lambstatus;
		}
	}

}
