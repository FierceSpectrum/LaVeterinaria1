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
    public partial class Form1 : Form

    {
        public static Panel mipanel;
        String Ruta = "";
        bool nuevo = true;

        public void CerrarVentanas()
        {
            PSubmenu.Visible = false;
            SubReportes.Visible = false;
            Subcrud.Visible = false;
        }
        bool movimiento = false;
        public Form1()
        {
            InitializeComponent();
            mipanel = PContenedor;
        }

        private void BtnCierre_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaxi.Visible = false;
            BtnResta.Visible = true;
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaxi.Visible = true;
            BtnResta.Visible = false;
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InCliente(), this.PContenedor);
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InMascota(), this.PContenedor);
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            switch (PSubmenu.Visible)
            {
                case true:
                    CerrarVentanas();
                    PSubmenu.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    PSubmenu.Visible = true;
                    break;
            }
            if (this.PContenedor.Controls.Count > 0)
            {
                this.PContenedor.Controls.RemoveAt(0);
            }
        }

        private void BtnEnfermedad_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InEnfermedad(), this.PContenedor);
        }

        private void BtnMedicamento_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InMedicamento(), this.PContenedor);
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            switch (SubReportes.Visible)
            {
                case true:
                    CerrarVentanas();
                    SubReportes.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    SubReportes.Visible = true;
                    break;
            }
            if (this.PContenedor.Controls.Count > 0)
            {
                this.PContenedor.Controls.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InReportesEn(), this.PContenedor);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InReporteMedi(), this.PContenedor);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnComparar_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new InComparar(), this.PContenedor);
        }

        private void BtnOpciones_Click(object sender, EventArgs e)
        {
            switch (Subcrud.Visible)
            {
                case true:
                    CerrarVentanas();
                    Subcrud.Visible = false;
                    break;
                case false:
                    CerrarVentanas();
                    Subcrud.Visible = true;
                    break;
            }
            if (this.PContenedor.Controls.Count > 0)
            {
                this.PContenedor.Controls.RemoveAt(0);
            }
        }

        private void BtnEdicliente_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            Funciones.Abrirfh(new CrudCliente(), this.PContenedor);

        }

        private void BtnEdmascota_Click(object sender, EventArgs e)
        {

            CerrarVentanas();
            Funciones.Abrirfh(new CrudMascota(), this.PContenedor);
        }

        private void BtnEdenfermedad_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
        }

        private void BtnEmedicamentos_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
        }
    }
}
