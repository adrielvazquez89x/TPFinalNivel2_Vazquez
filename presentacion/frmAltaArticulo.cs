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
using dominio;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        //Eventos y métodos que aplican en el formulario de alta de articulos


        private Articulo articulo = null;
         
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo ) //Sobrecarga para modificar
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcas = new MarcasNegocio();
            CategoriasNegocio categorias = new CategoriasNegocio();

            try
            {
                cboMarca.DataSource = marcas.listarMarcas();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Nombre";

                cboCategoria.DataSource = categorias.listarCategorias();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    //Cargamos los campos del objeto.
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrl.Text = articulo.UrlImg;
                    txtPrecio.Text = articulo.Precio.ToString("0.00");
                    cargarImagen(articulo.UrlImg);

                    //Preseleccion de los desplegables

                    cboCategoria.SelectedValue = articulo.Tipo.Id;
                    cboMarca.SelectedValue = articulo.Fabricante.Id;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                if (articulo == null) //Si es nulo, instanciamos.
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.UrlImg = txtUrl.Text;
                articulo.Precio.ToString("0.00");
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Fabricante = (Marca)cboMarca.SelectedItem;
                articulo.Tipo  = (Categoria)cboCategoria.SelectedItem;

                if(articulo.Id != 0)
                {

                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Modificación exitosa.");

                    //Modificar articulo
                }
                else
                {
                    //Agregar artículo:
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Agregado correctamente.");
                   

                }
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string img)
        {
            try
            {
                pbxAltaImagen.Load(img);
            }
            catch (Exception)
            {
                pbxAltaImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }
    }
}
