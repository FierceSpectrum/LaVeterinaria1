using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaVeterinaria1
{
    public partial class InMedicamento : Form
    {
        public InMedicamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaMascotas.Items.Clear(); 
            ListaMascotas.Text = "Mascotas";
            ListaEnfermedades.Items.Clear();
            ListaEnfermedades.Text = "Enfermedades";
            TxtDueño.Text = "";
            TxtMedicamento.Text = "";
            LNombre.Text = "";
            LAnimal.Text = "";
            LRaza.Text = "";
            LPeso.Text = "";
            LMedida.Text = "";
            LEnfermedad.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enfermedad Enfermedad = ListaEnfermedades.SelectedItem as Enfermedad;
            Medicamento Medicamento = new Medicamento(0, Convert.ToInt32(TxtDueño.Text), TxtMedicamento.Text, Enfermedad.Key);
            if (Medicamento.Guardar_Medicamento(Medicamento) != true)
            {
                MessageBox.Show("Esta ID no esta registrada", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se a agregado con Exito", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDueño.Text = "";
                TxtMedicamento.Text = "";
            }
        }

        private void TxtEnfermedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void PEnfermedad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.mipanel.Controls.Count > 0)
            {
                Form1.mipanel.Controls.RemoveAt(0);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void ListaMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListaEnfermedades.Items.Clear();
            ListaEnfermedades.Text = "Enfermedades";
            Mascota Mascota = ListaMascotas.SelectedItem as Mascota;
            LNombre.Text = Mascota.Nombre;
            LAnimal.Text = Mascota.TipoAnimal;
            LRaza.Text = Mascota.Raza;
            LPeso.Text = "" + Mascota.Peso;
            LMedida.Text = "" + Mascota.Medida;
            if (Enfermedad.Existencia_Archivo())
            {
                List<Enfermedad> Enfermedads = Enfermedad.Cargar_Enfermedad();
                foreach (Enfermedad Enfermedad in Enfermedads)
                {
                    if (Enfermedad.KeyMascota == Mascota.Key)
                    {
                        ListaEnfermedades.Items.Add(Enfermedad);
                    }
                }
            }
            else { MessageBox.Show("No existe la efermedad", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ListaMascotas.Items.Clear();
            ListaMascotas.Text = "Mascotas";
            ListaEnfermedades.Items.Clear();
            ListaEnfermedades.Text = "Enfermedades";
            if (Mascota.Existencia_Archivo())
            {
                List<Mascota> Mascotas = Mascota.Cargar_Mascota();
                foreach (Mascota Mascota in Mascotas)
                {
                    if (Mascota.IdCliente == Convert.ToInt32(TxtDueño.Text))
                    {

                        ListaMascotas.Items.Add(Mascota);
                    }
                }
            }
            else { MessageBox.Show("No existe la mascota", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ListaEnfermedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enfermedad Enfermedad = ListaEnfermedades.SelectedItem as Enfermedad;
            LEnfermedad.Text = Enfermedad.NEfermedad;
        }
    }
}
