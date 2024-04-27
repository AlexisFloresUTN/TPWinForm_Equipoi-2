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
    public partial class FormularioAgregarCategoria : Form
    {
        public FormularioAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria AgregarCategoria = new Categoria();
            NegocioCategoria agregarNegocio = new NegocioCategoria();
            try
            {
                AgregarCategoria.Descripcion = tbxCategoria.Text;
                agregarNegocio.AgregarNuevaCat(AgregarCategoria);
                this.Close();
                MessageBox.Show("Categoria agregada exitosamente");


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FormularioAgregarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
