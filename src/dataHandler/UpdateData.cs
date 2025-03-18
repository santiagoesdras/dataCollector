using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace dataCollector.dataHandler{
    public class UpdateData{
        public ComputerInfo computerInfo { get; set; }
        public NetworkInfo networkInfo { get; set; }
        public UiDataModel uiDataModel { get; set; }
        public UiDataModel.UiPcDataModel pcDataModel { get; set; }
        public UpdateData(ref ComputerInfo computerInfo, ref NetworkInfo networkInfo, ref UiDataModel uiDataModel, ref UiDataModel.UiPcDataModel pcDataModel){
            this.computerInfo = computerInfo;
            this.networkInfo = networkInfo;
            this.uiDataModel = uiDataModel;
            this.pcDataModel = pcDataModel;
        }
        public void updatePcData(){
//            Console.WriteLine("Nombre de usuario en uidDataModel: " + uiDataModel.UserName);
            networkInfo.SetUserName(uiDataModel.UserName);
            Console.WriteLine(pcDataModel.ActiveNumber);
            computerInfo.SetDeviceName(pcDataModel.ActiveNumber);

        }
    }
}