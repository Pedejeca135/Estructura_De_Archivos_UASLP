using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejadorDeArchivosPro
{
    public partial class CambiarNombreArchivo_Form : Form
    {
        public CambiarNombreArchivo_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNombre.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Escriba un nombre por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public String Nombre
        {
            get { return this.textBoxNombre.Text; }
        }
    }
}
