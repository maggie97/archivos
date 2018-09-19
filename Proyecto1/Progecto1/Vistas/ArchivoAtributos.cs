using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto1
{
    public partial class SoloAtributos : Form
    {
        List<Atributo> list_atributos, list_insercion;
        bool vistaArch = true; // archivo
        string fileName;
        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        /// <param name="Nombre">Nombre del proyecto</param>
        public SoloAtributos(string Nombre)
        {
            InitializeComponent();
            float tam = (float)(dgvAtributos.ClientSize.Width - 41) / (float)(dgvAtributos.Columns.Count);
            for (int i = dgvAtributos.Columns.Count - 1; i > -1; i--)
                dgvAtributos.Columns[i].Width = (int)tam;

            InitializeComponent();
            list_atributos = new List<Atributo>();
            list_insercion = new List<Atributo>();
            fileName = Nombre;
            dgvAtributos.MultiSelect = false;

        }
        
        private void Editor_Load(object sender, EventArgs e)
        {
            
        }

        private void SoloAtributos_SizeChanged(object sender, EventArgs e)
        {
            
            float tam = (float)(dgvAtributos.ClientSize.Width - 41) / (float)(dgvAtributos.Columns.Count);
            for (int i = dgvAtributos.Columns.Count-1;  i > -1; i--)
                dgvAtributos.Columns[i].Width = (int)tam;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        public long nuevoAtrib(Atributo a, long finArch)
        {
            long cab = -1;
            try
            {
                long sig_ent = -1;
                if (list_atributos.Count != 0)
                {
                    list_atributos.Last().DirSig = finArch;
                }
                //Entidad entidad = new Entidad(nomb.ToCharArray(), finArch, -1, sig_ent);
                Console.WriteLine(a.sNombre + a.DirAtributo.ToString() + a.DirSig.ToString());
                list_atributos.Add(a);
                list_insercion.Add(a);
                //Ordena las entidades
                list_atributos = list_atributos.OrderBy(o => o.sNombre).ToList();

                cab = list_atributos[0].DirAtributo; //Asigna el valor de la primera entidad a la cabecera 
                savCabecera(cab); //Se sobreescribe la cabecera

                savEntidad(a); //Se guarda la nueva entidad.
                ordena();
                reescribe();
            }
            catch (Exception e)
            {
                Console.WriteLine("causo una excepcion: ", e);
            }
            return cab;
        }
        public void ordena()
        {
            list_atributos = list_atributos.OrderBy(o => o.sNombre).ToList();
            for (int i = 0; i < list_atributos.Count - 1; i++)
            {
                list_atributos[i].DirSig = list_atributos[i + 1].DirAtributo;
            }
            list_atributos.Last().DirSig = -1;
            foreach (Atributo a in list_atributos)
            {
                int i = list_insercion.IndexOf(a);
                list_insercion[i] = a;
            }
        }
        public void RefreshGrid()
        {
            vistaArch = true;
            dgvAtributos.Rows.Clear();
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                long cab = reader.ReadInt64();
                Console.WriteLine(cab);
                int i = 0;
                while (reader.PeekChar() >= -1)
                {
                    string nomb = "", dir_ent, dir_atr, dir_dat, dir_sig;
                    char[] nombre = reader.ReadChars(30);
                    foreach (char n in nombre)
                    {
                        nomb += n;
                    }
                    dir_ent = reader.ReadInt64().ToString();
                    dir_atr = reader.ReadInt64().ToString();
                    dir_dat = reader.ReadInt64().ToString();
                    dir_sig = reader.ReadInt64().ToString();
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", nomb, dir_ent, dir_atr, dir_dat, dir_sig);
                    dgvAtributos.Rows.Add(nomb, dir_ent, dir_atr, dir_dat, dir_sig);
                }
            }
        }

        public void savEntidad(Atributo a)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append)))
            {

                writer.Write(a.Nombre);
                writer.Write(a.DirAtributo);
                writer.Write(a.Tipo);
                writer.Write(a.Longitud);
                writer.Write(a.TipoIndice);
                writer.Write(a.DirIndice);
                writer.Write(a.DirSig);
            }
        }

        public void reescribe()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Open)))
            {
                writer.Seek(8, SeekOrigin.Begin);
                foreach (Atributo a in list_insercion)
                {
                    writer.Write(a.Nombre);
                    writer.Write(a.DirAtributo);
                    writer.Write(a.Tipo);
                    writer.Write(a.Longitud);
                    writer.Write(a.TipoIndice);
                    writer.Write(a.DirIndice);
                    writer.Write(a.DirSig);
                }
            }
        }
        public void savCabecera(long primerAtributo)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Open)))
            {
                writer.Seek(0, SeekOrigin.Begin);
                writer.Write(primerAtributo);
            }
            /*using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                
                Console.WriteLine("Cabecera: " + reader.ReadInt64());
            }/**/
        }
        public void Actualiza()
        {
            vistaArch = false; // alfabeticamente
            dgvAtributos.Rows.Clear();
            try
            {
                foreach (Atributo a in list_atributos)
                {
                    dgvAtributos.Rows.Add(a.sNombre, a.DirAtributo, a.Tipo,
                        a.Longitud, a.TipoIndice, a.DirIndice, a.DirSig);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion:", ex);
            }
        }
        public void elimina()
        {
            if (!vistaArch)
            {
                foreach (DataGridViewRow r in dgvAtributos.SelectedRows)
                {
                    if (!r.IsNewRow)
                    {
                        int i = dgvAtributos.Rows.IndexOf(r);
                        dgvAtributos.Rows.Remove(r);
                        long ds = list_atributos[i].DirSig;
                        //if (list_entidades.Count > i) list_entidades[i + 1].Dir_sig = ds;
                        for (int j = 0; j < list_insercion.Count; j++)
                        {
                            if (list_insercion[j].DirSig == list_atributos[i].DirAtributo)
                            {
                                list_insercion[j].DirSig = ds;
                                int ind = list_insercion.IndexOf(list_atributos[i]);
                                list_insercion[i].DirSig = -1;
                            }
                        }

                        list_atributos.RemoveAt(i);
                        Console.WriteLine(i);
                    }


                    Console.WriteLine("");
                }

            }
        }
    }
}
