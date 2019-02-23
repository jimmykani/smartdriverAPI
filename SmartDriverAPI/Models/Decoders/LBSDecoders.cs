using System;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;
using SmartDriverAPI.Helper;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class LBSDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				string[] lbs = str.Split(';');
				if (lbs.GetLength(0) < 5)
					return null;
				var lbsdata = new LBSDecodedData();

				return lbsdata;
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
				if (dat.Length < 9)
					return null;
				if ((dat.Length - 4) % 5 != 0)
					return null;
				if ((dat.Length - 4) / 5 > 7)
					return null;

				var lbsdata = new LBSDecodedData();

				return lbsdata;
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
				return null;
			}
		}
	}


}
