using System.Data;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic;

namespace dataCollector{
    public class CsvHandler{
        private static string[] datas = {"Serie", "Activo", "Modelo", "Procesador", "Velocidad", "Memoria",
         "Disco", "Sistema Operativo", "Ip", "Office"};
        public void dataWritter(){
            string filepath = "../datos.csv";
            if(writeHeader(filepath)){
                try{
                    insertData(); 
                }catch(Exception e){
                    Console.WriteLine(e.ToString());    
                }
            }



        }
        public bool writeHeader(string filepath){
            bool fileExists = File.Exists(filepath);
            bool fileIsEmpty = new FileInfo(filepath).Length == 0;
            if(!fileExists || fileIsEmpty){
                using (var writer = new StreamWriter(filepath, append: true))
                using (var csv = new  CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture))){
                    foreach( string data in datas){
                        csv.WriteField(data);
                        csv.NextRecord();
                    }
                }
                return true;
            }else{
                Console.WriteLine($"Archivo csv ya existe, escribiendo datos en nuevo registro del archivo {filepath}");
                return false;
            }
        }
        public void insertData(){
            List<string> ComputerInfo = new List<string>();

        }
    }
}