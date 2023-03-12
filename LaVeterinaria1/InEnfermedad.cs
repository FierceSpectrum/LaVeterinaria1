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
            Enfermedad Enfermedad = new Enfermedad(0, Convert.ToInt32(TxtIdDueño.Text), TxtEnfermedad.Text);
            if (Enfermedad.Guardar_Enfermedad(Enfermedad) != true)
            {
                MessageBox.Show("Esta ID no esta registrada", "Efermedad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se a agregado con Exito", "Efermedad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIdDueño.Text = "";
                TxtEnfermedad.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtIdDueño.Text = "";
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
                foreach (Mascota Mascota in Mascotas)
                {
                    if (Mascota.getIdCliente() == Convert.ToInt32(TxtIdDueño.Text))
                    {
                        ListaMascotas.Items.Add(Mascota.);
                    }                
                }
                
            }
            else { }
            
            
        }
    }
}
