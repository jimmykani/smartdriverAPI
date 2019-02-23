using SmartDriverAPI.Helper;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using System;
using System.Reflection;
//using Microsoft.Extensions.Logging;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class ADCDecoders : IDecoder
	{



		public IDecodedData Decode(string str)
		{
			try
			{
				string[] adc = str.Split(';');
				if (adc.GetLength(0) % 2 != 0)
					return null;
				var adcdata = new ADCDecodedData();
				//adcdata.SeqNo = SeqNo;
				//adcdata.DeviceId = DeviceId;
				//adcdata.PacketDate = PacketDate;

				String[] infoAdc = {"Car_Battery",
								"Device_Temp",
								"Inner_Battery",
								"Input_Voltage"};

				for (int i = 0; i < adc.GetLength(0) / 2; i++)
				{
					if (i.ToString() == adc[2 * i])
					{
						if (i < infoAdc.GetLength(0))

							adcdata.GetType().GetProperty(infoAdc[i]).SetValue(adcdata, double.Parse(adc[2 * i + 1]));
					}
				}
				return adcdata;
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
				if (dat.Length % 2 != 0)
					if (dat.Length > 32)
						return null;
				var adcdata = new ADCDecodedData();


				String[] infoAdc = {"Car_Battery",
								"Device_Temp.",
								"Inner_Battery",
								"Input_Voltage"};

				return adcdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
	}

}
