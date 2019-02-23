using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;
using SmartDriverAPI.Models.Events;
using System.Reflection;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>

	public class EVTDecoders : IDecoder
	{
		private string[] eventInfo0 = {  "None",
								"Interval upload",
								"Angle change upload",
								"Distance upload",

								"Request upload"};

		private string[] eventInfo1 = { "Rfid reader",
								"iBeacon"};

		private EVTDecodedData evtdata;
		//public DateTime PacketDate { get; set; }

		public IDecodedData Decode(string str)
		{
			try
			{
				evtdata = new EVTDecodedData();
				return evtdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}

		public IDecodedData Decode(byte[] dat, bool b3d = false)
		{
			try
			{
				evtdata = new EVTDecodedData();
				return evtdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
		private void EvtCodeStringOut(byte evt, UInt32 mask)
		{
			evtdata = new EVTDecodedData();

		}
	}
}
