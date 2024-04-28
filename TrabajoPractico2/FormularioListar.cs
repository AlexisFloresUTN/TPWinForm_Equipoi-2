using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominioTp;
using NegocioTp;

namespace TrabajoPractico2
{
    public partial class FormularioListar : Form
    {
         
        public FormularioListar()
        {
            InitializeComponent();

        }
        
       
        private void FormularioListar_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            
            NegocioArticulo negocio = new NegocioArticulo();
            dgvArticulos.DataSource = negocio.Listar();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormularioAgregar modificar = new FormularioAgregar(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            Articulo seleccionado = new Articulo();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminar este artiuculo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocioArticulo.EliminarArticulo(seleccionado.Id);
                    Cargar();
                }

            }
            catch (Exception EX )
            {

                MessageBox.Show(EX.ToString()); ;
            }
        }
    }
}
