﻿using System;
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

        

        public List<Atributo> atributos { get; set; }



        #endregion



        #region Constructores
        public Entidad(byte[] ID, String nombre, long direccion, long dirAtributos, long dirResistros, long dirSiguiente)
        {
            this.id = ID;
            this.nombre = nombre;
            this.direccion = direccion;
            this.dirAtributos = dirAtributos;
            this.dirRegistros = dirResistros;
            this.dirSiguiente = dirSiguiente;
            this.atributos = new List<Atributo>();
        }

        public Entidad(byte[] ID, String nombre, long direccion, long dirAtributos, long dirResistros, long dirSiguiente,List<Atributo> atributos)
        {
            this.id = ID;
            this.nombre = nombre;
            this.direccion = direccion;
            this.dirAtributos = dirAtributos;
            this.dirRegistros = dirResistros;
            this.dirSiguiente = dirSiguiente;
            this.atributos = new List<Atributo>();
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

        #endregion

    }
}
