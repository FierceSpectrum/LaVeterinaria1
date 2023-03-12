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
        public void CerrarVentanas()
        {
            PMedicamento.Visible = false;
            PverMedi.Visible = false;
            PAmedicamento.Visible = false;
            PBormedi.Visible = false;
        }
        public CrudMedicamentos()
        {
            InitializeComponent();
        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            switch (PMedicamento.Visible)
            {
                case true:
                    CerrarVentanas();
                    PMedicamento.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PMedicamento.Visible = true;
                    break;
            }

        }

        private void BtnleerMedi_Click(object sender, EventArgs e)
        {
            switch (PverMedi.Visible)
            {
                case true:
                    CerrarVentanas();
                    PverMedi.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PverMedi.Visible = true;
                    break;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            switch (PAmedicamento.Visible)
            {
                case true:
                    CerrarVentanas();
                    PAmedicamento.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PAmedicamento.Visible = true;
                    break;
            }
        }

        private void BtnBorrarmedi_Click(object sender, EventArgs e)
        {
            switch (PBormedi.Visible)
            {
                case true:
                    CerrarVentanas();
                    PBormedi.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                   PBormedi.Visible = true;
                    break;
            }
        }
    }
}
