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
    public partial class frmVerDetalle : Form
    {
        private Articulo articulo = null;

        public frmVerDetalle()
        {
            InitializeComponent();
        }
        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            lblNombreArticulo.Text = articulo.Nombre;
            lblCodigo.Text += " " + articulo.Codigo;
            lblNombreMarca.Text += " " + articulo.Fabricante.Nombre;
            lblModelo.Text += " " + articulo.Nombre;
            lblCategoria.Text += " " + articulo.Tipo.Descripcion;
            lblPrecio.Text += " " +  articulo.Precio.ToString();
            rtbDescripcion.Text = articulo.Descripcion;

            cargarImagen(articulo.UrlImg);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrlImagen.Load(imagen);
            }
            catch (Exception)
            {

                pbxUrlImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
