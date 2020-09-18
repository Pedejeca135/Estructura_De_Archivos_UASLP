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
    public partial class ManejadorDeArchivos : Form
    {

        #region Constructores
        public ManejadorDeArchivos()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables_De_Instancia
        private Archivo archivo;
        private string directorio;
        #endregion

        #region EventosForm

        private void ManejadorDeArchivos_Load(object sender, EventArgs e)
        {
           
        }

        private void toolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.AccessibleName)
            {
                case "Nuevo":                   
                    break;
                case "Abrir":                    
                    break;
                case "Renombrar":                   
                    break;
                case "Cerrar":                   
                    break;
                default:
                    MessageBox.Show("Opción incorrecta o no implementada", "Atención");
                    break;
            }
        }

        private void entidades_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.archivo != null)
            {
                switch (e.ClickedItem.AccessibleName)
                {
                    case "Alta":                       
                        break;
                    case "Modificar":                       
                        break;
                    case "Consulta":                      
                        break;
                    case "Eliminar":                       
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

        private void atributos_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.archivo != null)
            {
                if (this.archivo.Entidades.Count > 0)
                {
                    #region Existen Entidades
                    switch (e.ClickedItem.AccessibleName)
                    {
                        case "Alta":                           
                            break;
                        case "Modificar":                           
                            break;
                        case "Consulta":
                            break;
                        case "Eliminar":                           
                            break;
                        default:
                            MessageBox.Show("Opción incorrecta o no implementada", "Atención");
                            break;
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Por favor Agregue Entidades primero", "Imposible");
                }
            }
            else
            {
                MessageBox.Show("Por favor cree una base de d   atos primero", "Error");
            }
        }

        #endregion

        #region MetodosForm
        #endregion

        
    }
}
