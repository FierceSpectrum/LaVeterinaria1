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
        public CrudCliente()
        {
            InitializeComponent();
        }

        private void Btnleercliente_Click(object sender, EventArgs e)
        {
            PVercliente.Visible = true;
            //PVercliente.Visible = true;
            //if (this.PContenedor.Controls.Count > 0)
            //{
            //    this.PContenedor.Controls.RemoveAt(0);
            //}

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Pactualizar.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            PCcliente.Visible = true;
        }

        private void PVercliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBoCliente_Click(object sender, EventArgs e)
        {
            PborrarCliente.Visible = true;
        }
    }
}
