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
        public void GetNetworkInfo(){
            try{
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces()){
                    if(nic.OperationalStatus == OperationalStatus.Up){
                        MacAddress = nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }

                string hostName = Dns.GetHostName();
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
                foreach (IPAddress ip in hostEntry.AddressList){
                    if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork){
                        IpAddress = ip.ToString();
                        break;
                    }
                }
                
                Domain = IPGlobalProperties.GetIPGlobalProperties().DomainName;
                UserName = Environment.UserName;
                Console.WriteLine(UserName);
            }catch (Exception e){
                Console.WriteLine("Error obteniendo informacion de red: " + e.Message);
            }
        }
    }
}