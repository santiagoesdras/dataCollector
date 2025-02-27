namespace dataCollector.dataHandler{
    public class UiDataGenerator{
        public Dictionary<string, string> DataToDictionary(ref ComputerInfo computerInfo, ref NetworkInfo networkInfo){
                                    List<string> disks = new List<string>();
                        foreach(DiskInfo disk in computerInfo.GetDisksInfo()){
                            disks.Add(disk.Name.ToString() + " " + (disk.TotalSize/(1024 * 1024 * 1024)).ToString() + "GB");
                        }
            Dictionary<string, string> DataForUi = new Dictionary<string, string>{
                {"SerialNumber", computerInfo.GetSerialNumber()},
                {"ActiveNumber", computerInfo.GetDeviceName()},
                {"Model", computerInfo.GetModel()},
                {"Processor", computerInfo.GetProcessorInfo()},
                {"ProcessorSpeed", computerInfo.GetProcessorSpeed()},
                {"RAM", computerInfo.GetRamSize().ToString()},
                {"DiskInfo", disks.First()}
            };
            return DataForUi;
        }
    }
}