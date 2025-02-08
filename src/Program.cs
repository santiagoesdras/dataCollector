/*
    DataCollector - Sistema de registro de hardware y red
    Copyright (c) 2025 [Esdras Santiago]

    Este software es propiedad de [Esdras Santiago].
    Está diseñado para uso interno y no se permite su distribución sin autorización.

    Para más información, contacta a: [github.com/santiagoesdras]
*/

using System;
using System.Collections.Generic;
using dataCollector;

    class Program{
        static void Main(string[] args){

            try{
                Console.WriteLine("Obteniendo informacion de red...");
                NetworkInfo network = new NetworkInfo();
                network.GetNetworkInfo();

                Console.WriteLine("Obteniendo informacion del sistema...");
                ComputerInfo computer = new ComputerInfo();
                computer.GetSystemInfo();
                
                computer.Disks = DiskInfo.GetDiskInfo();

                Console.WriteLine("\nInformacion del sistema: ");
                computer.DisplayInfo();
                network.DisplayInfo();                

                Console.WriteLine("\n===========================================");

                Console.WriteLine("\nObteniendo informacion de discos ...");
                foreach(var disk in computer.Disks){
                    disk.DisplayInfo();
                }
                Console.ReadLine();

            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
    }