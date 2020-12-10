namespace manejadorDeArchivosPro
{
    partial class ManejadorDeArchivos_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManejadorDeArchivos_Form));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.nuevo_SB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renombrar_SB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.abrir_SB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrar_SB = new System.Windows.Forms.ToolStripButton();
            this.Cabecera = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cabeceraAtributosDesperdiciados = new System.Windows.Forms.Label();
            this.CabeceraEntidadesDesperdiciadas = new System.Windows.Forms.Label();
            this.tam_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NombreEntidad_Combo = new System.Windows.Forms.ComboBox();
            this.NombreArchivoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridEntidades = new System.Windows.Forms.DataGridView();
            this.ID_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DreccionAtributo_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionDatos_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiguienteDireccion_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuEntidades = new System.Windows.Forms.MenuStrip();
            this.altaMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.modofocarMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Combo_entidadesParaAtributos = new System.Windows.Forms.ComboBox();
            this.ComboB_LongitudAtributo = new System.Windows.Forms.ComboBox();
            this.longitud = new System.Windows.Forms.Label();
            this.comboNombreAtributo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo_label = new System.Windows.Forms.Label();
            this.LB_TipoIndiceAtributo = new System.Windows.Forms.Label();
            this.ComboB_TipoIndiceAtributo = new System.Windows.Forms.ComboBox();
            this.ComboB_TipoAtributo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAtributos = new System.Windows.Forms.DataGridView();
            this.ID_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDato_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitud_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIndice_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionIndice_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siguiente_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuAtributos = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxIndices = new System.Windows.Forms.GroupBox();
            this.tabControlIndices = new System.Windows.Forms.TabControl();
            this.ClaveBusqueda = new System.Windows.Forms.TabPage();
            this.Primario = new System.Windows.Forms.TabPage();
            this.labelAtributoPrimario = new System.Windows.Forms.Label();
            this.dataGridIdxPrimmario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secundario = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridSecundario = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridSecundarioAuxiliar = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAtributosSecundarios = new System.Windows.Forms.ComboBox();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.dataGridRegistros = new System.Windows.Forms.DataGridView();
            this.comboBoxEntidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_entidadParaRegistro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuRegistros = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DGV_ClaveDeBusqueda = new System.Windows.Forms.DataGridView();
            this.toolBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntidades)).BeginInit();
            this.menuEntidades.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtributos)).BeginInit();
            this.menuAtributos.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxIndices.SuspendLayout();
            this.tabControlIndices.SuspendLayout();
            this.ClaveBusqueda.SuspendLayout();
            this.Primario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIdxPrimmario)).BeginInit();
            this.Secundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecundarioAuxiliar)).BeginInit();
            this.groupBoxRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistros)).BeginInit();
            this.menuRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ClaveDeBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.CanOverflow = false;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo_SB,
            this.toolStripSeparator1,
            this.renombrar_SB,
            this.toolStripSeparator2,
            this.abrir_SB,
            this.toolStripSeparator3,
            this.cerrar_SB});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1421, 35);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "Menu";
            this.toolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBar_ItemClicked);
            // 
            // nuevo_SB
            // 
            this.nuevo_SB.AccessibleName = "Nuevo";
            this.nuevo_SB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_SB.Image = ((System.Drawing.Image)(resources.GetObject("nuevo_SB.Image")));
            this.nuevo_SB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevo_SB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevo_SB.Name = "nuevo_SB";
            this.nuevo_SB.Size = new System.Drawing.Size(98, 32);
            this.nuevo_SB.Text = "Nuevo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // renombrar_SB
            // 
            this.renombrar_SB.AccessibleName = "Renombrar";
            this.renombrar_SB.Enabled = false;
            this.renombrar_SB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renombrar_SB.Image = ((System.Drawing.Image)(resources.GetObject("renombrar_SB.Image")));
            this.renombrar_SB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renombrar_SB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.renombrar_SB.Name = "renombrar_SB";
            this.renombrar_SB.Size = new System.Drawing.Size(137, 32);
            this.renombrar_SB.Text = "Renombrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // abrir_SB
            // 
            this.abrir_SB.AccessibleName = "Abrir";
            this.abrir_SB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir_SB.Image = ((System.Drawing.Image)(resources.GetObject("abrir_SB.Image")));
            this.abrir_SB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abrir_SB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrir_SB.Name = "abrir_SB";
            this.abrir_SB.Size = new System.Drawing.Size(84, 32);
            this.abrir_SB.Text = "Abrir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // cerrar_SB
            // 
            this.cerrar_SB.AccessibleName = "Cerrar";
            this.cerrar_SB.Enabled = false;
            this.cerrar_SB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar_SB.Image = ((System.Drawing.Image)(resources.GetObject("cerrar_SB.Image")));
            this.cerrar_SB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrar_SB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cerrar_SB.Name = "cerrar_SB";
            this.cerrar_SB.Size = new System.Drawing.Size(93, 32);
            this.cerrar_SB.Text = "Cerrar";
            // 
            // Cabecera
            // 
            this.Cabecera.AutoSize = true;
            this.Cabecera.Location = new System.Drawing.Point(8, 17);
            this.Cabecera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(77, 17);
            this.Cabecera.TabIndex = 2;
            this.Cabecera.Text = "Cabecera :";
            this.Cabecera.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cabeceraAtributosDesperdiciados);
            this.groupBox1.Controls.Add(this.CabeceraEntidadesDesperdiciadas);
            this.groupBox1.Controls.Add(this.tam_label);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.Cabecera);
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1421, 599);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cabeceraAtributosDesperdiciados
            // 
            this.cabeceraAtributosDesperdiciados.AutoSize = true;
            this.cabeceraAtributosDesperdiciados.Location = new System.Drawing.Point(368, 17);
            this.cabeceraAtributosDesperdiciados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cabeceraAtributosDesperdiciados.Name = "cabeceraAtributosDesperdiciados";
            this.cabeceraAtributosDesperdiciados.Size = new System.Drawing.Size(122, 17);
            this.cabeceraAtributosDesperdiciados.TabIndex = 8;
            this.cabeceraAtributosDesperdiciados.Text = "CabAtributosDes :";
            this.cabeceraAtributosDesperdiciados.Visible = false;
            // 
            // CabeceraEntidadesDesperdiciadas
            // 
            this.CabeceraEntidadesDesperdiciadas.AutoSize = true;
            this.CabeceraEntidadesDesperdiciadas.Location = new System.Drawing.Point(153, 17);
            this.CabeceraEntidadesDesperdiciadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CabeceraEntidadesDesperdiciadas.Name = "CabeceraEntidadesDesperdiciadas";
            this.CabeceraEntidadesDesperdiciadas.Size = new System.Drawing.Size(129, 17);
            this.CabeceraEntidadesDesperdiciadas.TabIndex = 5;
            this.CabeceraEntidadesDesperdiciadas.Text = "CabEntidadesDes :";
            this.CabeceraEntidadesDesperdiciadas.Visible = false;
            // 
            // tam_label
            // 
            this.tam_label.AutoSize = true;
            this.tam_label.Location = new System.Drawing.Point(564, 17);
            this.tam_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tam_label.Name = "tam_label";
            this.tam_label.Size = new System.Drawing.Size(64, 17);
            this.tam_label.TabIndex = 4;
            this.tam_label.Text = "Tamaño:";
            this.tam_label.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1381, 556);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NombreEntidad_Combo);
            this.tabPage1.Controls.Add(this.NombreArchivoLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dataGridEntidades);
            this.tabPage1.Controls.Add(this.menuEntidades);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1373, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NombreEntidad_Combo
            // 
            this.NombreEntidad_Combo.FormattingEnabled = true;
            this.NombreEntidad_Combo.Location = new System.Drawing.Point(77, 44);
            this.NombreEntidad_Combo.Margin = new System.Windows.Forms.Padding(4);
            this.NombreEntidad_Combo.Name = "NombreEntidad_Combo";
            this.NombreEntidad_Combo.Size = new System.Drawing.Size(160, 25);
            this.NombreEntidad_Combo.TabIndex = 4;
            this.NombreEntidad_Combo.SelectedIndexChanged += new System.EventHandler(this.NombreEntidad_Combo_SelectedIndexChanged);
            this.NombreEntidad_Combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombreEntidad_Combo_KeyDown);
            // 
            // NombreArchivoLabel
            // 
            this.NombreArchivoLabel.AutoSize = true;
            this.NombreArchivoLabel.Location = new System.Drawing.Point(355, 44);
            this.NombreArchivoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreArchivoLabel.Name = "NombreArchivoLabel";
            this.NombreArchivoLabel.Size = new System.Drawing.Size(59, 17);
            this.NombreArchivoLabel.TabIndex = 3;
            this.NombreArchivoLabel.Text = "Archivo:";
            this.NombreArchivoLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // dataGridEntidades
            // 
            this.dataGridEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Entidad,
            this.Nombre_Entidad,
            this.Direccion_Entidad,
            this.DreccionAtributo_Entidad,
            this.DireccionDatos_Entidad,
            this.SiguienteDireccion_Entidad});
            this.dataGridEntidades.Location = new System.Drawing.Point(4, 78);
            this.dataGridEntidades.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridEntidades.Name = "dataGridEntidades";
            this.dataGridEntidades.RowHeadersWidth = 51;
            this.dataGridEntidades.Size = new System.Drawing.Size(1355, 455);
            this.dataGridEntidades.TabIndex = 1;
            // 
            // ID_Entidad
            // 
            this.ID_Entidad.HeaderText = "ID";
            this.ID_Entidad.MinimumWidth = 6;
            this.ID_Entidad.Name = "ID_Entidad";
            this.ID_Entidad.Width = 125;
            // 
            // Nombre_Entidad
            // 
            this.Nombre_Entidad.HeaderText = "Nombre";
            this.Nombre_Entidad.MinimumWidth = 6;
            this.Nombre_Entidad.Name = "Nombre_Entidad";
            this.Nombre_Entidad.Width = 125;
            // 
            // Direccion_Entidad
            // 
            this.Direccion_Entidad.HeaderText = "Dirección";
            this.Direccion_Entidad.MinimumWidth = 6;
            this.Direccion_Entidad.Name = "Direccion_Entidad";
            this.Direccion_Entidad.Width = 125;
            // 
            // DreccionAtributo_Entidad
            // 
            this.DreccionAtributo_Entidad.HeaderText = "DirecciónAtributo";
            this.DreccionAtributo_Entidad.MinimumWidth = 6;
            this.DreccionAtributo_Entidad.Name = "DreccionAtributo_Entidad";
            this.DreccionAtributo_Entidad.Width = 125;
            // 
            // DireccionDatos_Entidad
            // 
            this.DireccionDatos_Entidad.HeaderText = "Dirección Datos";
            this.DireccionDatos_Entidad.MinimumWidth = 6;
            this.DireccionDatos_Entidad.Name = "DireccionDatos_Entidad";
            this.DireccionDatos_Entidad.Width = 125;
            // 
            // SiguienteDireccion_Entidad
            // 
            this.SiguienteDireccion_Entidad.HeaderText = "Siguiente Dirección";
            this.SiguienteDireccion_Entidad.MinimumWidth = 6;
            this.SiguienteDireccion_Entidad.Name = "SiguienteDireccion_Entidad";
            this.SiguienteDireccion_Entidad.Width = 125;
            // 
            // menuEntidades
            // 
            this.menuEntidades.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEntidades.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEntidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaMenuEntidades,
            this.modofocarMenuEntidades,
            this.consultaMenuEntidades,
            this.eliminarMenuEntidades});
            this.menuEntidades.Location = new System.Drawing.Point(4, 4);
            this.menuEntidades.Name = "menuEntidades";
            this.menuEntidades.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuEntidades.Size = new System.Drawing.Size(1365, 28);
            this.menuEntidades.TabIndex = 0;
            this.menuEntidades.Text = "menuStrip1";
            this.menuEntidades.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuEntidades_ItemClicked);
            // 
            // altaMenuEntidades
            // 
            this.altaMenuEntidades.AccessibleName = "Alta";
            this.altaMenuEntidades.BackColor = System.Drawing.Color.Transparent;
            this.altaMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaMenuEntidades.Name = "altaMenuEntidades";
            this.altaMenuEntidades.Size = new System.Drawing.Size(50, 24);
            this.altaMenuEntidades.Text = "Alta";
            // 
            // modofocarMenuEntidades
            // 
            this.modofocarMenuEntidades.AccessibleName = "Modificar";
            this.modofocarMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modofocarMenuEntidades.Name = "modofocarMenuEntidades";
            this.modofocarMenuEntidades.Size = new System.Drawing.Size(87, 24);
            this.modofocarMenuEntidades.Text = "Modificar";
            // 
            // consultaMenuEntidades
            // 
            this.consultaMenuEntidades.AccessibleName = "Consulta";
            this.consultaMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaMenuEntidades.Name = "consultaMenuEntidades";
            this.consultaMenuEntidades.Size = new System.Drawing.Size(80, 24);
            this.consultaMenuEntidades.Text = "Consulta";
            this.consultaMenuEntidades.Visible = false;
            // 
            // eliminarMenuEntidades
            // 
            this.eliminarMenuEntidades.AccessibleName = "Eliminar";
            this.eliminarMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarMenuEntidades.Name = "eliminarMenuEntidades";
            this.eliminarMenuEntidades.Size = new System.Drawing.Size(77, 24);
            this.eliminarMenuEntidades.Text = "Eliminar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Combo_entidadesParaAtributos);
            this.tabPage2.Controls.Add(this.ComboB_LongitudAtributo);
            this.tabPage2.Controls.Add(this.longitud);
            this.tabPage2.Controls.Add(this.comboNombreAtributo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tipo_label);
            this.tabPage2.Controls.Add(this.LB_TipoIndiceAtributo);
            this.tabPage2.Controls.Add(this.ComboB_TipoIndiceAtributo);
            this.tabPage2.Controls.Add(this.ComboB_TipoAtributo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridAtributos);
            this.tabPage2.Controls.Add(this.menuAtributos);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1373, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Atributos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Combo_entidadesParaAtributos
            // 
            this.Combo_entidadesParaAtributos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_entidadesParaAtributos.FormattingEnabled = true;
            this.Combo_entidadesParaAtributos.Location = new System.Drawing.Point(85, 38);
            this.Combo_entidadesParaAtributos.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_entidadesParaAtributos.Name = "Combo_entidadesParaAtributos";
            this.Combo_entidadesParaAtributos.Size = new System.Drawing.Size(160, 26);
            this.Combo_entidadesParaAtributos.TabIndex = 17;
            this.Combo_entidadesParaAtributos.SelectedIndexChanged += new System.EventHandler(this.Combo_entidadesParaAtributos_SelectedIndexChanged_1);
            // 
            // ComboB_LongitudAtributo
            // 
            this.ComboB_LongitudAtributo.FormattingEnabled = true;
            this.ComboB_LongitudAtributo.Location = new System.Drawing.Point(735, 37);
            this.ComboB_LongitudAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboB_LongitudAtributo.Name = "ComboB_LongitudAtributo";
            this.ComboB_LongitudAtributo.Size = new System.Drawing.Size(160, 26);
            this.ComboB_LongitudAtributo.TabIndex = 16;
            this.ComboB_LongitudAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_LongitudAtributo_SelectedIndexChanged);
            // 
            // longitud
            // 
            this.longitud.AutoSize = true;
            this.longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitud.Location = new System.Drawing.Point(653, 38);
            this.longitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(64, 18);
            this.longitud.TabIndex = 14;
            this.longitud.Text = "Longitud";
            // 
            // comboNombreAtributo
            // 
            this.comboNombreAtributo.FormattingEnabled = true;
            this.comboNombreAtributo.Location = new System.Drawing.Point(356, 38);
            this.comboNombreAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.comboNombreAtributo.Name = "comboNombreAtributo";
            this.comboNombreAtributo.Size = new System.Drawing.Size(160, 26);
            this.comboNombreAtributo.TabIndex = 13;
            this.comboNombreAtributo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboNombreAtributo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entidad:";
            // 
            // tipo_label
            // 
            this.tipo_label.AutoSize = true;
            this.tipo_label.Location = new System.Drawing.Point(537, 38);
            this.tipo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipo_label.Name = "tipo_label";
            this.tipo_label.Size = new System.Drawing.Size(41, 18);
            this.tipo_label.TabIndex = 10;
            this.tipo_label.Text = "Tipo:";
            // 
            // LB_TipoIndiceAtributo
            // 
            this.LB_TipoIndiceAtributo.AutoSize = true;
            this.LB_TipoIndiceAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TipoIndiceAtributo.Location = new System.Drawing.Point(921, 38);
            this.LB_TipoIndiceAtributo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TipoIndiceAtributo.Name = "LB_TipoIndiceAtributo";
            this.LB_TipoIndiceAtributo.Size = new System.Drawing.Size(83, 18);
            this.LB_TipoIndiceAtributo.TabIndex = 9;
            this.LB_TipoIndiceAtributo.Text = "Tipo Indice:";
            // 
            // ComboB_TipoIndiceAtributo
            // 
            this.ComboB_TipoIndiceAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_TipoIndiceAtributo.FormattingEnabled = true;
            this.ComboB_TipoIndiceAtributo.Items.AddRange(new object[] {
            "0 - Sin tipo de índice",
            "1 - Secuencial",
            "2 - Indice Primario",
            "3 - Indice Secundario",
            "4 - Indice Arbol B+"});
            this.ComboB_TipoIndiceAtributo.Location = new System.Drawing.Point(1023, 37);
            this.ComboB_TipoIndiceAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboB_TipoIndiceAtributo.Name = "ComboB_TipoIndiceAtributo";
            this.ComboB_TipoIndiceAtributo.Size = new System.Drawing.Size(160, 26);
            this.ComboB_TipoIndiceAtributo.TabIndex = 8;
            this.ComboB_TipoIndiceAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_TipoIndiceAtributo_SelectedIndexChanged);
            // 
            // ComboB_TipoAtributo
            // 
            this.ComboB_TipoAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_TipoAtributo.FormattingEnabled = true;
            this.ComboB_TipoAtributo.Items.AddRange(new object[] {
            "E",
            "C"});
            this.ComboB_TipoAtributo.Location = new System.Drawing.Point(591, 37);
            this.ComboB_TipoAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboB_TipoAtributo.Name = "ComboB_TipoAtributo";
            this.ComboB_TipoAtributo.Size = new System.Drawing.Size(41, 26);
            this.ComboB_TipoAtributo.TabIndex = 7;
            this.ComboB_TipoAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_TipoAtributo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // dataGridAtributos
            // 
            this.dataGridAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Atributo,
            this.Nombre_Atributo,
            this.tipoDato_Atributo,
            this.longitud_Atributo,
            this.Direccion_Atributo,
            this.TipoIndice_Atributo,
            this.DireccionIndice_Atributo,
            this.Siguiente_Atributo});
            this.dataGridAtributos.Location = new System.Drawing.Point(8, 71);
            this.dataGridAtributos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAtributos.Name = "dataGridAtributos";
            this.dataGridAtributos.RowHeadersWidth = 51;
            this.dataGridAtributos.Size = new System.Drawing.Size(1355, 462);
            this.dataGridAtributos.TabIndex = 2;
            // 
            // ID_Atributo
            // 
            this.ID_Atributo.HeaderText = "ID";
            this.ID_Atributo.MinimumWidth = 6;
            this.ID_Atributo.Name = "ID_Atributo";
            this.ID_Atributo.Width = 125;
            // 
            // Nombre_Atributo
            // 
            this.Nombre_Atributo.HeaderText = "Nombre";
            this.Nombre_Atributo.MinimumWidth = 6;
            this.Nombre_Atributo.Name = "Nombre_Atributo";
            this.Nombre_Atributo.Width = 125;
            // 
            // tipoDato_Atributo
            // 
            this.tipoDato_Atributo.HeaderText = "Tipo de Dato";
            this.tipoDato_Atributo.MinimumWidth = 6;
            this.tipoDato_Atributo.Name = "tipoDato_Atributo";
            this.tipoDato_Atributo.Width = 125;
            // 
            // longitud_Atributo
            // 
            this.longitud_Atributo.HeaderText = "Longitud";
            this.longitud_Atributo.MinimumWidth = 6;
            this.longitud_Atributo.Name = "longitud_Atributo";
            this.longitud_Atributo.Width = 125;
            // 
            // Direccion_Atributo
            // 
            this.Direccion_Atributo.HeaderText = "Dirección";
            this.Direccion_Atributo.MinimumWidth = 6;
            this.Direccion_Atributo.Name = "Direccion_Atributo";
            this.Direccion_Atributo.Width = 125;
            // 
            // TipoIndice_Atributo
            // 
            this.TipoIndice_Atributo.HeaderText = "Tipo de Índice";
            this.TipoIndice_Atributo.MinimumWidth = 6;
            this.TipoIndice_Atributo.Name = "TipoIndice_Atributo";
            this.TipoIndice_Atributo.Width = 125;
            // 
            // DireccionIndice_Atributo
            // 
            this.DireccionIndice_Atributo.HeaderText = "Dirección de Índice";
            this.DireccionIndice_Atributo.MinimumWidth = 6;
            this.DireccionIndice_Atributo.Name = "DireccionIndice_Atributo";
            this.DireccionIndice_Atributo.Width = 125;
            // 
            // Siguiente_Atributo
            // 
            this.Siguiente_Atributo.HeaderText = "Siguiente Atributo";
            this.Siguiente_Atributo.MinimumWidth = 6;
            this.Siguiente_Atributo.Name = "Siguiente_Atributo";
            this.Siguiente_Atributo.Width = 125;
            // 
            // menuAtributos
            // 
            this.menuAtributos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAtributos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAtributos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuAtributos.Location = new System.Drawing.Point(4, 4);
            this.menuAtributos.Name = "menuAtributos";
            this.menuAtributos.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuAtributos.Size = new System.Drawing.Size(1365, 28);
            this.menuAtributos.TabIndex = 1;
            this.menuAtributos.Text = "menuStrip2";
            this.menuAtributos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuAtributos_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleName = "Alta";
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 24);
            this.toolStripMenuItem1.Text = "Alta";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleName = "Modificar";
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "Modificar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AccessibleName = "Consulta";
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem3.Text = "Consulta";
            this.toolStripMenuItem3.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AccessibleName = "Eliminar";
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem4.Text = "Eliminar";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxIndices);
            this.tabPage3.Controls.Add(this.groupBoxRegistros);
            this.tabPage3.Controls.Add(this.CB_entidadParaRegistro);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.menuRegistros);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1373, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registros";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBoxIndices
            // 
            this.groupBoxIndices.Controls.Add(this.tabControlIndices);
            this.groupBoxIndices.Location = new System.Drawing.Point(692, 76);
            this.groupBoxIndices.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIndices.Name = "groupBoxIndices";
            this.groupBoxIndices.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIndices.Size = new System.Drawing.Size(677, 457);
            this.groupBoxIndices.TabIndex = 30;
            this.groupBoxIndices.TabStop = false;
            this.groupBoxIndices.Text = "Indices";
            // 
            // tabControlIndices
            // 
            this.tabControlIndices.Controls.Add(this.ClaveBusqueda);
            this.tabControlIndices.Controls.Add(this.Primario);
            this.tabControlIndices.Controls.Add(this.Secundario);
            this.tabControlIndices.Location = new System.Drawing.Point(8, 23);
            this.tabControlIndices.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlIndices.Name = "tabControlIndices";
            this.tabControlIndices.SelectedIndex = 0;
            this.tabControlIndices.Size = new System.Drawing.Size(544, 342);
            this.tabControlIndices.TabIndex = 5;
            // 
            // ClaveBusqueda
            // 
            this.ClaveBusqueda.Controls.Add(this.DGV_ClaveDeBusqueda);
            this.ClaveBusqueda.Location = new System.Drawing.Point(4, 27);
            this.ClaveBusqueda.Name = "ClaveBusqueda";
            this.ClaveBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.ClaveBusqueda.Size = new System.Drawing.Size(536, 311);
            this.ClaveBusqueda.TabIndex = 3;
            this.ClaveBusqueda.Text = "Cve_Busqueda";
            this.ClaveBusqueda.UseVisualStyleBackColor = true;
            this.ClaveBusqueda.Click += new System.EventHandler(this.ClaveBusqueda_Click);
            // 
            // Primario
            // 
            this.Primario.Controls.Add(this.labelAtributoPrimario);
            this.Primario.Controls.Add(this.dataGridIdxPrimmario);
            this.Primario.Location = new System.Drawing.Point(4, 27);
            this.Primario.Margin = new System.Windows.Forms.Padding(4);
            this.Primario.Name = "Primario";
            this.Primario.Padding = new System.Windows.Forms.Padding(4);
            this.Primario.Size = new System.Drawing.Size(536, 311);
            this.Primario.TabIndex = 1;
            this.Primario.Text = "Primario";
            this.Primario.UseVisualStyleBackColor = true;
            // 
            // labelAtributoPrimario
            // 
            this.labelAtributoPrimario.AutoSize = true;
            this.labelAtributoPrimario.Location = new System.Drawing.Point(8, 14);
            this.labelAtributoPrimario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAtributoPrimario.Name = "labelAtributoPrimario";
            this.labelAtributoPrimario.Size = new System.Drawing.Size(66, 18);
            this.labelAtributoPrimario.TabIndex = 3;
            this.labelAtributoPrimario.Text = "Atributo :";
            // 
            // dataGridIdxPrimmario
            // 
            this.dataGridIdxPrimmario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIdxPrimmario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridIdxPrimmario.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridIdxPrimmario.Location = new System.Drawing.Point(8, 44);
            this.dataGridIdxPrimmario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridIdxPrimmario.Name = "dataGridIdxPrimmario";
            this.dataGridIdxPrimmario.RowHeadersVisible = false;
            this.dataGridIdxPrimmario.RowHeadersWidth = 51;
            this.dataGridIdxPrimmario.Size = new System.Drawing.Size(657, 353);
            this.dataGridIdxPrimmario.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Llave";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 190;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Direccíon";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Secundario
            // 
            this.Secundario.Controls.Add(this.label6);
            this.Secundario.Controls.Add(this.label7);
            this.Secundario.Controls.Add(this.dataGridSecundario);
            this.Secundario.Controls.Add(this.dataGridSecundarioAuxiliar);
            this.Secundario.Controls.Add(this.label8);
            this.Secundario.Controls.Add(this.comboBoxAtributosSecundarios);
            this.Secundario.Location = new System.Drawing.Point(4, 27);
            this.Secundario.Margin = new System.Windows.Forms.Padding(4);
            this.Secundario.Name = "Secundario";
            this.Secundario.Padding = new System.Windows.Forms.Padding(4);
            this.Secundario.Size = new System.Drawing.Size(536, 311);
            this.Secundario.TabIndex = 2;
            this.Secundario.Text = "Secundario";
            this.Secundario.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Entidad";
            // 
            // dataGridSecundario
            // 
            this.dataGridSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSecundario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dataGridSecundario.Location = new System.Drawing.Point(8, 63);
            this.dataGridSecundario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSecundario.Name = "dataGridSecundario";
            this.dataGridSecundario.ReadOnly = true;
            this.dataGridSecundario.RowHeadersVisible = false;
            this.dataGridSecundario.RowHeadersWidth = 51;
            this.dataGridSecundario.Size = new System.Drawing.Size(253, 240);
            this.dataGridSecundario.TabIndex = 4;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Llave";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 93;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 93;
            // 
            // dataGridSecundarioAuxiliar
            // 
            this.dataGridSecundarioAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSecundarioAuxiliar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dataGridSecundarioAuxiliar.Location = new System.Drawing.Point(272, 33);
            this.dataGridSecundarioAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSecundarioAuxiliar.Name = "dataGridSecundarioAuxiliar";
            this.dataGridSecundarioAuxiliar.ReadOnly = true;
            this.dataGridSecundarioAuxiliar.RowHeadersVisible = false;
            this.dataGridSecundarioAuxiliar.RowHeadersWidth = 51;
            this.dataGridSecundarioAuxiliar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridSecundarioAuxiliar.Size = new System.Drawing.Size(253, 270);
            this.dataGridSecundarioAuxiliar.TabIndex = 2;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Direccion";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 186;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Atributos";
            // 
            // comboBoxAtributosSecundarios
            // 
            this.comboBoxAtributosSecundarios.FormattingEnabled = true;
            this.comboBoxAtributosSecundarios.Location = new System.Drawing.Point(76, 7);
            this.comboBoxAtributosSecundarios.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAtributosSecundarios.Name = "comboBoxAtributosSecundarios";
            this.comboBoxAtributosSecundarios.Size = new System.Drawing.Size(156, 26);
            this.comboBoxAtributosSecundarios.TabIndex = 0;
            // 
            // groupBoxRegistros
            // 
            this.groupBoxRegistros.Controls.Add(this.dataGridRegistros);
            this.groupBoxRegistros.Controls.Add(this.comboBoxEntidad);
            this.groupBoxRegistros.Controls.Add(this.label1);
            this.groupBoxRegistros.Location = new System.Drawing.Point(15, 76);
            this.groupBoxRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRegistros.Size = new System.Drawing.Size(560, 373);
            this.groupBoxRegistros.TabIndex = 29;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "ConsultaDeRegistros";
            this.groupBoxRegistros.Enter += new System.EventHandler(this.groupBoxRegistros_Enter);
            // 
            // dataGridRegistros
            // 
            this.dataGridRegistros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistros.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridRegistros.Location = new System.Drawing.Point(8, 64);
            this.dataGridRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridRegistros.Name = "dataGridRegistros";
            this.dataGridRegistros.RowHeadersVisible = false;
            this.dataGridRegistros.RowHeadersWidth = 51;
            this.dataGridRegistros.Size = new System.Drawing.Size(544, 375);
            this.dataGridRegistros.TabIndex = 1;
            this.dataGridRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRegistros_CellContentClick);
            // 
            // comboBoxEntidad
            // 
            this.comboBoxEntidad.FormattingEnabled = true;
            this.comboBoxEntidad.Location = new System.Drawing.Point(391, 31);
            this.comboBoxEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEntidad.Name = "comboBoxEntidad";
            this.comboBoxEntidad.Size = new System.Drawing.Size(160, 26);
            this.comboBoxEntidad.TabIndex = 2;
            this.comboBoxEntidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntidad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entidad";
            // 
            // CB_entidadParaRegistro
            // 
            this.CB_entidadParaRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_entidadParaRegistro.FormattingEnabled = true;
            this.CB_entidadParaRegistro.Location = new System.Drawing.Point(89, 42);
            this.CB_entidadParaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.CB_entidadParaRegistro.Name = "CB_entidadParaRegistro";
            this.CB_entidadParaRegistro.Size = new System.Drawing.Size(160, 26);
            this.CB_entidadParaRegistro.TabIndex = 27;
            this.CB_entidadParaRegistro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Entidad:";
            // 
            // menuRegistros
            // 
            this.menuRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRegistros.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuRegistros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.menuRegistros.Location = new System.Drawing.Point(4, 4);
            this.menuRegistros.Name = "menuRegistros";
            this.menuRegistros.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuRegistros.Size = new System.Drawing.Size(1365, 28);
            this.menuRegistros.TabIndex = 2;
            this.menuRegistros.Text = "menuStrip3";
            this.menuRegistros.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuRegistros_ItemClicked);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AccessibleName = "Alta";
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(50, 26);
            this.toolStripMenuItem5.Text = "Alta";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AccessibleName = "Modificar";
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(87, 26);
            this.toolStripMenuItem6.Text = "Modificar";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AccessibleName = "Consulta";
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem7.Text = "Consulta";
            this.toolStripMenuItem7.Visible = false;
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.AccessibleName = "Eliminar";
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(77, 26);
            this.toolStripMenuItem8.Text = "Eliminar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DGV_ClaveDeBusqueda
            // 
            this.DGV_ClaveDeBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ClaveDeBusqueda.Location = new System.Drawing.Point(5, 6);
            this.DGV_ClaveDeBusqueda.Name = "DGV_ClaveDeBusqueda";
            this.DGV_ClaveDeBusqueda.RowHeadersWidth = 51;
            this.DGV_ClaveDeBusqueda.RowTemplate.Height = 24;
            this.DGV_ClaveDeBusqueda.Size = new System.Drawing.Size(525, 418);
            this.DGV_ClaveDeBusqueda.TabIndex = 0;
            // 
            // ManejadorDeArchivos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuEntidades;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManejadorDeArchivos_Form";
            this.Text = "Manejador de archivos";
            this.Load += new System.EventHandler(this.ManejadorDeArchivos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManejadorDeArchivos_Form_KeyDown);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntidades)).EndInit();
            this.menuEntidades.ResumeLayout(false);
            this.menuEntidades.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtributos)).EndInit();
            this.menuAtributos.ResumeLayout(false);
            this.menuAtributos.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxIndices.ResumeLayout(false);
            this.tabControlIndices.ResumeLayout(false);
            this.ClaveBusqueda.ResumeLayout(false);
            this.Primario.ResumeLayout(false);
            this.Primario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIdxPrimmario)).EndInit();
            this.Secundario.ResumeLayout(false);
            this.Secundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecundarioAuxiliar)).EndInit();
            this.groupBoxRegistros.ResumeLayout(false);
            this.groupBoxRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistros)).EndInit();
            this.menuRegistros.ResumeLayout(false);
            this.menuRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ClaveDeBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton nuevo_SB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton renombrar_SB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton abrir_SB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cerrar_SB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextB_NombreEntidad;
        private System.Windows.Forms.Label Cabecera;
        private System.Windows.Forms.FolderBrowserDialog SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label tam_label;
        private System.Windows.Forms.Label CabeceraEntidadesDesperdiciadas;
        private System.Windows.Forms.Label cabeceraAtributosDesperdiciados;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox NombreEntidad_Combo;
        private System.Windows.Forms.Label NombreArchivoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridEntidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DreccionAtributo_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionDatos_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiguienteDireccion_Entidad;
        private System.Windows.Forms.MenuStrip menuEntidades;
        private System.Windows.Forms.ToolStripMenuItem altaMenuEntidades;
        private System.Windows.Forms.ToolStripMenuItem modofocarMenuEntidades;
        private System.Windows.Forms.ToolStripMenuItem consultaMenuEntidades;
        private System.Windows.Forms.ToolStripMenuItem eliminarMenuEntidades;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Combo_entidadesParaAtributos;
        private System.Windows.Forms.ComboBox ComboB_LongitudAtributo;
        private System.Windows.Forms.Label longitud;
        private System.Windows.Forms.ComboBox comboNombreAtributo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tipo_label;
        private System.Windows.Forms.Label LB_TipoIndiceAtributo;
        private System.Windows.Forms.ComboBox ComboB_TipoIndiceAtributo;
        private System.Windows.Forms.ComboBox ComboB_TipoAtributo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridAtributos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDato_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitud_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIndice_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionIndice_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siguiente_Atributo;
        private System.Windows.Forms.MenuStrip menuAtributos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuRegistros;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ComboBox CB_entidadParaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxRegistros;
        private System.Windows.Forms.DataGridView dataGridRegistros;
        private System.Windows.Forms.ComboBox comboBoxEntidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxIndices;
        private System.Windows.Forms.TabControl tabControlIndices;
        private System.Windows.Forms.TabPage ClaveBusqueda;
        private System.Windows.Forms.TabPage Primario;
        private System.Windows.Forms.Label labelAtributoPrimario;
        private System.Windows.Forms.DataGridView dataGridIdxPrimmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabPage Secundario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridSecundario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridSecundarioAuxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAtributosSecundarios;
        private System.Windows.Forms.DataGridView DGV_ClaveDeBusqueda;
    }
}

