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
    public partial class FormularioAgregar : Form
    {
        public FormularioAgregar()
        {
            InitializeComponent();
        }

        private void txtAgregarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioAgregar_Load(object sender, EventArgs e)
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            try
            {
                cbxMarca.DataSource = negocioMarca.ListarMarcas();
                cbxCat.DataSource = negocioCategoria.ListarCategorias();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarGuardar_Click(object sender, EventArgs e)
        {
            Articulo agregarArticulo = new Articulo();
            NegocioArticulo AgregarNegocio = new NegocioArticulo();
            Imagen AgregarImagen = new Imagen();
            NegocioImagen agregarNegocioIma = new NegocioImagen();
            try
            { 
                agregarArticulo.CodArt = tbxCodArt.Text; 
                agregarArticulo.Nombre = tbxNombre.Text;
                agregarArticulo.Descripcion = tbxDescrip.Text;
                agregarArticulo.Marca = (Marca)cbxMarca.SelectedItem;
                agregarArticulo.Categoria = (Categoria)cbxCat.SelectedItem;
                agregarArticulo.Precio = Convert.ToDecimal(tbxPrecio.Text);
                AgregarImagen.UrlImagen = tbxUrl1.Text;
                AgregarNegocio.AgregarNuevoArt(agregarArticulo, AgregarImagen);
                agregarNegocioIma.AgregarNuevaIma(AgregarImagen);
                this.Close();

                MessageBox.Show("Agregado Exitosamente");

            }
            catch (Exception ex)
            {

                throw ex;

            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pcbArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void tbxUrl1_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrl1.Text);
        }

        private void tbxUrl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarIma_Click(object sender, EventArgs e)
        {

        }
    }
}
