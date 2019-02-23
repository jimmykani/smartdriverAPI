using SmartDriverAPI.Interfaces;

namespace SmartDriverAPI.Models
{
    public class DecodedDataRepository : IDecodedDataRepository
    {
        public IDecodedData ADC{get;set;}
        public IDecodedData BCN{get;set;}
        public IDecodedData CAN{get;set;}
        public IDecodedData EGT{get;set;}
        public IDecodedData EVT{get;set;}
        public IDecodedData FUL{get;set;}
        public IDecodedData GFS{get;set;}
        public IDecodedData GPS{get;set;}
        public IDecodedData HDB{get;set;}
        public IDecodedData HDV{get;set;}

        public IDecodedData LBS{get;set;}
        public IDecodedData MGR{get;set;}
        public IDecodedData OAL{get;set;}
        public IDecodedData OBD{get;set;}
        public IDecodedData RFI{get;set;}
        public IDecodedData STT{get;set;}
        public IDecodedData VIN{get;set;}
        public IDecodedData TRP{get;set;}
    }
}