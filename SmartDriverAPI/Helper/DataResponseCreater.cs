using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models;
using System;
using System.Collections.Generic;
using static SmartDriverAPI.Models.enums;

namespace SmartDriverAPI.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class DataResponseCreater
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataItems"></param>
        /// <param name="packetdate"></param>
        /// <param name="deviceid"></param>
        /// <returns></returns>
        public static DecodedDataResponse CreateDataResponse(List<IDecodedData> DataItems,DateTime packetdate,string deviceid)
        {
            var responsedata = new DecodedDataResponse(deviceid, packetdate);
            foreach (IDecodedData item in DataItems)
            {
                if (item == null)
                    continue;
                switch (item.DecoderType)
                {
                    case DecoderType.LBS://LBS--LBS data
                        responsedata.LBS = item;
                        break;
                    case DecoderType.GPS://GPS--GPS data
                        responsedata.GPS = item;
                        break;
                    case DecoderType.STT://STT--Device status data
                        responsedata.STT = item;
                        break;
                    case DecoderType.MGR://MGR--Mileage
                        responsedata.MGR = item;
                        break;
                    case DecoderType.ADC://ADC--Analog data
                        responsedata.ADC = item;
                        break;
                    case DecoderType.GFS://GFS--Geo-fence status
                        responsedata.GFS = item;
                        break;
                    case DecoderType.OBD://OBD--OBD data
                        responsedata.OBD = item;
                        break;
                    case DecoderType.OAL://OAL OBD alarm data
                        responsedata.OAL = item;
                        break;
                    case DecoderType.FUL1://FUL--Fuel used data
                        responsedata.FUL = item;
                        break;
                    case DecoderType.HDB://HDB--Driver behavior
                        responsedata.HDB = item;
                        break;
                    case DecoderType.CAN://CAN--J1939 data
                        responsedata.CAN = item;
                        break;
                    case DecoderType.HVD://HVD--J1708 data
                        responsedata.HVD = item;
                        break;
                    case DecoderType.VIN://VIN--VIN data
                        responsedata.VIN = item;
                        break;
                    case DecoderType.RFI://RFI--RFID data
                        responsedata.RFI = item;
                        break;
                    case DecoderType.EVT://EVT--Event code data
                        responsedata.EVT = item;
                        break;
                    case DecoderType.BCN://BCN--iBeacon info data
                        responsedata.BCN = item;
                        break;
                    case DecoderType.EGT://EGT--Engine seconds
                        responsedata.EGT = item;
                        break;
                    case DecoderType.TRP://EGT--Engine seconds
                        responsedata.TRP = item;
                        break;
                }
            }
            return responsedata;
           

        }
    }
}
