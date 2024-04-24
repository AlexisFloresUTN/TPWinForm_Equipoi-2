namespace TrabajoPractico2
{
    partial class FormularioModificar
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
            this.btnGuardarMod = new System.Windows.Forms.Button();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.cbmMarca = new System.Windows.Forms.ComboBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbUrl2 = new System.Windows.Forms.TextBox();
            this.txbUrl1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmxMarca = new System.Windows.Forms.ComboBox();
            this.lblUrl2 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarMod
            // 
            this.btnGuardarMod.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMod.Location = new System.Drawing.Point(655, 348);
            this.btnGuardarMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarMod.Name = "btnGuardarMod";
            this.btnGuardarMod.Size = new System.Drawing.Size(109, 42);
            this.btnGuardarMod.TabIndex = 70;
            this.btnGuardarMod.Text = "Guardar";
            this.btnGuardarMod.UseVisualStyleBackColor = false;
            this.btnGuardarMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 50F);
            this.txbDescripcion.Location = new System.Drawing.Point(49, 236);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(715, 104);
            this.txbDescripcion.TabIndex = 69;
            this.txbDescripcion.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cbmMarca
            // 
            this.cbmMarca.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmMarca.FormattingEnabled = true;
            this.cbmMarca.Location = new System.Drawing.Point(584, 57);
            this.cbmMarca.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbmMarca.Name = "cbmMarca";
            this.cbmMarca.Size = new System.Drawing.Size(180, 35);
            this.cbmMarca.TabIndex = 68;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(215, 59);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(150, 33);
            this.txbNombre.TabIndex = 67;
            // 
            // txbUrl2
            // 
            this.txbUrl2.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUrl2.Location = new System.Drawing.Point(215, 160);
            this.txbUrl2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbUrl2.Name = "txbUrl2";
            this.txbUrl2.Size = new System.Drawing.Size(549, 33);
            this.txbUrl2.TabIndex = 66;
            this.txbUrl2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbUrl1
            // 
            this.txbUrl1.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUrl1.Location = new System.Drawing.Point(215, 112);
            this.txbUrl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbUrl1.Name = "txbUrl1";
            this.txbUrl1.Size = new System.Drawing.Size(549, 33);
            this.txbUrl1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Imagen 1 (url):";
            // 
            // cmxMarca
            // 
            this.cmxMarca.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmxMarca.FormattingEnabled = true;
            this.cmxMarca.Location = new System.Drawing.Point(387, 57);
            this.cmxMarca.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmxMarca.Name = "cmxMarca";
            this.cmxMarca.Size = new System.Drawing.Size(180, 35);
            this.cmxMarca.TabIndex = 63;
            // 
            // lblUrl2
            // 
            this.lblUrl2.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.lblUrl2.AutoSize = true;
            this.lblUrl2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl2.Location = new System.Drawing.Point(45, 168);
            this.lblUrl2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUrl2.Name = "lblUrl2";
            this.lblUrl2.Size = new System.Drawing.Size(137, 24);
            this.lblUrl2.TabIndex = 62;
            this.lblUrl2.Text = "Imagen 2 (url):";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(577, 27);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 24);
            this.lblCategoria.TabIndex = 61;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(383, 27);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 24);
            this.lblMarca.TabIndex = 60;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(45, 206);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(113, 24);
            this.lblDescripcion.TabIndex = 59;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(211, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 24);
            this.lblNombre.TabIndex = 58;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.lblId.Location = new System.Drawing.Point(45, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 24);
            this.lblId.TabIndex = 71;
            this.lblId.Text = "ID:";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Trebuchet MS", 12.75F);
            this.txbId.Location = new System.Drawing.Point(49, 57);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(149, 32);
            this.txbId.TabIndex = 72;
            // 
            // FormularioModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnGuardarMod);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.cbmMarca);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbUrl2);
            this.Controls.Add(this.txbUrl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmxMarca);
            this.Controls.Add(this.lblUrl2);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioModificar";
            this.Text = "FormularioModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarMod;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.ComboBox cbmMarca;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbUrl2;
        private System.Windows.Forms.TextBox txbUrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmxMarca;
        private System.Windows.Forms.Label lblUrl2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;
    }
}