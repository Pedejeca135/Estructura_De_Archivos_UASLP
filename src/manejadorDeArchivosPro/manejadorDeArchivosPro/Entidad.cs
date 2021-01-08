using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejadorDeArchivosPro
{
    public class Entidad
    {
        #region Variables de Instancia
        private byte[] id;
        private string nombre;//Nombre de la entidad
        private long direccion;//Direccion en el archivo de la entidad
        private long dirAtributos;//Direccion en el archivo de los atributos
        private long dirRegistros;
        private long dirSiguiente;
        private long dirPrimario;
        private long dirSecundario;
        private long dirRegistroDesperdiciados;

        public List<Atributo> atributos { get; set; }
        #endregion

        #region Constructores
        public Entidad(byte[] ID, String nombre, long direccion, long dirAtributos, long dirResistros,long dirRegDesp, long dirSiguiente)
        {
            this.id = ID;
            this.nombre = nombre;
            this.direccion = direccion;
            this.dirAtributos = dirAtributos;
            this.dirRegistros = dirResistros;
            this.dirSiguiente = dirSiguiente;
            this.atributos = new List<Atributo>();
            dirRegistroDesperdiciados = dirRegDesp;
        }

        public Entidad(byte[] ID, String nombre, long direccion, long dirAtributos, long dirResistros,long dirRegDesp, long dirSiguiente,List<Atributo> atributos)
        {
            this.id = ID;
            this.nombre = nombre;
            this.direccion = direccion;
            this.dirAtributos = dirAtributos;
            this.dirRegistros = dirResistros;
            this.dirSiguiente = dirSiguiente;
            this.atributos = new List<Atributo>();
            dirRegistroDesperdiciados = -1;
        }
        #endregion

        #region Gets & Sets
        public byte[] ID
        {
            get { return this.id; }
        }
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
        public long DireccionRegistrosDesperdiciados
        {
            get { return this.dirRegistroDesperdiciados; }
            set { this.dirRegistroDesperdiciados = value; }
        }
        public long DireccionSiguiente
        {
            get { return this.dirSiguiente; }
            set { this.dirSiguiente = value; }
        }
        public String IDString
        {
            get { return this.IDToString(); }
        }

        #endregion

        #region Metodos
        public void addAtributo(Atributo at)
        {
            this.atributos.Add(at);
        }

        public void eliminaAtributo(String nombre)
        {
            Atributo at = getAtributo(nombre);
            if(at != null)
            {
                this.atributos.Remove(at);
            }            
        }

        private String IDToString()
        {
            String res = "";
            res = new System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary(this.ID).ToString();
            res = res.Insert(2,":");
            res = res.Insert(5, ":");
            res = res.Insert(8, ":");
            res =res.Insert(11, ":");
            return res;
        }


        public Boolean Equals(Entidad entidad)
        {
            if (entidad.Nombre == this.Nombre && entidad.ID == this.ID && entidad.Direccion == this.Direccion)
            {
                return true;
            }
            return false;
        }

        public Boolean existeAtributo(String nombre)
        {
            foreach (Atributo at in this.atributos)
            {
                if(at.Nombre == nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public Atributo getAtributo(String nombre)
        {
            foreach(Atributo at in this.atributos)
            {
                if(at.Nombre == nombre)
                {
                    return at;
                }
            }
            return null;
        }
        public void Remove(Atributo at)
        {
            this.atributos.Remove(at);
        }

        public Atributo apuntaA(Atributo inAt)
        {
            Atributo res = null;

            foreach(Atributo at in this.atributos)
            {
                if(at.DirSiguiente == inAt.Direccion)
                {
                    return at;
                }
            }


            return res;
        }

        #region offsetDeRegistro

        public long getOffsetByAtributoIndex(int index)
        {
            int res = 8;
            if(index >= this.atributos.Count)
            {
                return 0;
            }
            for(int i = 0; i < index;i++)
            {
                res += this.atributos[i].Longitud;
            }
            return res;
        }

        public long getOffsetAtributoByName(string name)
        {
            foreach(Atributo atr in this.atributos)
            {
                if(atr.Nombre == name)
                {
                    return getOffsetByAtributoIndex(atributos.IndexOf(atr));
                }
            }
            return 0;
        }

        public long getOffsetDeAtributo(Atributo atri)
        {
            //this.off
            long res = 8;
            foreach (Atributo atribut in this.atributos)
            {
                if (atribut.Equals(atri))
                {
                    return res;
                }
                else
                {
                    res += atribut.Longitud;
                }
            }
            return -1;
        }
        public long offsetByKey(int key)
        {
            foreach (Atributo at in this.atributos)
            {
                if (at.TipoIndice == key)
                {
                    return getOffsetByAtributoIndex(this.atributos.IndexOf(at));
                }
            }
            return 0;
        }

        public long getOffsetMultilista(Atributo atributoMultilista)
        {
            int res = 8;
            foreach (Atributo at in this.atributos)
            {
                res += at.Longitud;
            }
            foreach (Atributo at in this.getAtributosMultilista())
            {
                if (at.Equals(atributoMultilista))
                {
                    return res;
                }
                else
                {
                    res += 8;
                }
            }
            return -1;
        }

        public long getEntidadTamRegistro()
        {
            int res = 0;
            foreach(Atributo at in this.atributos)
            {
                res += at.Longitud;
                if(at.TipoIndice == 5)
                {
                    res += 8;//sesuman por cada atributo multilista
                }
            }
            return res;
        }

        public long offSetSiguienteRegistro()
        {
            return 8 + getEntidadTamRegistro();
        }

        public long getRegistroTamTotal()
        {
            return offSetSiguienteRegistro()+8;
        }

        #endregion

        public Atributo[] getAtributoByTipoIndice(int tipoIndice)
        {
            List<Atributo> res = new List<Atributo>();
            foreach(Atributo at in this.atributos)
            {
                if(tipoIndice == at.TipoIndice)
                {
                    res.Add(at);
                }
            }
            return res.ToArray();
        }

       /*public List<Atributo> getAtributosSecundario()
        {
            List<Atributo> res = new List<Atributo>();

            foreach(Atributo at in this.atributos)
            {
                if(at.TipoIndice == 3)
                {
                    res.Add(at);
                }
            }
            return res;
        }*/

        public List<Atributo> getAtributosMultilista()
        {
            List<Atributo> res = new List<Atributo>();

            foreach (Atributo at in this.atributos)
            {
                if (at.TipoIndice == 5)
                {
                    res.Add(at);
                }
            }
            return res;
        }

       



        public bool canCreateLlave(String tipoIndi)
        {
            if (tipoIndi.Contains("1"))//clave de busqueda.
            {
                if(this.getAtributoByTipoIndice(1).Length != 0)
                {
                    return false;
                }
            }
            else if (tipoIndi.Contains("2"))//indice primario
            {
                if (this.getAtributoByTipoIndice(2).Length != 0)
                {
                    return false;
                }
            }
            else if (tipoIndi.Contains("4"))//indice Arbol
            {
                if (this.getAtributoByTipoIndice(4).Length != 0)
                {
                    return false;
                }
            }
            return true;
        }


        public Atributo getAtributoIndice(int tipoIndice)
        {
            foreach (Atributo at in this.atributos)
            {
                if (at.TipoIndice == tipoIndice)
                {
                    return at;
                }
            }
            return null;
        }

        public int getIndexByTipoIndice(int tipoIndice)
        {
            foreach (Atributo at in this.atributos)
            {
                if (at.TipoIndice == tipoIndice)
                {
                    return this.atributos.IndexOf(at);
                }
            }
            return -1;
        }

        public object objetoEnRegistro(Atributo atri, List<List<byte>> registro)
        {
            if(atri.Tipo == 'C' && atri.Tipo == 'c')
            {
               return UtilStatic.getStringByByteArray( registro.ElementAt(this.atributos.IndexOf(this.getAtributoByName(atri.Nombre)) + 1).ToArray());
            }
            else if(atri.Tipo == 'E' && atri.Tipo == 'e')
            {
                return BitConverter.ToInt32(registro.ElementAt(this.atributos.IndexOf(this.getAtributoByName(atri.Nombre)) + 1).ToArray(),0);
            }
            return null;
        }

        public object objetoEnPseudoRegistro(Atributo atri, List<List<byte>> registro)
        {
            if (atri.Tipo == 'C' && atri.Tipo == 'c')
            {
                return UtilStatic.getStringByByteArray(registro.ElementAt(this.atributos.IndexOf(this.getAtributoByName(atri.Nombre))).ToArray());
            }
            else if (atri.Tipo == 'E' && atri.Tipo == 'e')
            {
                return BitConverter.ToInt32(registro.ElementAt(this.atributos.IndexOf(this.getAtributoByName(atri.Nombre))).ToArray(), 0);
            }
            return null;
        }

        public Atributo getAtributoByName(String name)
        {
            foreach(Atributo at in this.atributos)
            {
                if(name.Equals(at.Nombre))
                {
                    return at;
                }
            }
            return null;
        }

        public int getIndexByAtributoName(string name)
        {
            return this.atributos.IndexOf(this.getAtributoByName(name));
        }
        public int getIndexByAtributo(Atributo at)
        {
            return this.atributos.IndexOf(at);
        }

        #endregion

    }
}
