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
        }
        #endregion

        #region Variables_De_Instancia
        private Archivo archivoDeTrabajo;

        private String pathDirectorio;
        private String pathNombreArchivo;
        #endregion


        #region EventosForm

        private void ManejadorDeArchivos_Load(object sender, EventArgs e)
        {
            pathDirectorio = Environment.CurrentDirectory + @"\Archivos";
            if (!Directory.Exists(pathDirectorio))//Verifica si la carpeta existe
            {
                Directory.CreateDirectory(pathDirectorio);
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
                        NuevoArchivo_Form nuevoArchivoF;
                        String nombreArchivo;
                        FileStream file;
                        nuevoArchivoF = new NuevoArchivo_Form();

                        folderBrowserDialog1.SelectedPath = pathDirectorio;

                        if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
                        {
                            //this.upDirectorio = this.directorio = SelectFolder.SelectedPath;
                            if (nuevoArchivoF.ShowDialog().Equals(DialogResult.OK))
                            {
                                if (nuevoArchivoF.Nombre.Contains('/') || nuevoArchivoF.Nombre.Contains(':')
                                    || nuevoArchivoF.Nombre.Contains('*') || nuevoArchivoF.Nombre.Contains('?')
                                    || nuevoArchivoF.Nombre.Contains('"') || nuevoArchivoF.Nombre.Contains('<')
                                    || nuevoArchivoF.Nombre.Contains('>') || nuevoArchivoF.Nombre.Contains('|') || nuevoArchivoF.Nombre.Contains(@"\"))
                                {
                                    MessageBox.Show("Hay caracteres invalidos en el nombre de archivo que intenta crear.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                                else if (nuevoArchivoF.Nombre == ".dd")
                                {
                                    MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    //break;
                                }
                                else
                                {
                                    pathNombreArchivo += @"\" + nuevoArchivoF.Nombre;//Crea la dirección del archivo
                                    if (!File.Exists(pathNombreArchivo))//Verifica si el archivo ya existe
                                    {
                                        try
                                        {
                                            Directory.CreateDirectory(pathNombreArchivo);//Si no existe La crea.
                                            nuevo_SB.Enabled = false;//Deshabilita la opcion de crear un nuevo archivo.
                                            abrir_SB.Enabled = false;//Deshabilita la opcion de abrir un nuevo archivo.
                                            renombrar_SB.Enabled = true;//habiolita la opcion de renombrar un archivo.
                                            cerrar_SB.Enabled = true;//Habilita la opcion de cerrar el archivo.                                   


                                            if (nuevoArchivoF.Nombre.Contains(".dd"))
                                            {
                                                if (nuevoArchivoF.Nombre.Substring(nuevoArchivoF.Nombre.Length - 3, 3) == ".dd")//si el nombre ya contiene el .dd
                                                {
                                                    nombreArchivo = pathDirectorio + "\\" + nuevoArchivoF.Nombre;
                                                }
                                                else
                                                {
                                                    nombreArchivo = pathDirectorio + "\\" + nuevoArchivoF.Nombre + ".dd";//Crea el nombre del archivo
                                                }
                                            }
                                            else
                                            {
                                                nombreArchivo = pathDirectorio + "\\" + nuevoArchivoF.Nombre + ".dd";//Crea el nombre del archivo
                                            }

                                            this.archivoDeTrabajo = new Archivo(nombreArchivo,true);//Construye el objeto archivo
                                            this.Text = Path.GetFileNameWithoutExtension(this.archivoDeTrabajo.Nombre) +".dd"+ " - Manejador de Archivos Pro";
                                            this.Update();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Algo salio mal al crear el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El archivo que intenta crear ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
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
                    openFileDialog1.Filter = "(*.dd) | *.dd";
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
                            this.Text = Path.GetFileName(openFileDialog1.FileName) + " - Manejador de Archivos Pro";
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
                        if (nuevoNombre.Nombre.Contains('/') || nuevoNombre.Nombre.Contains(':')
                            || nuevoNombre.Nombre.Contains('*') || nuevoNombre.Nombre.Contains('?')
                            || nuevoNombre.Nombre.Contains('"') || nuevoNombre.Nombre.Contains('<')
                            || nuevoNombre.Nombre.Contains('>') || nuevoNombre.Nombre.Contains('|') || nuevoNombre.Nombre.Contains(@"\"))
                        {
                            MessageBox.Show("Hay caracteres invalidos en el nombre al que intenda cambiar.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else if(nuevoNombre.Nombre == ".dd" || nuevoNombre.Nombre == "")
                        {
                            MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //break;
                        }
                        else
                        {
                            if (nuevoNombre.Nombre.Contains(".dd"))
                            {
                                if (nuevoNombre.Nombre.Substring(nuevoNombre.Nombre.Length - 3, 3) == ".dd")
                                {
                                    nuevoNombreFinal = pathDirectorio + "\\" + nuevoNombre.Nombre;
                                }
                                else
                                {
                                    nuevoNombreFinal = pathDirectorio + "\\" + nuevoNombre.Nombre + ".dd";//Crea el nombre del archivo
                                }
                            }
                            else
                            {
                                nuevoNombreFinal = pathDirectorio + "\\" + nuevoNombre.Nombre + ".dd";//Crea el nombre del archivo
                            }
                            if (!File.Exists(nuevoNombreFinal))
                            {
                                File.Move(this.archivoDeTrabajo.Nombre, nuevoNombreFinal);
                                File.Delete(this.archivoDeTrabajo.Nombre);
                                this.archivoDeTrabajo.Nombre = nuevoNombreFinal;
                                this.Text = Path.GetFileNameWithoutExtension(this.archivoDeTrabajo.Nombre) + ".dd" + " - Manejador de Archivos Pro";
                            }
                            else
                            {
                                MessageBox.Show("El archivo" + nuevoNombre.Nombre + " ya existe, Elija otro nombre", "Error : Archivo Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        this.archivoDeTrabajo = null;
                        nuevo_SB.Enabled = true;//Habilita la opcion de crear un nuevo archivo
                        abrir_SB.Enabled = true;//Habilita la opcion de abrir un nuevo archivo
                        renombrar_SB.Enabled = false;
                        cerrar_SB.Enabled = false;//Deshabilita la opcion de cerrar el archivo
                        this.Text = "Manejador de Archivos Pro";
                        this.Cierra();
                    }
                    #endregion
                    break;
                default:
                    MessageBox.Show("Opción incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }


        private void NuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void menuEntidades_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.archivoDeTrabajo != null)
            {
                switch (e.ClickedItem.AccessibleName)
                {
                    case "Alta":
                        #region Alta                       
                        if (this.nombre_TB.Text.Contains('/') || this.nombre_TB.Text.Contains(':')
                                   || this.nombre_TB.Text.Contains('*') || this.nombre_TB.Text.Contains('?')
                                   || this.nombre_TB.Text.Contains('"') || this.nombre_TB.Text.Contains('<')
                                   || this.nombre_TB.Text.Contains('>') || this.nombre_TB.Text.Contains('|') 
                                   || this.nombre_TB.Text.Contains(@"\") || this.nombre_TB.Text.Contains(" "))
                        {
                            MessageBox.Show("Hay caracteres invalidos en el nombre la Entidad que intenta crear.\nEvite:" + @" \/:*?\" + "<>| ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else if (this.nombre_TB.Text == " " || this.nombre_TB.Text =="")
                        {
                            MessageBox.Show("Escriba un nombre valido no vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //break;
                        }
                        else
                        {
                            this.archivoDeTrabajo.altaEntidad(nombre_TB.Text);  
                        }
                            #endregion
                            this.nombre_TB.Text = "";
                            break;
                    case "Modificar":
                        #region Modoficar
                        #endregion
                        break;
                    case "Consulta":
                        #region Consulta
                        #endregion
                        break;
                    case "Eliminar":
                        #region Eliminar
                        #endregion
                        break;
                    default:
                        MessageBox.Show("Opción incorrecta o no implementada", "Atención");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor abra una base de datos", "Error");
            }
        }


        #endregion

        #region MetodosForm
        public void Reload()
        {
            foreach (Entidad en in archivoDeTrabajo.Entidades)
            {
                this.comboBox2.Items.Add(en.Nombre);
                Object[] Row = { en.IDString , en.Nombre, en.Direccion, en.DireccionAtributos, en.DireccionRegistros, en.DireccionSiguiente };
                dataGridEntidades.Rows.Add(Row);
                //dataGridEntidades.Rows.
            }

        } 

        public void Cierra()
        {

        }
        public void Update()
        {

        }
        #endregion


        

        private void menuAtributos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuRegistros_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte a = Convert.ToByte(':');
            byte b = Convert.ToByte(255);
            String r=" ";

            String sa = a.ToString();
            String sb = b.ToString();

            char ca = Convert.ToChar(b);
           char cb= Convert.ToChar(a);

            





        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
