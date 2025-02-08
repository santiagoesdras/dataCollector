using System;
using System.Collections.Generic;
using System.Management;
using System.Net;

namespace dataCollector{
    public class ComputerInfo : SystemInfo{
        public string Manufacturer { get; set; } = "";
        public string Model { get; set;} = "";
        public string SerialNumber { get; set; } = "";
        public int RamSize { get; set; }
        public List<DiskInfo> Disks { get; set; } = new List<DiskInfo>();

        public override void DisplayInfo(){
            base.DisplayInfo();
            Console.WriteLine($"Fabricante: {Manufacturer}");
            Console.WriteLine($"Modelo: {Model}");
            Console.WriteLine($"Numero de Serie: {SerialNumber}");
            Console.WriteLine($"RAM: {RamSize} MB");
        }
        public void GetSystemInfo(){
            try{
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach(ManagementObject obj in searcher.Get()){
                    Manufacturer = obj["Manufacturer"]?.ToString() ?? "Desconocido";
                    Model = obj["Model"]?.ToString() ?? "Desconocido";
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                foreach (ManagementObject obj in searcher.Get()){
                    SerialNumber = obj["SerialNumber"]?.ToString() ?? "Desconocido";
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject obj in searcher.Get()){
                    RamSize = Convert.ToInt32(Convert.ToDouble(obj["TotalPhysicalMemory"]) / (1024 * 1024));
                }
                DeviceName = Dns.GetHostName();
                OperatingSystem = Environment.OSVersion.ToString();
            }catch(Exception e){
                Console.WriteLine("Error obteniendo informacion del sistema: " + e.Message);
            }
        }
        
    }
}