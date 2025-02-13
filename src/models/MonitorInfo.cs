using System;
using System.Management;
using System.Linq;
using System.Text;

namespace dataCollector{
    public class MonitorInfo{
        public static string Brand { get; set; } = "Desconocido";
        public static string SerialNumber { get; set; } = "Desconocido";
        public MonitorInfo(){
            GetMonitorInfo();
        }
        public void DisplayInfo(){
            Console.WriteLine($"Marca: {Brand}");
            Console.WriteLine($"Numero de serie: {SerialNumber}");
        }
        public static void GetMonitorInfo(){
            try{
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\\.\root\WMI", "SELECT * FROM WmiMonitorID");
                foreach (ManagementObject obj in searcher.Get()){
                    if (obj["ManufacturerName"] is byte[] manufacturerBytes){
                        Brand = Encoding.ASCII.GetString(manufacturerBytes).TrimEnd('\0');
                    }
                    if (obj["SerialNumberID"] is byte[] serialBytes){
                        SerialNumber = Encoding.ASCII.GetString(serialBytes).TrimEnd('\0');
                    }
                }
            }catch(Exception e){
                Console.WriteLine($"Error al obtener datos del monitor: {e.Message}");
            }
        }
        public string GetMonitorBrand(){
            return Brand.ToString();
        }
        public string GetMonitorSerialNumber(){
            return SerialNumber.ToString();
        }
    }
}