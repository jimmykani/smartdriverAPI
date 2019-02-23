using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models.DecodedData
{
	/// <summary>
	/// 
	/// </summary>
	public class ADCDecodedData : IDecodedData
	{
		/// <summary>
		/// 
		/// </summary>
		public ADCDecodedData()
		{
			this.DecoderType = DecoderType.ADC;
		}
		/// <summary>
		/// 
		/// </summary>
		public DecoderType DecoderType { get; private set; }
		/// <summary>
		/// 
		/// </summary>

		public double Car_Battery { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double Device_Temp { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double Inner_Battery { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double Input_Voltage { get; set; }

	}
}
