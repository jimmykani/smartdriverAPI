using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Helper;
using SmartDriverAPI.Models.DecodedData;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class STTDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				string[] stt = str.Split(';');
				if (stt.GetLength(0) != 2)
					return null;

				var sttdecoder = new STTDecodedData();

				return sttdecoder;
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
				if (dat.Length != 4)
					return null;

				var sttdecoder = new STTDecodedData();


				return sttdecoder;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
	}

}
