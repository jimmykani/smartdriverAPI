using SmartDriverAPI.Interfaces;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DecoderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_fileType"></param>
        /// <param name="_decoderType"></param>
        /// <returns></returns>
        public static IDecoder GetDecoder(FileType _fileType, DecoderType _decoderType)
        {
            IDecoder result = null; ;
            switch (_fileType)
            {
                case FileType.Binary:
                    result= BinaryDecoderFactory.GetDecoder(_decoderType);
                    break;
                case FileType.Text:
                    result= TextDecoderFactory.GetDecoder(_decoderType);
                    break;
                default:
                    return null;
            }
            if (result!= null)
            {
                //result.SeqNo = (int)_decoderType;

            }
            return result;
        }
    }
}
