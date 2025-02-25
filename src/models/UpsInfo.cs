namespace dataCollector{
    public class UpsInfo{
        public static string ActiveNumber { get; set; } =  "";
        public static string Brand { get; set; } = "";
        public static string Model { get; set; } = ""; 
        public static string SerialNumber { get; set; } = "";
        public UpsInfo(){
            GetUpsInfo();
        }
        public void DisplayInfo(){
            Console.WriteLine($"Numero de activo: {ActiveNumber}");
            Console.WriteLine($"Marca: {Brand}");
            Console.WriteLine($"Modelo {Model}");
            Console.WriteLine($"Numero de serie: {SerialNumber}");
        }
        public static void GetUpsInfo(){
            try{
                string[] information = {"Numero de activo", "Marca", "Modelo", "Numero de serie"};
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
                    ActiveNumber = i == 0 ? info : ActiveNumber;
                    Brand = i == 1 ? info: Brand;
                    Model = i == 2 ? info: Model;
                    SerialNumber = i == 3 ? info : SerialNumber;
                }
            }catch(Exception e){
                Console.WriteLine($"Error al obtener datos del UPS: {e.Message}");
            }
        }
        public string GetUpsActiveNumber(){
            return ActiveNumber.ToString();
        }
        public string GetUpsBrand(){
            return Brand.ToString();
        }
        public string GetUpsModel(){
            return Model.ToString(); 
        }
        public string GetUpsSerialNumber(){
            return SerialNumber.ToString();
        }
    }
}