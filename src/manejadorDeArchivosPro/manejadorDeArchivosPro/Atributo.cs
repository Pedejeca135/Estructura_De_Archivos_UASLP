using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace manejadorDeArchivosPro
{

    public class Atributo
    {
        byte[] ID;
        private string nombre;//Nombre de la entidad
        char tipo;
        private int longitud;
        private long direccion;
        private int tipoIndice;
        //private long direccion;//Direccion en el archivo del atributo
        private long dirIn;
        private long dirSiguiente;
        public Atributo(byte[]ID, String nombre, char tipo, int longitud, long direccion, int tipoIndice, long dirIn, long dirSiguiente)
        {

        }
    }
}
