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
    public partial class frmAltaMarca : Form
    {
        //Métodos para el formulario "Alta de marcas"

        public frmAltaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();

            try
            {
                Marca marca = new Marca();
                marca.Nombre = txtNombreMarca.Text;

                if(marca.Nombre.Length > 1 )
                {
                    negocio.agregarMarca(marca);
                    MessageBox.Show($"Agregado correctamente.");
                    Close();
                }
                else if(marca.Nombre.Length == 1)
                {
                    DialogResult confirmacion = MessageBox.Show("El nombre ingresado tiene una sola letra, es correcto?", "Nombre incompleto", MessageBoxButtons.YesNo);
                    if(confirmacion == DialogResult.Yes)
                    {
                        negocio.agregarMarca(marca);
                        MessageBox.Show($"Agregado correctamente.");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido.");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
