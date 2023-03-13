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
    public partial class CrudEnfermedad : Form
    {
        public string CRUD;
        public Enfermedad Enfermedad;
        public Mascota Mascota;
        public CrudEnfermedad()
        {
            InitializeComponent();
        }
        public void Create()
        {
            Enfermedad enfermedade = new Enfermedad(0, Mascota.IdCliente, Txtenfermedad.Text, Mascota.Key);
            if (Enfermedad.NEfermedad == enfermedade.NEfermedad && Enfermedad.KeyMascota == enfermedade.KeyMascota)
            {
                if (Enfermedad.Guardar_Enfermedad(enfermedade) != true)
                {
                    MessageBox.Show("Actualmente esta Id no exite", "Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se a Registrado con Exito", "Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombreAnimal.Text = "";
                    Txtenfermedad.Text = "";
                }
            }
            else { MessageBox.Show("Actualmente esta Enfermedad ya esta registrada", "Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Readtrue()
        {
            TxtNombreAnimal.ReadOnly = true;
            Txtenfermedad.ReadOnly = true;
        }
        public void Readfalse()
        {
            TxtNombreAnimal.ReadOnly = false;
            Txtenfermedad.ReadOnly = false;
        }
        public void Read()
        {
            Readtrue();
        }
        public void Update()
        {
            List<Enfermedad> Enfermedades = Enfermedad.Cargar_Enfermedad();
            foreach (Enfermedad enfermedad in Enfermedades)
            {
                if (enfermedad.Key == Enfermedad.Key)
                {
                    enfermedad.IdMascota = Mascota.IdCliente;
                    enfermedad.NEfermedad = Txtenfermedad.Text;
                    enfermedad.KeyMascota = Mascota.Key;
                }
            }
            Enfermedad.EliminarArchivo(Enfermedades);
            MessageBox.Show("Se a Actualisado con Exito", "Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtNombreAnimal.Text = "";
            Txtenfermedad.Text = "";
        }
        private void Delete()
        {
            List<Enfermedad> Enfermedades = Enfermedad.Cargar_Enfermedad();
            Enfermedades.RemoveAt(Enfermedad.Key - 1);
            Enfermedad.EliminarArchivo(Enfermedades);
        }
        public void ComboBox()
        {
            ListaEnfermedades.Items.Clear();
            ListaEnfermedades.Text = "Enfermedades";

            if (Enfermedad.Existencia_Archivo())
            {
                List<Enfermedad> Enfermedades = Enfermedad.Cargar_Enfermedad();
                ListaEnfermedades.Items.AddRange(Enfermedades.ToArray());
            }
            else
            { MessageBox.Show("No hay Enfermedades", "Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void BtnCrearEnfermedad_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "C";
        }

        private void BtnLeerEnfermedad_Click(object sender, EventArgs e)
        {
            Readtrue();
            this.CRUD = "R";
            ComboBox();
        }

        private void BtnActualizarEnfermedad_Click(object sender, EventArgs e)
        {
            Readfalse();
            TxtNombreAnimal.ReadOnly = true;
            this.CRUD = "U";
        }

        private void BtnBorrarEnfermedad_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "D";
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
            TxtNombreAnimal.Text = "";
            Txtenfermedad.Text = "";
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

        private void ListaEnfermedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enfermedad = ListaEnfermedades.SelectedItem as Enfermedad;
            if (Mascota.Existencia_Archivo())
            {
                List<Mascota> Mascotas = Mascota.Cargar_Mascota();
                foreach (Mascota mascota in Mascotas)
                {
                    if (mascota.Key == Enfermedad.KeyMascota)
                    {
                        Mascota = mascota;
                    }
                }
            }
            else
            { MessageBox.Show("No hay Mascotas", "Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            TxtNombreAnimal.Text = Mascota.Nombre;
            Txtenfermedad.Text = Enfermedad.NEfermedad;
        }
    }
}
