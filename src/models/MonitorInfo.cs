using System;
using System.Management;
using System.Linq;
using System.Text;

namespace dataCollector{
    public class MonitorInfo{
        public string Brand { get; set; } = "Desconocido";
        public string SerialNumber { get; set; } = "Desconocido";
        public MonitorInfo(){
            GetMonitorInfo();
        }
        public static void GetMonitorInfo(){
            try{

            }catch(Exception e){
                Console.WriteLine($"Error al obtener datos del monitor: {e.Message}");
            }
        }
    }
}