using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
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

        FileStream indicePrimario;
        FileStream indiceSecundario;
        FileStream indiceArbolBPlus;

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
            this.length = new System.IO.FileInfo(path).Length;

            long dirSiguienteEntidad = 0;//Crea un long que servira como iterador
            byte[] identificador = new byte[5];

            long dirActual;
            string nombre;
            long dirAtributo;
            long dirRegistros;
            long dirRegistrosDesp;
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
                    dirRegistrosDesp = lector.ReadInt64();
                    dirSiguienteEntidad = lector.ReadInt64();////Lee un long que de la dirección de la siguiente entidad


                    entidad = new Entidad(identificador,nombre, dirActual, dirAtributo, dirRegistros,dirRegistrosDesp,dirSiguienteEntidad);//Crea una nueva entidad con los datos leidos
                   

                    while (dirAtributo != -1)
                    {
                        lector.BaseStream.Seek(dirAtributo, SeekOrigin.Begin);
                        byte[] ID = lector.ReadBytes(5).ToArray();
                        String nombreAtributo = getNombreEnString(lector.ReadBytes(30));//Lee el string del nombre
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



        public void Cerrar(String path)
        {
            this.pathName = "";//cambia el nombre del archivo
            entidades.Clear();//borra todas las entidades de la lista
            this.length = 0;
            this.cabecera  = -1;
            this.cabeceraEntidadesDesperdiciadas = -1;
            this.cabeceraAtributosDesperdiciados = -1; 
                 
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
        public long CabeceraEntidadesDesperdiciadas
        {
            get { return this.cabeceraEntidadesDesperdiciadas; }
        }
        public long CabeceraAtributosDesperdiciados
        {
            get { return this.cabeceraAtributosDesperdiciados; }
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
                    using (this.lector = new BinaryReader(new FileStream(this.PathName, FileMode.Open)))//Abre el archivo con el BinaryReader
                    {
                        lector.BaseStream.Seek(cabeceraEntidadesDesperdiciadas + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);//Se posciona en la posición del iterador
                        cabeceraEntidadesDesperdiciadas = lector.ReadInt64();//Lee un long que de la dirección actual
                    }
                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    this.archivo.Seek(UtilStatic.Enum_Direccion, SeekOrigin.Begin);//escribe en la cabeceradeEntidadesDesperdiciadas
                    this.escritor.Write(cabeceraEntidadesDesperdiciadas);
                    this.cierraElArchivo();
                }
                foreach (byte b in BitConverter.GetBytes(directionDefault))//direccion a los atributos.
                {
                    entidadAlta.Add(b);
                }
                foreach (byte b in BitConverter.GetBytes(directionDefault))//direccion a los datos.
                {
                    entidadAlta.Add(b);
                }

                Entidad aux = new Entidad(ID,nombre, direccionParaEntidad, directionDefault, directionDefault,directionDefault, directionDefault);
                
                long direccionSiguienteEntidad = getSiguienteDireccionDeEntidadConInsersion(ref aux);

                foreach (byte b in BitConverter.GetBytes((long)-1))
                {
                    entidadAlta.Add(b);
                }

                foreach (byte b in BitConverter.GetBytes(direccionSiguienteEntidad))
                {
                    entidadAlta.Add(b);
                }

                this.abreElArchivo();                
                this.archivo.Seek(direccionParaEntidad, SeekOrigin.Current);
                escritor = new BinaryWriter(archivo);
                this.escritor.Write(entidadAlta.ToArray());
                this.archivo.Seek(0, SeekOrigin.Begin);
                this.escritor.Write(this.cabecera);
                this.cierraElArchivo();              
            }
            else
            {
                MessageBox.Show("La entidad que desea incluir al archivo"+ this.nombre +"ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void altaAtributo(String entidad, String nombre, String tipo , int longitud, String tipoIndice)
        {
            if (existeEntidad(entidad))
            {
                Entidad entidadAuxiliar = this.getEntidad(entidad);

                if (!entidadAuxiliar.existeAtributo(nombre))
                {

                    List<byte> atributoAlta = new List<byte>();

                    byte[] ID = creaID();
                    foreach (byte b in ID)//para ID
                    {
                        atributoAlta.Add(b);
                    }
                    foreach (byte b in getNombreEnByteArray(nombre))//para nombre
                    {
                        atributoAlta.Add(b);
                    }

                    atributoAlta.Add(Convert.ToByte(tipo[0]));

                    foreach (byte b in BitConverter.GetBytes(longitud))// para longitud
                    {
                        atributoAlta.Add(b);
                    }

                    long direccionParaAtributo = directionDefault;
                    if (cabeceraAtributosDesperdiciados == -1)//no se reusara espacio
                    {
                        foreach (byte b in BitConverter.GetBytes(this.Length))//direccion de entidad
                        {
                            atributoAlta.Add(b);
                        }
                        direccionParaAtributo = this.Length;
                    }
                    else//se reciclara espacio
                    {
                        foreach (byte b in BitConverter.GetBytes(cabeceraAtributosDesperdiciados))//direccion de entidad
                        {
                            atributoAlta.Add(b);
                        }
                        direccionParaAtributo = cabeceraAtributosDesperdiciados;
                        using (this.lector = new BinaryReader(new FileStream(this.PathName, FileMode.Open)))//Abre el archivo con el BinaryReader
                        {
                            lector.BaseStream.Seek(cabeceraAtributosDesperdiciados + UtilStatic.offset_Atributo_DirSigAtributo, SeekOrigin.Begin);//Se posciona en la posición del iterador
                            cabeceraAtributosDesperdiciados = lector.ReadInt64();//Lee un long que de la dirección actual
                        }
                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(UtilStatic.Enum_Direccion * 2, SeekOrigin.Begin);//escribe en la cabeceraAtributosDesperdiciados
                        this.escritor.Write(cabeceraAtributosDesperdiciados);
                        this.cierraElArchivo();
                    }
                    //para localizar el atributo entrante
                    if (entidadAuxiliar.atributos.Count() > 0)
                    {
                        Atributo ultimoAtributoEnLista = entidadAuxiliar.atributos.Last();
                        ultimoAtributoEnLista.DirSiguiente = direccionParaAtributo;

                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(ultimoAtributoEnLista.Direccion + UtilStatic.offset_Atributo_DirSigAtributo, SeekOrigin.Begin);//escribe en la cabeceraAtributosDesperdiciados
                        this.escritor.Write(direccionParaAtributo);
                        this.cierraElArchivo();
                    }
                    else
                    {
                        entidadAuxiliar.DireccionAtributos = direccionParaAtributo;

                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(entidadAuxiliar.Direccion + UtilStatic.offset_Entidad_direccionAtrib, SeekOrigin.Begin);
                        this.escritor.Write(direccionParaAtributo);
                        this.cierraElArchivo();

                    }

                    int tipoIndiceNuevo = 0;//sin indice
                    if (tipoIndice.Contains('1'))
                    {
                        tipoIndiceNuevo = 1;
                    }
                    else if (tipoIndice.Contains('2'))//secuencial indice primario
                    {
                        tipoIndiceNuevo = 2;
                    }
                    else if (tipoIndice.Contains('3'))//secuencial indice secundario
                    {
                        tipoIndiceNuevo = 3;
                    }
                    else if (tipoIndice.Contains('4'))//arbol b+
                    {
                        tipoIndiceNuevo = 4;
                    }

                    foreach (byte b in BitConverter.GetBytes(tipoIndiceNuevo))//direccion a los atributos.
                    {
                        atributoAlta.Add(b);
                    }

                    long direccionIn = directionDefault;
                    foreach (byte b in BitConverter.GetBytes(direccionIn))//direccion In
                    {
                        atributoAlta.Add(b);
                    }

                    long direccionSiguienteAtributo = directionDefault;

                    foreach (byte b in BitConverter.GetBytes(direccionSiguienteAtributo))
                    {
                        atributoAlta.Add(b);
                    }

                    Atributo aux = new Atributo(ID, nombre, tipo[0], longitud, direccionParaAtributo, tipoIndiceNuevo, direccionIn, direccionSiguienteAtributo);

                    entidadAuxiliar.atributos.Add(aux);

                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    this.archivo.Seek(direccionParaAtributo, SeekOrigin.Begin);
                    this.escritor.Write(atributoAlta.ToArray());
                    this.cierraElArchivo();
                }
                else
                {
                    MessageBox.Show("El atributo " + nombre + " ya existe intente con otro nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La entidad " + entidad + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void eliminaEntidad(String nombre)
        {
            int indexEnt = -1; 
            foreach (Entidad en in this.entidades)
            {
                if (en.Nombre == nombre)
                {
                    indexEnt = entidades.IndexOf(en);
                    if (indexEnt == 0)
                    {
                        cabecera = en.DireccionSiguiente;
                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(0, SeekOrigin.Begin);
                        this.escritor.Write(cabecera);
                        this.cierraElArchivo();
                    }
                    else
                    {
                        entidades.ElementAt(indexEnt - 1).DireccionSiguiente = en.DireccionSiguiente;
                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(entidades.ElementAt(indexEnt-1).Direccion+UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(entidades.ElementAt(indexEnt - 1).DireccionSiguiente);
                        this.cierraElArchivo();
                    }
                    long auxEntDesp = cabeceraEntidadesDesperdiciadas;
                    cabeceraEntidadesDesperdiciadas = en.Direccion;

                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                    this.escritor.Write(auxEntDesp);
                    this.archivo.Seek(UtilStatic.Enum_Direccion,SeekOrigin.Begin);
                    this.escritor.Write(cabeceraEntidadesDesperdiciadas);
                    this.cierraElArchivo();

                    if (en.atributos.Count() > 0)
                    {
                        en.atributos.ElementAt(en.atributos.Count() - 1).DirSiguiente = cabeceraAtributosDesperdiciados;
                        cabeceraAtributosDesperdiciados = en.atributos.ElementAt(en.atributos.Count() - 1).Direccion;
                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(UtilStatic.Enum_Direccion * 2, SeekOrigin.Begin);
                        this.escritor.Write(cabeceraAtributosDesperdiciados);
                        this.archivo.Seek(cabeceraAtributosDesperdiciados, SeekOrigin.Begin);
                        this.escritor.Write(en.atributos.ElementAt(en.atributos.Count() - 1).DirSiguiente);
                        this.cierraElArchivo();
                    }
                    break;
                }
                
            }
            if(indexEnt>-1)
            entidades.RemoveAt(indexEnt);
        }

        public void eliminaAtributo(String nombreEntidad, String nombre)
        {
            Entidad en = getEntidad(nombreEntidad);
            Atributo at = getEntidad(nombreEntidad).getAtributo(nombre);

            Atributo enAuxApuntaAtributos = en.apuntaA(at);
            if (enAuxApuntaAtributos == null)
            {
                en.DireccionAtributos = at.DirSiguiente;
                this.abreElArchivo();
                escritor = new BinaryWriter(archivo);
                this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_direccionAtrib, SeekOrigin.Begin);
                this.escritor.Write(en.DireccionAtributos);
                this.cierraElArchivo();
            }
            else
            {
                enAuxApuntaAtributos.DirSiguiente = at.DirSiguiente;
                this.abreElArchivo();
                escritor = new BinaryWriter(archivo);
                this.archivo.Seek(enAuxApuntaAtributos.Direccion + UtilStatic.offset_Atributo_DirSigAtributo, SeekOrigin.Begin);
                this.escritor.Write(enAuxApuntaAtributos.DirSiguiente);
                this.cierraElArchivo();
            }

                at.DirSiguiente = cabeceraAtributosDesperdiciados;                
                cabeceraAtributosDesperdiciados = at.Direccion;

                this.abreElArchivo();
                escritor = new BinaryWriter(archivo);
                this.archivo.Seek(UtilStatic.Enum_Direccion * 2, SeekOrigin.Begin);
                this.escritor.Write(cabeceraAtributosDesperdiciados);
                this.archivo.Seek(cabeceraAtributosDesperdiciados, SeekOrigin.Begin);
                this.escritor.Write(at.DirSiguiente);
                this.cierraElArchivo();
                en.Remove(at);
        }

        public void CambiaNombreAtributo( String nombreEntidad, String nombreAtributo, String nuevoNombre)
        {
            Atributo at = getEntidad(nombreEntidad).getAtributo(nombreAtributo);
            at.Nombre = nuevoNombre;


            List<byte> atributoNuevoNombre = new List<byte>();

            foreach (byte b in getNombreEnByteArray(nuevoNombre))//para nombre
            {
                atributoNuevoNombre.Add(b);
            }

            this.abreElArchivo();
            escritor = new BinaryWriter(archivo);
            this.archivo.Seek(at.Direccion + UtilStatic.offset_Atributo_Nombre, SeekOrigin.Begin);
            this.escritor.Write(atributoNuevoNombre.ToArray());
            this.cierraElArchivo();

        }

        public void CambiaAtributo(String entidadNombre, String atributoNombre, String atributoNuevoNombre, char tipo, int longitud, int tipoIndice, Boolean cambiarNombre)
        {
            Atributo at = getEntidad(entidadNombre).getAtributo(atributoNombre);
            if(cambiarNombre)
            at.Nombre = atributoNuevoNombre;
            at.Tipo = tipo;
            at.Longitud = longitud;
            at.TipoIndice = tipoIndice;


            List<byte> atributoNuevoNombreByteList = new List<byte>();

            foreach (byte b in getNombreEnByteArray(atributoNuevoNombre))//para nombre
            {
                atributoNuevoNombreByteList.Add(b);
            }

            this.abreElArchivo();
            escritor = new BinaryWriter(archivo);
            if (cambiarNombre)
            {
                this.archivo.Seek(at.Direccion + UtilStatic.offset_Atributo_Nombre, SeekOrigin.Begin);
                this.escritor.Write(atributoNuevoNombreByteList.ToArray());
            }

            this.archivo.Seek(at.Direccion + UtilStatic.offset_Atributo_TipoDato, SeekOrigin.Begin);
            this.escritor.Write(at.Tipo);

            this.archivo.Seek(at.Direccion + UtilStatic.offset_Atributo_Longitud, SeekOrigin.Begin);
            this.escritor.Write(at.Longitud);

            this.archivo.Seek(at.Direccion + UtilStatic.offset_Atributo_TipoIndice, SeekOrigin.Begin);
            this.escritor.Write(at.TipoIndice);
            this.cierraElArchivo();
        }

        public void CambiaNombreEntidad(String nombre, String nuevoNombre)
        {
            Entidad en = getEntidad(nombre);
            en.Nombre = nuevoNombre;
            List<byte> entidadNuevoNombre = new List<byte>();

            foreach (byte b in getNombreEnByteArray(nuevoNombre))//para nombre
            {
                entidadNuevoNombre.Add(b);
            }

            this.abreElArchivo();
            escritor = new BinaryWriter(archivo);
            this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_nombre, SeekOrigin.Begin);
            this.escritor.Write(entidadNuevoNombre.ToArray());
            this.cierraElArchivo();

            cambiaDireccionesParaNuevoNombre(en);

        }

        public void cambiaDireccionesParaNuevoNombre(Entidad en)
        {
            Entidad apuntando = getEntidadApuntando(en);

            if(apuntando == null)
            {
                cabecera = en.DireccionSiguiente;

                this.abreElArchivo();
                escritor = new BinaryWriter(archivo);
                this.archivo.Seek(0, SeekOrigin.Begin);
                this.escritor.Write(cabecera);
                this.cierraElArchivo();

            }
            else
            {
                apuntando.DireccionSiguiente = en.DireccionSiguiente;
                this.abreElArchivo();
                escritor = new BinaryWriter(archivo);
                this.archivo.Seek(apuntando.Direccion, SeekOrigin.Begin);
                this.escritor.Write(apuntando.DireccionSiguiente);
                this.cierraElArchivo();
            }
                        
            int i;
            entidades.Remove(en);

            for ( i = entidades.Count() - 1; i >= 0; i--)
            {
                if (en.Nombre.CompareTo(entidades[i].Nombre) > 0 )//se encontro alguno entones va a la derecha
                {
                    en.DireccionSiguiente = entidades[i].DireccionSiguiente;
                    entidades[i].DireccionSiguiente = en.Direccion;


                    entidades.Insert(i + 1, en);

                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    
                    this.archivo.Seek(entidades[i].Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                    this.escritor.Write(entidades[i].DireccionSiguiente);

                    this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                    this.escritor.Write(en.DireccionSiguiente);

                    this.cierraElArchivo();
                    break;
                }
                else if (en.Nombre.CompareTo(entidades[i].Nombre) == 0)// si es igual se pone a la izquierda
                {
                    Entidad entidadAlaIzquierda = getEntidadApuntando(entidades[i]);
                    if (entidadAlaIzquierda == null)
                    {
                        en.DireccionSiguiente = cabecera;
                        cabecera = en.Direccion;
                        entidades.Insert(0, en);

                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);

                        this.archivo.Seek(0, SeekOrigin.Begin);
                        this.escritor.Write(cabecera);


                        this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(en.DireccionSiguiente);
                        this.cierraElArchivo();

                    }
                    else
                    {
                        en.DireccionSiguiente = entidadAlaIzquierda.DireccionSiguiente;
                        entidadAlaIzquierda.DireccionSiguiente = en.Direccion;
                        entidades.Insert(i - 1, en);

                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(entidadAlaIzquierda.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(entidadAlaIzquierda.DireccionSiguiente);
                        this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(en.DireccionSiguiente);
                        this.cierraElArchivo();

                    }
                    break;
                }
            }
            if (i == -1 && entidades.Count() > 0)//se inserta al inicio
            {
                en.DireccionSiguiente = cabecera;
                cabecera = en.Direccion;
                entidades.Insert(0, en);

                this.abreElArchivo();
                escritor = new BinaryWriter(archivo);

                this.archivo.Seek(0, SeekOrigin.Begin);
                this.escritor.Write(cabecera);


                this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                this.escritor.Write(en.DireccionSiguiente);
                this.cierraElArchivo();


            }


        }

        private Entidad getEntidadApuntando(Entidad enApuntaPasiva)
        {
            foreach(Entidad en in this.entidades)
            {
                if(en.DireccionSiguiente == enApuntaPasiva.Direccion)
                {
                    return en;
                }
            }
            return null;            
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

        public void Close()
        {
            if (this.archivo != null)
            {
                this.archivo.Close();
            }
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
                if(entidad.Nombre.CompareTo(entidades[i].Nombre) > 0)//se encontro alguno entones va a la derecha
                {
                    entidad.DireccionSiguiente = entidades[i].DireccionSiguiente;
                    entidades[i].DireccionSiguiente = entidad.Direccion;
                    entidades.Insert(i+1,entidad);

                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    this.archivo.Seek(entidades[i].Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                    this.escritor.Write(entidades[i].DireccionSiguiente);
                    this.cierraElArchivo();
                    break;
                }
                else if(entidad.Nombre.CompareTo(entidades[i].Nombre) == 0)
                {
                    Entidad entidadAlaIzquierda = getEntidadApuntando(entidades[i]);
                    if(entidadAlaIzquierda  == null)
                    {
                        entidad.DireccionSiguiente = cabecera;
                        cabecera = entidad.Direccion;
                        entidades.Insert(0,entidad);

                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(0, SeekOrigin.Begin);
                        this.escritor.Write(cabecera);
                        this.archivo.Seek(entidad.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(entidad.DireccionSiguiente);
                        this.cierraElArchivo();

                    }
                    else
                    {
                        entidad.DireccionSiguiente = entidades[i].Direccion;
                        entidadAlaIzquierda.DireccionSiguiente = entidad.Direccion;
                        entidades.Insert(i-1, entidad);

                        this.abreElArchivo();
                        escritor = new BinaryWriter(archivo);
                        this.archivo.Seek(entidadAlaIzquierda.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(entidadAlaIzquierda.DireccionSiguiente);
                        this.archivo.Seek(entidad.Direccion + UtilStatic.offset_Entidad_sigDir, SeekOrigin.Begin);
                        this.escritor.Write(entidad.DireccionSiguiente);
                        this.cierraElArchivo();

                    }                   

                    
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

        public Entidad getEntidad(long direccion)
        {
            foreach (Entidad en in entidades)
            {
                if (en.Direccion == direccion)
                    return en;
            }
            return null;
        }

        public Entidad getEntidad(String name)
        {
            foreach (Entidad en in entidades)
            {
                if (en.Nombre == name)
                    return en;
            }
            return null;
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
            for (i = 0; i < nombre.Length && i < 30 ; i++)
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


        public Boolean ContainsName(String nombre)
        {
            foreach(Entidad en in this.entidades)
            {
                if(en.Nombre == nombre)
                return true;
            }
            return false;
        }

        public Boolean Contains(Entidad entidad)
        {
            foreach (Entidad en in this.entidades)
            {
                if (en.Equals(entidad))
                    return true;
            }
            return false;
        }

        public bool grabaRegistro(List<List<byte>> registro, Entidad entidad)
        {
            if (entidad.DireccionRegistros == -1)//si aun no existe registro alguno
            {
                FileStream archivoDatos = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.PathName) + ".dat", FileMode.Create);//Crea el archivo en disco de datos
                entidad.DireccionRegistros = 0;

                List<byte> listaAuxiliarDeBytes = new List<byte>();//se agrega su direccion en el registro
                
                foreach (byte b in BitConverter.GetBytes(entidad.DireccionRegistros))
                {
                    listaAuxiliarDeBytes.Add(b);
                }

                registro.Insert(0, listaAuxiliarDeBytes);

                //long para la direccion siguiente registro del primer registro insertado = -1
                long auxDir = -1;
                listaAuxiliarDeBytes = new List<byte>();

                foreach (byte b in BitConverter.GetBytes(auxDir))
                {
                    listaAuxiliarDeBytes.Add(b);
                }

                registro.Add(listaAuxiliarDeBytes);

                this.abreElArchivo();//se escribe la direccion de los registros en el archivo de trabajo en la entidad
                escritor = new BinaryWriter(archivo);
                this.archivo.Seek(entidad.Direccion + UtilStatic.offset_Entidad_direccionReg, SeekOrigin.Current);
                this.escritor.Write(entidad.DireccionRegistros);
                this.cierraElArchivo();

                
                creaIndices(entidad);

            }
            else//si si que los hay(registros)
            {
                Atributo atributoSecuencialAux = entidad.getAtributoByTipoIndice(1);
                if (atributoSecuencialAux != null)//insersion secuencial indexada
                {
                  insertaSecuencial(registro, entidad);
                }
                else//insercion normal sin orden alguno 
                {
                   insetaSinTipoDeIndice(registro, entidad);
                }
                Atributo atributoPrimario = entidad.getAtributoByTipoIndice(2);
                if(atributoPrimario != null)
                {

                }
                List<Atributo> listaAtributosSecundarios = entidad.getAtributosSecundario();


            }

            //atAux = entidad.getAtributoByTipoIndice(2);

            return false;
        }

        public List<object> LeeRegistro(Entidad en, long direccion)
        {
            List<object> res = new List<object>();

            using (BinaryReader lect = new BinaryReader(new FileStream(Path.GetDirectoryName(this.PathName) +"\\"+Path.GetFileNameWithoutExtension(this.PathName) + ".dat", FileMode.Open)))//Abre el archivo con el BinaryReader
            {
                lect.BaseStream.Seek(direccion, SeekOrigin.Begin);//Se posciona en la posición del iterador
                long direccionAux = lect.ReadInt64();
                res.Add(direccionAux);

                foreach(Atributo at in en.atributos)
                {
                    if (at.Tipo == 'E' || at.Tipo == 'e')
                    {
                        res.Add(lect.ReadInt32());
                    }
                    else if(at.Tipo == 'C' || at.Tipo == 'c')
                    {

                        byte[] byteArrayAux = lect.ReadBytes(at.Longitud).ToArray();
                        String nombreAtributo = getNombreEnString(byteArrayAux);//Lee el string del nombre
                        res.Add(nombreAtributo);
                    }
                }

                direccionAux = lect.ReadInt64();
                res.Add(direccionAux);
                return res;
            }                 
        }

        private void creaIndices(Entidad en)
        {
            foreach (Atributo atr in en.atributos)
            {
                switch (atr.TipoIndice)
                {
                    case 2://Indice primario
                        if (!File.Exists(Path.GetDirectoryName(this.pathName) +"\\"+ Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_P.idx"))//Crea el archivo en disco de datos
                        {
                            
                            indicePrimario = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_P.idx", FileMode.OpenOrCreate);//Crea el archivo en disco de datos
                            
                            using (BinaryWriter b = new BinaryWriter(indicePrimario))
                            {
                                long x = -1;
                                for (int i = 0; i < 256; i++)
                                {
                                    b.Write(x);
                                }
                            }
                        }
                        else
                        {
                            indicePrimario = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_P.idx",FileMode.Open);//Crea el archivo en disco de datos
                        }
                        break;
                    case 3://Indice secundario
                         if (!File.Exists(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_S.idx"))//Crea el archivo en disco de datos
                        {
                            indiceSecundario = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_S.idx", FileMode.OpenOrCreate);//Crea el archivo en disco de datos

                            using (BinaryWriter b = new BinaryWriter(indicePrimario))
                            {
                                long x = -1;
                                for (int i = 0; i < 256; i++)
                                {
                                    b.Write(x);
                                }
                            }
                        }
                        else
                        {
                            indiceSecundario = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_S.idx", FileMode.Open);//Crea el archivo en disco de datos
                        }
                        break;
                    case 4://Indice arbol B+
                        if (!File.Exists(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_B.idx"))//Crea el archivo en disco de datos
                        {
                            indiceSecundario = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_B.idx", FileMode.OpenOrCreate);//Crea el archivo en disco de datos
                        }
                        else
                        {
                            indiceSecundario = new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.pathName) + "_" + atr.Nombre + "_B.idx", FileMode.Open);//Crea el archivo en disco de datos
                        }
                        break;
                }
            }
        }

        private Atributo getAtributoIndice(int tipoIndice, Entidad en)
        {
            foreach (Atributo at in en.atributos)
            {
                if (at.TipoIndice == tipoIndice)
                {
                    return at;
                }
            }
            return null;
        }

        private void insetaSinTipoDeIndice(List<List<byte>> registro, Entidad en)
        {
            long direccionAnterior;// auxiliar que guarda la direccion del registro anterior
            long direccionDeRegistro;//registro a observar
            direccionAnterior = direccionDeRegistro = en.DireccionRegistros;

            FileStream registroFile;

             string nombreDelArchivoDat = Path.GetDirectoryName(this.pathName)+ "\\"+Path.GetFileNameWithoutExtension(this.PathName) + ".dat";
            if (!File.Exists(nombreDelArchivoDat))
            {
                registroFile = new FileStream(nombreDelArchivoDat, FileMode.Create);
                registroFile.Close();
            }

            registroFile = new FileStream(nombreDelArchivoDat, FileMode.Open);
            long tamRegistroDatos = registroFile.Length;
            registroFile.Close();

            using (BinaryWriter esc = new BinaryWriter(new FileStream(nombreDelArchivoDat, FileMode.Open)))
            {
                List<byte> listaAuxiliarDeBytes = new List<byte>();

                foreach(byte b in BitConverter.GetBytes(tamRegistroDatos))
                {
                    listaAuxiliarDeBytes.Add(b);
                }

                registro.Insert(0, listaAuxiliarDeBytes);

                    listaAuxiliarDeBytes = new List<byte>();
                    //direccion del registro al que apuntara                   
                foreach(byte b in BitConverter.GetBytes(direccionDeRegistro))
                {
                    listaAuxiliarDeBytes.Add(b);
                }


                registro.Add(listaAuxiliarDeBytes);

                    en.DireccionRegistros = tamRegistroDatos;
                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_direccionReg, SeekOrigin.Current);
                    this.escritor.Write(en.DireccionRegistros);
                    this.cierraElArchivo();
                    esc.Seek(0,SeekOrigin.End);
                    foreach (List<byte> lB in registro)
                    {
                        esc.Write(lB.ToArray());
                    }
                
            }
        }

        private void insertaSecuencial(List<List<byte>> registro, Entidad en)
        {
            long direccionAnterior;// auxiliar que guarda la direccion del registro anterior
            long direccionDeRegistro;//registro a observar
            direccionAnterior = direccionDeRegistro = en.DireccionRegistros;

            bool mayoresEncontrados = false;

            FileStream registroFile = File.OpenRead(Path.GetDirectoryName(this.pathName)+ "\\" + Path.GetFileNameWithoutExtension(this.PathName) + ".dat");
            long tamRegistroDatos = registroFile.Length;
            registroFile.Close();

            Atributo atributoLlaveSecuencial = en.getAtributoByTipoIndice(1);

            using (BinaryReader lect = new BinaryReader(new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.PathName) + ".dat", FileMode.Open)))//Abre el archivo con el BinaryReader
            {
                while(direccionDeRegistro  > -1 && !mayoresEncontrados)
                {
                    if (atributoLlaveSecuencial.Tipo == 'E' || atributoLlaveSecuencial.Tipo == 'e')//es entero
                    {
                        lect.BaseStream.Seek(direccionDeRegistro + en.offsetByKey(1), SeekOrigin.Begin);//Se posciona en la posición del iterador
                        int llaveLeida = lect.ReadInt32();

                        if (llaveLeida >= Convert.ToInt32(registro[en.atributos.IndexOf(en.getAtributoByTipoIndice(1))]))// se tiene que insertar
                        {
                            mayoresEncontrados = true;

                        }
                        else
                        {
                            direccionAnterior = direccionDeRegistro;
                            lect.BaseStream.Seek(direccionDeRegistro + en.offSetSiguienteRegistro(), SeekOrigin.Begin);//Se posciona en la posición del iterador
                            direccionDeRegistro = lect.ReadInt64();//llave
                        }
                    }
                    else
                    {
                        lect.BaseStream.Seek(direccionDeRegistro + en.offsetByKey(1), SeekOrigin.Begin);//Se posciona en la posición del iterador
                        
                        string llaveLeida = UtilStatic.getStringByByteArray(lect.ReadBytes(en.getAtributoByTipoIndice(1).Longitud));

                        if (llaveLeida.CompareTo(Convert.ToString(registro[en.atributos.IndexOf(en.getAtributoByTipoIndice(1))]))>=0 )// se tiene que insertar
                        {
                            mayoresEncontrados = true;
                        }
                        else
                        {
                            direccionAnterior = direccionDeRegistro;
                            int auxOSet = en.offSetSiguienteRegistro();
                            lect.BaseStream.Seek(direccionDeRegistro + auxOSet, SeekOrigin.Begin);//Se posciona en la posición del iterador
                            direccionDeRegistro = lect.ReadInt64();//llave
                        }
                    }
                     
                }
            }


            using (BinaryWriter esc = new BinaryWriter(new FileStream(Path.GetDirectoryName(this.pathName) + "\\" + Path.GetFileNameWithoutExtension(this.PathName) + ".dat", FileMode.Open)))
            {
                List<byte> listaAuxiliarDeBytes = new List<byte>();
                listaAuxiliarDeBytes.Add(Convert.ToByte(tamRegistroDatos));//la nueva direccion del nuevo registro 
                registro.Insert(0, listaAuxiliarDeBytes);

                if (direccionDeRegistro == direccionAnterior)//Se inserta al inicio
                {
                    listaAuxiliarDeBytes = new List<byte>();
                    listaAuxiliarDeBytes.Add(Convert.ToByte(direccionDeRegistro));//direccion del registro al que apuntara
                    registro.Insert(registro.Count-1, listaAuxiliarDeBytes);

                    en.DireccionRegistros = tamRegistroDatos;
                    this.abreElArchivo();
                    escritor = new BinaryWriter(archivo);
                    this.archivo.Seek(en.Direccion + UtilStatic.offset_Entidad_direccionReg, SeekOrigin.Current);                    
                    this.escritor.Write(en.DireccionRegistros);
                    this.cierraElArchivo();

                   foreach(List<byte> lB in registro)
                    {
                        esc.Write(lB.ToArray());
                    }
                }
                else// se escribira entre registros.
                {
                    esc.Seek(en.offSetSiguienteRegistro() + Convert.ToInt32(direccionAnterior), SeekOrigin.Begin);
                    esc.Write(tamRegistroDatos);//escribir en el anterior la direccion del registro nuevo

                    esc.Seek(en.offSetSiguienteRegistro() + Convert.ToInt32(tamRegistroDatos), SeekOrigin.Begin);
                    esc.Write(direccionDeRegistro);//escribir en el anterior la direccion del registro nuevo
                }
            }
        }

        public bool eliminaRegistro(Entidad entidad)
        {
           
            if(entidad.getAtributoByTipoIndice(1) == null)//eliminacion no secuencial
            {

            }
            else
            {

            }
        }

        /*Cuando se trate de un arbol b+ se debe de tomar en cuenta que los nodos dentro de las hojas tienen una clave y aparte 
         * la direccion de d

        #endregion
    }
}
