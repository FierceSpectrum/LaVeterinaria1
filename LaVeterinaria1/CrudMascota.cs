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
        public CrudMascota()
        {
            InitializeComponent();
        }

        private void CrudMascota_Load(object sender, EventArgs e)
        {

        }

        private void Btnleercliente_Click(object sender, EventArgs e)
        {
            PvMascota.Visible = true;

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            PactualizarMas.Visible = true;
        }

        private void BtnBoCliente_Click(object sender, EventArgs e)
        {
            PborrarMascota.Visible = true;
        }

        private void PvMascota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCcliente_Click(object sender, EventArgs e)
        {
            PMascota.Visible = true;
        }
    }
}
