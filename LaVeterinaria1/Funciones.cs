using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaVeterinaria1
{
    public class Funciones
    {
        public static void Abrirfh(object FormHijo, Panel PContenedor)
        {
            if (PContenedor.Controls.Count > 0)
            {
                PContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            PContenedor.Controls.Add(fh);
            PContenedor.Tag = fh;
            fh.Show();
        }
    }
}
