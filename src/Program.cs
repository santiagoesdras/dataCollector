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
        private static string format = "csv";
        static void Main(string[] args){

            try{
                Console.WriteLine("Obteniendo informacion de red...");
                NetworkInfo network = new NetworkInfo();
                network.GetNetworkInfo();

                Console.WriteLine("Obteniendo informacion del sistema...");
                ComputerInfo computer = new ComputerInfo();
                computer.GetSystemInfo();
                
                computer.Disks = DiskInfo.GetDiskInfo();

                JsonManager jsonManager = new JsonManager();
                string json = jsonManager.GenerateJson();
                CsvHandler csvHandler = new CsvHandler();

                Console.WriteLine("\nInformacion del sistema: ");
                computer.DisplayInfo();
                network.DisplayInfo();                

                Console.WriteLine("\n===========================================");

                Console.WriteLine("\nObteniendo informacion de discos ...");
                foreach(var disk in computer.Disks){
                    disk.DisplayInfo();
                }
                Console.WriteLine("Presione Enter para guardar la informacion en el formato seleccionado");
                Console.ReadLine();
                Console.WriteLine(json);
                if(format == "json"){
                    jsonManager.SaveJsonToFile($"{computer.GetDeviceName()}");
                }else if(format == "csv"){
                    csvHandler.insertData();
                }

            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
    }