using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models.DecodedData
{
    public class GPSBaseDecodedData : IGPSBaseDecodedData
    {
        public string Latitude { get; set; }
       

        public string Longitude { get; set; }
    }
}
