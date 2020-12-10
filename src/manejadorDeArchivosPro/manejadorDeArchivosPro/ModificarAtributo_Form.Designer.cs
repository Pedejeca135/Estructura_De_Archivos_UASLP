namespace manejadorDeArchivosPro
{
    partial class ModificarAtributo_Form
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
            this.TB_ModificaAtributoNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Combo_Atributos = new System.Windows.Forms.ComboBox();
            this.ComboB_TipoAtributo = new System.Windows.Forms.ComboBox();
            this.ComboB_LongitudAtributo = new System.Windows.Forms.ComboBox();
            this.ComboB_TipoIndiceAtributo = new System.Windows.Forms.ComboBox();
            this.LB_TipoIndiceAtributo = new System.Windows.Forms.Label();
            this.longitud = new System.Windows.Forms.Label();
            this.tipo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_ModificaAtributoNewName
            // 
            this.TB_ModificaAtributoNewName.Location = new System.Drawing.Point(393, 11);
            this.TB_ModificaAtributoNewName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ModificaAtributoNewName.Name = "TB_ModificaAtributoNewName";
            this.TB_ModificaAtributoNewName.Size = new System.Drawing.Size(160, 22);
            this.TB_ModificaAtributoNewName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nuevo Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(108, 134);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(127, 42);
            this.Modificar.TabIndex = 20;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Atributo:";
            // 
            // Combo_Atributos
            // 
            this.Combo_Atributos.FormattingEnabled = true;
            this.Combo_Atributos.Location = new System.Drawing.Point(79, 11);
            this.Combo_Atributos.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_Atributos.Name = "Combo_Atributos";
            this.Combo_Atributos.Size = new System.Drawing.Size(160, 24);
            this.Combo_Atributos.TabIndex = 18;
            this.Combo_Atributos.SelectedIndexChanged += new System.EventHandler(this.Combo_Atributos_SelectedIndexChanged);
            // 
            // ComboB_TipoAtributo
            // 
            this.ComboB_TipoAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_TipoAtributo.FormattingEnabled = true;
            this.ComboB_TipoAtributo.Items.AddRange(new object[] {
            "E",
            "C"});
            this.ComboB_TipoAtributo.Location = new System.Drawing.Point(45, 75);
            this.ComboB_TipoAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboB_TipoAtributo.Name = "ComboB_TipoAtributo";
            this.ComboB_TipoAtributo.Size = new System.Drawing.Size(41, 24);
            this.ComboB_TipoAtributo.TabIndex = 24;
            this.ComboB_TipoAtributo.SelectionChangeCommitted += new System.EventHandler(this.indiceTipoAtributo);
            // 
            // ComboB_LongitudAtributo
            // 
            this.ComboB_LongitudAtributo.FormattingEnabled = true;
            this.ComboB_LongitudAtributo.Location = new System.Drawing.Point(165, 75);
            this.ComboB_LongitudAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboB_LongitudAtributo.Name = "ComboB_LongitudAtributo";
            this.ComboB_LongitudAtributo.Size = new System.Drawing.Size(160, 24);
            this.ComboB_LongitudAtributo.TabIndex = 25;
            this.ComboB_LongitudAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_LongitudAtributo_SelectedIndexChanged);
            this.ComboB_LongitudAtributo.SelectionChangeCommitted += new System.EventHandler(this.indiceLongitudAtributo);
            this.ComboB_LongitudAtributo.SelectedValueChanged += new System.EventHandler(this.ComboB_LongitudAtributo_SelectedValueChanged);
            this.ComboB_LongitudAtributo.TextChanged += new System.EventHandler(this.ComboB_LongitudAtributo_TextChanged);
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
            this.ComboB_TipoIndiceAtributo.Location = new System.Drawing.Point(376, 75);
            this.ComboB_TipoIndiceAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.ComboB_TipoIndiceAtributo.Name = "ComboB_TipoIndiceAtributo";
            this.ComboB_TipoIndiceAtributo.Size = new System.Drawing.Size(160, 24);
            this.ComboB_TipoIndiceAtributo.TabIndex = 26;
            this.ComboB_TipoIndiceAtributo.SelectedIndexChanged += new System.EventHandler(this.ComboB_TipoIndiceAtributo_SelectedIndexChanged);
            this.ComboB_TipoIndiceAtributo.SelectionChangeCommitted += new System.EventHandler(this.indiceTipoIndice);
            // 
            // LB_TipoIndiceAtributo
            // 
            this.LB_TipoIndiceAtributo.AutoSize = true;
            this.LB_TipoIndiceAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TipoIndiceAtributo.Location = new System.Drawing.Point(372, 50);
            this.LB_TipoIndiceAtributo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TipoIndiceAtributo.Name = "LB_TipoIndiceAtributo";
            this.LB_TipoIndiceAtributo.Size = new System.Drawing.Size(83, 18);
            this.LB_TipoIndiceAtributo.TabIndex = 27;
            this.LB_TipoIndiceAtributo.Text = "Tipo Indice:";
            // 
            // longitud
            // 
            this.longitud.AutoSize = true;
            this.longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitud.Location = new System.Drawing.Point(161, 50);
            this.longitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(64, 18);
            this.longitud.TabIndex = 28;
            this.longitud.Text = "Longitud";
            this.longitud.Click += new System.EventHandler(this.longitud_Click);
            // 
            // tipo_label
            // 
            this.tipo_label.AutoSize = true;
            this.tipo_label.Location = new System.Drawing.Point(41, 53);
            this.tipo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipo_label.Name = "tipo_label";
            this.tipo_label.Size = new System.Drawing.Size(40, 17);
            this.tipo_label.TabIndex = 29;
            this.tipo_label.Text = "Tipo:";
            // 
            // ModificarAtributo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 213);
            this.Controls.Add(this.tipo_label);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.LB_TipoIndiceAtributo);
            this.Controls.Add(this.ComboB_TipoIndiceAtributo);
            this.Controls.Add(this.ComboB_LongitudAtributo);
            this.Controls.Add(this.ComboB_TipoAtributo);
            this.Controls.Add(this.TB_ModificaAtributoNewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Atributos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarAtributo_Form";
            this.Text = "ModificarAtributo_Form";
            this.Load += new System.EventHandler(this.ModificarAtributo_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_ModificaAtributoNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo_Atributos;
        private System.Windows.Forms.ComboBox ComboB_TipoAtributo;
        private System.Windows.Forms.ComboBox ComboB_LongitudAtributo;
        private System.Windows.Forms.ComboBox ComboB_TipoIndiceAtributo;
        private System.Windows.Forms.Label LB_TipoIndiceAtributo;
        private System.Windows.Forms.Label longitud;
        private System.Windows.Forms.Label tipo_label;
    }
}