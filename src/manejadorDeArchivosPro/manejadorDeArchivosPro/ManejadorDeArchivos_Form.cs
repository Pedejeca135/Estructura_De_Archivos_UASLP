using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//para el uso del filestream
using System.Windows.Forms;

namespace manejadorDeArchivosPro
{
    public partial class ManejadorDeArchivos_Form : Form
    {

        #region Constructores
        public ManejadorDeArchivos_Form()
        {
            InitializeComponent();
            /*
             * 0-> Sin ndice
             * 1-> Organizacion Secuencial
             * 2-> OS Indice Primario
             * 3-> OS Indice Secundario
             * 4-> Arbol B+             * 
             * */
           
        }
        #endregion
        #region Constantes
        String NombrePorDefectoArchivo = "nuevoArchivo.dd";
        #endregion
        #region Variables_De_Instancia
        private Archivo archivoDeTrabajo;

        private String pathDirectorio;
        private String pathNombreArchivo;
        private List<int> listaLongitud;
        
        #endregion


        #region EventosForm

        private void ManejadorDeArchivos_Load(object sender, EventArgs e)
        {
            pathDirectorio = Environment.CurrentDirectory + @"\Archivos";
            if (!Directory.Exists(pathDirectorio))//Verifica si la carpeta existe
            {
                Directory.CreateDirectory(pathDirectorio);
            }
            listaLongitud = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach(int i in listaLongitud)
            {
                ComboB_LongitudAtributo.Items.Add(i);
            }
            

        }

