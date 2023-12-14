using dominio;
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


namespace presentacion
{
    public partial class frmListadoMarcas : Form
    {
        private List<Marca> listaMarcas;

        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void cargarListado()
        {
            MarcasNegocio negocio = new MarcasNegocio();

            try
            {
                listaMarcas = negocio.listarMarcas();
                dgvMarcas.DataSource = listaMarcas;
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            cargarListado();
           // pbxLogo.Load("https://fotosdememes.b-cdn.net/wp-content/uploads/2022/04/aqui-colocaria-mi-trofeo-si-tuviera-uno-sin-texto.jpg");
        }

        public void OcultarColumnas()
        {
            dgvMarcas.Columns["UrlImg"].Visible = false;
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
            cargarListado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            Marca seleccionada;

            try
            {
                DialogResult valor = MessageBox.Show("Eliminar un registro es irreversible. Está seguro que quiere realizar esta acción?","Eliminar marca", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (valor == DialogResult.OK)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(seleccionada.Nombre);
                }

                cargarListado();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
