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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
