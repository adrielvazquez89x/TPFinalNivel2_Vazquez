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
using System.Security.Policy;

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
                articulo.Fabricante = (Marca)cboMarca.SelectedItem;
                articulo.Tipo  = (Categoria)cboCategoria.SelectedItem;
                string precio = txtPrecio.Text.Trim();

                if (validarCampos())
                {
                    MessageBox.Show(precio);
                }

                articulo.Precio = Convert.ToDecimal(precio.Replace(".",","));

                //Agregar o modificar articulos
                if (articulo.Id != 0)
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

        private bool validarCampos()
        {
            bool nombre = string.IsNullOrEmpty(txtNombre.Text);
            bool codigo = string.IsNullOrEmpty(txtCodigo.Text);

            if (nombre|| codigo)
            {
                MessageBox.Show("Hay campos requeridos que están vacíos.");

                if(nombre)
                {
                    lblRequeridoNombre.Visible = true;
                    txtNombre.BackColor = Color.LightPink;
                }

                if(codigo)
                {
                    lblRequeridoCodigo.Visible = true;
                    txtCodigo.BackColor = Color.LightPink;

                }
                return true;
            }
            lblRequeridoNombre.Visible = false;
            txtNombre.BackColor = SystemColors.Window;
            lblRequeridoCodigo.Visible = false;
            txtCodigo.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("El campo precio no puede estar vacío");
                lblRequeridoPrecio.Text = "Campo Requerido";
                lblRequeridoPrecio.Visible = true;
                txtPrecio.BackColor = Color.LightPink;
                return true;
            }
            else
            {
                lblRequeridoPrecio.Visible = false;
                txtPrecio.BackColor = SystemColors.Window;
            }

            if(!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("El campo Precio solo admite valores numéricos.");
                lblRequeridoPrecio.Text = "Este campo solo admite números.";
                lblRequeridoPrecio.Visible = true;
                txtPrecio.BackColor = Color.LightPink;
                return true;
            }
            else
            {
                lblRequeridoPrecio.Visible = false;
                txtPrecio.BackColor = SystemColors.Window;

            }

            return false;
        }

        private bool soloNumeros(string numero)
        {
            decimal validar;
            if (decimal.TryParse(numero, out validar))
            {
                return true;
            }

            return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
