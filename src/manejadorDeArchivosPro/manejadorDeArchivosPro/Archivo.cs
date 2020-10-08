using System;
using System.Collections.Generic;
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
        int en_Cabecera = 8;
        int en_Nombre = 30;
        int en_Tipo = 1;
        int en_direcciones = 8;

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
        public Archivo(string path)
        {
            this.cabecera = cabeceraAtributosDesperdiciados = cabeceraEntidadesDesperdiciadas = -1;
            this.pathName = path;
            this.nombre = Path.GetFileNameWithoutExtension(path);
            this.entidades = new List<Entidad>();
            archivo = new FileStream(path, FileMode.Create);//Crea el archivo en disco
            archivo.Close();
            this.Init();
        }
        public void Init()
        {
            //archivo = File.Open(pathName, FileMode.Open, FileAccess.Write, FileShare.None);
            this.abreElArchivo();
            archivo.Seek(0, SeekOrigin.Begin);
            escritor = new BinaryWriter(archivo);
            escritor.Write(cabecera);
            escritor.Write(cabeceraEntidadesDesperdiciadas);
            escritor.Write(cabeceraAtributosDesperdiciados);
            this.cierraElArchivo();
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

                foreach (byte b in creaID())//para ID
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
                    //cabeceraEntidadesDesperdiciadas = getNextEntidadesDesperdiciadas;
                }
                foreach (byte b in BitConverter.GetBytes(directionDefault))//direccion a los atributos.
                {
                    entidadAlta.Add(b);
                }
                foreach (byte b in BitConverter.GetBytes(directionDefault))//direccion a los datos.
                {
                    entidadAlta.Add(b);
                }

                Entidad aux = new Entidad(nombre, direccionParaEntidad, directionDefault, directionDefault, directionDefault);
                long direccionSiguienteEntidad = getSiguienteDireccionDeEntidadConInsersion(ref aux);

                foreach (byte b in BitConverter.GetBytes(direccionSiguienteEntidad))
                {
                    entidadAlta.Add(b);
                }
                this.abreElArchivo();
                this.archivo.Seek(this.archivo.Length, SeekOrigin.Begin);
                escritor = new BinaryWriter(archivo);
                this.escritor.Write(entidadAlta.ToArray());
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
                    entidades.Insert(i,entidad);
                    break;
                }
            }
            if(i == -1 && entidades.Count()>0)//se inserta al inicio
            {
                entidad.DireccionSiguiente = entidades[0].Direccion;
                entidades.Insert(0, entidad);
            }
            return entidad.DireccionSiguiente;
        }

        public void renombraEntidad(String anterior, String nuevo)
        {

        }

        public void eliminaEntidad(String nombre)
        {

        }


        public void Abrir(String path)
        {

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
            List<byte> aux = new List<byte>();

            foreach(byte b in nombre)
            {
                if(b >= Convert.ToByte(255))
                {
                    break;
                }
                aux.Add(b);
            }
            return aux.ToArray().ToString();
        }





        #endregion
    }
}
