using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejadorDeArchivosPro
{
    class Entidad
    {

        #region Variables de Instancia
        private string nombre;//Nombre de la entidad
        private long direccion;//Direccion en el archivo de la entidad
        private long dirAtributos;//Direccion en el archivo de los atributos
        private long dirRegistros;
        private long dirSiguiente;

        int en_id_Entidad = 5;
        int en_nombre = 30;
        int direcciones = 8;

        public List<Atributo> atributos;



        #endregion

        #region Constructores
        public Entidad(string nombre, long dirActual, long dirAtributos, long dirRegistros, long dirSiguiente)
        {
            this.nombre = nombre;
            this.direccion = dirActual;
            this.dirAtributos = dirAtributos;
            this.dirRegistros = dirRegistros;
            this.dirSiguiente = dirSiguiente;
        }
        #endregion

        #region Gets & Sets

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public long Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public long DireccionAtributos
        {
            get { return this.dirAtributos; }
            set { this.dirAtributos = value; }
        }
        public long DireccionRegistros
        {
            get { return this.dirRegistros; }
            set { this.dirRegistros = value; }
        }
        public long DireccionSiguiente
        {
            get { return this.dirSiguiente; }
            set { this.dirSiguiente = value; }
        }
        #endregion


        #region Metodos


        #endregion

    }
}
