/*
    DataCollector - Sistema de registro de hardware y red
    Copyright (c) 2025 [Esdras Santiago]

    Este software es propiedad de [Esdras Santiago].
    Está diseñado para uso interno y no se permite su distribución sin autorización.

    Para más información, contacta a: [github.com/santiagoesdras]
*/

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

               /*  Console.WriteLine("Obteniendo informacion de monitor...");
                MonitorInfo monitor = new MonitorInfo(); */
                
                computer.Disks = DiskInfo.GetDiskInfo();

                JsonManager jsonManager = new JsonManager();
                string json = jsonManager.GenerateJson();
                CsvHandler csvHandler = new CsvHandler();

                Console.WriteLine("\nInformacion del sistema: ");
                computer.DisplayInfo();
                network.DisplayInfo();
/*                 monitor.DisplayInfo();   */              

                Console.WriteLine("\n===========================================");

                Console.WriteLine("\nObteniendo informacion de discos ...");
                foreach(var disk in computer.Disks){
                    disk.DisplayInfo();
                }
                while(true){
                    string activeNumber = computer.GetDeviceName();
                    if(activeNumberVerify(ref activeNumber)){
                        logger(ref network, ref computer, ref jsonManager, ref csvHandler, ref json);  
                        break; 
                    }
                    computer.SetDeviceName(activeNumber);
                }

            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
        public static bool activeNumberVerify(ref string activeNumber){
             Console.WriteLine($"Es este el numero de activo correcto? {activeNumber} Si(s), No(n)");
                string response = Console.ReadLine().ToLower();
                if(response == "n"){
                    Console.WriteLine("Ingrese el numero de activo correcto: ");
                    string input = Console.ReadLine();
                    activeNumber = !string.IsNullOrEmpty(input) ? input.Remove(0,1) : input;
                    return false;
                }else if (response == "s"){
                    return true;
                }else{
                    Console.WriteLine($"La opcion {response} no existe");
                    return false;
                }
        }
        public static void logger(ref NetworkInfo network, ref ComputerInfo computer, ref JsonManager jsonManager, ref CsvHandler csvHandler, ref string json){
            Console.WriteLine(json);
                if(format == "json"){
                    jsonManager.SaveJsonToFile($"{computer.GetDeviceName()}");
                }else if(format == "csv"){
                        List<string> disks = new List<string>();
                        foreach(DiskInfo disk in computer.GetDisksInfo()){
                            disks.Add(disk.Name.ToString() + " " + (disk.TotalSize/(1024 * 1024 * 1024)).ToString() + "GB");
                        }
                    string[] CsvStrings = {
                        network.GetUserName(),
                        computer.GetSerialNumber(), 
                        computer.GetDeviceName(),
                        computer.GetManufacturer() + computer.GetModel(),
                        computer.GetProcessorInfo(),
                        (float.Parse(computer.GetProcessorSpeed())/1000).ToString(),
                        computer.GetRamSize().ToString(),
                        disks.First(),
                        computer.GetOperatingSystem(),
                        network.GetIpAddress()
                    };
                    csvHandler.dataWritter(CsvStrings);
                }
        }
    }