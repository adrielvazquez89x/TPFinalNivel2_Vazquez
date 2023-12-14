using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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


        // METODOS
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
                //lblListadoArticulo.Text = listaArticulos[0].Fabricante.ToString();
                //lblListadoModeloArticulo.Text = listaArticulos[0].Nombre.ToString();
                //frmListadoPrecioArticulo.Text = "$" + listaArticulos[0].Precio.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

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
        private void ocultarColumnas()
        {
            dgvListadoArticulos.Columns["UrlImg"].Visible = false;
            dgvListadoArticulos.Columns["Id"].Visible = false;
        }

        private bool soloNumeros(string cadena)
        {

            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }

            return true;
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un campo para filtrar");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un criterio para filtrar");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingresá un valor para filtrar");
                    return true;
                }

                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo números por favor");
                    return true;
                }
            }

            return false;
        }




        // EVENTOS

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
            cargarListado();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo alta = new frmAltaArticulo(seleccionado);
            alta.ShowDialog();
            cargarListado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult valor = MessageBox.Show("Estas seguro que querés eliminarlo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(valor == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado);
                }
                cargarListado();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            frmVerDetalle detalle = new frmVerDetalle(seleccionado);
            detalle.ShowDialog();

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();  

            //Stringueamos el contenido de los combobox para pasarlos por parámetros

            try
            {
                if(validarFiltro())
                {
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvListadoArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegistrosEliminados_Click(object sender, EventArgs e)
        {
            frmRecuperarArticulos articulos = new frmRecuperarArticulos();
            articulos.ShowDialog();
            cargarListado();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambiar el contenido del campo Criterio, cuando cambie el contenido de campo

            string opcion = cboCampo.SelectedItem.ToString();

            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a ");
                cboCriterio.Items.Add("Menor a ");
                cboCriterio.Items.Add("Igual a ");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImg);

                //Datos al lado de la imágen
                lblListadoArticulo.Text = seleccionado.Fabricante.ToString();
                lblListadoModeloArticulo.Text = seleccionado.Nombre.ToString();
                frmListadoPrecioArticulo.Text = "$" + seleccionado.Precio;
            }
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            cargarListado();

            //Cargar filtros
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Fabricante.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvListadoArticulos.DataSource = null;
            dgvListadoArticulos.DataSource = listaFiltrada;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
