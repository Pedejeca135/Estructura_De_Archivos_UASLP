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

        private int indiceDeInteresEnCombo;


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

            if (enti.existeAtributo(Nombre) && !enti.existeAtributo(NuevoNombre) && UtilStatic.ValidacionDeNombreLight(NuevoNombre))
            {
                if (enti.DireccionRegistros != -1 && this.ComboB_LongitudAtributo.Text != this.longitudTextoInicial_CB)
                //si ya hay registros y la longitud cambio
                {
                        MessageBox.Show("longitud no puede cambiar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    this.Tipo = ComboB_TipoAtributo.Text.ElementAt(0);
                    int longitudAux;
                    Int32.TryParse(ComboB_LongitudAtributo.Text, out longitudAux);
                    this.Longitud = longitudAux;
                    this.TipoIndice = UtilStatic.getTipoIndice(ComboB_TipoIndiceAtributo.Text);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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

        Atributo atribu;
        int indice_CBIndice = 0;
        int indice_CBTipo = 0;
        String longitudTextoInicial_CB;
        
        private void Combo_Atributos_SelectedIndexChanged(object sender, EventArgs e)
        {
             atribu = this.enti.getAtributo(Combo_Atributos.Text);
            if (atribu != null)
            {
                ComboB_TipoAtributo.Text = atribu.Tipo.ToString();
                ComboB_LongitudAtributo.Text = atribu.Longitud.ToString();
                ComboB_TipoIndiceAtributo.SelectedIndex = atribu.TipoIndice;

                indice_CBIndice = this.ComboB_TipoIndiceAtributo.SelectedIndex;
                indice_CBTipo = this.ComboB_TipoAtributo.SelectedIndex;
                longitudTextoInicial_CB = this.ComboB_LongitudAtributo.Text;

                TB_ModificaAtributoNewName.Select();
            }
        }


        private void indiceTipoIndice(object sender, EventArgs e)
        {
            indiceDeInteresEnCombo = ComboB_TipoIndiceAtributo.SelectedIndex;
         ComboB_TipoIndiceAtributo_SelectionChangeCommitted(sender , e);
        }
        private void ComboB_TipoIndiceAtributo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (enti.DireccionRegistros != -1)//ya existen registros
            {
                atribu = this.enti.getAtributo(Combo_Atributos.Text);
                if (atribu != null)
                {
                    //ComboB_TipoIndiceAtributo.Text = atribu.TipoIndice.ToString();
                    //ComboB_TipoIndiceAtributo.SelectedIndex = ComboB_TipoIndiceAtributo.Items.IndexOf(atribu.TipoIndice.ToString());
                 
                    ComboB_TipoIndiceAtributo.SelectedIndex = indice_CBIndice;
               
                    TB_ModificaAtributoNewName.Select();
                }
                MessageBox.Show("El atributo " + Nombre + " no puede cambiar su tipo de indice porque ya existen registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void indiceTipoAtributo(object sender, EventArgs e)
        {
            indiceDeInteresEnCombo = ComboB_TipoAtributo.SelectedIndex;
            ComboB_TipoAtributo_SelectionChangeCommitted(sender, e);
        }

        private void ComboB_TipoAtributo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (enti.DireccionRegistros != -1)//ya existen registros 
            {

                atribu = this.enti.getAtributo(Combo_Atributos.Text);
                if (atribu != null)
                {
                    //ComboB_TipoAtributo.Text = atribu.Tipo.ToString();
                    //ComboB_TipoAtributo.SelectedIndex = ComboB_TipoAtributo.Items.IndexOf(atribu.Tipo.ToString());
                    //int aux = ComboB_TipoAtributo.SelectedIndex;
                    ComboB_TipoAtributo.SelectedIndex = indice_CBTipo;
                    TB_ModificaAtributoNewName.Select();
                }
                MessageBox.Show("El atributo " + Nombre + " no puede cambiar su tipo porque ya existen registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (ComboB_TipoAtributo.Text == "E")
                {
                    ComboB_LongitudAtributo.Text = 4.ToString();
                }
            }
        }

        private void indiceLongitudAtributo(object sender, EventArgs e)
        {
            indiceDeInteresEnCombo = ComboB_LongitudAtributo.SelectedIndex;
            ComboB_LongitudAtributo_SelectionChangeCommitted(sender, e);
        }

        private void ComboB_LongitudAtributo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (enti.DireccionRegistros != -1)//ya existen registros
            {
                atribu = this.enti.getAtributo(Combo_Atributos.Text);
                if (atribu != null)
                {
                    ComboB_LongitudAtributo.Text = atribu.Longitud.ToString();
                    TB_ModificaAtributoNewName.Select();
                }
                MessageBox.Show("El atributo " + Nombre + " no puede cambiar su longitud porque ya existen registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ComboB_LongitudAtributo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (enti.DireccionRegistros != -1)//ya existen registros
            {
                atribu = this.enti.getAtributo(Combo_Atributos.Text);
                if (atribu != null)
                {
                    ComboB_LongitudAtributo.Text = atribu.Longitud.ToString();
                    TB_ModificaAtributoNewName.Select();
                }
                MessageBox.Show("El atributo " + Nombre + " no puede cambiar su longitud porque ya existen registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ComboB_LongitudAtributo_TextChanged(object sender,EventArgs e)
        {
            
        }

        private void ModificarAtributo_Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("looooooad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        private void ComboB_TipoIndiceAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboB_LongitudAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
