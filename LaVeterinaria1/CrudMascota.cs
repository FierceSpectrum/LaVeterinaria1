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
        public void CerrarVentanas()
        {
            PMascota.Visible = false;
            PvMascota.Visible = false;
            PactualizarMas.Visible = false;
            PborrarMascota.Visible = false;
        }
        public CrudMascota()
        {
            InitializeComponent();
        }

        private void CrudMascota_Load(object sender, EventArgs e)
        {

        }

        private void Btnleercliente_Click(object sender, EventArgs e)
        {
            switch (PvMascota.Visible)
            {
                case true:
                    CerrarVentanas();
                    PvMascota.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PvMascota.Visible = true;
                    break;
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            switch (PactualizarMas.Visible)
            {
                case true:
                    CerrarVentanas();
                    PactualizarMas.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PactualizarMas.Visible = true;
                    break;
            }
        }

        private void BtnBoCliente_Click(object sender, EventArgs e)
        {
            switch (PborrarMascota.Visible)
            {
                case true:
                    CerrarVentanas();
                    PborrarMascota.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PborrarMascota.Visible = true;
                    break;
            }
        }

        private void PvMascota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            switch (PMascota.Visible)
            {
                case true:
                    CerrarVentanas();
                   PMascota.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PMascota.Visible = true;
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
