using System;
using System.Net;
using System.Net.NetworkInformation;

namespace dataCollector{
    public class NetworkInfo : SystemInfo{
        public string MacAddress { get; set; } = "";
        public string IpAddress { get; set; } = "";
        public string Domain { get; set; } = "";

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"MAC Address: {MacAddress}");
            Console.WriteLine($"IP Address: {IpAddress}");
            Console.WriteLine($"Nombre de Dominio: {Domain}");
        }
    }
}