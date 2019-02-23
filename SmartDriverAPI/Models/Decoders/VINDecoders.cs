using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.DecodedData;

namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class VINDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			try
			{
				var vindecoder = new VINDecodedData();

				vindecoder.VIN = str;
				return vindecoder;
			}
			catch { return null; }
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
				var vindecoder = new VINDecodedData();

				vindecoder.VIN = System.Text.Encoding.Unicode.GetString(dat);
				return vindecoder;
			}
			catch { return null; }
		}
	}
}
