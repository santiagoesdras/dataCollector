using System;
using System.Windows.Forms;

namespace dataCollector.ui
{
    public class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;


        public Form1()
        {
            InitializeComponent();
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            this.textBox19 = new System.Windows.Forms.TextBox();
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
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(26, 56);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(275, 20);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "text1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(330, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(275, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "text6";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(330, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(275, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(330, 132);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(275, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(330, 169);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(275, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(330, 209);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(275, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(26, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 20);
            this.textBox5.TabIndex = 14;
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
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(26, 21);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(172, 20);
            this.textBox19.TabIndex = 30;
            // Agregar controles al formulario
            this.Controls.Add(this.textBox19);
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
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DataCollector";
            
            // Configuración general del formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 550);
            this.Text = "Data Collector";
            this.ResumeLayout(false);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox19;
    }
}
