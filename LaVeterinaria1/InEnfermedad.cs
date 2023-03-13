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
    public partial class InEnfermedad : Form
    {
        public InEnfermedad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascota Mascota = ListaMascotas.SelectedItem as Mascota;
            Enfermedad Enfermedad = new Enfermedad(0, Convert.ToInt32(TxtDueño.Text), TxtEnfermedad.Text, Mascota.Key);
            if (Enfermedad.Guardar_Enfermedad(Enfermedad) != true)
            {
                MessageBox.Show("Esta ID no esta registrada", "Efermedad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se a agregado con Exito", "Efermedad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDueño.Text = "";
                TxtEnfermedad.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDueño.Text = "";
            TxtEnfermedad.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.mipanel.Controls.Count > 0)
            {
                Form1.mipanel.Controls.RemoveAt(0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Mascota.Existencia_Archivo())
            {
                List<Mascota> Mascotas = Mascota.Cargar_Mascota();
                int count = 1;
                foreach (Mascota Mascota in Mascotas)
                {
                    if (Mascota.IdCliente == Convert.ToInt32(TxtDueño.Text))
                    {

                        ListaMascotas.Items.Add(Mascota);
                        count++;
                    }
                }
            }
            else
            { MessageBox.Show("No existe la mascota", "Efermedad", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void Cmb_mascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ListaMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mascota Mascota = ListaMascotas.SelectedItem as Mascota;
            LNombre.Text = Mascota.Nombre;
            LAnimal.Text = Mascota.TipoAnimal;
            LRaza.Text = Mascota.Raza;
            LPeso.Text = "" + Mascota.Peso;
            LMedida.Text = "" + Mascota.Medida;
        }

        private void InEnfermedad_Load(object sender, EventArgs e)
        {

        }
    }
}
