using DominioTp;
using NegocioTp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico2
{
    public partial class FormularioAgregarMarca : Form
    {
        public FormularioAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca AgregarMarca = new Marca();
            NegocioMarca agregarNegocio = new NegocioMarca();
            try
            {
                AgregarMarca.Descripcion = tbxMarca.Text;
                agregarNegocio.AgregarNuevaMarca(AgregarMarca);
                this.Close();
                MessageBox.Show("Marca agregada exitosamente");
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void FormularioAgregarMarca_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
