using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class frmRecuperarArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public frmRecuperarArticulos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarListado()
        {
            RecuperadosNegocio negocio = new RecuperadosNegocio();

            try
            {
                listaArticulos = negocio.listaRecuperar();
                dgvListadoArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].UrlImg);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No hay elementos para recuperar.");
            }

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

        private void frmRecuperarArticulos_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImg);
            }
        }

        private void bntRecuperarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvListadoArticulos.RowCount == 0)
            {
                MessageBox.Show("No hay elementos para recuperar");
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Estás por restaurar este registro, estás seguro?", "Resturando... ", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    RecuperadosNegocio negocio = new RecuperadosNegocio();
                    Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                    negocio.restaurarRegistro(seleccionado.Id);
                    cargarListado();
                }
            }


        }

        private void btnCerrarRecuperar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
