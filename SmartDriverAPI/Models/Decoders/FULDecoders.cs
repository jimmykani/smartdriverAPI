using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class FULDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				var fuldata = new FULDecodedData();

				return fuldata;
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
				var fuldata = new FULDecodedData();

				return fuldata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}

		}
	}

}
