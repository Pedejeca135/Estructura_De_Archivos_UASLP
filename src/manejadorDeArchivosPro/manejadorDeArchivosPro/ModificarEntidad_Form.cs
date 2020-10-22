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
        public String Nombre { get; set; }
        public String NuevoNombre{get;set;}
        Archivo archi;

        
        public ModificarEntidad_Form(String SelectedYet,ref Archivo ar)
        {
            InitializeComponent();
            foreach (Entidad en in ar.Entidades)
            {
                Combo_entidadesParaAtributos.Items.Add(en.Nombre);
            }
            this.Combo_entidadesParaAtributos.Text = SelectedYet;
            TB_ModificaEntidadNewName.Select();
            archi = ar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = Combo_entidadesParaAtributos.Text;
            NuevoNombre = TB_ModificaEntidadNewName.Text;
            if (archi.ContainsName(Nombre) && !archi.ContainsName(NuevoNombre))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("La entidad "+ Nombre +" no puede cambiar a "+NuevoNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombre = NuevoNombre = "";
            this.Close();
        }
    }
}
