using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic;

namespace dataCollector{
    public class CsvHandler{
        public ComputerInfo computer { get; set; }
        public NetworkInfo network { get; set; }
        public UpsInfo ups { get; set; }
        public MonitorInfo monitor { get; set; }
        private static string format = "csv";

        private static string[][] datas = {["Nombre de Usuario", "Serie", "Activo", "Modelo", "Procesador", "Velocidad (Ghz)", "Memoria (MB)",
         "Disco", "Sistema Operativo", "Ip", "Office"], ["Nombre de Usuario", "Marca", "Activo", "Serie"], ["Nombre de usuario", "Activo", "Marca", "Modelo", "Serie"]};
        public static List<string> ActiveInfo = new List<string>();
        public CsvHandler(ref NetworkInfo networkInfo, ref ComputerInfo computerInfo, ref UpsInfo upsInfo, ref MonitorInfo monitorInfo){
            computer = computerInfo;
            network = networkInfo;
            ups = upsInfo;
            monitor = monitorInfo;
        }
        public void UpsLogger(){
            string [] CsvStrings = {
                network.GetUserName(),
                ups.GetUpsActiveNumber(),
                ups.GetUpsBrand(),
                ups.GetUpsModel(),
                ups.GetUpsSerialNumber()
            };
            
            dataWritter(CsvStrings, 2);
        }
        public void MonitorLogger(){
            string[] CsvStrings = {
                network.GetUserName(),
                monitor.GetMonitorBrand(),
                monitor.GetMonitorActiveNumber(),
                monitor.GetMonitorSerialNumber()
            };
            dataWritter(CsvStrings, 1);
        }
        public void logger(){
            if(format == "json"){
                //jsonManager.SaveJsonToFile($"{computer.GetDeviceName()}");
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
                dataWritter(CsvStrings, 0);
            }
        }
        public static void dataWritter(string[] CsvStrings, int activeType){
            ActiveInfo.Clear();
            string[] filepath = {"CPU.csv", "Monitor.csv", "UPS.csv"};
            if(writeHeader(filepath[activeType], activeType)){
                try{
                    insertData(CsvStrings);
                    using (var writer = new StreamWriter(filepath[activeType], append: true))
                    using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture))){
                        foreach(string info in ActiveInfo){
                            csv.WriteField(info);
                        }
                        csv.NextRecord();
                    }
                }catch(Exception e){
                    Console.WriteLine(e.ToString());    
                }
            }
        }
        public static bool writeHeader(string filepath, int activeType){
            bool fileExists = File.Exists(filepath);
            bool fileIsEmpty = fileExists && new FileInfo(filepath).Length == 0;
            if(!fileExists || fileIsEmpty){
                using (var writer = new StreamWriter(filepath, append: true))
                using (var csv = new  CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture))){
                    foreach( string data in datas[activeType]){
                        csv.WriteField(data);
                    }
                    csv.NextRecord();
                }
                return true;
            }else{
                Console.WriteLine($"Archivo csv ya existe, escribiendo datos en nuevo registro del archivo {filepath}");
                return true;
            }
        }
        public static void insertData(string[] CsvStrings){
            foreach(string data in CsvStrings){
                ActiveInfo.Add(data);
            }
        }
    }
}