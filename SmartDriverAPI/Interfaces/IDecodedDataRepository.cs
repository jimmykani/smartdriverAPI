namespace SmartDriverAPI.Interfaces
{
    public interface IDecodedDataRepository
    {
        IDecodedData ADC{get;set;}
        IDecodedData BCN{get;set;}
        IDecodedData CAN{get;set;}
        IDecodedData EGT{get;set;}
        IDecodedData EVT{get;set;}
        IDecodedData FUL{get;set;}
        IDecodedData GFS{get;set;}
        IDecodedData GPS{get;set;}
        IDecodedData HDB{get;set;}
        IDecodedData HDV{get;set;}

        IDecodedData LBS{get;set;}
        IDecodedData MGR{get;set;}
        IDecodedData OAL{get;set;}
        IDecodedData OBD{get;set;}
        IDecodedData RFI{get;set;}
        IDecodedData STT{get;set;}
        IDecodedData VIN{get;set;}
       /* void Add(IDecodedData item);
        List<IDecodedData> GetAll();
        IDecodedData Find(string type, string deviceId);
        void Remove(string type, string deviceId);
        void Update(IDecodedData item);
        */
    }
}
