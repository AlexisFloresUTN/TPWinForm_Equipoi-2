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
    }
}
