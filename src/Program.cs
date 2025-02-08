using System;
using System.Collections.Generic;
using dataCollector;

    class Program{
        static void Main(string[] args){

            try{
                Console.WriteLine("Obteniendo informacion dels sistema...");
                ComputerInfo computer = new ComputerInfo();
                NetworkInfo network = new NetworkInfo();
                network.GetNetworkInfo();
                computer.GetSystemInfo();
                computer.Disks = DiskInfo.GetDiskInfo();

                Console.WriteLine("\nInformacion del sistema: ");
                computer.DisplayInfo();

                Console.WriteLine("\n===========================================");

                Console.WriteLine("\nObteniendo informacion de discos ...");
                foreach(var disk in computer.Disks){
                    disk.DisplayInfo();
                }

                Console.WriteLine("Obteniendo informacion de red...");
                network.DisplayInfo();                
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
    }