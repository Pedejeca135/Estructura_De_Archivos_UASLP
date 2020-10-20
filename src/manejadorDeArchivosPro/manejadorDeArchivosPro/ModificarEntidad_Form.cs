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
    public partial class ModificarEntidad_Form : Form
    {
        public String NuevoNombre
        {
            get { return TB_ModificaEntidadNewName.Text; }       
        }
        public ModificarEntidad_Form(String SelectedYet)
        {
            InitializeComponent();
            this.Combo_entidadesParaAtributos.Text = SelectedYet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
