using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using dataCollector;

namespace dataCollector.ui
{
    public class MainForm : Form
    {
        private Button btnGetInfo;
        private TextBox txtInfo;
        private Label label1;
        
        public MainForm()
        {
            // Configuración básica de la ventana
            this.Text = "Data Collector";
            this.Size = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Crear botón
            btnGetInfo = new Button();
            btnGetInfo.Text = "Obtener Datos";
            btnGetInfo.Size = new Size(150, 40);
            btnGetInfo.Location = new Point(175, 200);
            btnGetInfo.Click += BtnGetInfo_Click;

            // Crear caja de texto
            txtInfo = new TextBox();
            txtInfo.Size = new Size(200, 40);
            txtInfo.Multiline = true;
            txtInfo.Location = new Point(50, 120);

            // Crear label para mostrar informacion de CPU
            label1 = new Label();
            label1.Text = "Procesador";
            label1.Size = new Size(75, 50);
            label1.Location = new Point(20, 80);


            // Agregar controles al formulario
            this.Controls.Add(btnGetInfo);
            this.Controls.Add(txtInfo);
            this.Controls.Add(label1);
        }

        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            // Llamar a la lógica existente (SystemInfo.cs)
            ComputerInfo computer = new ComputerInfo();
            computer.GetSystemInfo();
            string cpuInfo = computer.GetProcessorInfo();
            txtInfo.Text = cpuInfo;
        }
    }
}
