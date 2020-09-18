using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejadorDeArchivosPro
{
    class Archivo
    {
        #region Variables_De_Instancia
        private long cabecera;
        private string nombre;
        private List<Entidad> entidades;
        #endregion

        #region Constructores
        public Archivo(string nombre)
        {
            this.cabecera = -1;
            this.nombre = nombre;
            this.entidades = new List<Entidad>();
        }
        #endregion

        #region Geters&Seters
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public long Cabecera
        {
            get { return this.cabecera; }
        }
        public List<Entidad> Entidades
        {
            get { return this.entidades; }
        }
        #endregion

        #region Metodos
       
        #endregion
    }
}
