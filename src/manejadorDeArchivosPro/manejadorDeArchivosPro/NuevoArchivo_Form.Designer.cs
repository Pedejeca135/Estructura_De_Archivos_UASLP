namespace manejadorDeArchivosPro
{
    partial class NuevoArchivo_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoArchivo_Form));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.cancelarBT = new System.Windows.Forms.Button();
            this.crearBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 25);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(259, 29);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // cancelarBT
            // 
            this.cancelarBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBT.Location = new System.Drawing.Point(177, 70);
            this.cancelarBT.Name = "cancelarBT";
            this.cancelarBT.Size = new System.Drawing.Size(94, 34);
            this.cancelarBT.TabIndex = 2;
            this.cancelarBT.Text = "Cancelar";
            this.cancelarBT.UseVisualStyleBackColor = true;
            this.cancelarBT.Click += new System.EventHandler(this.cancelarBT_Click);
            // 
            // crearBT
            // 
            this.crearBT.Location = new System.Drawing.Point(12, 70);
            this.crearBT.Name = "crearBT";
            this.crearBT.Size = new System.Drawing.Size(94, 34);
            this.crearBT.TabIndex = 3;
            this.crearBT.Text = "Crear";
            this.crearBT.UseVisualStyleBackColor = true;
            this.crearBT.Click += new System.EventHandler(this.crearBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // NuevoArchivo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crearBT);
            this.Controls.Add(this.cancelarBT);
            this.Controls.Add(this.textBoxNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoArchivo_Form";
            this.Text = "Nuevo Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button cancelarBT;
        private System.Windows.Forms.Button crearBT;
        private System.Windows.Forms.Label label1;
    }
}