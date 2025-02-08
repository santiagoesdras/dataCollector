using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;

namespace dataCollector{
    public class DiskInfo{
        public  string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public long TotalSize { get; set; }
        public long Freespace { get; set; }
        public long FileSystem { get; set; } 

        public void DisplayInfo(){
            Console.WriteLine($"Disco: {Name}");
            Console.WriteLine($"Tipo: {Type}");
            Console.WriteLine($"Tamaño total: {TotalSize} GB");
            Console.WriteLine($"Espacio Libre: {Freespace} GB");
            Console.WriteLine($"Sistema de Archivos: {FileSystem}");
        }
    }
}