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



namespace LaVeterinaria1
{
    public partial class CrudCliente : Form
    {
        public string CRUD;
        public Cliente Cliente;
        public CrudCliente()
        {
            InitializeComponent();

        }
        public void Create()
        {
            Cliente Client = new Cliente(0, Convert.ToInt32(TxtIndentificacion.Text), Convert.ToInt32(TxtTelefono.Text), TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text);
            if (Cliente.Guardar_Cliente(Client) != true)
            {
                MessageBox.Show("Actualmente esta cedula ya esta registrada", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se a Registrado con Exito", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIndentificacion.Text = "";
                TxtTelefono.Text = "";
                TxtNombre.Text = "";
                TxtApellido.Text = "";
                TxtDireccion.Text = "";
            }
        }
        public void Readtrue()
        {
            TxtIndentificacion.ReadOnly = true;
            TxtTelefono.ReadOnly = true;
            TxtNombre.ReadOnly = true;
            TxtApellido.ReadOnly = true;
            TxtDireccion.ReadOnly = true;
        }
        public void Readfalse()
        {
            TxtIndentificacion.ReadOnly = false;
            TxtTelefono.ReadOnly = false;
            TxtNombre.ReadOnly = false;
            TxtApellido.ReadOnly = false;
            TxtDireccion.ReadOnly = false;
        }
        public void Read()
        {
            Readtrue();
        }
        public void Update()
        {
            List<Cliente> Clientes = Cliente.Cargar_Cliente();
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Key == Cliente.Key)
                {
                    cliente.Identificacion = Convert.ToInt32(TxtIndentificacion.Text);
                    cliente.Cell = Convert.ToInt32(TxtTelefono.Text);
                    cliente.Nombre = TxtNombre.Text;
                    cliente.Appellidos = TxtApellido.Text;
                    cliente.Direccion = TxtDireccion.Text;
                }
            }
            Cliente.EliminarArchivo(Clientes);
            MessageBox.Show("Se a Actualisado con Exito", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtIndentificacion.Text = "";
            TxtTelefono.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDireccion.Text = "";
        }
        private void Delete()
        {
            List<Cliente> Clientes = Cliente.Cargar_Cliente();
            Clientes.RemoveAt(Cliente.Key - 1);
            Cliente.EliminarArchivo(Clientes);
        }
        public void ComboBox()
        {
            ListaClientes.Items.Clear();
            ListaClientes.Text = "Clientes";

            if (Cliente.Existencia_Archivo())
            {
                List<Cliente> Clientes = Cliente.Cargar_Cliente();
                ListaClientes.Items.AddRange(Clientes.ToArray());
            }
            else
            { MessageBox.Show("No hay clientes", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            TxtIndentificacion.ReadOnly = true;
            this.CRUD = "U";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "C";
        }

        private void PVercliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBoCliente_Click(object sender, EventArgs e)
        {
            Readfalse();
            this.CRUD = "D";
        }

        private void Cmb_Leercliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente = ListaClientes.SelectedItem as Cliente;
            TxtIndentificacion.Text = "" + Cliente.Identificacion;
            TxtTelefono.Text = "" + Cliente.Cell;
            TxtNombre.Text = Cliente.Nombre;
            TxtApellido.Text = Cliente.Appellidos;
            TxtDireccion.Text = Cliente.Direccion;
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtIndentificacion.Text = "";
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
