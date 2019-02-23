using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class RFIDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				string[] paras = str.Split(';');
				var rfiddecoder = new RFIDecodedData();

				rfiddecoder.RFID = paras[1] == "0" ? "Unauthorized" : "Authorized";
				return rfiddecoder;
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

				if (dat.GetLength(0) != 11)
					return null;
				var rfiddecoder = new RFIDecodedData();
				//rfiddecoder.SeqNo = SeqNo;
				rfiddecoder.RFID = dat[10] == 0 ? "Unauthorized" : "Authorized";
				return rfiddecoder;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}

		}
	}
}
