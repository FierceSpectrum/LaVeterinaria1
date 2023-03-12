using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaVeterinaria1
{
    public partial class InMascota : Form
    {
        public InMascota()
        {
            InitializeComponent();
        }

        private void Mascota_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascota Mascota = new Mascota(0, TxtNMascota.Text, TxtTipoAnimal.Text, TxtRaza.Text, Convert.ToInt32(TxtPeso.Text), Convert.ToInt32(TxtMedida.Text), Convert.ToInt32(TxtIDdueño.Text));
            if (Mascota.Guardar_Mascota(Mascota) != true)
            {
                MessageBox.Show("Actualmente esta cedula no esta registrada", "Inicio de Secion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se a Registrado con Exito", "Inicio de Secion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNMascota.Text = "";
                TxtTipoAnimal.Text = "";
                TxtRaza.Text = "";
                TxtPeso.Text = "";
                TxtMedida.Text = "";
                TxtIDdueño.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNMascota.Text = "";
            TxtTipoAnimal.Text = "";
            TxtRaza.Text = "";
            TxtPeso.Text = "";
            TxtMedida.Text = "";
            TxtIDdueño.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.mipanel.Controls.Count > 0)
            {
                Form1.mipanel.Controls.RemoveAt(0);
            }
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtidentificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgreEnfe_Click(object sender, EventArgs e)
        {
            Panel pane2 = Form1.mipanel;
            Funciones.Abrirfh(new InEnfermedad(), pane2);
        }
    }
}
