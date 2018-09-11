using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Entidad
    {
        char[] nombreEntidad = new char[50];
        long dir_Entidad;
        long dir_Atributos;
        long dir_Datos;

        public Entidad(char[] nombreEntidad, long dir_Entidad, long dir_Atributos, long dir_Datos)
        {
            this.nombreEntidad = nombreEntidad;
            this.dir_Entidad = dir_Entidad;
            this.dir_Atributos = dir_Atributos;
            this.dir_Datos = dir_Datos;
        }

        public char[] NombreEntidad { get => nombreEntidad; set => nombreEntidad = value; }
        public long Dir_Entidad { get => dir_Entidad; set => dir_Entidad = value; }
        public long Dir_Atributos { get => dir_Atributos; set => dir_Atributos = value; }
        public long Dir_Datos { get => dir_Datos; set => dir_Datos = value; }
    }
}
