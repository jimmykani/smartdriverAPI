using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models.Decoders;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BinaryDecoderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_decoderType"></param>
        /// <returns></returns>
        public static IDecoder GetDecoder(DecoderType _decoderType)
        {
            switch (_decoderType)
            {
                case DecoderType.LBS://LBS--LBS data

                case DecoderType.GPS://GPS--GPS data
                    return new GPSDecoders();
                case DecoderType.STT://STT--Device status data
                    return new STTDecoders();
                case DecoderType.MGR://MGR--Mileage
                    return new MGRDecoders();
                case DecoderType.ADC://ADC--Analog data
                    return new ADCDecoders();
                case DecoderType.GFS://GFS--Geo-fence status
                    return new GFSDecoders();
                case DecoderType.OBD://OBD--OBD data
                    return new OBDDecoders();
                case DecoderType.OAL://OAL OBD alarm data
                    return new OALDecoders();
                case DecoderType.FUL1://FUL--Fuel used data
                    return new FULDecoders();
                case DecoderType.HDB://HDB--Driver behavior
                    return new HDBDecoders();
                case DecoderType.CAN://CAN--J1939 data
                    return new CANDecoders();
                case DecoderType.HVD://HVD--J1708 data
                    return new HDBDecoders();
                case DecoderType.VIN://VIN--VIN data
                    return new VINDecoders();
                case DecoderType.RFI://RFI--RFID data
                    return new RFIDecoders();
                case DecoderType.EVT://EVT--Event code data
                    return new EVTDecoders();
                case DecoderType.BCN://BCN--iBeacon info data
                    return new BCNDecoders();
                case DecoderType.EGT://EGT--Engine seconds
                    return new EGTDecoders();
                case DecoderType.TRP://EGT--Engine seconds
                    return new TRPDecoders();
                default:
                    return null;
            }
        }


    }
}
