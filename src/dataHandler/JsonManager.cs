using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic;

namespace dataCollector{
    public class JsonData{
        public string SistemaOperativo { get ; set; }
        public string NombreDeEquipo { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string NumeroDeSerie { get; set; }
        public int Ram { get; set; }
        public string Procesador { get; set; }
        public List<DiskInfo> Discos { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public string NombreDeDominio { get; set; }
        public string UsuarioDeDominio { get; set; }
    }
    public class JsonManager {     
            private ComputerInfo computer = new ComputerInfo();
            private NetworkInfo network = new NetworkInfo();
        public string GenerateJson(){
                computer.GetSystemInfo();
                network.GetNetworkInfo();
            JsonData jsonSerialized = new JsonData{
                SistemaOperativo = computer.GetOperatingSystem(),
                NombreDeEquipo = computer.GetDeviceName(),
                Fabricante = computer.GetManufacturer(),
                Modelo = computer.GetModel(),
                NumeroDeSerie = computer.GetSerialNumber(),
                Ram = computer.GetRamSize(),
                Procesador = computer.GetProcessorInfo(),
                Discos = DiskInfo.GetDiskInfo(),
                MacAddress = network.GetMacAddress(),
                IpAddress = network.GetIpAddress(),
                NombreDeDominio = network.GetDomain(),
                UsuarioDeDominio = network.GetUserName()
            };
            return JsonSerializer.Serialize(jsonSerialized, new JsonSerializerOptions { WriteIndented = true });
        }
        public void SaveJsonToFile(string filepath){
            string json = GenerateJson();
            File.WriteAllText(filepath, json);
        }
    }
}