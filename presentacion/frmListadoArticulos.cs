using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        public void cargarListado()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                listaArticulos = negocio.listarArticulos();
                dgvListadoArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            cargarListado();
        }
    }
}
