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
        private Articulo articulo = null;
        public FormularioAgregar(Articulo ArticuloM)
        {
            InitializeComponent();
            this.articulo = ArticuloM;
            Text = "Modificar Articulo";
        }
        private void txtAgregarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioAgregar_Load(object sender, EventArgs e)
        {
            Imagen aux = new Imagen();
            NegocioImagen negocioImagen = new NegocioImagen();
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            cbxMarca.DataSource = negocioMarca.ListarMarcas();
            cbxMarca.ValueMember = "Id";
            cbxMarca.DisplayMember = "Descripcion";
            cbxCat.DataSource = negocioCategoria.ListarCategorias();
            cbxCat.ValueMember = "Id";
            cbxCat.DisplayMember = "Descripcion";
            
            
            try
            {
                
                if (articulo != null)
                {
                    int ID = articulo.Id;
                    aux = negocioImagen.ListarPor(ID);
                    tbxCodArt.Text = articulo.CodArt.ToString();
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescrip.Text = articulo.Descripcion;
                    
                    
                    tbxUrl1.Text=aux.UrlImagen.ToString();

                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCat.SelectedValue = articulo.Categoria.Id;
                    tbxPrecio.Text = articulo.Precio.ToString();

                }
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
            NegocioArticulo AgregarNegocio = new NegocioArticulo();
            Imagen AgregarImagen = new Imagen();
            NegocioImagen agregarNegocioIma = new NegocioImagen();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.CodArt = tbxCodArt.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescrip.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCat.SelectedItem;
                articulo.Precio = Convert.ToDecimal(tbxPrecio.Text);
                AgregarImagen = agregarNegocioIma.ListarPor(articulo.Id);
                AgregarImagen.UrlImagen = tbxUrl1.Text;
                if(articulo.Id != 0)
                {
                    AgregarNegocio.ModificarArticulo(articulo);
                    agregarNegocioIma.ModificarImagen(AgregarImagen);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                
                AgregarNegocio.AgregarNuevoArt(articulo, AgregarImagen);
                agregarNegocioIma.AgregarNuevaIma(AgregarImagen);
                MessageBox.Show("Agregado Exitosamente");
                }
                
                
                this.Close();

                

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
                pcbArticulos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDLGVl2FArnrtfhtWTomWS_DFPOOG91lPQMsyY4Av4wA&s");
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

        private void lblUrl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
