using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;

namespace dataCollector{
    public class DiskInfo{
        public  string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public long TotalSize { get; set; }
        public long FreeSpace { get; set; }
        public string FileSystem { get; set; } = "";

        public void DisplayInfo(){
            Console.WriteLine($"Disco: {Name}");
            Console.WriteLine($"Tipo: {Type}");
            Console.WriteLine($"Tamaño total: {TotalSize / (1024 * 1024 * 1024)} GB");
            Console.WriteLine($"Espacio Libre: {FreeSpace / (1024 * 1024 * 1024)} GB");
            Console.WriteLine($"Sistema de Archivos: {FileSystem}");
        }
        public static List<DiskInfo> GetDiskInfo(){
            List<DiskInfo> disks = new List<DiskInfo>();
            foreach (DriveInfo drive in DriveInfo.GetDrives()){
                if (drive.IsReady){
                    disks.Add(new DiskInfo
                    {
                        Name = drive.Name,
                        Type = drive.DriveType.ToString(),
                        TotalSize = drive.TotalSize,
                        FreeSpace = drive.AvailableFreeSpace,
                        FileSystem = drive.DriveFormat
                    });
                }
            }
        return disks;
        }
    }
}