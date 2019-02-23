using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartDriverAPI.Interfaces;
using SmartDriverAPI.Models;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860


namespace SmartDriverAPI.Controllers
{
    /// <summary>
    /// controller for decoder API
    /// </summary>
    [Route("api/[controller]")]
    public class DecoderController : Controller
    {
       /// <summary>
       /// Post request for line decoder
       /// </summary>
       /// <param name="DataLine"></param>
       /// <returns> </returns>
        [HttpPost]
        public async Task<IDecoderResponse> Post([FromBody]DecoderRequest DataLine)
        {
           // var reData = new List<IDecodedDataResponse>();
            var res = new DecoderResponse();
            try
            {
               // List<IDecodedData> data = null;
                var lineDecoder = new LineDecoder();
                //  if (DataLine.StringData != "" && DataLine.StringData != null)
                //         data = lineDecoder.TextFrameDecode(DataLine.StringData);
                //    else if (DataLine.BinaryData != null)
                //       data = lineDecoder.BinFrameDecode(DataLine.BinaryData, DataLine.BinaryData.Length);
                //   reData.Add((IDecodedDataResponse)DataResponseCreater.CreateDataResponse(data, lineDecoder.PacketDate, lineDecoder.DeviceId));
                var x = await lineDecoder.DecodeDataLine(DataLine.StringData);
                  res.Data = lineDecoder.DecodedData;
              //  res.Data = reData;
                res.Status = true;
                
            }
            catch(Exception e)
            {
                res.ErrorMessage = e.StackTrace;
                res.Status = false;
            }
            return await Task.FromResult(res);

        }

        /// <summary>
        /// get message for decode data line
        /// </summary>
        /// <param name="DataLine"></param>
        /// <returns></returns>
        [HttpGet("{dataline}")]
        public async Task<IDecoderResponse> DecodedataLine(DecoderRequest DataLine)
        {
            //  var reData = new List<IDecodedDataResponse>();
            var res = new DecoderResponse();
            try
            {
                //List<IDecodedData> data = null;
                var lineDecoder = new LineDecoder();
                //if (DataLine.StringData != "" || DataLine.StringData != null)
                //        data = lineDecoder.TextFrameDecode(DataLine.StringData);
                //else if (DataLine.BinaryData != null)
                //        data = lineDecoder.BinFrameDecode(DataLine.BinaryData, DataLine.BinaryData.Length);
                await lineDecoder.DecodeDataLine(DataLine.StringData);
                res.Data = lineDecoder.DecodedData;
                //reData.Add((IDecodedDataResponse)DataResponseCreater.CreateDataResponse(data, lineDecoder.PacketDate, lineDecoder.DeviceId));
                //res.Data = reData;
                res.Status = true;
            }
            catch (Exception e)
            {
                res.ErrorMessage = e.StackTrace;
                res.Status = false;
            }
            return await Task.FromResult(res);   ;
        }
        /// <summary>
        /// test method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
