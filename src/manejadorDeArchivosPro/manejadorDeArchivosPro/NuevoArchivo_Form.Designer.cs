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
            this.textBoxNombre.Location = new System.Drawing.Point(16, 31);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ShortcutsEnabled = false;
            this.textBoxNombre.Size = new System.Drawing.Size(344, 22);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombre_KeyDown);
            // 
            // cancelarBT
            // 
            this.cancelarBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBT.Location = new System.Drawing.Point(236, 86);
            this.cancelarBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarBT.Name = "cancelarBT";
            this.cancelarBT.Size = new System.Drawing.Size(125, 42);
            this.cancelarBT.TabIndex = 2;
            this.cancelarBT.Text = "Cancelar";
            this.cancelarBT.UseVisualStyleBackColor = true;
            this.cancelarBT.Click += new System.EventHandler(this.cancelarBT_Click);
            // 
            // crearBT
            // 
            this.crearBT.Location = new System.Drawing.Point(16, 86);
            this.crearBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crearBT.Name = "crearBT";
            this.crearBT.Size = new System.Drawing.Size(125, 42);
            this.crearBT.TabIndex = 3;
            this.crearBT.Text = "Crear";
            this.crearBT.UseVisualStyleBackColor = true;
            this.crearBT.Click += new System.EventHandler(this.crearBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // NuevoArchivo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crearBT);
            this.Controls.Add(this.cancelarBT);
            this.Controls.Add(this.textBoxNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NuevoArchivo_Form";
            this.Text = "Nuevo Archivo";
            this.Load += new System.EventHandler(this.NuevoArchivo_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NuevoArchivo_Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button crearBT;
        private System.Windows.Forms.Button cancelarBT;        
        private System.Windows.Forms.Label label1;
    }
}