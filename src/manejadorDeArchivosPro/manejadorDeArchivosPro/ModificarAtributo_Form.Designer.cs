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
            this.SuspendLayout();
            // 
            // TB_ModificaAtributoNewName
            // 
            this.TB_ModificaAtributoNewName.Location = new System.Drawing.Point(140, 55);
            this.TB_ModificaAtributoNewName.Name = "TB_ModificaAtributoNewName";
            this.TB_ModificaAtributoNewName.Size = new System.Drawing.Size(121, 20);
            this.TB_ModificaAtributoNewName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nuevo Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(81, 99);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(95, 34);
            this.Modificar.TabIndex = 20;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Atributo:";
            // 
            // Combo_Atributos
            // 
            this.Combo_Atributos.FormattingEnabled = true;
            this.Combo_Atributos.Location = new System.Drawing.Point(140, 18);
            this.Combo_Atributos.Name = "Combo_Atributos";
            this.Combo_Atributos.Size = new System.Drawing.Size(121, 21);
            this.Combo_Atributos.TabIndex = 18;
            // 
            // ModificarAtributo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 173);
            this.Controls.Add(this.TB_ModificaAtributoNewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Atributos);
            this.Name = "ModificarAtributo_Form";
            this.Text = "ModificarAtributo_Form";
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
    }
}