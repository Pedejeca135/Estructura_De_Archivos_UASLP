using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejadorDeArchivosPro
{
    public abstract class Indice
    {

        #region Variables Instancia
        private string nombre;
        private long dirAct;
        private long dirSig;
        #endregion

        #region Constructor
        public Indice(string nombre, long dirAct, long dirSig)
        {
            this.nombre = nombre;
            this.dirAct = dirAct;
            this.dirSig = dirSig;
        }
        #endregion

        #region Gets & Sets
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public long DirAct
        {
            get { return this.dirAct; }
            set { this.dirAct = value; }
        }
        public long DirSig
        {
            get { return this.dirSig; }
            set { this.dirSig = value; }
        }

        #endregion

        #region Metodos
        public abstract int indiceLlave(string llave);

        public abstract bool existeLlave(string llave);

        #endregion
    }
}
