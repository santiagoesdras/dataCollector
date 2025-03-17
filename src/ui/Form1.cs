using System;
using System.Windows.Forms;

namespace dataCollector.ui
{
    public class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Dictionary<string, string> _PcDataBoxes;


        public Form1(Dictionary<string, string> PcDataBoxes)
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
            _PcDataBoxes = PcDataBoxes;
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
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.MonitorSerialNumber = new System.Windows.Forms.TextBox();
            this.MonitorBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
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
            this.SerialNumber.Text = "text1";
            this.SerialNumber.TextChanged += TextBox_TextChanged;
            // 
            // RAM
            // 
            this.RAM.Location = new System.Drawing.Point(330, 56);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(275, 20);
            this.RAM.TabIndex = 6;
            this.RAM.Text = "text6";
            this.RAM.TextChanged += TextBox_TextChanged;
            // 
            // DiskInfo
            // 
            this.DiskInfo.Location = new System.Drawing.Point(330, 93);
            this.DiskInfo.Name = "DiskInfo";
            this.DiskInfo.Size = new System.Drawing.Size(275, 20);
            this.DiskInfo.TabIndex = 7;
            this.DiskInfo.TextChanged += TextBox_TextChanged;
            // 
            // OperativeSystem
            // 
            this.OperativeSystem.Location = new System.Drawing.Point(330, 132);
            this.OperativeSystem.Name = "OperativeSystem";
            this.OperativeSystem.Size = new System.Drawing.Size(275, 20);
            this.OperativeSystem.TabIndex = 8;
            this.OperativeSystem.TextChanged += TextBox_TextChanged;
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(330, 169);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(275, 20);
            this.Ip.TabIndex = 9;
            this.Ip.TextChanged += TextBox_TextChanged;
            // 
            // OfficeVersion
            // 
            this.OfficeVersion.Location = new System.Drawing.Point(330, 209);
            this.OfficeVersion.Name = "OfficeVersion";
            this.OfficeVersion.Size = new System.Drawing.Size(275, 20);
            this.OfficeVersion.TabIndex = 10;
            this.OfficeVersion.TextChanged += TextBox_TextChanged;
            // 
            // ActiveNumber
            // 
            this.ActiveNumber.Location = new System.Drawing.Point(26, 93);
            this.ActiveNumber.Name = "ActiveNumber";
            this.ActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.ActiveNumber.TabIndex = 11;
            this.ActiveNumber.TextChanged += TextBox_TextChanged;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(26, 132);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(275, 20);
            this.Model.TabIndex = 12;
            this.Model.TextChanged += TextBox_TextChanged;
            // 
            // Processor
            // 
            this.Processor.Location = new System.Drawing.Point(26, 169);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(275, 20);
            this.Processor.TabIndex = 13;
            this.Processor.TextChanged += TextBox_TextChanged;
            // 
            // ProcessorSpeed
            // 
            this.ProcessorSpeed.Location = new System.Drawing.Point(26, 209);
            this.ProcessorSpeed.Name = "ProcessorSpeed";
            this.ProcessorSpeed.Size = new System.Drawing.Size(275, 20);
            this.ProcessorSpeed.TabIndex = 14;
            this.ProcessorSpeed.Text += TextBox_TextChanged;
            // 
            // UpsInfoCheckBox
            // 
            this.UpsInfoCheckBox.AutoSize = true;
            this.UpsInfoCheckBox.Location = new System.Drawing.Point(26, 472);
            this.UpsInfoCheckBox.Name = "UpsInfoCheckBox";
            this.UpsInfoCheckBox.Size = new System.Drawing.Size(159, 17);
            this.UpsInfoCheckBox.TabIndex = 15;
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
            this.MonitorInfoCheckBox.TabIndex = 16;
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
            this.CpuInfoCheckBox.TabIndex = 17;
            this.CpuInfoCheckBox.Text = "Almacenar Informacion CPU";
            this.CpuInfoCheckBox.UseVisualStyleBackColor = true;
            this.CpuInfoCheckBox.AutoCheck = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpsActiveNumber
            // 
            this.UpsActiveNumber.Location = new System.Drawing.Point(26, 278);
            this.UpsActiveNumber.Name = "UpsActiveNumber";
            this.UpsActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.UpsActiveNumber.TabIndex = 21;
            this.UpsActiveNumber.TextChanged += TextBox_TextChanged;
            this.UpsActiveNumber.Text = "UpsActiveNumber";
            // 
            // UpsBrand
            // 
            this.UpsBrand.Location = new System.Drawing.Point(26, 315);
            this.UpsBrand.Name = "UpsBrand";
            this.UpsBrand.Size = new System.Drawing.Size(275, 20);
            this.UpsBrand.TabIndex = 22;
            this.UpsBrand.TextChanged += TextBox_TextChanged;
            this.UpsBrand.Text = "UpsBrand";
            // 
            // UpsModel
            // 
            this.UpsModel.Location = new System.Drawing.Point(330, 278);
            this.UpsModel.Name = "UpsModel";
            this.UpsModel.Size = new System.Drawing.Size(275, 20);
            this.UpsModel.TabIndex = 23;
            this.UpsModel.TextChanged += TextBox_TextChanged;
            this.UpsModel.Text = "UpsModel";
            // 
            // UpsSerialNumber
            // 
            this.UpsSerialNumber.Location = new System.Drawing.Point(330, 315);
            this.UpsSerialNumber.Name = "UpsSerialNumber";
            this.UpsSerialNumber.Size = new System.Drawing.Size(275, 20);
            this.UpsSerialNumber.TabIndex = 24;
            this.UpsSerialNumber.TextChanged += TextBox_TextChanged;
            this.UpsSerialNumber.Text = "UpsSerialNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Informacion UPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorBrand
            // 
            this.MonitorBrand.Location = new System.Drawing.Point(26, 388);
            this.MonitorBrand.Name = "MonitorBrand";
            this.MonitorBrand.Size = new System.Drawing.Size(275, 20);
            this.MonitorBrand.TabIndex = 25;
            this.MonitorBrand.Text = "MonitorBrand";
            // 
            // MonitorActiveNumber
            // 
            this.MonitorActiveNumber.Location = new System.Drawing.Point(26, 425);
            this.MonitorActiveNumber.Name = "MonitorActiveNumber";
            this.MonitorActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.MonitorActiveNumber.TabIndex = 26;
            this.MonitorActiveNumber.Text = "MonitorActiveNumber";
            // 
            // MonitorSerialNumber
            // 
            this.MonitorSerialNumber.Location = new System.Drawing.Point(330, 388);
            this.MonitorSerialNumber.Name = "MonitorSerialNumber";
            this.MonitorSerialNumber.Size = new System.Drawing.Size(275, 20);
            this.MonitorSerialNumber.TabIndex = 27;
            this.MonitorSerialNumber.Text = "MonitorSerialNumber";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(330, 425);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(275, 20);
            this.textBox16.TabIndex = 28;
            this.textBox16.Text = "TextBox16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Informacion Monitor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(26, 21);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(172, 20);
            this.UserName.TabIndex = 30;
            this.UserName.TextChanged += TextBox_TextChanged;

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
            this.Controls.Add(this.textBox16);
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
            MessageBox.Show("Guardando información...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Shown(object sender, EventArgs e){
            UpdatePcTextBoxes(_PcDataBoxes); // Llama la función después de que la UI se ha cargado
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
            CpuInfoCheckBox.Checked = !string.IsNullOrWhiteSpace(SerialNumber.Text) &&
                                !string.IsNullOrWhiteSpace(ActiveNumber.Text) &&
                                !string.IsNullOrWhiteSpace(Model.Text) &&
                                !string.IsNullOrWhiteSpace(Processor.Text) &&
                                !string.IsNullOrWhiteSpace(ProcessorSpeed.Text) &&
                                !string.IsNullOrWhiteSpace(RAM.Text) &&
                                !string.IsNullOrWhiteSpace(DiskInfo.Text) &&
                                !string.IsNullOrWhiteSpace(OperativeSystem.Text) &&
                                !string.IsNullOrWhiteSpace(Ip.Text) &&
                                !string.IsNullOrWhiteSpace(OfficeVersion.Text) &&
                                !string.IsNullOrWhiteSpace(UserName.Text);

            UpsInfoCheckBox.Checked = !string.IsNullOrWhiteSpace(UpsActiveNumber.Text) &&
                                !string.IsNullOrWhiteSpace(UpsBrand.Text) &&
                                !string.IsNullOrWhiteSpace(UpsSerialNumber.Text) &&
                                !string.IsNullOrWhiteSpace(UpsModel.Text);

            //MonitorInfoCheckBox = !string.IsNullOrWhiteSpace();
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
        private System.Windows.Forms.TextBox UpsActiveNumber; //debe ser el 11
        private System.Windows.Forms.TextBox UpsBrand; //debe ser el 12
        private System.Windows.Forms.TextBox UpsSerialNumber; //debe ser el 13
        private System.Windows.Forms.TextBox UpsModel; //debe ser el 14
        private System.Windows.Forms.TextBox MonitorBrand; //  debe ser el 15
        private System.Windows.Forms.TextBox MonitorActiveNumber; //  deber ser el 16
        private System.Windows.Forms.TextBox MonitorSerialNumber; //  debe ser el 17
        private System.Windows.Forms.TextBox textBox16; //  deber ser el 18
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
    }
}
