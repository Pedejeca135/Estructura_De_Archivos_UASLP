﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manejadorDeArchivosPro
{
    public class Archivo
    {
        /****
         * Enumerables 
         * funcionan para tener en cuenta el tamaño de la entidad
         preferible cambiarlos a un lugar mas global */
        int en_Nombre = 30;
        int en_Tipo = 1;
        int en_direccion = 8;

        long directionDefault = -1;

        #region Variables_De_Instancia

        private long cabecera;
        private long cabeceraEntidadesDesperdiciadas;
        private long cabeceraAtributosDesperdiciados;

        private string nombre;
        private String pathName;
        private List<Entidad> entidades;
        private FileStream archivo;

        private BinaryReader lector;
        private BinaryWriter escritor;
        private long length = 0;

        #endregion

        #region Constructores
        public Archivo()
        {
            this.cabecera = cabeceraAtributosDesperdiciados = cabeceraEntidadesDesperdiciadas = -1;
            this.entidades = new List<Entidad>();
        }

        public Archivo(string path, Boolean nuevo)
        {
            if (nuevo)
            {
                this.cabecera = cabeceraAtributosDesperdiciados = cabeceraEntidadesDesperdiciadas = -1;
                this.pathName = path;
                this.nombre = Path.GetFileNameWithoutExtension(path);
                this.entidades = new List<Entidad>();
                this.Init();
            }
            else
            {
                if (this.pathName != path)
                {
                    this.PathName = path;
                    this.Abrir(this.pathName);
                }
            }
        }
        public void Init()
        {
            archivo = new FileStream(this.pathName, FileMode.Create);//Crea el archivo en disco
            archivo.Close();
            this.abreElArchivo();
            archivo.Seek(0, SeekOrigin.Begin);
            escritor = new BinaryWriter(archivo);
            escritor.Write(cabecera);
            escritor.Write(cabeceraEntidadesDesperdiciadas);
            escritor.Write(cabeceraAtributosDesperdiciados);
            this.cierraElArchivo();
        }

        
        /**
        * Metodo que se encarga de leer las entidades guardadas
        * en el diccionario de datos utilizando un BinaryReader
        * y una secuencia con un while para que se detenga cuando
        * el valor de la dirección siguiente sea igual a -1
        */
        public void Abrir(String path)
        {
            this.pathName = path;//cambia el nombre del archivo
            entidades.Clear();//borra todas las entidades de la lista

            long dirSiguienteEntidad = 0;//Crea un long que servira como iterador
            byte[] identificador = new byte[5];

            long dirActual;
            string nombre;
            long dirAtributo;
            long dirRegistros;
            Entidad entidad;

            while (dirSiguienteEntidad != -1)//Se cicla mientras
            {
                using (this.lector = new BinaryReader(new FileStream(this.PathName, FileMode.Open)))//Abre el archivo con el BinaryReader
                {
                    if ((int)dirSiguienteEntidad == 0)//Si es 0 o lo que es lo mismo entrar por primera vez
                    {
                        this.cabecera = dirSiguienteEntidad = lector.ReadInt64();//La cabecera y el iterador  son iguales al resultado de leer un long
                        this.cabeceraEntidadesDesperdiciadas = lector.ReadInt64();
                        this.cabeceraAtributosDesperdiciados = lector.ReadInt64();
                        continue;
                    }
                    lector.BaseStream.Seek(dirSiguienteEntidad, SeekOrigin.Begin);//Se posciona en la posición del iterador
                    identificador = lector.ReadBytes(5);
                    nombre = getNombreEnString(lector.ReadBytes(30));//Lee el string del nombre
                    dirActual = lector.ReadInt64();//Lee un long que de la dirección actual
                    dirAtributo = lector.ReadInt64();//Lee un long que de la dirección de los atributos
                    dirRegistros = lector.ReadInt64();//Lee un long que de la dirección de los registros
                    dirSiguienteEntidad = lector.ReadInt64();////Lee un long que de la dirección de la siguiente entidad


                    entidad = new Entidad(identificador,nombre, dirActual, dirAtributo, dirRegistros, dirSiguienteEntidad);//Crea una nueva entidad con los datos leidos

                    while (dirAtributo != -1)
                    {
                        lector.BaseStream.Seek(dirAtributo, SeekOrigin.Begin);
                        byte[] ID = lector.ReadBytes(5).ToArray();
                        String nombreAtributo = getNombreEnString(lector.ReadChars(30));//Lee el string del nombre
                        char tipo = lector.ReadChar();
                        int longitud = lector.ReadInt32();
                        long direccionDelAtributo = lector.ReadInt64();
                        int tipoIndice = lector.ReadInt32();
                        long dirIn = lector.ReadInt64();
                        long dirSiguienteAtributo = lector.ReadInt64();
                        Atributo at = new Atributo(ID,nombreAtributo,tipo,longitud,direccionDelAtributo,tipoIndice,dirIn,dirSiguienteAtributo);
                        dirAtributo = dirSiguienteAtributo;
                        entidad.addAtributo(at);
                    }                    
                    entidades.Add(entidad);//Añade la entidad a la lista de entidades
                }
            }
        }

        #endregion

        #region Geters&Seters
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string PathName
        {
            get { return this.pathName; }
            set { this.pathName = value; }
        }
        public long Cabecera
        {
            get { return this.cabecera; }
        }
        public long Length
        {
            get { return length; }
        }
        public List<Entidad> Entidades
        {
            get { return this.entidades; }
        }

        
        #endregion

        /*
        public long getLength()
        {
            archivo = File.Open(pathName, FileMode.Open, FileAccess.Write, FileShare.None);
            long res = archivo.Length;
            archivo.Close();
            return res;
        }*/

        #region Metodos



        public void altaEntidad(String nombre)
        {            
            if (!existeEntidad(nombre))
            {                
                List<byte> entidadAlta = new List<byte>();
                byte[] ID = creaID();

                foreach (byte b in ID)//para ID
                {
                    entidadAlta.Add(b);
                }
                foreach (byte b in getNombreEnByteArray(nombre))//para nombre
                {
                    entidadAlta.Add(b);
                }

                long direccionParaEntidad = directionDefault;
                if (cabeceraEntidadesDesperdiciadas == -1)//no se reusara espacio
                {
                    foreach (byte b in BitConverter.GetBytes(this.Length))//direccion de entidad
                    {
                        entidadAlta.Add(b);
                    }
                    direccionParaEntidad = this.Length;
                }
                else//se reciclara espacio
                {
                    foreach (byte b in BitConverter.GetBytes(cabeceraEntidadesDesperdiciadas))//direccion de entidad
                    {
                        entidadAlta.Add(b);
                    }
                    direccionParaEntidad = cabeceraEntidadesDesperdiciadas;
                    //cabeceraEntidadesDesperdiciadas = getNextEntidadesDesperdiciadas();
                }
                foreach (byte b in BitConverter.GetBytes(directionDefault))//direccion a los atributos.
                {
                    entidadAlta.Add(b);
                }
                foreach (byte b in BitConverter.GetBytes(directionDefault))//direccion a los datos.
                {
                    entidadAlta.Add(b);
                }

                Entidad aux = new Entidad(ID,nombre, direccionParaEntidad, directionDefault, directionDefault, directionDefault);
                
                long direccionSiguienteEntidad = getSiguienteDireccionDeEntidadConInsersion(ref aux);

                foreach (byte b in BitConverter.GetBytes(direccionSiguienteEntidad))
                {
                    entidadAlta.Add(b);
                }

                this.abreElArchivo();                
                long sPos = this.archivo.Seek(this.Length, SeekOrigin.Current);
                escritor = new BinaryWriter(archivo);
                this.escritor.Write(entidadAlta.ToArray());
                 sPos = this.archivo.Seek(0, SeekOrigin.Begin);
                this.escritor.Write(this.cabecera);
                this.cierraElArchivo();              
            }
            else
            {
                MessageBox.Show("La entidad que desea incluir al archivo"+ this.nombre +"ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean existeEntidad(String name)
        {
            foreach (Entidad en in entidades)
            {
                if (name.Equals(en.Nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public void cierraElArchivo()//cadavez que esto ocurra se actualizara el tamaño
        {
            this.length = archivo.Length;
            this.archivo.Close();
        }

        private void abreElArchivo()
        {
            this.archivo = File.Open(pathName, FileMode.Open, FileAccess.Write, FileShare.None);
        }
        
        private long getSiguienteDireccionDeEntidadConInsersion(ref Entidad entidad)
        {
            int i = 0;
            entidad.DireccionSiguiente = -1;
            for (i = entidades.Count()-1; i>= 0; i--)
            {
                if(entidad.Nombre.CompareTo(entidades[i].Nombre) >= 0)//se encontro alguno entones va a la derecha
                {
                    entidad.DireccionSiguiente = entidades[i].DireccionSiguiente;
                    entidades[i].DireccionSiguiente = entidad.Direccion;
                    entidades.Insert(i+1,entidad);
                    break;
                }
            }
            if(i == -1 && entidades.Count()>0)//se inserta al inicio
            {
                entidad.DireccionSiguiente = entidades[0].Direccion;
                entidades.Insert(0, entidad);
                cabecera = entidad.Direccion;
            }
            else if(entidades.Count() == 0)
            {
                entidades.Add(entidad);
                cabecera = entidad.Direccion;
            }
            return entidad.DireccionSiguiente;
        }

        public void renombraEntidad(String anterior, String nuevo)
        {

        }

        public void eliminaEntidad(String nombre)
        {

        }

        public long combierteALong(byte[]  by)
        {
            long res = 0;
            for (int i = 0; i < by.Length; i++)
            {
                res = (res << 8) + (by[i] & 0xff);
            }
            return res;
        }   
        
        List<byte[]> idList = new List<byte[]>();

       
        public byte[] creaID()
        {
            Boolean next = true;
            byte[] buffer = new byte[5];

            while (next)
            {
                next = false;

                Random random = new Random();
                random.NextBytes(buffer);

                foreach(byte[] id in idList)
                {
                    if(id.SequenceEqual(buffer))
                    {
                        next = true;
                        break;
                    }
                }
            }
                return buffer;
        }

        public byte[] creaID(List<byte[]> idList)
        {
            Boolean next = true;
            byte[] buffer = new byte[5];

            while (next)
            {
                next = false;

                Random random = new Random();
                random.NextBytes(buffer);

                foreach (byte[] id in idList)
                {
                    if (id.SequenceEqual(buffer))
                    {
                        next = true;
                        break;
                    }
                }
            }
            return buffer;
        }

        public byte[] getNombreEnByteArray(String nombre)
        {
            List<byte> result = new List<byte>();
            int i;
            for (i = 0; i < nombre.Length; i++)
            {
                result.Add(Convert.ToByte(nombre[i]));
            }
            for (; i < en_Nombre; i++)
            {
                result.Add(Convert.ToByte(255));
            }
            
            return result.ToArray();
        }

        public String getNombreEnString(byte[] nombre)
        {
            List<char> aux = new List<char>();

            foreach(byte b in nombre)
            {
                if(b >= Convert.ToByte(255))
                {
                    break;
                }
                aux.Add(Convert.ToChar(b));
                
            }

            String res = new string(aux.ToArray());
            return res;
        }

        public String getNombreEnString(char[] nombre)
        {
            return nombre.ToString();
        }





        #endregion
    }
}
