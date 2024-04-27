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
    }
}
