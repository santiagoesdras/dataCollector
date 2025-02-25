using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic;

namespace dataCollector{
    public class CsvHandler{
        private static string[][] datas = {["Nombre de Usuario", "Serie", "Activo", "Modelo", "Procesador", "Velocidad (Ghz)", "Memoria (MB)",
         "Disco", "Sistema Operativo", "Ip", "Office"], ["Nombre de Usuario", "Marca", "Activo", "Serie"], ["Nombre de usuario", "Activo", "Marca", "Modelo", "Serie"]};
        public static List<string> ActiveInfo = new List<string>();
        public void dataWritter(string[] CsvStrings, int activeType){
            ActiveInfo.Clear();
            string[] filepath = {"CPU.csv", "Monitor.csv", "UPS.csv"};
            if(writeHeader(filepath[activeType], activeType)){
                try{
                    insertData(CsvStrings);
                    using (var writer = new StreamWriter(filepath[activeType], append: true))
                    using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture))){
                        foreach(string info in ActiveInfo){
                            csv.WriteField(info);
                        }
                        csv.NextRecord();
                    }
                }catch(Exception e){
                    Console.WriteLine(e.ToString());    
                }
            }
        }
        public bool writeHeader(string filepath, int activeType){
            bool fileExists = File.Exists(filepath);
            bool fileIsEmpty = fileExists && new FileInfo(filepath).Length == 0;
            if(!fileExists || fileIsEmpty){
                using (var writer = new StreamWriter(filepath, append: true))
                using (var csv = new  CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture))){
                    foreach( string data in datas[activeType]){
                        csv.WriteField(data);
                    }
                    csv.NextRecord();
                }
                return true;
            }else{
                Console.WriteLine($"Archivo csv ya existe, escribiendo datos en nuevo registro del archivo {filepath}");
                return true;
            }
        }
        public void insertData(string[] CsvStrings){
            foreach(string data in CsvStrings){
                ActiveInfo.Add(data);
            }
        }
    }
}