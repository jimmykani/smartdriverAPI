using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Helper;
using SmartDriverAPI.Models.DecodedData;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class BCNDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				string[] paras = str.Split(';');
				if (paras.GetLength(0) < 2)
					return null;

				var bcndata = new BCNDecodedData();

				return bcndata;
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
				var bcndata = new BCNDecodedData();

				return bcndata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
	}
}
