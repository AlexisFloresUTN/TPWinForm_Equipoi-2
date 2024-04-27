namespace TrabajoPractico2
{
    partial class formularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioPrincipal));
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesAvanzadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.cbxArt = new System.Windows.Forms.ComboBox();
            this.lblArt = new System.Windows.Forms.Label();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.pcbImagenes = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnModificarA = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarA = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnListarA = new System.Windows.Forms.Button();
            this.gbxAgregar = new System.Windows.Forms.GroupBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.gbxListar = new System.Windows.Forms.GroupBox();
            this.btnListarI = new System.Windows.Forms.Button();
            this.btnListarC = new System.Windows.Forms.Button();
            this.btnListarM = new System.Windows.Forms.Button();
            this.gbxModificar = new System.Windows.Forms.GroupBox();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.btnModificarI = new System.Windows.Forms.Button();
            this.btnModificarM = new System.Windows.Forms.Button();
            this.gbxEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenes)).BeginInit();
            this.gbxAgregar.SuspendLayout();
            this.gbxListar.SuspendLayout();
            this.gbxModificar.SuspendLayout();
            this.gbxEliminar.SuspendLayout();
            this.gbxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar ";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir ";
            // 
            // aBMLToolStripMenuItem
            // 
            this.aBMLToolStripMenuItem.Name = "aBMLToolStripMenuItem";
            this.aBMLToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.aBMLToolStripMenuItem.Text = "Configuracion";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ageToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // ageToolStripMenuItem
            // 
            this.ageToolStripMenuItem.Name = "ageToolStripMenuItem";
            this.ageToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesAvanzadasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // opcionesAvanzadasToolStripMenuItem
            // 
            this.opcionesAvanzadasToolStripMenuItem.Name = "opcionesAvanzadasToolStripMenuItem";
            this.opcionesAvanzadasToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.opcionesAvanzadasToolStripMenuItem.Text = "Opciones avanzadas";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // cambiarDeUsuarioToolStripMenuItem
            // 
            this.cambiarDeUsuarioToolStripMenuItem.Name = "cambiarDeUsuarioToolStripMenuItem";
            this.cambiarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.cambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de usuario";
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(841, 93);
            this.cbxMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(120, 26);
            this.cbxMarcas.TabIndex = 6;
            this.cbxMarcas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMarcas
            // 
            this.lblMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(837, 68);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(65, 23);
            this.lblMarcas.TabIndex = 7;
            this.lblMarcas.Text = "Marcas";
            // 
            // cbxArt
            // 
            this.cbxArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxArt.FormattingEnabled = true;
            this.cbxArt.Location = new System.Drawing.Point(1089, 93);
            this.cbxArt.Margin = new System.Windows.Forms.Padding(2);
            this.cbxArt.Name = "cbxArt";
            this.cbxArt.Size = new System.Drawing.Size(120, 26);
            this.cbxArt.TabIndex = 8;
            // 
            // lblArt
            // 
            this.lblArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArt.AutoSize = true;
            this.lblArt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt.Location = new System.Drawing.Point(1085, 67);
            this.lblArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(81, 23);
            this.lblArt.TabIndex = 9;
            this.lblArt.Text = "Articulos";
            // 
            // cbxCat
            // 
            this.cbxCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(965, 93);
            this.cbxCat.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(120, 26);
            this.cbxCat.TabIndex = 10;
            this.cbxCat.SelectedIndexChanged += new System.EventHandler(this.cbxCat_SelectedIndexChanged);
            // 
            // lblCat
            // 
            this.lblCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(961, 67);
            this.lblCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(86, 23);
            this.lblCat.TabIndex = 11;
            this.lblCat.Text = "Categoria";
            this.lblCat.Click += new System.EventHandler(this.label2_Click);
            // 
            // pcbImagenes
            // 
            this.pcbImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbImagenes.Location = new System.Drawing.Point(873, 227);
            this.pcbImagenes.Margin = new System.Windows.Forms.Padding(2);
            this.pcbImagenes.Name = "pcbImagenes";
            this.pcbImagenes.Size = new System.Drawing.Size(270, 260);
            this.pcbImagenes.TabIndex = 12;
            this.pcbImagenes.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnterior.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(813, 337);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(56, 59);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguiente.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(1153, 337);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(56, 59);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnModificarA
            // 
            this.btnModificarA.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificarA.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarA.Location = new System.Drawing.Point(5, 20);
            this.btnModificarA.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarA.Name = "btnModificarA";
            this.btnModificarA.Size = new System.Drawing.Size(143, 38);
            this.btnModificarA.TabIndex = 15;
            this.btnModificarA.Text = "Articulos";
            this.btnModificarA.UseVisualStyleBackColor = false;
            this.btnModificarA.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(5, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 38);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.BackColor = System.Drawing.Color.Red;
            this.btnEliminarA.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarA.Location = new System.Drawing.Point(5, 20);
            this.btnEliminarA.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(143, 38);
            this.btnEliminarA.TabIndex = 17;
            this.btnEliminarA.Text = "Articulos";
            this.btnEliminarA.UseVisualStyleBackColor = false;
            this.btnEliminarA.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(5, 24);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 35);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(12, 218);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(763, 407);
            this.panelContenedor.TabIndex = 19;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btnListarA
            // 
            this.btnListarA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnListarA.Font = new System.Drawing.Font("Trebuchet MS", 10.9F);
            this.btnListarA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarA.Location = new System.Drawing.Point(6, 20);
            this.btnListarA.Name = "btnListarA";
            this.btnListarA.Size = new System.Drawing.Size(141, 38);
            this.btnListarA.TabIndex = 20;
            this.btnListarA.Text = "Articulos";
            this.btnListarA.UseVisualStyleBackColor = false;
            this.btnListarA.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gbxAgregar
            // 
            this.gbxAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxAgregar.Controls.Add(this.btnAgregarM);
            this.gbxAgregar.Controls.Add(this.btnAgregarC);
            this.gbxAgregar.Controls.Add(this.btnAgregar);
            this.gbxAgregar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgregar.Location = new System.Drawing.Point(12, 12);
            this.gbxAgregar.Name = "gbxAgregar";
            this.gbxAgregar.Size = new System.Drawing.Size(153, 200);
            this.gbxAgregar.TabIndex = 21;
            this.gbxAgregar.TabStop = false;
            this.gbxAgregar.Text = "Agregar";
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.BackColor = System.Drawing.Color.Green;
            this.btnAgregarM.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarM.Location = new System.Drawing.Point(5, 65);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(142, 38);
            this.btnAgregarM.TabIndex = 17;
            this.btnAgregarM.Text = "Marcas";
            this.btnAgregarM.UseVisualStyleBackColor = false;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.Green;
            this.btnAgregarC.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.Location = new System.Drawing.Point(5, 109);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(143, 38);
            this.btnAgregarC.TabIndex = 18;
            this.btnAgregarC.Text = "Categorias";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // gbxListar
            // 
            this.gbxListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxListar.Controls.Add(this.btnListarI);
            this.gbxListar.Controls.Add(this.btnListarC);
            this.gbxListar.Controls.Add(this.btnListarM);
            this.gbxListar.Controls.Add(this.btnListarA);
            this.gbxListar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListar.Location = new System.Drawing.Point(171, 12);
            this.gbxListar.Name = "gbxListar";
            this.gbxListar.Size = new System.Drawing.Size(153, 200);
            this.gbxListar.TabIndex = 22;
            this.gbxListar.TabStop = false;
            this.gbxListar.Text = "Listar";
            // 
            // btnListarI
            // 
            this.btnListarI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnListarI.Font = new System.Drawing.Font("Trebuchet MS", 10.9F);
            this.btnListarI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarI.Location = new System.Drawing.Point(6, 152);
            this.btnListarI.Name = "btnListarI";
            this.btnListarI.Size = new System.Drawing.Size(141, 38);
            this.btnListarI.TabIndex = 21;
            this.btnListarI.Text = "Imagenes";
            this.btnListarI.UseVisualStyleBackColor = false;
            this.btnListarI.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnListarC
            // 
            this.btnListarC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnListarC.Font = new System.Drawing.Font("Trebuchet MS", 10.9F);
            this.btnListarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarC.Location = new System.Drawing.Point(6, 108);
            this.btnListarC.Name = "btnListarC";
            this.btnListarC.Size = new System.Drawing.Size(141, 38);
            this.btnListarC.TabIndex = 22;
            this.btnListarC.Text = "Categorias";
            this.btnListarC.UseVisualStyleBackColor = false;
            this.btnListarC.Click += new System.EventHandler(this.btnListarC_Click);
            // 
            // btnListarM
            // 
            this.btnListarM.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnListarM.Font = new System.Drawing.Font("Trebuchet MS", 10.9F);
            this.btnListarM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarM.Location = new System.Drawing.Point(6, 64);
            this.btnListarM.Name = "btnListarM";
            this.btnListarM.Size = new System.Drawing.Size(141, 38);
            this.btnListarM.TabIndex = 21;
            this.btnListarM.Text = "Marcas";
            this.btnListarM.UseVisualStyleBackColor = false;
            this.btnListarM.Click += new System.EventHandler(this.btnListarM_Click);
            // 
            // gbxModificar
            // 
            this.gbxModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxModificar.Controls.Add(this.btnModificarC);
            this.gbxModificar.Controls.Add(this.btnModificarI);
            this.gbxModificar.Controls.Add(this.btnModificarM);
            this.gbxModificar.Controls.Add(this.btnModificarA);
            this.gbxModificar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxModificar.Location = new System.Drawing.Point(330, 12);
            this.gbxModificar.Name = "gbxModificar";
            this.gbxModificar.Size = new System.Drawing.Size(153, 200);
            this.gbxModificar.TabIndex = 23;
            this.gbxModificar.TabStop = false;
            this.gbxModificar.Text = "Modificar";
            // 
            // btnModificarC
            // 
            this.btnModificarC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificarC.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarC.Location = new System.Drawing.Point(5, 104);
            this.btnModificarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(143, 42);
            this.btnModificarC.TabIndex = 17;
            this.btnModificarC.Text = "Categorias";
            this.btnModificarC.UseVisualStyleBackColor = false;
            // 
            // btnModificarI
            // 
            this.btnModificarI.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificarI.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarI.Location = new System.Drawing.Point(5, 152);
            this.btnModificarI.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarI.Name = "btnModificarI";
            this.btnModificarI.Size = new System.Drawing.Size(143, 38);
            this.btnModificarI.TabIndex = 16;
            this.btnModificarI.Text = "Imagenes";
            this.btnModificarI.UseVisualStyleBackColor = false;
            // 
            // btnModificarM
            // 
            this.btnModificarM.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificarM.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarM.Location = new System.Drawing.Point(5, 62);
            this.btnModificarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarM.Name = "btnModificarM";
            this.btnModificarM.Size = new System.Drawing.Size(143, 38);
            this.btnModificarM.TabIndex = 16;
            this.btnModificarM.Text = "Marcas";
            this.btnModificarM.UseVisualStyleBackColor = false;
            // 
            // gbxEliminar
            // 
            this.gbxEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxEliminar.Controls.Add(this.btnEliminarI);
            this.gbxEliminar.Controls.Add(this.btnEliminarC);
            this.gbxEliminar.Controls.Add(this.btnEliminarM);
            this.gbxEliminar.Controls.Add(this.btnEliminarA);
            this.gbxEliminar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEliminar.Location = new System.Drawing.Point(489, 12);
            this.gbxEliminar.Name = "gbxEliminar";
            this.gbxEliminar.Size = new System.Drawing.Size(153, 200);
            this.gbxEliminar.TabIndex = 0;
            this.gbxEliminar.TabStop = false;
            this.gbxEliminar.Text = "Eliminar";
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.BackColor = System.Drawing.Color.Red;
            this.btnEliminarI.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarI.Location = new System.Drawing.Point(5, 152);
            this.btnEliminarI.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(143, 38);
            this.btnEliminarI.TabIndex = 18;
            this.btnEliminarI.Text = "Imagens";
            this.btnEliminarI.UseVisualStyleBackColor = false;
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.BackColor = System.Drawing.Color.Red;
            this.btnEliminarC.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarC.Location = new System.Drawing.Point(5, 104);
            this.btnEliminarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(143, 42);
            this.btnEliminarC.TabIndex = 19;
            this.btnEliminarC.Text = "Categorias";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.Color.Red;
            this.btnEliminarM.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarM.Location = new System.Drawing.Point(5, 62);
            this.btnEliminarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(143, 38);
            this.btnEliminarM.TabIndex = 18;
            this.btnEliminarM.Text = "Marcas";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxBuscar.Controls.Add(this.btnBuscar);
            this.gbxBuscar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscar.Location = new System.Drawing.Point(648, 12);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(127, 200);
            this.gbxBuscar.TabIndex = 24;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Buscar";
            // 
            // formularioPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 637);
            this.Controls.Add(this.gbxModificar);
            this.Controls.Add(this.gbxListar);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.gbxEliminar);
            this.Controls.Add(this.gbxAgregar);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pcbImagenes);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.cbxArt);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.cbxMarcas);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                      ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenes)).EndInit();
            this.gbxAgregar.ResumeLayout(false);
            this.gbxListar.ResumeLayout(false);
            this.gbxModificar.ResumeLayout(false);
            this.gbxEliminar.ResumeLayout(false);
            this.gbxBuscar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem aBMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesAvanzadasToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.ComboBox cbxArt;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.PictureBox pcbImagenes;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnModificarA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarA;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnListarA;
        private System.Windows.Forms.GroupBox gbxAgregar;
        private System.Windows.Forms.GroupBox gbxListar;
        private System.Windows.Forms.GroupBox gbxEliminar;
        private System.Windows.Forms.GroupBox gbxModificar;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnListarI;
        private System.Windows.Forms.Button btnListarC;
        private System.Windows.Forms.Button btnListarM;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Button btnModificarI;
        private System.Windows.Forms.Button btnModificarM;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnEliminarM;
    }
}

