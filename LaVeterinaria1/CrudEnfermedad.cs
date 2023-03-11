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
        public void CerrarVentanas()
        {
            PEnfermedad.Visible = false;
            PverEnfe.Visible = false;
            Pactuenfe.Visible = false;
            PBorenfe.Visible = false;
        }
        public CrudEnfermedad()
        {
            InitializeComponent();
        }

        private void BtnCrearEnfermedad_Click(object sender, EventArgs e)
        {
            switch (PEnfermedad.Visible)
            {
                case true:
                    CerrarVentanas();
                    PEnfermedad.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PEnfermedad.Visible = true;
                    break;
            }
        }

        private void BtnLeerEnfermedad_Click(object sender, EventArgs e)
        {
            switch (PverEnfe.Visible)
            {
                case true:
                    CerrarVentanas();
                    PverEnfe.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PverEnfe.Visible = true;
                    break;
            }
        }

        private void BtnActualizarEnfermedad_Click(object sender, EventArgs e)
        {
            switch (Pactuenfe.Visible)
            {
                case true:
                    CerrarVentanas();
                    Pactuenfe.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    Pactuenfe.Visible = true;
                    break;
            }
        }

        private void BtnBorrarEnfermedad_Click(object sender, EventArgs e)
        {
            switch (PBorenfe.Visible)
            {
                case true:
                    CerrarVentanas();
                    PBorenfe.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                   PBorenfe.Visible = true;
                    break;
            }
        }
    }
}
