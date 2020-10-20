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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tam_label = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CabeceraEntidadesDesperdiciadas = new System.Windows.Forms.Label();
            this.cabeceraAtributosDesperdiciados = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuRegistros = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuAtributos = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridAtributos = new System.Windows.Forms.DataGridView();
            this.Siguiente_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionIndice_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIndice_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitud_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDato_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboB_TipoAtributo = new System.Windows.Forms.ComboBox();
            this.ComboB_TipoIndiceAtributo = new System.Windows.Forms.ComboBox();
            this.LB_TipoIndiceAtributo = new System.Windows.Forms.Label();
            this.tipo_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNombreAtributo = new System.Windows.Forms.ComboBox();
            this.longitud = new System.Windows.Forms.Label();
            this.ComboB_LongitudAtributo = new System.Windows.Forms.ComboBox();
            this.Combo_entidadesParaAtributos = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuEntidades = new System.Windows.Forms.MenuStrip();
            this.altaMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.modofocarMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuEntidades = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridEntidades = new System.Windows.Forms.DataGridView();
            this.SiguienteDireccion_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionDatos_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DreccionAtributo_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreArchivoLabel = new System.Windows.Forms.Label();
            this.NombreEntidad_Combo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuRegistros.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuAtributos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtributos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.menuEntidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntidades)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            this.toolBar.Size = new System.Drawing.Size(1066, 31);
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
            this.nuevo_SB.Size = new System.Drawing.Size(84, 28);
            this.nuevo_SB.Text = "Nuevo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
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
            this.renombrar_SB.Size = new System.Drawing.Size(117, 28);
            this.renombrar_SB.Text = "Renombrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // abrir_SB
            // 
            this.abrir_SB.AccessibleName = "Abrir";
            this.abrir_SB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir_SB.Image = ((System.Drawing.Image)(resources.GetObject("abrir_SB.Image")));
            this.abrir_SB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abrir_SB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrir_SB.Name = "abrir_SB";
            this.abrir_SB.Size = new System.Drawing.Size(73, 28);
            this.abrir_SB.Text = "Abrir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
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
            this.cerrar_SB.Size = new System.Drawing.Size(82, 28);
            this.cerrar_SB.Text = "Cerrar";
            // 
            // Cabecera
            // 
            this.Cabecera.AutoSize = true;
            this.Cabecera.Location = new System.Drawing.Point(6, 14);
            this.Cabecera.Name = "Cabecera";
            this.Cabecera.Size = new System.Drawing.Size(59, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 487);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tam_label
            // 
            this.tam_label.AutoSize = true;
            this.tam_label.Location = new System.Drawing.Point(423, 14);
            this.tam_label.Name = "tam_label";
            this.tam_label.Size = new System.Drawing.Size(49, 13);
            this.tam_label.TabIndex = 4;
            this.tam_label.Text = "Tamaño:";
            this.tam_label.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CabeceraEntidadesDesperdiciadas
            // 
            this.CabeceraEntidadesDesperdiciadas.AutoSize = true;
            this.CabeceraEntidadesDesperdiciadas.Location = new System.Drawing.Point(115, 14);
            this.CabeceraEntidadesDesperdiciadas.Name = "CabeceraEntidadesDesperdiciadas";
            this.CabeceraEntidadesDesperdiciadas.Size = new System.Drawing.Size(98, 13);
            this.CabeceraEntidadesDesperdiciadas.TabIndex = 5;
            this.CabeceraEntidadesDesperdiciadas.Text = "CabEntidadesDes :";
            this.CabeceraEntidadesDesperdiciadas.Visible = false;
            // 
            // cabeceraAtributosDesperdiciados
            // 
            this.cabeceraAtributosDesperdiciados.AutoSize = true;
            this.cabeceraAtributosDesperdiciados.Location = new System.Drawing.Point(276, 14);
            this.cabeceraAtributosDesperdiciados.Name = "cabeceraAtributosDesperdiciados";
            this.cabeceraAtributosDesperdiciados.Size = new System.Drawing.Size(92, 13);
            this.cabeceraAtributosDesperdiciados.TabIndex = 8;
            this.cabeceraAtributosDesperdiciados.Text = "CabAtributosDes :";
            this.cabeceraAtributosDesperdiciados.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.menuRegistros);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1028, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registros";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuRegistros
            // 
            this.menuRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRegistros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.menuRegistros.Location = new System.Drawing.Point(3, 3);
            this.menuRegistros.Name = "menuRegistros";
            this.menuRegistros.Size = new System.Drawing.Size(1022, 24);
            this.menuRegistros.TabIndex = 2;
            this.menuRegistros.Text = "menuStrip3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem5.Text = "Alta";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem6.Text = "Modificar";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem7.Text = "Consulta";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem8.Text = "Eliminar";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1028, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Atributos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuAtributos
            // 
            this.menuAtributos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAtributos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuAtributos.Location = new System.Drawing.Point(3, 3);
            this.menuAtributos.Name = "menuAtributos";
            this.menuAtributos.Size = new System.Drawing.Size(1022, 24);
            this.menuAtributos.TabIndex = 1;
            this.menuAtributos.Text = "menuStrip2";
            this.menuAtributos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuAtributos_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleName = "Alta";
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem1.Text = "Alta";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleName = "Modificar";
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem2.Text = "Modificar";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AccessibleName = "Consulta";
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem3.Text = "Consulta";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AccessibleName = "Eliminar";
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem4.Text = "Eliminar";
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
            this.dataGridAtributos.Location = new System.Drawing.Point(6, 58);
            this.dataGridAtributos.Name = "dataGridAtributos";
            this.dataGridAtributos.Size = new System.Drawing.Size(1016, 375);
            this.dataGridAtributos.TabIndex = 2;
            // 
            // Siguiente_Atributo
            // 
            this.Siguiente_Atributo.HeaderText = "Siguiente Atributo";
            this.Siguiente_Atributo.Name = "Siguiente_Atributo";
            // 
            // DireccionIndice_Atributo
            // 
            this.DireccionIndice_Atributo.HeaderText = "Dirección de Índice";
            this.DireccionIndice_Atributo.Name = "DireccionIndice_Atributo";
            // 
            // TipoIndice_Atributo
            // 
            this.TipoIndice_Atributo.HeaderText = "Tipo de Índice";
            this.TipoIndice_Atributo.Name = "TipoIndice_Atributo";
            // 
            // Direccion_Atributo
            // 
            this.Direccion_Atributo.HeaderText = "Dirección";
            this.Direccion_Atributo.Name = "Direccion_Atributo";
            // 
            // longitud_Atributo
            // 
            this.longitud_Atributo.HeaderText = "Longitud";
            this.longitud_Atributo.Name = "longitud_Atributo";
            // 
            // tipoDato_Atributo
            // 
            this.tipoDato_Atributo.HeaderText = "Tipo de Dato";
            this.tipoDato_Atributo.Name = "tipoDato_Atributo";
            // 
            // Nombre_Atributo
            // 
            this.Nombre_Atributo.HeaderText = "Nombre";
            this.Nombre_Atributo.Name = "Nombre_Atributo";
            // 
            // ID_Atributo
            // 
            this.ID_Atributo.HeaderText = "ID";
            this.ID_Atributo.Name = "ID_Atributo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // ComboB_TipoAtributo
            // 
            this.ComboB_TipoAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_TipoAtributo.FormattingEnabled = true;
            this.ComboB_TipoAtributo.Items.AddRange(new object[] {
            "E",
            "C"});
            this.ComboB_TipoAtributo.Location = new System.Drawing.Point(443, 30);
            this.ComboB_TipoAtributo.Name = "ComboB_TipoAtributo";
            this.ComboB_TipoAtributo.Size = new System.Drawing.Size(32, 23);
            this.ComboB_TipoAtributo.TabIndex = 7;
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
            this.ComboB_TipoIndiceAtributo.Location = new System.Drawing.Point(767, 30);
            this.ComboB_TipoIndiceAtributo.Name = "ComboB_TipoIndiceAtributo";
            this.ComboB_TipoIndiceAtributo.Size = new System.Drawing.Size(121, 23);
            this.ComboB_TipoIndiceAtributo.TabIndex = 8;
            // 
            // LB_TipoIndiceAtributo
            // 
            this.LB_TipoIndiceAtributo.AutoSize = true;
            this.LB_TipoIndiceAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TipoIndiceAtributo.Location = new System.Drawing.Point(691, 31);
            this.LB_TipoIndiceAtributo.Name = "LB_TipoIndiceAtributo";
            this.LB_TipoIndiceAtributo.Size = new System.Drawing.Size(70, 15);
            this.LB_TipoIndiceAtributo.TabIndex = 9;
            this.LB_TipoIndiceAtributo.Text = "Tipo Indice:";
            // 
            // tipo_label
            // 
            this.tipo_label.AutoSize = true;
            this.tipo_label.Location = new System.Drawing.Point(403, 31);
            this.tipo_label.Name = "tipo_label";
            this.tipo_label.Size = new System.Drawing.Size(34, 15);
            this.tipo_label.TabIndex = 10;
            this.tipo_label.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entidad:";
            // 
            // comboNombreAtributo
            // 
            this.comboNombreAtributo.FormattingEnabled = true;
            this.comboNombreAtributo.Location = new System.Drawing.Point(267, 31);
            this.comboNombreAtributo.Name = "comboNombreAtributo";
            this.comboNombreAtributo.Size = new System.Drawing.Size(121, 23);
            this.comboNombreAtributo.TabIndex = 13;
            this.comboNombreAtributo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // longitud
            // 
            this.longitud.AutoSize = true;
            this.longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitud.Location = new System.Drawing.Point(490, 31);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(55, 15);
            this.longitud.TabIndex = 14;
            this.longitud.Text = "Longitud";
            // 
            // ComboB_LongitudAtributo
            // 
            this.ComboB_LongitudAtributo.FormattingEnabled = true;
            this.ComboB_LongitudAtributo.Location = new System.Drawing.Point(551, 30);
            this.ComboB_LongitudAtributo.Name = "ComboB_LongitudAtributo";
            this.ComboB_LongitudAtributo.Size = new System.Drawing.Size(121, 23);
            this.ComboB_LongitudAtributo.TabIndex = 16;
            // 
            // Combo_entidadesParaAtributos
            // 
            this.Combo_entidadesParaAtributos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_entidadesParaAtributos.FormattingEnabled = true;
            this.Combo_entidadesParaAtributos.Location = new System.Drawing.Point(64, 31);
            this.Combo_entidadesParaAtributos.Name = "Combo_entidadesParaAtributos";
            this.Combo_entidadesParaAtributos.Size = new System.Drawing.Size(121, 23);
            this.Combo_entidadesParaAtributos.TabIndex = 17;
            this.Combo_entidadesParaAtributos.SelectedIndexChanged += new System.EventHandler(this.Combo_entidadesParaAtributos_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NombreEntidad_Combo);
            this.tabPage1.Controls.Add(this.NombreArchivoLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dataGridEntidades);
            this.tabPage1.Controls.Add(this.menuEntidades);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1028, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuEntidades
            // 
            this.menuEntidades.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEntidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaMenuEntidades,
            this.modofocarMenuEntidades,
            this.consultaMenuEntidades,
            this.eliminarMenuEntidades});
            this.menuEntidades.Location = new System.Drawing.Point(3, 3);
            this.menuEntidades.Name = "menuEntidades";
            this.menuEntidades.Size = new System.Drawing.Size(1022, 24);
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
            this.altaMenuEntidades.Size = new System.Drawing.Size(40, 20);
            this.altaMenuEntidades.Text = "Alta";
            // 
            // modofocarMenuEntidades
            // 
            this.modofocarMenuEntidades.AccessibleName = "Modificar";
            this.modofocarMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modofocarMenuEntidades.Name = "modofocarMenuEntidades";
            this.modofocarMenuEntidades.Size = new System.Drawing.Size(70, 20);
            this.modofocarMenuEntidades.Text = "Modificar";
            // 
            // consultaMenuEntidades
            // 
            this.consultaMenuEntidades.AccessibleName = "Consulta";
            this.consultaMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaMenuEntidades.Name = "consultaMenuEntidades";
            this.consultaMenuEntidades.Size = new System.Drawing.Size(66, 20);
            this.consultaMenuEntidades.Text = "Consulta";
            // 
            // eliminarMenuEntidades
            // 
            this.eliminarMenuEntidades.AccessibleName = "Eliminar";
            this.eliminarMenuEntidades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarMenuEntidades.Name = "eliminarMenuEntidades";
            this.eliminarMenuEntidades.Size = new System.Drawing.Size(62, 20);
            this.eliminarMenuEntidades.Text = "Eliminar";
            // 
            // dataGridEntidades
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEntidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Entidad,
            this.Nombre_Entidad,
            this.Direccion_Entidad,
            this.DreccionAtributo_Entidad,
            this.DireccionDatos_Entidad,
            this.SiguienteDireccion_Entidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEntidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEntidades.Location = new System.Drawing.Point(3, 63);
            this.dataGridEntidades.Name = "dataGridEntidades";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEntidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEntidades.Size = new System.Drawing.Size(1016, 370);
            this.dataGridEntidades.TabIndex = 1;
            // 
            // SiguienteDireccion_Entidad
            // 
            this.SiguienteDireccion_Entidad.HeaderText = "Siguiente Dirección";
            this.SiguienteDireccion_Entidad.Name = "SiguienteDireccion_Entidad";
            // 
            // DireccionDatos_Entidad
            // 
            this.DireccionDatos_Entidad.HeaderText = "Dirección Datos";
            this.DireccionDatos_Entidad.Name = "DireccionDatos_Entidad";
            // 
            // DreccionAtributo_Entidad
            // 
            this.DreccionAtributo_Entidad.HeaderText = "DirecciónAtributo";
            this.DreccionAtributo_Entidad.Name = "DreccionAtributo_Entidad";
            // 
            // Direccion_Entidad
            // 
            this.Direccion_Entidad.HeaderText = "Dirección";
            this.Direccion_Entidad.Name = "Direccion_Entidad";
            // 
            // Nombre_Entidad
            // 
            this.Nombre_Entidad.HeaderText = "Nombre";
            this.Nombre_Entidad.Name = "Nombre_Entidad";
            // 
            // ID_Entidad
            // 
            this.ID_Entidad.HeaderText = "ID";
            this.ID_Entidad.Name = "ID_Entidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // NombreArchivoLabel
            // 
            this.NombreArchivoLabel.AutoSize = true;
            this.NombreArchivoLabel.Location = new System.Drawing.Point(266, 36);
            this.NombreArchivoLabel.Name = "NombreArchivoLabel";
            this.NombreArchivoLabel.Size = new System.Drawing.Size(46, 13);
            this.NombreArchivoLabel.TabIndex = 3;
            this.NombreArchivoLabel.Text = "Archivo:";
            this.NombreArchivoLabel.Visible = false;
            // 
            // NombreEntidad_Combo
            // 
            this.NombreEntidad_Combo.FormattingEnabled = true;
            this.NombreEntidad_Combo.Location = new System.Drawing.Point(58, 36);
            this.NombreEntidad_Combo.Name = "NombreEntidad_Combo";
            this.NombreEntidad_Combo.Size = new System.Drawing.Size(121, 21);
            this.NombreEntidad_Combo.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 452);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // ManejadorDeArchivos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuEntidades;
            this.Name = "ManejadorDeArchivos_Form";
            this.Text = "Manejador de archivos";
            this.Load += new System.EventHandler(this.ManejadorDeArchivos_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuRegistros.ResumeLayout(false);
            this.menuRegistros.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuAtributos.ResumeLayout(false);
            this.menuAtributos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtributos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuEntidades.ResumeLayout(false);
            this.menuEntidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntidades)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
    }
}

