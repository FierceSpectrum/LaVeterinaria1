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
        public void CerrarVentanas()
        {
            PCcliente.Visible = false;
            PVercliente.Visible = false;
            Pactualizar.Visible = false;
            PborrarCliente.Visible = false;
        }
        public CrudCliente()
        {
            InitializeComponent();
        }

        private void Btnleercliente_Click(object sender, EventArgs e)
        {
            
            switch (PVercliente.Visible)
            {
                case true:
                    CerrarVentanas();
                    PVercliente.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PVercliente.Visible = true;
                    break;
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            switch (Pactualizar.Visible)
            {
                case true:
                    CerrarVentanas();
                    Pactualizar.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                   Pactualizar.Visible = true;
                    break;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            switch (PCcliente.Visible)
            {
                case true:
                    CerrarVentanas();
                   PCcliente.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                   PCcliente.Visible = true;
                    break;
            }
        }

        private void PVercliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBoCliente_Click(object sender, EventArgs e)
        {
            switch (PborrarCliente.Visible)
            {
                case true:
                    CerrarVentanas();
                    PborrarCliente.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PborrarCliente.Visible = true;
                    break;
            }
        }

        private void Cmb_Leercliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
