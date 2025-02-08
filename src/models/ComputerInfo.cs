using System;
using System.Collections.Generic;
using System.Management;

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

            Console.WriteLine("===============================================");
            Console.WriteLine("Informacion de Discos: ");
            foreach(DiskInfo disk in Disks){
                disk.DisplayInfo();
                Console.WriteLine("-------------------------------------------------");
            }
        }
        public void GetSystemInfo(){
            try{
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            }catch(Exception e){
                
            }
        }
        
    }
}