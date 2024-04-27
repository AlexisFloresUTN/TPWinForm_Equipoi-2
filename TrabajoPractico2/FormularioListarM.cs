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
    public partial class FormularioListarM : Form
    {
        public FormularioListarM()
        {
            InitializeComponent();
        }

        private void dgbMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Cargar()
        {
        
            
        }

        private void ForrmularioListarM_Load(object sender, EventArgs e)
        {
            NegocioMarca negocio = new NegocioMarca();
            dgvMarcas.DataSource = negocio.ListarMarcas();
        }
    }
}
