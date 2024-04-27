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
    public partial class FormularioListarI : Form
    {
        public FormularioListarI()
        {
            InitializeComponent();
        }

        private void FormularioListarI_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            NegocioImagen negocio = new NegocioImagen();
            dgvImagenes.DataSource = negocio.Listar();
        }
    }
}
