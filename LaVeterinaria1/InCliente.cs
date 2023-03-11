using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaVeterinaria1;
using System.IO;



namespace LaVeterinaria1
{
    public partial class InCliente : Form
    {
        String Ruta = "";
        bool nuevo = true;

        public InCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMascota_Click(object sender, EventArgs e)
        {
            Panel pane2 = Form1.mipanel;
            Funciones.Abrirfh(new InMascota(), pane2);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente Client = new Cliente(0,Convert.ToInt32(Txtidentificar.Text), Convert.ToInt32(TxtTelefono.Text), TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text);
            Cliente.Guardar_Cliente(Client);
            Txtidentificar.Text = "";
            TxtTelefono.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDireccion.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtidentificar.Text = "";
            TxtTelefono.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDireccion.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (Form1.mipanel.Controls.Count > 0)
            {
                Form1.mipanel.Controls.RemoveAt(0);
            }
        }
    }
}
