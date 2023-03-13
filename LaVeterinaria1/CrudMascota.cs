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
    public partial class CrudMascota : Form
    {
        public string CRUD;
        public Mascota Mascota;
        public CrudMascota()
        {
            InitializeComponent();
        }
        public void Create()
        {
            Mascota Pet = new Mascota(0, TxtNombreMas.Text, TxtTipoAni.Text, TxtRazaAn.Text, Convert.ToInt32(TxtPesoan.Text), Convert.ToInt32(TxtMedida.Text), Convert.ToInt32(TxtIndenMascota.Text));
            if (Mascota.Nombre == Pet.Nombre && Mascota.TipoAnimal == Pet.TipoAnimal) {
                if (Mascota.Guardar_Mascota(Pet) != true)
                {
                    MessageBox.Show("Actualmente esta Id no exite", "Mascota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se a Registrado con Exito", "Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtIndenMascota.Text = "";
                    TxtNombreMas.Text = "";
                    TxtTipoAni.Text = "";
                    TxtRazaAn.Text = "";
                    TxtPesoan.Text = "";
                    TxtMedida.Text = "";
                }
            }
            else { MessageBox.Show("Actualmente esta mascota ya esta registrada", "Mascota", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Readtrue()
        {
            TxtIndenMascota.ReadOnly = true;
            TxtNombreMas.ReadOnly = true;
            TxtTipoAni.ReadOnly = true;
            TxtRazaAn.ReadOnly = true;
            TxtPesoan.ReadOnly = true;
            TxtMedida.ReadOnly = true;
        }
        public void Readfalse()
        {
            TxtIndenMascota.ReadOnly = false;
            TxtNombreMas.ReadOnly = false;
            TxtTipoAni.ReadOnly = false;
            TxtRazaAn.ReadOnly = false;
            TxtPesoan.ReadOnly = false;
            TxtMedida.ReadOnly = false;
        }
        public void Read()
        {
            Readtrue();
        }
        public void Update()
        {
            List<Mascota> Mascotas = Mascota.Cargar_Mascota();
            foreach (Mascota Mascota in Mascotas)
            {
                if (Mascota.Key == Mascota.Key)
                {
                    Mascota.Nombre = TxtNombreMas.Text;
                    Mascota.TipoAnimal = TxtTipoAni.Text;
                    Mascota.Raza = TxtRazaAn.Text;
                    Mascota.Peso = Convert.ToInt32(TxtPesoan.Text);
                    Mascota.Medida = Convert.ToInt32(TxtMedida.Text);
                    Mascota.IdCliente = Convert.ToInt32(TxtIndenMascota.Text);
                }
            }
            Mascota.EliminarArchivo(Mascotas);
            MessageBox.Show("Se a Registrado con Exito", "Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtIndenMascota.Text = "";
            TxtNombreMas.Text = "";
            TxtTipoAni.Text = "";
            TxtRazaAn.Text = "";
            TxtPesoan.Text = "";
            TxtMedida.Text = "";
        }
        private void Delete()
        {
            List<Mascota> Mascotas = Mascota.Cargar_Mascota();
            Mascotas.RemoveAt(Mascota.Key - 1);
            Mascota.EliminarArchivo(Mascotas);
        }
        public void ComboBox()
        {
            ListaMascotas.Items.Clear();
            ListaMascotas.Text = "Mascotas";

            if (Mascota.Existencia_Archivo())
            {
                List<Mascota> Mascotas = Mascota.Cargar_Mascota();
                ListaMascotas.Items.AddRange(Mascotas.ToArray());
            }
            else
            { MessageBox.Show("No hay Mascotas", "Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void CrudMascota_Load(object sender, EventArgs e)
        {

        }

        private void Btnleercliente_Click(object sender, EventArgs e)
        {
            Readtrue();
            this.CRUD = "R";
            ComboBox();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Readfalse();
            TxtIndenMascota.ReadOnly = true;
            this.CRUD = "U";
        }

        private void BtnBoCliente_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "D";
        }

        private void PvMascota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "C";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (Form1.mipanel.Controls.Count > 0)
            {
                Form1.mipanel.Controls.RemoveAt(0);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtIndenMascota.Text = "";
            TxtNombreMas.Text = "";
            TxtTipoAni.Text = "";
            TxtRazaAn.Text = "";
            TxtPesoan.Text = "";
            TxtMedida.Text = "";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.CRUD)
            {
                case "C":
                    Create();
                    break;
                case "R":
                    break;
                case "U":
                    Update();
                    break;
                case "D":
                    Delete();
                    break;
            }
        }

        private void ListaMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mascota = ListaMascotas.SelectedItem as Mascota;
            TxtIndenMascota.Text = "" + Mascota.IdCliente;
            TxtNombreMas.Text = Mascota.Nombre;
            TxtTipoAni.Text = Mascota.TipoAnimal;
            TxtRazaAn.Text = Mascota.Raza;
            TxtPesoan.Text = "" + Mascota.Peso;
            TxtMedida.Text = "" + Mascota.Medida;
        }
    }
}
