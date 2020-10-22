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
    public partial class ModificarAtributo_Form : Form
    {
        public String Nombre { get; set; }
        public String NuevoNombre { get; set; }
        Entidad enti;
        public ModificarAtributo_Form(String SelectedYet, Entidad en)
        {
            InitializeComponent();
            foreach (Atributo at in en.atributos)
            {
                Combo_Atributos.Items.Add(at.Nombre);
            }
            this.Combo_Atributos.Text = SelectedYet;
            Modificar.Select();
            enti = en;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = Combo_Atributos.Text;
            NuevoNombre = TB_ModificaAtributoNewName.Text;
            if (enti.existeAtributo(Nombre) && !enti.existeAtributo(NuevoNombre))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El atributo " + Nombre + " no puede cambiar a " + NuevoNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombre = NuevoNombre = "";
            this.Close();
        }
    }
}
