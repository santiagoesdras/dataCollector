namespace dataCollector{
    public class DataVerify{
              public bool dataVerify(ref string dataToVerify, string dataType){

                if(dataType == null){
                    return false;
                }
             Console.WriteLine($"{dataType} correcto? {dataToVerify} Si(s), No(n)");
                string response = Console.ReadLine().ToLower();
                if(response == "n"){
                    Console.WriteLine($"Ingrese {dataType} correcto: ");
                    string input = Console.ReadLine();
                    dataToVerify = !string.IsNullOrEmpty(input)? input : input;
                    dataToVerify = dataType == "Numero de activo" ? dataToVerify.Remove(0,1) : dataToVerify;
                    return false;
                }else if (response == "s"){
                    return true;
                }else{
                    Console.WriteLine($"La opcion {response} no existe");
                    return false;
                }
        }
    };
      
}