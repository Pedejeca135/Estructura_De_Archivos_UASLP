using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace manejadorDeArchivosPro
{

    public class Atributo
    {
        byte[] id;
        private string nombre;//Nombre de la entidad
        char tipo;
        private int longitud;
        private long direccion;
        private int tipoIndice;
        //private long direccion;//Direccion en el archivo del atributo
        private long dirIn;
        private long dirSiguiente;

        public Atributo(byte[] ID, String nombre, char tipo, int longitud, long direccion, int tipoIndice, long dirIn, long dirSiguiente)
        {
            this.id = ID;
            this.nombre = nombre;
            this.tipo = tipo;
            this.longitud = longitud;
            this.direccion = direccion;
            this.tipoIndice = tipoIndice;
            this.dirIn = dirIn;
            this.dirSiguiente = dirSiguiente;
        }


        #region getters and setters:
        public byte[] ID
        {
            get { return this.id; }
            set{ this.id = value; }
        }
        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public char Tipo
        {
            get { return this.tipo;}
            set { this.tipo = value; }
        }
        public int Longitud
        {
            get { return this.longitud; }
            set { this.longitud = value; }
        }        
        public long Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value;}
        }
        public int TipoIndice
        {
            get { return this.tipoIndice;}
            set { this.tipoIndice = value; }
        }        
        public long DirIn
        {
            get { return this.dirIn; }
            set { this.dirIn = value; }
        }        
        public long DirSiguiente
        {
            get { return this.dirSiguiente; }
            set { this.dirSiguiente = value; }
        }

        #endregion

        public String IDToString()
        {
            String res = "";
            res = new System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary(this.ID).ToString();
            res = res.Insert(2, ":");
            res = res.Insert(5, ":");
            res = res.Insert(8, ":");
            res = res.Insert(11, ":");
            return res;
        }


        #region Primario
        public void altaIndicePrimario(string llave, long dir, string directorio)
        {
            int longitud;
            long dirIdx;
            Indice indice;
            dirIdx = -1;
            longitud = MetodosAuxiliares.calculaTamIdxPrim(this.longitud);
            dirIdx = MetodosAuxiliares.ultimaDireccionDeArchivo(directorio);
            if (this.indices.Count == 0)
            {
                indice = new Primario(this.nombre, dirIdx, longitud, -1);
                ((Primario)indice).alta(llave, dir);
                this.indices.Add(indice);
            }
            else
            {
                bool band;
                band = false;
                foreach (Indice idx in this.indices)
                {
                    if (((Primario)idx).EspacioLibre != -1)
                    {
                        ((Primario)idx).alta(llave, dir);
                        band = true;
                        break;
                    }
                }
                if (!band)
                {
                    indice = new Primario(this.nombre, dirIdx, longitud, -1);
                    ((Primario)indice).alta(llave, dir);
                    this.indices.Last().DirSig = indice.DirAct;
                    this.indices.Add(indice);
                }
            }
            this.dirIndice = this.indices.First().DirAct;
            foreach (Indice idx in this.indices)
            {
                this.grabaIndicePrimario((Primario)idx, directorio);
            }

        }

        public void modificaIndicePrimario(string llave, string nuevaLlave, string directorio)
        {
            foreach (Indice indice in this.indices)
            {
                if (((Primario)indice).existeLlave(llave))
                {
                    ((Primario)indice).modifica(llave, nuevaLlave);
                    break;
                }
            }
            this.dirIndice = this.indices.First().DirAct;
            foreach (Indice idx in this.indices)
            {
                this.grabaIndicePrimario((Primario)idx, directorio);
            }
        }

        public void eliminaIndicePrimario(string llave, string directorio)
        {
            foreach (Indice indice in this.indices)
            {
                if (((Primario)indice).existeLlave(llave))
                {
                    if (((Primario)indice).elimina(llave))
                    {
                        this.indices.Remove(indice);
                        for (int i = 0; i < this.indices.Count - 1; i++)
                        {
                            this.indices[i].DirSig = this.indices[i + 1].DirAct;
                        }
                    }
                    break;
                }
            }
            if (this.indices.Count > 0)
            {
                this.dirIndice = this.indices.First().DirAct;
            }
            else
            {
                this.dirIndice = -1;
            }
            foreach (Indice idx in this.indices)
            {
                this.grabaIndicePrimario((Primario)idx, directorio);
            }
        }

        #endregion


    }
}
