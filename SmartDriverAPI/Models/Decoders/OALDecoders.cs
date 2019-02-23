using System;
using SmartDriverAPI.Interfaces;
namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class OALDecoders : IDecoder
	{


		public IDecodedData Decode(string str)
		{
			try
			{
				var obddecoder = new OBDDecoders();
				return obddecoder.Decode(str);
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
				var obddecoder = new OBDDecoders();
				return obddecoder.Decode(dat, b3d);
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}

		}
	}
}
