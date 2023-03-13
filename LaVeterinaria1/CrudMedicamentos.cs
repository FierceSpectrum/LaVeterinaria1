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
    public partial class CrudMedicamentos : Form
    {
        public string CRUD;
        public Medicamento Medicamento;
        public Enfermedad Enfermedad;
        public Mascota Mascota;
        public CrudMedicamentos()
        {
            InitializeComponent();
        }
        public void Create()
        {
            Medicamento Medicamentos = new Medicamento(0, Enfermedad.IdMascota, TxtMedicamento.Text, Enfermedad.Key);
            if (Medicamento.NMedicamento == Medicamentos.NMedicamento && Medicamento.KeyEnfermedad == Medicamentos.KeyEnfermedad)
            {
                if (Medicamento.Guardar_Medicamento(Medicamentos) != true)
                {
                    MessageBox.Show("Actualmente esta Id no exite", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se a Registrado con Exito", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombreAnimal.Text = "";
                    TxtMedicamento.Text = "";
                    TxtEnfermedad.Text = "";
                }
            }
            else { MessageBox.Show("Actualmente este Medicamento ya esta registrada", "EnfMedicamentoermedad", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Readtrue()
        {
            TxtNombreAnimal.ReadOnly = true;
            TxtMedicamento.ReadOnly = true;
            TxtEnfermedad.ReadOnly = true;
        }
        public void Readfalse()
        {
            TxtNombreAnimal.ReadOnly = false;
            TxtMedicamento.ReadOnly = false;
            TxtEnfermedad.ReadOnly = false;
        }
        public void Read()
        {
            Readtrue();
        }
        public void Update()
        {
            List<Medicamento> Medicamentos = Medicamento.Cargar_Medicamento();
            foreach (Medicamento medicamento in Medicamentos)
            {
                if (medicamento.Key == Medicamento.Key)
                {
                    medicamento.IdEfermedad = Enfermedad.IdMascota;
                    medicamento.NMedicamento = TxtMedicamento.Text;
                    medicamento.KeyEnfermedad = Enfermedad.Key;
                }
            }
            Medicamento.EliminarArchivo(Medicamentos);
            MessageBox.Show("Se a Actualisado con Exito", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtNombreAnimal.Text = "";
            TxtMedicamento.Text = "";
            TxtEnfermedad.Text = "";
        }
        private void Delete()
        {
            List<Medicamento> Medicamentos = Medicamento.Cargar_Medicamento();
            Medicamentos.RemoveAt(Medicamento.Key - 1);
            Medicamento.EliminarArchivo(Medicamentos);
        }
        public void ComboBox()
        {
            ListaMedicamentos.Items.Clear();
            ListaMedicamentos.Text = "Medicamentos";

            if (Enfermedad.Existencia_Archivo())
            {
                List<Medicamento> Medicamentos = Medicamento.Cargar_Medicamento();
                ListaMedicamentos.Items.AddRange(Medicamentos.ToArray());
            }
            else
            { MessageBox.Show("No hay Medicamentos", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "C";
        }

        private void BtnleerMedi_Click(object sender, EventArgs e)
        {
            Readtrue();
            this.CRUD = "R";
            ComboBox();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Readfalse();
            TxtNombreAnimal.ReadOnly = true;
            this.CRUD = "U";
        }

        private void BtnBorrarmedi_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "D";
        }

        private void CrudMedicamentos_Load(object sender, EventArgs e)
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
            TxtNombreAnimal.Text = "";
            TxtMedicamento.Text = "";
            TxtEnfermedad.Text = "";
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

        private void ListaMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicamento = ListaMedicamentos.SelectedItem as Medicamento;
            if (Enfermedad.Existencia_Archivo())
            {
                List<Enfermedad> Enfermedades = Enfermedad.Cargar_Enfermedad();
                foreach (Enfermedad enfermedad in Enfermedades)
                {
                    if (enfermedad.Key == Medicamento.KeyEnfermedad)
                    {
                        Enfermedad = enfermedad;
                    }
                }
            }
            else
            { MessageBox.Show("No hay Enfermedad", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            { MessageBox.Show("No hay Mascotas", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            TxtNombreAnimal.Text = Mascota.Nombre;
            TxtMedicamento.Text = Medicamento.NMedicamento;
            TxtEnfermedad.Text = Enfermedad.NEfermedad;
        }
    }
}
