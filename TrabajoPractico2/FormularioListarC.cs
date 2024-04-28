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
    public partial class FormularioListarC : Form
    {
        public FormularioListarC()
        {
            InitializeComponent();
        }

        private void FormularioListarC_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            NegocioCategoria negocio = new NegocioCategoria();
            dgvCategorias.DataSource = negocio.ListarCategorias();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioCategoria negocio = new NegocioCategoria();
            Categoria seleccionado = new Categoria();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminar esta Categoria?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.EliminarCategoria(seleccionado.Id);
                    Cargar();
                }

            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString()); ;
            }
        }
    }
}
