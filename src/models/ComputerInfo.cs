using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Net;

namespace dataCollector{
    public class ComputerInfo : SystemInfo{
        public string Manufacturer { get; set; } = "";
        public string Model { get; set;} = "";
        public string SerialNumber { get; set; } = "";
        public int RamSize { get; set; }
        public List<DiskInfo> Disks { get; set; } = new List<DiskInfo>();
        public string Processor { get; set; } = "";
        public string ProcessorSpeed { get; set; } = "";

        public override void DisplayInfo(){
            base.DisplayInfo();
            Console.WriteLine($"Fabricante: {Manufacturer}");
            Console.WriteLine($"Modelo: {Model}");
            Console.WriteLine($"Numero de Serie: {SerialNumber}");
            Console.WriteLine($"RAM: {RamSize} MB");
            Console.WriteLine($"Procesador: {Processor}");
            Console.WriteLine($"Velocidad del procesado: {float.Parse(ProcessorSpeed)/1000}Ghz");
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

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get()){
                    Processor = obj["Name"].ToString();
                    ProcessorSpeed =  obj["MaxClockSpeed"].ToString();
                }
                DeviceName = Dns.GetHostName();

                //Obteniendo version de Windows en la que se ejecuta el programa
                string version = Environment.OSVersion.Version.ToString();
                if(version.StartsWith("10.0.")){
                    int build = Environment.OSVersion.Version.Build;
                    if(build >= 22000)
                        OperatingSystem = "Windows 11";
                    else
                        OperatingSystem = "Windows 10";
                }
                else if(version.StartsWith("6.3"))
                    OperatingSystem = "Windows 8.1";
                else if(version.StartsWith("6.2"))
                    OperatingSystem = "Windows 8";
                else if(version.StartsWith("6.1"))
                    OperatingSystem = "Windows 7";
                else if(version.StartsWith("6.0"))
                    OperatingSystem = "Windows Vista";
                else if(version.StartsWith("5.1"))
                    OperatingSystem = "Windows XP";
                else
                    OperatingSystem = "Version de Windows no encontrada";
            }catch(Exception e){
                Console.WriteLine("Error obteniendo informacion del sistema: " + e.Message);
            }
        }
        public string GetOperatingSystem(){
            return OperatingSystem;
        }
        public string GetDeviceName(){
            return DeviceName;
        }
        public string GetManufacturer(){
            return Manufacturer;
        }
        public string GetModel(){
            return Model;
        }
        public string GetSerialNumber(){
            return SerialNumber;
        }
        public int GetRamSize(){
            return RamSize;
        }
        public List<DiskInfo> GetDisksInfo(){
            return Disks;
        }
        public string GetProcessorInfo(){
            return Processor;
        }
        public string GetProcessorSpeed(){
            return ProcessorSpeed;
        }
    }
}