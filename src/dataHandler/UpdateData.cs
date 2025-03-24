using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace dataCollector.dataHandler{
    public class UpdateData{
        public ComputerInfo computerInfo { get; set; }
        public NetworkInfo networkInfo { get; set; }
        public MonitorInfo monitorInfo { get; set; }
        public UpsInfo upsInfo { get; set; }
        public UiDataModel uiDataModel { get; set; }
        public UiDataModel.UiPcDataModel pcDataModel { get; set; }
        public UiDataModel.UiUpsDataModel uiUpsDataModel { get; set; }
        public UiDataModel.UiMonitorModel uiMonitorModel { get; set; }
        public UpdateData(ref ComputerInfo computerInfo, ref NetworkInfo networkInfo, ref UpsInfo upsInfo, ref MonitorInfo monitorInfo, ref UiDataModel uiDataModel, ref UiDataModel.UiPcDataModel pcDataModel, ref UiDataModel.UiUpsDataModel upsDataModel, ref UiDataModel.UiMonitorModel monitorDataModel){
            this.computerInfo = computerInfo;
            this.networkInfo = networkInfo;
            this.monitorInfo = monitorInfo;
            this.upsInfo = upsInfo;
            this.uiDataModel = uiDataModel;
            this.pcDataModel = pcDataModel;
            this.uiUpsDataModel = upsDataModel;
            this.uiMonitorModel = monitorDataModel;
        }
        public void updatePcData(){
//            Console.WriteLine("Nombre de usuario en uidDataModel: " + uiDataModel.UserName);
            networkInfo.SetUserName(uiDataModel.UserName);
            Console.WriteLine(pcDataModel.ActiveNumber);
            computerInfo.SetDeviceName(pcDataModel.ActiveNumber);
            computerInfo.SetOfficeVersion(pcDataModel.OfficeVersion);
        }
        public void updateUpsData(){
            upsInfo.SetUpsActiveNumber(uiUpsDataModel.UpsActiveNumber);
            upsInfo.SetUpsBrand(uiUpsDataModel.UpsBrand);
            upsInfo.SetUpsModel(uiUpsDataModel.UpsModel);
            upsInfo.SetUpsSerialNumber(uiUpsDataModel.UpsSerialNumber);
        }
        public void updateMonitorData(){
            monitorInfo.SetMonitorActiveNumber(uiMonitorModel.MonitorActiveNumber);
            monitorInfo.SetMonitorSerialNumber(uiMonitorModel.MonitorSerialNumber);
            monitorInfo.SetMonitorBrand(uiMonitorModel.MonitorBrand);
            Console.WriteLine("Activo de monitor: " + monitorInfo.GetMonitorActiveNumber());
        }
    }
}