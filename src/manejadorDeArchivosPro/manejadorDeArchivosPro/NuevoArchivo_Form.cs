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
    public partial class NuevoArchivo_Form : Form
    {
        public NuevoArchivo_Form()
        {
            InitializeComponent();
        }
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void crearBT_Click(object sender, EventArgs e)
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

        private void cancelarBT_Click(object sender, EventArgs e)
        {

        }

        public String Nombre
        {
            get { return this.textBoxNombre.Text; }
        }

        
    }
}
