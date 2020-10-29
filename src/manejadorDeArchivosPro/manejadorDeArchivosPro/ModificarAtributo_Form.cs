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

        public char Tipo { get; set; }
        public int Longitud { get; set; }
        public int TipoIndice { get; set; }


       Entidad enti;
        public ModificarAtributo_Form(String SelectedYet, Entidad en)
        {
            InitializeComponent();
            this.Text = "Modificar Atributos de : " + en.Nombre;
            enti = en;
            foreach (Atributo at in enti.atributos)
            {
                Combo_Atributos.Items.Add(at.Nombre);
            }
            this.Combo_Atributos.Text = SelectedYet;
            Modificar.Select();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = Combo_Atributos.Text;
            NuevoNombre = TB_ModificaAtributoNewName.Text;

            if (enti.existeAtributo(Nombre) && !enti.existeAtributo(NuevoNombre) && Util.ValidacionDeNombreLight(NuevoNombre))
            {
                    this.Tipo = ComboB_TipoAtributo.Text.ElementAt(0);
                    int longitudAux;
                    Int32.TryParse(ComboB_LongitudAtributo.Text, out longitudAux);
                    this.Longitud = longitudAux;
                    this.TipoIndice = Util.getTipoIndice(ComboB_TipoIndiceAtributo.Text);

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

        private void longitud_Click(object sender, EventArgs e)
        {

        }

        private void Combo_Atributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atributo atribu = this.enti.getAtributo(Combo_Atributos.Text);
            if (atribu != null)
            {
                ComboB_TipoAtributo.Text = atribu.Tipo.ToString();
                ComboB_LongitudAtributo.Text = atribu.Longitud.ToString();
                ComboB_TipoIndiceAtributo.SelectedIndex = atribu.TipoIndice;
                TB_ModificaAtributoNewName.Select();
            }
        }

        private void ComboB_TipoAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboB_TipoAtributo.Text == "E")
            {
                ComboB_LongitudAtributo.Text = 4.ToString();
            }
        }
    }
}
