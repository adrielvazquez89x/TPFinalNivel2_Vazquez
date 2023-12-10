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
        public List<Articulo> listaArticulos;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void cargarListado()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                listaArticulos = negocio.listarArticulos();
                dgvListadoArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].UrlImg);

                //Datos al lado de la imágen
                lblListadoArticulo.Text = listaArticulos[0].Fabricante.ToString();
                lblListadoModeloArticulo.Text = listaArticulos[0].Nombre.ToString();
                frmListadoPrecioArticulo.Text = "$" + listaArticulos[0].Precio.ToString();
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

        private void ocultarColumnas()
        {
            dgvListadoArticulos.Columns["UrlImg"].Visible = false;
            dgvListadoArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbxImagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImg);

                //Datos al lado de la imágen
                lblListadoArticulo.Text = seleccionado.Fabricante.ToString();
                lblListadoModeloArticulo.Text = seleccionado.Nombre.ToString();
                frmListadoPrecioArticulo.Text = "$" + seleccionado.Precio;
            }
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
        }
    }
}
