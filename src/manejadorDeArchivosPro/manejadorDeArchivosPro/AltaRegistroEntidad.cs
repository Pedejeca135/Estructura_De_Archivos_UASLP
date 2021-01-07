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
    public partial class AltaRegistroEntidad : Form
    {
        Entidad entidad;
        int indiceAtributo = 0;

        String lastValueInBuffer = "";

        public List<List<byte>> RegistroAlta { get; }



        public AltaRegistroEntidad(String SelectedYet, Entidad en)
        {
            InitializeComponent();
            this.Text = "Registro de Entidad : " + en.Nombre;
            entidad = en;
            this.Anterior.Enabled = false;
            this.Aceptar.Enabled = false;
            RegistroAlta = new List<List<byte>>();
            cargaAtributo();

        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            limpiaAtributo();
            if (indiceAtributo > 0)
            {
                RegistroAlta.Remove(RegistroAlta.ElementAt(RegistroAlta.Count-1));//elimina el ultimo elemento agregado
                indiceAtributo--;
                Siguiente.Enabled = true;
                Aceptar.Enabled = false;

                if (indiceAtributo == 0)
                {
                    Anterior.Enabled = false;
                    RegistroAlta.Clear();
                }
                cargaAtributo();
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            
            if (indiceAtributo < entidad.atributos.Count)
            {
                List<byte> auxRegCampo = validaInformacionLista();
                 
                if (auxRegCampo != null)
                {
                    RegistroAlta.Add(auxRegCampo);
                    indiceAtributo++;
                    Anterior.Enabled = true;
                    limpiaAtributo();

                    if (indiceAtributo == this.entidad.atributos.Count)
                    {
                        this.Siguiente.Enabled = false;//se desactiva el botton de siguiente
                        this.Aceptar.Enabled = true;
                        this.Aceptar.Visible = true;
                    }
                    else
                    {
                        cargaAtributo();
                    }
                }
            }
        }

        private void cargaAtributo()
        {
            try
            {
                Atributo atAux = entidad.atributos[indiceAtributo];
                textBoxAtributo.Text = atAux.Nombre;
                textBoxTipo.Text = atAux.Tipo.ToString();
                textBoxIndice.Text = atAux.TipoIndice.ToString();
                textBoxLong.Text = atAux.Longitud.ToString();
            }
            catch
            {
                MessageBox.Show("No hay atributos en la entidad: "+entidad.Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void limpiaAtributo()
        {
            textBoxAtributo.Text = "";
            textBoxTipo.Text = "";
            textBoxIndice.Text = "";
            textBoxLong.Text = "";
            textBoxDato.Text = "";
        }

        private List<byte> validaInformacionLista()
        {

            byte[] aux = validaInformacion();
        
               if (aux == null)
                return null;

                List<byte> res = new List<byte>();
                for(int i =0; i< aux.Length; i++)
                {
                    res.Add(aux[i]);
                }
                return res;

        }


        private byte[] validaInformacion()
        {
            Atributo atAux = entidad.atributos[indiceAtributo];

            if(atAux.Tipo == 'E' || atAux.Tipo == 'e')
            {
                int d;
                if (Int32.TryParse(textBoxDato.Text, out d))
                {
                    return  BitConverter.GetBytes(d);
                }
                MessageBox.Show("Caracteres no permitidos en el entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(atAux.Tipo == 'C' || atAux.Tipo == 'c')
            {
                if(textBoxDato.Text.Length <= atAux.Longitud)
                {
                    return UtilStatic.getStringEnByteArray(textBoxDato.Text,atAux.Longitud);
                }
                MessageBox.Show("El tamaño de la cadena excede el permitido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void textBoxAtributo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
               this.DialogResult = DialogResult.OK;
                this.Close();                
            }
            catch(FormatException)
            {
              MessageBox.Show("El tamaño de la cadena excede el permitido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AltaRegistroEntidad_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                if (Aceptar.Enabled)
                {
                    this.Aceptar_Click(sender, e);
                }
                else
                {
                    this.Siguiente_Click(sender, e);
                }
            }
        }





    }
}
