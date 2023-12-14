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
        public bool BanderaBtn { get; set; }

        public Main()
        {
            InitializeComponent();
           
        }
        private void btnAbrirArticulos_Click(object sender, EventArgs e)
        {
            if(!VerificarVentanasAbiertas())
            {
                frmListadoArticulos listadoArt = new frmListadoArticulos();
                listadoArt.MdiParent = this;
                listadoArt.Show();
            }

        }

        private void btnAbrirMarcas_Click(object sender, EventArgs e)
        {
            if(!VerificarVentanasAbiertas())
            {
                frmListadoMarcas listadoMarcas = new frmListadoMarcas();
                listadoMarcas.MdiParent = this;
                listadoMarcas.Show();
              
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (!VerificarVentanasAbiertas())
            {
                frmAbout about = new frmAbout();
                about.MdiParent = this;
                about.Show();

            }
        }

        private bool VerificarVentanasAbiertas()
        {
            foreach (Form ventanaAbierta in Application.OpenForms)
            {
                if (ventanaAbierta.GetType() == typeof(frmListadoMarcas) || ventanaAbierta.GetType() == typeof(frmListadoArticulos) || ventanaAbierta.GetType() == typeof(frmAbout))
                {
                    ventanaAbierta.Focus(); 

                    return true; 
                }

            }
            return false; 
        }
        

    }
}
