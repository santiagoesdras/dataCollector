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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
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
            // 
            // RAM
            // 
            this.RAM.Location = new System.Drawing.Point(330, 56);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(275, 20);
            this.RAM.TabIndex = 6;
            this.RAM.Text = "text6";
            // 
            // DiskInfo
            // 
            this.DiskInfo.Location = new System.Drawing.Point(330, 93);
            this.DiskInfo.Name = "DiskInfo";
            this.DiskInfo.Size = new System.Drawing.Size(275, 20);
            this.DiskInfo.TabIndex = 7;
            // 
            // OperativeSystem
            // 
            this.OperativeSystem.Location = new System.Drawing.Point(330, 132);
            this.OperativeSystem.Name = "OperativeSystem";
            this.OperativeSystem.Size = new System.Drawing.Size(275, 20);
            this.OperativeSystem.TabIndex = 8;
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(330, 169);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(275, 20);
            this.Ip.TabIndex = 9;
            // 
            // OfficeVersion
            // 
            this.OfficeVersion.Location = new System.Drawing.Point(330, 209);
            this.OfficeVersion.Name = "OfficeVersion";
            this.OfficeVersion.Size = new System.Drawing.Size(275, 20);
            this.OfficeVersion.TabIndex = 10;
            // 
            // ActiveNumber
            // 
            this.ActiveNumber.Location = new System.Drawing.Point(26, 93);
            this.ActiveNumber.Name = "ActiveNumber";
            this.ActiveNumber.Size = new System.Drawing.Size(275, 20);
            this.ActiveNumber.TabIndex = 11;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(26, 132);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(275, 20);
            this.Model.TabIndex = 12;
            // 
            // Processor
            // 
            this.Processor.Location = new System.Drawing.Point(26, 169);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(275, 20);
            this.Processor.TabIndex = 13;
            // 
            // ProcessorSpeed
            // 
            this.ProcessorSpeed.Location = new System.Drawing.Point(26, 209);
            this.ProcessorSpeed.Name = "ProcessorSpeed";
            this.ProcessorSpeed.Size = new System.Drawing.Size(275, 20);
            this.ProcessorSpeed.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 472);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Almacenar Informacion UPS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 511);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Almacenar Informacion Monitor";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(206, 511);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(159, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Almacenar Informacion CPU";
            this.checkBox3.UseVisualStyleBackColor = true;
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
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(26, 315);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(275, 20);
            this.textBox11.TabIndex = 24;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(330, 315);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(275, 20);
            this.textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(330, 278);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(275, 20);
            this.textBox13.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(26, 278);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(275, 20);
            this.textBox14.TabIndex = 21;
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
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(26, 425);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(275, 20);
            this.textBox15.TabIndex = 29;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(330, 425);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(275, 20);
            this.textBox16.TabIndex = 28;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(330, 388);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(275, 20);
            this.textBox17.TabIndex = 27;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(26, 388);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(275, 20);
            this.textBox18.TabIndex = 26;
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


            // Añadir los objetos al formulario
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
                if(control is TextBox textBoxTemp){
                    if(PcDataBoxes.TryGetValue(textBoxTemp.Name, out string newTextBox)){
                        textBoxTemp.Text = newTextBox;
                    }
                }
            }
            this.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox UserName;

        //Declaracion de CheckBoxes
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;

        //Declaracion de Buttons
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        //Declaracion de Labels
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
