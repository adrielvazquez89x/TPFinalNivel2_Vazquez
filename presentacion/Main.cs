using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
           
        }
        private void btnAbrirArticulos_Click(object sender, EventArgs e)
        {
            

            foreach (var window in Application.OpenForms)
            {
                if (window.GetType() == typeof(frmListadoMarcas) || window.GetType() == typeof(frmListadoArticulos))
                {
                    return;
                }
            }

            frmListadoArticulos listadoArt = new frmListadoArticulos();
            listadoArt.MdiParent = this;
            listadoArt.Show();
        }

        private void btnAbrirMarcas_Click(object sender, EventArgs e)
        {
            foreach (var window in Application.OpenForms)
            {
                if (window.GetType() == typeof(frmListadoMarcas) || window.GetType() == typeof (frmListadoArticulos))
                {
                    return;
                }
            }

            frmListadoMarcas listadoMarcas = new frmListadoMarcas();
            listadoMarcas.MdiParent = this;
            listadoMarcas.Size = this.Size;
            listadoMarcas.Show();
        }

    }
}
