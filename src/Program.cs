/*
    DataCollector - Sistema de registro de hardware y red
    Copyright (c) 2025 [Esdras Santiago]

    Este software es propiedad de [Esdras Santiago].
    Está diseñado para uso interno y no se permite su distribución sin autorización.

    Para más información, visita: [github.com/santiagoesdras]
*/

using dataCollector;
using dataCollector.dataHandler;
using dataCollector.ui;
using dataCollector.dataHandler;
    class Program{
        private static string format = "csv";
        public static string globalUserName = "";
        static void Main(string[] args){
            CpuInfo();
        }
        public static void infoWritterSelector(string type){
            if(type == ""){
                Console.WriteLine("Tipo de activo no reconocido");
            }else if(type == "CPU"){
                CpuInfo();
            }else if(type == "Monitor"){
                ScreenInfo();
            }else if(type == "UPS"){
                UpsInfo();
            }
        }
        public static void CpuInfo(){
            
            try{
                NetworkInfo network = new NetworkInfo();
                network.GetNetworkInfo();

                ComputerInfo computer = new ComputerInfo();
                computer.GetSystemInfo();                
                computer.Disks = DiskInfo.GetDiskInfo();

                UiDataGenerator uiDataGenerator = new UiDataGenerator();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1(uiDataGenerator.DataToDictionary(ref computer, ref network));
            Application.Run(form1);
            
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
        public static void ScreenInfo(){
            MonitorInfo monitorInfo = new MonitorInfo();
            string[] CsvStrings = {
                globalUserName,
                monitorInfo.GetMonitorBrand(),
                monitorInfo.GetMonitorActiveNumber(),
                monitorInfo.GetMonitorSerialNumber()
            };
            CsvHandler csvHandler = new CsvHandler();
            csvHandler.dataWritter(CsvStrings, 1);
        }
        public static void UpsInfo(){
            UpsInfo upsInfo = new UpsInfo();
            string [] CsvStrings = {
                globalUserName,
                upsInfo.GetUpsActiveNumber(),
                upsInfo.GetUpsBrand(),
                upsInfo.GetUpsModel(),
                upsInfo.GetUpsSerialNumber()
            };
            CsvHandler csvHandler = new CsvHandler();
            csvHandler.dataWritter(CsvStrings, 2);
        }
        public static void logger(ref NetworkInfo network, ref ComputerInfo computer, ref JsonManager jsonManager, ref CsvHandler csvHandler, ref string json){
                if(format == "json"){
                    jsonManager.SaveJsonToFile($"{computer.GetDeviceName()}");
                }else if(format == "csv"){
                        List<string> disks = new List<string>();
                        foreach(DiskInfo disk in computer.GetDisksInfo()){
                            disks.Add(disk.Name.ToString() + " " + (disk.TotalSize/(1024 * 1024 * 1024)).ToString() + "GB");
                        }
                    string[] CsvStrings = {
                        network.GetUserName(),
                        computer.GetSerialNumber(), 
                        computer.GetDeviceName(),
                        computer.GetManufacturer() + computer.GetModel(),
                        computer.GetProcessorInfo(),
                        (float.Parse(computer.GetProcessorSpeed())/1000).ToString(),
                        computer.GetRamSize().ToString(),
                        disks.First(),
                        computer.GetOperatingSystem(),
                        network.GetIpAddress(),
                        computer.GetOfficeVersion()
                    };
                    csvHandler.dataWritter(CsvStrings, 0);
                }
        }
    }