using System;
using System.Windows.Forms;
using CsvHelper.Configuration.Attributes;
using dataCollector.dataHandler;

namespace dataCollector.ui
{
    public class Form1 : Form
    {
        private bool SavePcInfo;
        private bool SaveUpsInfo;
        private bool SaveMonitorInfo;
        private System.ComponentModel.IContainer components = null;
        private Dictionary<string, string> _PcDataBoxes;
        private UiDataModel dataModel;
        private UiDataModel.UiPcDataModel pcDataModel;
        private UiDataModel.UiUpsDataModel uiUpsDataModel;
        private UiDataModel.UiMonitorModel monitorDataModel;
        UpdateData updateData;
        CsvHandler csvHandler;

        public Form1(ref ComputerInfo computerInfo, ref NetworkInfo networkInfo, ref UpsInfo upsInfo, ref MonitorInfo monitorInfo)
        {
            InitializeComponent();
            UiDataModel uiDataModel = new UiDataModel();
            dataModel = uiDataModel.GenerateUiData(ref computerInfo, ref networkInfo);
            pcDataModel = uiDataModel.GenerateUiData(ref computerInfo, ref networkInfo);
            uiUpsDataModel = new UiDataModel.UiUpsDataModel();
            monitorDataModel = new UiDataModel.UiMonitorModel();
            InitializeDataBindings();
            updateData = new UpdateData(ref computerInfo, ref networkInfo, ref upsInfo, ref monitorInfo, ref dataModel, ref pcDataModel, ref uiUpsDataModel, ref monitorDataModel);
            csvHandler = new CsvHandler(ref networkInfo, ref computerInfo, ref upsInfo, ref monitorInfo);
        }
        private void InitializeDataBindings(){
            //Vinculando informacion PC
            UserName.DataBindings.Add("Text", dataModel, "UserName", false, DataSourceUpdateMode.OnPropertyChanged);
            SerialNumber.DataBindings.Add("Text", pcDataModel, "SerialNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            ActiveNumber.DataBindings.Add("Text", pcDataModel, "ActiveNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            Model.DataBindings.Add("Text", pcDataModel, "Model", false, DataSourceUpdateMode.OnPropertyChanged);
            Processor.DataBindings.Add("Text", pcDataModel, "Processor", false, DataSourceUpdateMode.OnPropertyChanged);
            ProcessorSpeed.DataBindings.Add("Text", pcDataModel, "ProcessorSpeed", false, DataSourceUpdateMode.OnPropertyChanged);
            RAM.DataBindings.Add("Text", pcDataModel, "RAM", false, DataSourceUpdateMode.OnPropertyChanged);
            DiskInfo.DataBindings.Add("Text", pcDataModel, "DiskInfo", false, DataSourceUpdateMode.OnPropertyChanged);
            OperativeSystem.DataBindings.Add("Text", pcDataModel, "OperativeSystem", false, DataSourceUpdateMode.OnPropertyChanged);
            Ip.DataBindings.Add("Text", pcDataModel, "Ip", false, DataSourceUpdateMode.OnPropertyChanged);
            OfficeVersion.DataBindings.Add("Text", pcDataModel, "OfficeVersion", false, DataSourceUpdateMode.OnPropertyChanged);

            //Vinculando informacion UPS
            UpsActiveNumber.DataBindings.Add("Text", uiUpsDataModel, "UpsActiveNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            UpsBrand.DataBindings.Add("Text", uiUpsDataModel, "UpsBrand", false, DataSourceUpdateMode.OnPropertyChanged);
            UpsModel.DataBindings.Add("Text", uiUpsDataModel, "UpsModel", false, DataSourceUpdateMode.OnPropertyChanged);
            UpsSerialNumber.DataBindings.Add("Text", uiUpsDataModel, "UpsSerialNumber", false, DataSourceUpdateMode.OnPropertyChanged);

            //Vinculando informacion Monitor
            MonitorActiveNumber.DataBindings.Add("Text", monitorDataModel, "MonitorActiveNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            MonitorSerialNumber.DataBindings.Add("Text", monitorDataModel, "MonitorSerialNumber", false, DataSourceUpdateMode.OnPropertyChanged);
            MonitorBrand.DataBindings.Add("Text", monitorDataModel, "MonitorBrand", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            // Inicialización de controles
            this.label1 = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.RAM = new System.Windows.Forms.TextBox();
            this.DiskInfo = new System.Windows.Forms.TextBox();
            this.OperativeSystem = new System.Windows.Forms.TextBox();
            this.Ip = new System.Windows.Forms.TextBox();
            this.OfficeVersion = new System.Windows.Forms.TextBox();
            this.ActiveNumber = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Processor = new System.Windows.Forms.TextBox();
            this.ProcessorSpeed = new System.Windows.Forms.TextBox();
            this.UpsInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.MonitorInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.CpuInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UpsBrand = new System.Windows.Forms.TextBox();
            this.UpsSerialNumber = new System.Windows.Forms.TextBox();
            this.UpsModel = new System.Windows.Forms.TextBox();
            this.UpsActiveNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MonitorActiveNumber = new System.Windows.Forms.TextBox();
            this.MonitorSerialNumber = new System.Windows.Forms.TextBox();
            this.MonitorBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.ActiveNumberLabel = new System.Windows.Forms.Label();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion PC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(26, 56);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(275, 20);
            this.SerialNumber.TabIndex = 1;
            this.SerialNumber.PlaceholderText = "SerialNumber";            
            this.SerialNumber.TextChanged += TextBox_TextChanged;
            //
            //ActiveNumberLabel
            //
            this.ActiveNumberLabel.AutoSize = true;
            this.ActiveNumberLabel.Location = new System.Drawing.Point(30, 79);
            this.ActiveNumberLabel.Name = "ActiveNumberLabel";
            this.ActiveNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.ActiveNumberLabel.TabIndex = 35;
            this.ActiveNumberLabel.Text = "No. Activo";
            // 
            // ActiveNumber
            // 
            this.ActiveNumber.Location = new System.Drawing.Point(26, 93);
            this.ActiveNumber.Name = "ActiveNumber";
            this.ActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.ActiveNumber.TabIndex = 2;
            this.ActiveNumber.PlaceholderText = "ActiveNumber";
            this.ActiveNumber.TextChanged += TextBox_TextChanged;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(26, 132);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(275, 20);
            this.Model.TabIndex = 3;
            this.Model.PlaceholderText = "Model";
            this.Model.TextChanged += TextBox_TextChanged;
            // 
            // Processor
            // 
            this.Processor.Location = new System.Drawing.Point(26, 169);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(275, 20);
            this.Processor.TabIndex = 4;
            this.Processor.PlaceholderText = "Processor";
            this.Processor.TextChanged += TextBox_TextChanged;
            // 
            // ProcessorSpeed
            // 
            this.ProcessorSpeed.Location = new System.Drawing.Point(26, 209);
            this.ProcessorSpeed.Name = "ProcessorSpeed";
            this.ProcessorSpeed.Size = new System.Drawing.Size(275, 20);
            this.ProcessorSpeed.TabIndex = 5;
            this.ProcessorSpeed.PlaceholderText = "ProcessorSpeed";
            this.ProcessorSpeed.TextChanged += TextBox_TextChanged;
            // 
            // RAM
            // 
            this.RAM.Location = new System.Drawing.Point(330, 56);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(275, 20);
            this.RAM.TabIndex = 6;
            this.RAM.PlaceholderText = "RAM";
            this.RAM.TextChanged += TextBox_TextChanged;
            // 
            // DiskInfo
            // 
            this.DiskInfo.Location = new System.Drawing.Point(330, 93);
            this.DiskInfo.Name = "DiskInfo";
            this.DiskInfo.Size = new System.Drawing.Size(275, 20);
            this.DiskInfo.TabIndex = 7;
            this.DiskInfo.PlaceholderText = "DiskInfo";
            this.DiskInfo.TextChanged += TextBox_TextChanged;
            // 
            // OperativeSystem
            // 
            this.OperativeSystem.Location = new System.Drawing.Point(330, 132);
            this.OperativeSystem.Name = "OperativeSystem";
            this.OperativeSystem.Size = new System.Drawing.Size(275, 20);
            this.OperativeSystem.TabIndex = 8;
            this.OperativeSystem.PlaceholderText = "OperativeSystem";
            this.OperativeSystem.TextChanged += TextBox_TextChanged;
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(330, 169);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(275, 20);
            this.Ip.TabIndex = 9;
            this.Ip.PlaceholderText = "Ip";
            this.Ip.TextChanged += TextBox_TextChanged;
            // 
            // OfficeVersion
            // 
            this.OfficeVersion.Location = new System.Drawing.Point(330, 209);
            this.OfficeVersion.Name = "OfficeVersion";
            this.OfficeVersion.Size = new System.Drawing.Size(275, 20);
            this.OfficeVersion.TabIndex = 10;
            this.OfficeVersion.PlaceholderText = "OfficeVersion";
            this.OfficeVersion.TextChanged += TextBox_TextChanged;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Informacion UPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpsActiveNumber
            // 
            this.UpsActiveNumber.Location = new System.Drawing.Point(26, 278);
            this.UpsActiveNumber.Name = "UpsActiveNumber";
            this.UpsActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.UpsActiveNumber.TabIndex = 12;
            this.UpsActiveNumber.PlaceholderText = "No. de Activo";
            this.UpsActiveNumber.TextChanged += TextBox_TextChanged;
            // 
            // UpsBrand
            // 
            this.UpsBrand.Location = new System.Drawing.Point(26, 315);
            this.UpsBrand.Name = "UpsBrand";
            this.UpsBrand.Size = new System.Drawing.Size(275, 20);
            this.UpsBrand.TabIndex = 13;
            this.UpsBrand.PlaceholderText = "Marca";
            this.UpsBrand.TextChanged += TextBox_TextChanged;
            // 
            // UpsModel
            // 
            this.UpsModel.Location = new System.Drawing.Point(330, 278);
            this.UpsModel.Name = "UpsModel";
            this.UpsModel.Size = new System.Drawing.Size(275, 20);
            this.UpsModel.TabIndex = 14;
            this.UpsModel.PlaceholderText = "Modelo";
            this.UpsModel.TextChanged += TextBox_TextChanged;
            // 
            // UpsSerialNumber
            // 
            this.UpsSerialNumber.Location = new System.Drawing.Point(330, 315);
            this.UpsSerialNumber.Name = "UpsSerialNumber";
            this.UpsSerialNumber.Size = new System.Drawing.Size(275, 20);
            this.UpsSerialNumber.TabIndex = 15;
            this.UpsSerialNumber.PlaceholderText = "No. de serie";
            this.UpsSerialNumber.TextChanged += TextBox_TextChanged;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Informacion Monitor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorBrand
            // 
            this.MonitorBrand.Location = new System.Drawing.Point(26, 388);
            this.MonitorBrand.Name = "MonitorBrand";
            this.MonitorBrand.Size = new System.Drawing.Size(275, 20);
            this.MonitorBrand.TabIndex = 17;
            this.MonitorBrand.PlaceholderText = "Marca";
            this.MonitorBrand.TextChanged += TextBox_TextChanged;
            // 
            // MonitorActiveNumber
            // 
            this.MonitorActiveNumber.Location = new System.Drawing.Point(26, 425);
            this.MonitorActiveNumber.Name = "MonitorActiveNumber";
            this.MonitorActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.MonitorActiveNumber.TabIndex = 18;
            this.MonitorActiveNumber.PlaceholderText = "No. de activo";
            this.MonitorActiveNumber.TextChanged += TextBox_TextChanged;
            // 
            // MonitorSerialNumber
            // 
            this.MonitorSerialNumber.Location = new System.Drawing.Point(330, 388);
            this.MonitorSerialNumber.Name = "MonitorSerialNumber";
            this.MonitorSerialNumber.Size = new System.Drawing.Size(275, 20);
            this.MonitorSerialNumber.TabIndex = 19;
            this.MonitorSerialNumber.PlaceholderText = "No. de serie";
            this.MonitorSerialNumber.TextChanged += TextBox_TextChanged;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(26, 21);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(172, 20);
            this.UserName.TabIndex = 20;
            this.UserName.TextChanged += TextBox_TextChanged;
            // 
            // UpsInfoCheckBox
            // 
            this.UpsInfoCheckBox.AutoSize = true;
            this.UpsInfoCheckBox.Location = new System.Drawing.Point(26, 472);
            this.UpsInfoCheckBox.Name = "UpsInfoCheckBox";
            this.UpsInfoCheckBox.Size = new System.Drawing.Size(159, 17);
            this.UpsInfoCheckBox.TabIndex = 21;
            this.UpsInfoCheckBox.Text = "Almacenar Informacion UPS";
            this.UpsInfoCheckBox.UseVisualStyleBackColor = true;
            this.UpsInfoCheckBox.AutoCheck = false;
            // 
            // MonitorInfoCheckBox
            // 
            this.MonitorInfoCheckBox.AutoSize = true;
            this.MonitorInfoCheckBox.Location = new System.Drawing.Point(26, 511);
            this.MonitorInfoCheckBox.Name = "MonitorInfoCheckBox";
            this.MonitorInfoCheckBox.Size = new System.Drawing.Size(172, 17);
            this.MonitorInfoCheckBox.TabIndex = 22;
            this.MonitorInfoCheckBox.Text = "Almacenar Informacion Monitor";
            this.MonitorInfoCheckBox.UseVisualStyleBackColor = true;
            this.MonitorInfoCheckBox.AutoCheck = false;
            // 
            // CpuInfoCheckBox
            // 
            this.CpuInfoCheckBox.AutoSize = true;
            this.CpuInfoCheckBox.Location = new System.Drawing.Point(206, 511);
            this.CpuInfoCheckBox.Name = "CpuInfoCheckBox";
            this.CpuInfoCheckBox.Size = new System.Drawing.Size(159, 17);
            this.CpuInfoCheckBox.TabIndex = 23;
            this.CpuInfoCheckBox.Text = "Almacenar Informacion CPU";
            this.CpuInfoCheckBox.UseVisualStyleBackColor = true;
            this.CpuInfoCheckBox.AutoCheck = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Añadir los objetos al formulario
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.MonitorBrand);
            this.Controls.Add(this.MonitorActiveNumber);
            this.Controls.Add(this.MonitorSerialNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpsActiveNumber);
            this.Controls.Add(this.UpsBrand);
            this.Controls.Add(this.UpsSerialNumber);
            this.Controls.Add(this.UpsModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CpuInfoCheckBox);
            this.Controls.Add(this.MonitorInfoCheckBox);
            this.Controls.Add(this.UpsInfoCheckBox);
            this.Controls.Add(this.ProcessorSpeed);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.ActiveNumber);
            this.Controls.Add(this.OfficeVersion);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.OperativeSystem);
            this.Controls.Add(this.DiskInfo);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActiveNumberLabel);
            this.Name = "Form1";
            this.Text = "DataCollector";
            
            // Configuración general del formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 550);
            this.Text = "Data Collector";
            this.ResumeLayout(true);
            this.PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Información sobre la PC");
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(!SavePcInfo || !SaveUpsInfo || !SaveMonitorInfo){
                MessageBox.Show("Debe completar la informacion para almacenarla.");
            }else{
                if(SavePcInfo){
                    updateData.updatePcData();
                    csvHandler.logger();
                }if(SaveUpsInfo){
                    updateData.updateUpsData();
                    csvHandler.UpsLogger();
                }if(SaveMonitorInfo){
                    updateData.updateMonitorData();
                    csvHandler.MonitorLogger();
                }
                    MessageBox.Show("Informacion almacenada.");
                    this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void UpdatePcTextBoxes(Dictionary<string, string> PcDataBoxes){
            this.SuspendLayout();

            foreach(Control control in this.Controls){
                if(control is TextBox textBoxUpsModel){
                    if(PcDataBoxes.TryGetValue(textBoxUpsModel.Name, out string newTextBox)){
                        textBoxUpsModel.Text = newTextBox;
                    }
                }
            }
            this.ResumeLayout(false);
        }
        private void TextBox_TextChanged(object sender, EventArgs e){
            CpuInfoCheckBox.Checked =!string.IsNullOrWhiteSpace(UserName.Text)&&
                                !string.IsNullOrWhiteSpace(SerialNumber.Text) &&
                                !string.IsNullOrWhiteSpace(ActiveNumber.Text) &&
                                !string.IsNullOrWhiteSpace(Model.Text) &&
                                !string.IsNullOrWhiteSpace(Processor.Text) &&
                                !string.IsNullOrWhiteSpace(ProcessorSpeed.Text) &&
                                !string.IsNullOrWhiteSpace(RAM.Text) &&
                                !string.IsNullOrWhiteSpace(DiskInfo.Text) &&
                                !string.IsNullOrWhiteSpace(OperativeSystem.Text) &&
                                !string.IsNullOrWhiteSpace(Ip.Text) &&
                                !string.IsNullOrWhiteSpace(OfficeVersion.Text);

            UpsInfoCheckBox.Checked = !string.IsNullOrWhiteSpace(UpsActiveNumber.Text) &&
                                !string.IsNullOrWhiteSpace(UpsBrand.Text) &&
                                !string.IsNullOrWhiteSpace(UpsSerialNumber.Text) &&
                                !string.IsNullOrWhiteSpace(UpsModel.Text);

            MonitorInfoCheckBox.Checked = !string.IsNullOrWhiteSpace(MonitorActiveNumber.Text)&&
                                !string.IsNullOrWhiteSpace(MonitorSerialNumber.Text)&&
                                !string.IsNullOrWhiteSpace(MonitorBrand.Text);
            SavePcInfo = CpuInfoCheckBox.Checked;
            SaveUpsInfo = UpsInfoCheckBox.Checked;
            SaveMonitorInfo = MonitorInfoCheckBox.Checked;
        }

        //Declaracion de TextBoxes
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.TextBox ActiveNumber;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Processor;
        private System.Windows.Forms.TextBox ProcessorSpeed;
        private System.Windows.Forms.TextBox RAM;
        private System.Windows.Forms.TextBox DiskInfo;
        private System.Windows.Forms.TextBox OperativeSystem;
        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.TextBox OfficeVersion;
        private System.Windows.Forms.TextBox UpsActiveNumber;
        private System.Windows.Forms.TextBox UpsBrand;
        private System.Windows.Forms.TextBox UpsSerialNumber;
        private System.Windows.Forms.TextBox UpsModel;
        private System.Windows.Forms.TextBox MonitorBrand;
        private System.Windows.Forms.TextBox MonitorActiveNumber;
        private System.Windows.Forms.TextBox MonitorSerialNumber;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox UserName;

        //Declaracion de CheckBoxes
        private System.Windows.Forms.CheckBox CpuInfoCheckBox;
        private System.Windows.Forms.CheckBox UpsInfoCheckBox;
        private System.Windows.Forms.CheckBox MonitorInfoCheckBox;

        //Declaracion de Buttons
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        //Declaracion de Labels
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActiveNumberLabel;
    }
}
