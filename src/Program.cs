/*
    DataCollector - Sistema de registro de hardware y red
    Copyright (c) 2025 [Esdras Santiago]

    Este software es propiedad de [Esdras Santiago].
    Está diseñado para uso interno y no se permite su distribución sin autorización.

    Para más información, visita: [github.com/santiagoesdras]
*/

using dataCollector;
using dataCollector.ui;

    class Program{
        private static string format = "csv";
        public static string globalUserName = "";
        static void Main(string[] args){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            string[] types = {"CPU", "Monitor", "UPS"};
            foreach(string type in types){
                string response = "";
                Console.WriteLine($"Desea almacenar la informacion de {type}? Si(s), No(n): ");
                response = Console.ReadLine().ToLower();
                if(response == "s"){
                    infoWritterSelector(type);
                }
                if(globalUserName == ""){
                while(true){
                string tempUserName;
                Console.Write("Ingrese el nombre de usuario al que se asociara el ups y el monitor: ");
                tempUserName = Console.ReadLine();
                Console.WriteLine($"Nombre de usuario: {tempUserName}");
                Console.Write("Nombre de usuario para asociar ups y monitor correcto? Si(s), No(n): ");
                response = Console.ReadLine().ToLower();
                if(response == "s"){
                    globalUserName = tempUserName;
                    break;
                }}
            }
            }
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
                Console.WriteLine("Obteniendo informacion de red...");
                NetworkInfo network = new NetworkInfo();
                network.GetNetworkInfo();

                Console.WriteLine("Obteniendo informacion del sistema...");
                ComputerInfo computer = new ComputerInfo();
                computer.GetSystemInfo();

               /*  Console.WriteLine("Obteniendo informacion de monitor...");
                MonitorInfo monitor = new MonitorInfo(); */
                
                computer.Disks = DiskInfo.GetDiskInfo();

                JsonManager jsonManager = new JsonManager();
                string json = jsonManager.GenerateJson();
                CsvHandler csvHandler = new CsvHandler();

                Console.WriteLine("\nInformacion del sistema: ");
                computer.DisplayInfo();
                network.DisplayInfo();
/*                 monitor.DisplayInfo();   */              

                Console.WriteLine("\n===========================================");

                Console.WriteLine("\nObteniendo informacion de discos ...");
                foreach(var disk in computer.Disks){
                    disk.DisplayInfo();
                }
                bool dataVerifyFlag = true;
                while(dataVerifyFlag){
                    DataVerify dataVerify = new DataVerify();
                    string activeNumber = computer.GetDeviceName();
                    string userName = network.GetUserName();
                    if(dataVerify.dataVerify(ref activeNumber, "Numero de activo") && dataVerify.dataVerify(ref userName, "Nombre de usuario")){
                        logger(ref network, ref computer, ref jsonManager, ref csvHandler, ref json);  
                        dataVerifyFlag = false; 
                    }
                    computer.SetDeviceName(activeNumber);
                    network.SetUserName(userName);
                    globalUserName = userName;
                }

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