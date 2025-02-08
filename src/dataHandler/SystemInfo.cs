namespace dataCollector{
    public class SystemInfo{
        public string OperatingSystem {get;set;} = "";
        public string DeviceName {get;set;} = "";
        public string UserName { get; set;} = "";

        public virtual void DisplayInfo(){
            Console.WriteLine($"Sistema Operativo: {OperatingSystem}");
            Console.WriteLine($"Nombre del Equipo: {DeviceName}");
        }
    } 
}