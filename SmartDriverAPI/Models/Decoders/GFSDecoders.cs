using SmartDriverAPI.Interfaces;
namespace SmartDriverAPI.Models.Decoders
{
	/// <summary>
	/// 
	/// </summary>
	public class GFSDecoders : IDecoder
	{

		public IDecodedData Decode(string str)
		{
			return null;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dat"></param>
		/// <param name="b3d"></param>
		/// <returns></returns>
		public IDecodedData Decode(byte[] dat, bool b3d = false)
		{
			return null;
		}
	}
}
