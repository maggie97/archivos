﻿namespace Proyecto1
{
    public class Atributo
    {
        char[] nombre = new char[30];
        long dirAtributo = -1, dirSig = -1, dirIndice = -1;
        string tipo;
        int longitud;
        int tipoIndice = 0;

        public Atributo(string nombre, long dirAtributo, string tipo, int longitud, int tipoIndice, long dirIndice, long dirs)
        {
            for (int i = 0; i < 30; i++)
            {
                if (nombre.Length > i)
                    this.nombre[i] = nombre[i];
                else
                    this.nombre[i] = ' ';
            }
            this.dirAtributo = dirAtributo;
            this.tipo = tipo;
            this.longitud = longitud;
            this.tipoIndice = tipoIndice;
            this.dirIndice = dirIndice;
            dirSig = dirs;
        }

        public char[] Nombre { get => nombre; set => nombre = value; }
        public long DirAtributo { get => dirAtributo; set => dirAtributo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Longitud { get => longitud; set => longitud = value; }
        public int TipoIndice { get => tipoIndice; set => tipoIndice = value; }

        public string sNombre
        {
            get
            {
                string nom = "";
                for (int i = 0; i < 30; i++)
                {
                    if (nombre[i] > -1)
                        nom += nombre[i].ToString();
                }
                return nom;
            }
        }

        public long DirSig { get => dirSig; set => dirSig = value; }
        public long DirIndice { get => dirIndice; set => dirIndice = value; }
    }
}
