namespace dataCollector{
    public class MonitorInfo{
        public static string Brand { get; set; } = "";
        public static string ActiveNumber { get; set; } =  "";
        public static string SerialNumber { get; set; } = "";
        public MonitorInfo(){
            //GetMonitorInfo();
        }
        public void DisplayInfo(){
            Console.WriteLine($"Marca: {Brand}");
            Console.WriteLine($"Numero de activo: {ActiveNumber}");
            Console.WriteLine($"Numero de serie: {SerialNumber}");
        }
        public static void GetMonitorInfo(){
            try{
                string[] information = {"Marca", "Numero de activo", "Numero de serie"};
                for(int i  = 0; i < information.Length; i++){
                    string info;
                    while(true){
                        string response;
                        Console.Write($"Inserte {information[i]}: ");
                        info = Console.ReadLine();
                        info = information[i] == "Numero de activo" ? info.Remove(0,1) : info;
                        Console.WriteLine($"{information[i]} {info}");
                        Console.Write($"Informacion sobre {information[i]} correcta ? Si(s), No(n): ");
                        response = Console.ReadLine().ToLower();
                        if(response == "s"){
                            break;
                        }
                    }
                    Brand = i == 0 ? info: Brand;
                    ActiveNumber = i == 1 ? info : ActiveNumber;
                    SerialNumber = i == 2 ? info : SerialNumber;
                }
            }catch(Exception e){
                Console.WriteLine($"Error al obtener datos del monitor: {e.Message}");
            }
        }
        public string GetMonitorBrand(){
            return Brand.ToString();
        }
        public string GetMonitorActiveNumber(){
            return ActiveNumber.ToString(); 
        }
        public string GetMonitorSerialNumber(){
            return SerialNumber.ToString();
        }
    }
}