        private void toolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.AccessibleName)
            {
                case "Nuevo":
                    #region Nuevo
                    if (this.archivoDeTrabajo == null)//Verifica que no exista un archivo abierto
                    {
                           SaveFileDialog SFD = new SaveFileDialog();
                           SFD.FileName = NombrePorDefectoArchivo;
                           SFD.InitialDirectory = pathDirectorio;
                           SFD.Title = "Crear Archivo";
                           SFD.DefaultExt = ".dd";
                           SFD.Filter = "Diccionario de Datos|*.dd";//(.idx)|*.idx|(.dat)|*.dat";
                           SFD.AddExtension = true;
                            String nuevoArchivoNombre;

                        if (SFD.ShowDialog().Equals(DialogResult.OK))
                        {                           
                                nuevoArchivoNombre = Path.GetFileName(SFD.FileName);

                                if (!Util.ValidacionDeNombre(nuevoArchivoNombre))
                                {
                                    MessageBox.Show("Hay caracteres invalidos en el nombre de archivo que intenta crear.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    
                                    break;
                                }
                                else if (nuevoArchivoNombre == ".dd")
                                {
                                    MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                   
                                    break;
                                }
                                else
                                {
                                    if (nuevoArchivoNombre.Contains(".dd"))
                                    {
                                        if (nuevoArchivoNombre.Substring(nuevoArchivoNombre.Length - 3, 3) != ".dd")//si el nombre ya contiene el .dd
                                        {
                                            nuevoArchivoNombre = nuevoArchivoNombre + ".dd";//Crea el nombre del archivo

                                            String auxPathFileName = Path.GetDirectoryName(SFD.FileName);
                                            pathNombreArchivo = auxPathFileName + "\\" + nuevoArchivoNombre;
                                        }
                                        else
                                        {
                                            pathNombreArchivo = SFD.FileName;
                                        }
                                    }
                                    else
                                    {
                                        nuevoArchivoNombre = nuevoArchivoNombre + ".dd";//Crea el nombre del archivo

                                        String auxPathFileName = Path.GetDirectoryName(SFD.FileName);
                                        pathNombreArchivo = auxPathFileName + "\\" + nuevoArchivoNombre;
                                    }
                                    nuevo_SB.Enabled = false;//Deshabilita la opcion de crear un nuevo archivo.
                                    abrir_SB.Enabled = false;//Deshabilita la opcion de abrir un nuevo archivo.
                                    renombrar_SB.Enabled = true;//habiolita la opcion de renombrar un archivo.
                                    cerrar_SB.Enabled = true;//Habilita la opcion de cerrar el archivo.
                                    

                                    this.archivoDeTrabajo = new Archivo(pathNombreArchivo, true);//Construye el objeto archivo
                                    this.Text = Path.GetFileName(this.archivoDeTrabajo.PathName) + " - Manejador de Archivos Pro";
                                     this.Reload();
                                }                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiene que cerrar el archivo actual para crear uno nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    #endregion
                    break;
                case "Abrir":
                    #region Abrir                   
                    openFileDialog1.Title = "Abrir Archivo";
                    openFileDialog1.DefaultExt = ".dd";
                    openFileDialog1.Filter = "(*.dd)|*.dd";
                    openFileDialog1.AddExtension = true;
                    openFileDialog1.RestoreDirectory = true;
                    openFileDialog1.InitialDirectory = pathDirectorio;//Redirecciona la carpeta del directorio inicial al directorio donde se encuentra el ejecutable
                    if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
                    {
                        if (File.Exists(openFileDialog1.FileName))//si el archivo que se quiere abrir existe
                        {
                            if(archivoDeTrabajo == null)
                            {
                                archivoDeTrabajo = new Archivo();
                            }
                            nuevo_SB.Enabled = false;//Deshabilita la opcion de crear un nuevo archivo
                            abrir_SB.Enabled = false;//Des habilita la opcion de abrir un nuevo archivo
                            renombrar_SB.Enabled = true;//habilita la opcion de renombrar archivo
                            cerrar_SB.Enabled = true;//Habilita la opcion de cerrar el archivo
                           
                            this.archivoDeTrabajo.Abrir(openFileDialog1.FileName);//Abre el archivo
                            this.Text = Path.GetFileName(this.archivoDeTrabajo.PathName) + " - Manejador de Archivos Pro";
                            this.Reload();//Recarga todo en la forma. //Manda actualizar los combo box y los data grid
                        }
                        else
                        {
                            MessageBox.Show("El archivo que intenta abrir no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                    break;
                case "Renombrar":
                    #region Renombrar

                    CambiarNombreArchivo_Form nuevoNombre;                    
                    nuevoNombre = new CambiarNombreArchivo_Form();
                    String nuevoNombreFinal;

                    if (nuevoNombre.ShowDialog().Equals(DialogResult.OK))
                    {
                        if(!Util.ValidacionDeNombre(nuevoNombre.Nombre))
                        {
                            MessageBox.Show("Hay caracteres invalidos en el nombre al que intenda cambiar.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else if(nuevoNombre.Nombre == ".dd" || nuevoNombre.Nombre == "")
                        {
                            MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            if (nuevoNombre.Nombre.Contains(".dd"))
                            {
                                if (nuevoNombre.Nombre.Substring(nuevoNombre.Nombre.Length - 3, 3) == ".dd")
                                {
                                    nuevoNombreFinal = Path.GetDirectoryName(this.archivoDeTrabajo.PathName) + "\\" + nuevoNombre.Nombre;
                                }
                                else
                                {
                                    nuevoNombreFinal = Path.GetDirectoryName(this.archivoDeTrabajo.PathName) + "\\" + nuevoNombre.Nombre + ".dd";//Crea el nombre del archivo
                                }
                            }
                            else
                            {
                                nuevoNombreFinal = Path.GetDirectoryName(this.archivoDeTrabajo.PathName) + "\\" + nuevoNombre.Nombre + ".dd";//Crea el nombre del archivo
                            }
                            if (!File.Exists(nuevoNombreFinal))
                            {
                                File.Move(this.archivoDeTrabajo.PathName, nuevoNombreFinal);
                                File.Delete(this.archivoDeTrabajo.PathName);
                                this.archivoDeTrabajo.PathName = nuevoNombreFinal;
                                this.Text = Path.GetFileName(this.archivoDeTrabajo.PathName) + " - Manejador de Archivos Pro"; ;
                            }
                            else
                            {
                                MessageBox.Show("El archivo " + nuevoNombre.Nombre + " ya existe, Elija otro nombre", "Error : Archivo Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    #endregion
                    break;
                case "Cerrar":
                    #region Cerrar
                    if (this.archivoDeTrabajo != null)
                    {
                        pathDirectorio = Environment.CurrentDirectory + @"\Archivos";
                        this.archivoDeTrabajo.Close();
                        this.archivoDeTrabajo = null;
                        nuevo_SB.Enabled = true;//Habilita la opcion de crear un nuevo archivo
                        abrir_SB.Enabled = true;//Habilita la opcion de abrir un nuevo archivo
                        renombrar_SB.Enabled = false;
                        cerrar_SB.Enabled = false;//Deshabilita la opcion de cerrar el archivo
                        this.Text = "Manejador de Archivos Pro";
                    }
                    this.Cierra();
                    this.Reload();
                    #endregion
                    break;
                default:
                    MessageBox.Show("Opción incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
        #region menuEntidades

        private void menuEntidades_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.archivoDeTrabajo != null)
            {
                switch (e.ClickedItem.AccessibleName)
                {
                    case "Alta":
                        #region Alta 
                        if (this.NombreEntidad_Combo.Text == " " || this.NombreEntidad_Combo.Text == "")
                        {
                            MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else if (!Util.ValidacionDeNombre(this.NombreEntidad_Combo.Text))
                        {
                            MessageBox.Show("Hay caracteres invalidos en el nombre de la Entidad que intenta crear.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            this.archivoDeTrabajo.altaEntidad(NombreEntidad_Combo.Text);
                            this.Reload();
                        }
                        #endregion
                        this.NombreEntidad_Combo.Text = "";
                            break;
                    case "Modificar":
                        #region Modificar
                        if (this.archivoDeTrabajo.existeEntidad(NombreEntidad_Combo.Text))
                        {
                            ModificarEntidad_Form modificador = new ModificarEntidad_Form(NombreEntidad_Combo.Text,ref this.archivoDeTrabajo);
                            if (modificador.ShowDialog().Equals(DialogResult.OK))
                            {
                                archivoDeTrabajo.CambiaNombreEntidad(modificador.Nombre, modificador.NuevoNombre);
                                this.Reload();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La entidad que desea modificar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        #endregion
                        break;
                    case "Consulta":
                        #region Consulta
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        if (this.archivoDeTrabajo.existeEntidad(NombreEntidad_Combo.Text))
                        {
                            this.archivoDeTrabajo.eliminaEntidad(NombreEntidad_Combo.Text);
                            this.Reload();
                        }
                        else
                        {
                            MessageBox.Show("La entidad que desea eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        #endregion
                        break;
                    default:
                        MessageBox.Show("Opcion no implementada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor abra un archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    #region menuAtributos
        private void menuAtributos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.archivoDeTrabajo != null)
            {
                switch (e.ClickedItem.AccessibleName)
                {
                    case "Alta":
                        #region Alta 
                        if (this.comboNombreAtributo.Text == " " || this.comboNombreAtributo.Text == "")
                        {
                            MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;                            
                        }
                        else if (!Util.ValidacionDeNombre(this.comboNombreAtributo.Text))
                        {
                            MessageBox.Show("Hay caracteres invalidos en el nombre del atributo que intenta crear.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            if (ComboB_TipoAtributo.Text == "E")
                            {
                                ComboB_LongitudAtributo.Text = 4.ToString();
                            }
                                int longitudNuevoAtributo = 1;
                            if (Int32.TryParse(ComboB_LongitudAtributo.Text, out longitudNuevoAtributo))
                            {

                                if (!listaLongitud.Contains(longitudNuevoAtributo))
                                {
                                    listaLongitud.Add(longitudNuevoAtributo);
                                }
                                this.archivoDeTrabajo.altaAtributo(Combo_entidadesParaAtributos.Text, comboNombreAtributo.Text, ComboB_TipoAtributo.Text, longitudNuevoAtributo, ComboB_TipoIndiceAtributo.Text);
                                this.Reload();
                            }
                            else
                            {
                                MessageBox.Show("La longitud tiene un formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        #endregion
                        this.NombreEntidad_Combo.Text = "";
                        break;
                    case "Modificar":
                        #region Modificar
                        if (this.archivoDeTrabajo.existeEntidad(Combo_entidadesParaAtributos.Text))
                        {
                            ModificarAtributo_Form modificador = new ModificarAtributo_Form(comboNombreAtributo.Text,this.archivoDeTrabajo.getEntidad(Combo_entidadesParaAtributos.Text));
                            if (modificador.ShowDialog().Equals(DialogResult.OK))
                            {
                                if (modificador.NuevoNombre == "" || modificador.NuevoNombre == " ")
                                {
                                    archivoDeTrabajo.CambiaAtributo(Combo_entidadesParaAtributos.Text, modificador.Nombre, modificador.NuevoNombre, modificador.Tipo, modificador.Longitud, modificador.TipoIndice,false);
                                    
                                }
                                else
                                {
                                    archivoDeTrabajo.CambiaAtributo(Combo_entidadesParaAtributos.Text, modificador.Nombre, modificador.NuevoNombre, modificador.Tipo, modificador.Longitud, modificador.TipoIndice,true );
                                }
                                this.Reload();

                            }
                        }
                        else
                        {
                            MessageBox.Show("La entidad que desea modificar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        #endregion
                        break;
                    case "Consulta":
                        #region Consulta
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        if (this.archivoDeTrabajo.existeEntidad(Combo_entidadesParaAtributos.Text))
                        {
                            if(this.archivoDeTrabajo.getEntidad(Combo_entidadesParaAtributos.Text).existeAtributo(comboNombreAtributo.Text))
                            {
                                this.archivoDeTrabajo.eliminaAtributo(Combo_entidadesParaAtributos.Text, comboNombreAtributo.Text);
                                this.Reload();
                            }
                            else
                            {
                                MessageBox.Show("El atributo " + comboNombreAtributo.Text + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("La entidad "+ Combo_entidadesParaAtributos.Text + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        #endregion
                        break;
                    default:
                        MessageBox.Show("Opcion no implementada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor abra un archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

#endregion

        #region MetodosForm
        private void Cierra()
        {
            NombreEntidad_Combo.Items.Clear();
            comboNombreAtributo.Items.Clear();
            Combo_entidadesParaAtributos.Items.Clear();
        }
        public void Reload()
        {
            this.dataGridEntidades.Rows.Clear();            
            this.dataGridAtributos.Rows.Clear();
            this.NombreEntidad_Combo.Items.Clear();
            this.ComboB_LongitudAtributo.Items.Clear();

            int auxComboAtributos = Combo_entidadesParaAtributos.SelectedIndex;
            this.Combo_entidadesParaAtributos.Items.Clear();


            foreach (int i in listaLongitud)
            {
                ComboB_LongitudAtributo.Items.Add(i);
            }                

            if (this.archivoDeTrabajo != null) 
            {
                foreach (Entidad en in archivoDeTrabajo.Entidades)
                {
                    this.Combo_entidadesParaAtributos.Items.Add(en.Nombre);
                    this.NombreEntidad_Combo.Items.Add(en.Nombre);
                    
                    Object[] Row = { en.IDString, en.Nombre, en.Direccion, en.DireccionAtributos, en.DireccionRegistros, en.DireccionSiguiente };
                    dataGridEntidades.Rows.Add(Row);
                }
                this.Text = Path.GetFileName(this.archivoDeTrabajo.PathName) + "- Manejador de Archivos Pro";
                //NombreArchivoLabel.Text = "Cabecera: "+ this.archivoDeTrabajo.Cabecera.ToString();
                
                tam_label.Text = "Tamaño: " + this.archivoDeTrabajo.Length.ToString();
                Cabecera.Text = "Cabecera: " + this.archivoDeTrabajo.Cabecera.ToString();
                CabeceraEntidadesDesperdiciadas.Text = "CabEntidadesDes: " + this.archivoDeTrabajo.CabeceraEntidadesDesperdiciadas.ToString(); ;
                cabeceraAtributosDesperdiciados.Text = "CabAtributosDes: " + this.archivoDeTrabajo.CabeceraAtributosDesperdiciados.ToString();

                tam_label.Visible = true;
                Cabecera.Visible = true;
                CabeceraEntidadesDesperdiciadas.Visible = true;
                cabeceraAtributosDesperdiciados.Visible = true;

            }
            else
            {
                this.Text = "- Manejador de Archivos Pro";
                //NombreArchivoLabel.Visible = false;
                tam_label.Visible = false;
                Cabecera.Visible = false;
                CabeceraEntidadesDesperdiciadas.Visible = false;
                cabeceraAtributosDesperdiciados.Visible = false;


            }

            Combo_entidadesParaAtributos.SelectedIndex = auxComboAtributos;

        }


        #endregion



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboNombreAtributo.Items.Clear();
            if (this.archivoDeTrabajo != null)
            {this.Reload();
                if(this.archivoDeTrabajo.ContainsName(Combo_entidadesParaAtributos.Text))
                {
                    foreach(Atributo at in this.archivoDeTrabajo.getEntidad(Combo_entidadesParaAtributos.Text).atributos)
                    {
                        comboNombreAtributo.Items.Add(at.Nombre);
                    }
                }
            }
        }


        private void Combo_entidadesParaAtributos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridAtributos.Rows.Clear();
            comboNombreAtributo.Items.Clear();
            this.CargaGridAtributos(Combo_entidadesParaAtributos.Text);
        }

        private void CargaGridAtributos(String nameEntidad)
        {
            Entidad aux = this.archivoDeTrabajo.getEntidad(nameEntidad);
            if ( aux != null)
            {
                foreach(Atributo at in aux.atributos)
                {
                    comboNombreAtributo.Items.Add(at.Nombre);
                    Object[] RowAt = { at.IDToString(), at.Nombre, at.Tipo, at.Longitud, at.Direccion, at.TipoIndice, at.DirIn, at.DirSiguiente };
                    dataGridAtributos.Rows.Add(RowAt);
                }
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboB_TipoAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboB_TipoAtributo.Text == "E")
            {
                ComboB_LongitudAtributo.Text = 4.ToString();
            }
        }

        private void ComboB_LongitudAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
