using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejadorDeArchivosPro
{
    public static class Util
    {
        static int en_id = 5;
        static int en_nombre = 30;
        static int en_direccion = 8;
        static int en_TipoDato = 1;
        static int en_tipoIndice = 4;
        static int en_longitud = 4;

        public static int Enum_ID
        {
            get { return en_id; }
        }
        public static int Enum_Nombre
        {
            get { return en_nombre; }
        }
        public static int Enum_Direccion
        {
            get { return en_direccion; }
        }
        public static int Enum_TipoDato
        {
            get { return en_TipoDato; }
        }
        public static int Enum_TipoIndice
        {
            get { return en_tipoIndice; }
        }
        public static int Enum_Longitud
        {
            get { return en_longitud; }
        }

        public static Boolean ValidacionDeNombre(String nombre)
        {
            if (nombre.Contains('/') || nombre.Contains(':')
             || nombre.Contains('*') || nombre.Contains('?')
             || nombre.Contains('"') || nombre.Contains('<')
             || nombre.Contains('>') || nombre.Contains('|')
             || nombre.Contains(@"\") || nombre == "" || nombre == " ")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean ValidacionDeNombreLight(String nombre)
        {
            if (nombre.Contains('/') || nombre.Contains(':')
             || nombre.Contains('*') || nombre.Contains('?')
             || nombre.Contains('"') || nombre.Contains('<')
             || nombre.Contains('>') || nombre.Contains('|')
             || nombre.Contains(@"\"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static byte[] getByteArrayAFull(uint num)
            {
                byte[] res = new byte[num];

                for (int i = 0; i < num; i++)
                {
                    res[i] = 0xFF;
                }
                 return res;
            }

        #region getEntidadesOffsets
        public static int offset_Entidad_id
        {
            get { return 0; }
        }
        public static int offset_Entidad_nombre
        {
            get { return offset_Entidad_id + Util.Enum_ID; }
        }
        public static int offset_Entidad_direccion
        {
            get { return offset_Entidad_nombre + Util.Enum_Nombre; }
        }
        public static int offset_Entidad_direccionAtrib
        {
            get { return offset_Entidad_direccion + Util.Enum_Direccion; }
        }
        public static int offset_Entidad_direccionReg
        {
            get { return offset_Entidad_direccionAtrib + Util.Enum_Direccion; }
        }
        public static int offset_Entidad_sigDir
        {
            get { return offset_Entidad_direccionReg + Util.Enum_Direccion; }
        }
#endregion


        #region getAtributoOffsets
        public static int offset_Atributo_ID
        {
            get { return 0; }
        }
        public static int offset_Atributo_Nombre
        {
            get { return offset_Atributo_ID + Util.Enum_ID; }
        }
        public static int offset_Atributo_TipoDato
        {
            get { return offset_Atributo_Nombre + Util.Enum_Nombre; }
        }
        public static int offset_Atributo_Longitud
        {
            get { return offset_Atributo_TipoDato + Util.Enum_TipoDato; }
        }
        public static int offset_Atributo_Direccion
        {
            get { return offset_Atributo_Longitud + Util.Enum_Longitud; }
        }
        public static int offset_Atributo_TipoIndice
        {
            get { return offset_Atributo_Direccion + Util.Enum_Direccion; }
        }
        public static int offset_Atributo_DireccionIndice
        {
            get { return offset_Atributo_TipoIndice + Util.Enum_TipoIndice; }
        }
        public static int offset_Atributo_DirSigAtributo
        {
            get { return offset_Atributo_DireccionIndice + Util.Enum_Direccion; }
        }
        #endregion

        public static int getTipoIndice(String tipondice)
        {
            int res = 0;
            if(tipondice.Contains('0'))
            {
                res = 0;
            }
            else if(tipondice.Contains('1'))
            {
                res = 1;
            }
            else if(tipondice.Contains('2'))
            {
                res = 2;
            }
            else if (tipondice.Contains('3'))
            {
                res = 3;
            }
            else if (tipondice.Contains('4'))
            {
                res = 4;
            }
            return res;
        }
    }
   

}
