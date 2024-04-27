namespace TrabajoPractico2
{
    partial class FormularioAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxUrl1 = new System.Windows.Forms.TextBox();
            this.lblUrl1 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.tbxDescrip = new System.Windows.Forms.TextBox();
            this.btnModificarGuardar = new System.Windows.Forms.Button();
            this.iblCodArt = new System.Windows.Forms.Label();
            this.tbxCodArt = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.pcbArticulos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUrl1
            // 
            this.tbxUrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUrl1.Location = new System.Drawing.Point(177, 134);
            this.tbxUrl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbxUrl1.Name = "tbxUrl1";
            this.tbxUrl1.Size = new System.Drawing.Size(407, 32);
            this.tbxUrl1.TabIndex = 48;
            this.tbxUrl1.TextChanged += new System.EventHandler(this.tbxUrl1_TextChanged);
            this.tbxUrl1.Leave += new System.EventHandler(this.tbxUrl1_Leave);
            // 
            // lblUrl1
            // 
            this.lblUrl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.lblUrl1.AutoSize = true;
            this.lblUrl1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl1.Location = new System.Drawing.Point(46, 138);
            this.lblUrl1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUrl1.Name = "lblUrl1";
            this.lblUrl1.Size = new System.Drawing.Size(131, 24);
            this.lblUrl1.TabIndex = 47;
            this.lblUrl1.Text = "Imagen 1(url):";
            this.lblUrl1.Click += new System.EventHandler(this.lblUrl1_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(777, 27);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 24);
            this.lblCategoria.TabIndex = 43;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(539, 27);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 24);
            this.lblMarca.TabIndex = 42;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(46, 215);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(113, 24);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(303, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 24);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(543, 54);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(170, 33);
            this.cbxMarca.TabIndex = 45;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(307, 55);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(170, 32);
            this.tbxNombre.TabIndex = 52;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // cbxCat
            // 
            this.cbxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(781, 54);
            this.cbxCat.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(170, 33);
            this.cbxCat.TabIndex = 54;
            this.cbxCat.SelectedIndexChanged += new System.EventHandler(this.cbxCat_SelectedIndexChanged);
            // 
            // tbxDescrip
            // 
            this.tbxDescrip.Font = new System.Drawing.Font("Trebuchet MS", 12.8F);
            this.tbxDescrip.Location = new System.Drawing.Point(177, 207);
            this.tbxDescrip.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbxDescrip.Name = "tbxDescrip";
            this.tbxDescrip.Size = new System.Drawing.Size(407, 32);
            this.tbxDescrip.TabIndex = 56;
            // 
            // btnModificarGuardar
            // 
            this.btnModificarGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnModificarGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGuardar.Location = new System.Drawing.Point(845, 346);
            this.btnModificarGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarGuardar.Name = "btnModificarGuardar";
            this.btnModificarGuardar.Size = new System.Drawing.Size(109, 42);
            this.btnModificarGuardar.TabIndex = 57;
            this.btnModificarGuardar.Text = "Agregar";
            this.btnModificarGuardar.UseVisualStyleBackColor = false;
            this.btnModificarGuardar.Click += new System.EventHandler(this.btnModificarGuardar_Click);
            // 
            // iblCodArt
            // 
            this.iblCodArt.AutoSize = true;
            this.iblCodArt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.iblCodArt.Location = new System.Drawing.Point(46, 28);
            this.iblCodArt.Name = "iblCodArt";
            this.iblCodArt.Size = new System.Drawing.Size(105, 24);
            this.iblCodArt.TabIndex = 60;
            this.iblCodArt.Text = "Codigo Art:";
            // 
            // tbxCodArt
            // 
            this.tbxCodArt.Font = new System.Drawing.Font("Trebuchet MS", 12.7F);
            this.tbxCodArt.Location = new System.Drawing.Point(48, 55);
            this.tbxCodArt.Name = "tbxCodArt";
            this.tbxCodArt.Size = new System.Drawing.Size(170, 32);
            this.tbxCodArt.TabIndex = 61;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.lblPrecio.Location = new System.Drawing.Point(46, 289);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 24);
            this.lblPrecio.TabIndex = 62;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio.Location = new System.Drawing.Point(177, 282);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(407, 31);
            this.tbxPrecio.TabIndex = 63;
            // 
            // pcbArticulos
            // 
            this.pcbArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbArticulos.Location = new System.Drawing.Point(594, 130);
            this.pcbArticulos.Name = "pcbArticulos";
            this.pcbArticulos.Size = new System.Drawing.Size(360, 183);
            this.pcbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArticulos.TabIndex = 64;
            this.pcbArticulos.TabStop = false;
            // 
            // FormularioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(967, 416);
            this.Controls.Add(this.pcbArticulos);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tbxCodArt);
            this.Controls.Add(this.iblCodArt);
            this.Controls.Add(this.btnModificarGuardar);
            this.Controls.Add(this.tbxDescrip);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxUrl1);
            this.Controls.Add(this.lblUrl1);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioAgregar";
            this.Text = "v";
            this.Load += new System.EventHandler(this.FormularioAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxUrl1;
        private System.Windows.Forms.Label lblUrl1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.TextBox tbxDescrip;
        private System.Windows.Forms.Button btnModificarGuardar;
        private System.Windows.Forms.Label iblCodArt;
        private System.Windows.Forms.TextBox tbxCodArt;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.PictureBox pcbArticulos;
    }
}