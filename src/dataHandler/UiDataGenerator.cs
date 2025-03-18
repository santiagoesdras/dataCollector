namespace dataCollector.dataHandler{
    public class UiDataModel{
        public string UserName { get; set; }
        public class UiPcDataModel: UiDataModel{
            public string SerialNumber { get; set; }
            public string ActiveNumber { get; set; }
            public string Model { get; set; }
            public string Processor { get; set; }
            public string ProcessorSpeed { get; set; }
            public string Ram { get; set; }
            public string DiskInfo { get; set; }
            public string OperativeSystem { get; set; }
            public string Ip { get; set; }
            public string OfficeVersion { get; set; }
        }
        public class UiUpsDataModel: UiDataModel{
            public string UpsActiveNumber { get; set; }
            public string UpsBrand { get; set; }
            public string UpsModel { get; set; }
            public string UpsSerialNumber { get; set; }
        }
        public class UiMonitorModel: UiDataModel{

        }
        public UiPcDataModel GenerateUiData(ref ComputerInfo computerInfo, ref NetworkInfo networkInfo){
            List<string> disks = new List<string>();
            foreach (DiskInfo disk in computerInfo.GetDisksInfo()){
                disks.Add(disk.Name.ToString() + " " + (disk.TotalSize/(1024 * 1024 *1024)).ToString() + "GB");
            }
            return new UiPcDataModel{
                UserName = networkInfo.GetUserName(), 
                SerialNumber = computerInfo.GetSerialNumber(),
                ActiveNumber = computerInfo.GetDeviceName(),
                Model = computerInfo.GetModel(),
                Processor = computerInfo.GetProcessorInfo(),
                ProcessorSpeed = computerInfo.GetProcessorSpeed(),
                Ram = computerInfo.GetRamSize().ToString(),
                DiskInfo = disks.First(),
                OperativeSystem = computerInfo.GetOperatingSystem(),
                Ip = networkInfo.GetIpAddress(),
                OfficeVersion = computerInfo.GetOfficeVersion()
            };
        }
    }
    public class UiDataGenerator{
        public Dictionary<string, string> DataToDictionary(ref ComputerInfo computerInfo, ref NetworkInfo networkInfo){
                                    List<string> disks = new List<string>();
                        foreach(DiskInfo disk in computerInfo.GetDisksInfo()){
                            disks.Add(disk.Name.ToString() + " " + (disk.TotalSize/(1024 * 1024 * 1024)).ToString() + "GB");
                        }
            Dictionary<string, string> DataForUi = new Dictionary<string, string>{
                {"UserName", networkInfo.GetUserName()},
                {"SerialNumber", computerInfo.GetSerialNumber()},
                {"ActiveNumber", computerInfo.GetDeviceName()},
                {"Model", computerInfo.GetModel()},
                {"Processor", computerInfo.GetProcessorInfo()},
                {"ProcessorSpeed", computerInfo.GetProcessorSpeed()},
                {"RAM", computerInfo.GetRamSize().ToString()},
                {"DiskInfo", disks.First()},
                {"OperativeSystem", computerInfo.GetOperatingSystem()},
                {"Ip", networkInfo.GetIpAddress()},
                {"OfficeVersion", computerInfo.GetOfficeVersion()}
            };
            return DataForUi;
        }
    }
}