using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class SoloAtributos : Form
    {
        
        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        /// <param name="Nombre">Nombre del proyecto</param>
        /// <param name="n"> Número de pestaña </param>
        public SoloAtributos(string Nombre, int n)
        {
            InitializeComponent();
            float tam = (float)(dataGridView1.ClientSize.Width - 41) / (float)(dataGridView1.Columns.Count);
            for (int i = dataGridView1.Columns.Count - 1; i > -1; i--)
                dataGridView1.Columns[i].Width = (int)tam;
        }
        public SoloAtributos()
        {
            InitializeComponent();
            float tam = (float)(dataGridView1.ClientSize.Width - 41) / (float)(dataGridView1.Columns.Count);
            for (int i = dataGridView1.Columns.Count - 1; i > -1; i--)
                dataGridView1.Columns[i].Width = (int)tam;
        }
        
        private void Editor_Load(object sender, EventArgs e)
        {
            
        }

        private void SoloAtributos_SizeChanged(object sender, EventArgs e)
        {
            
            float tam = (float)(dataGridView1.ClientSize.Width - 41) / (float)(dataGridView1.Columns.Count);
            for (int i = dataGridView1.Columns.Count-1;  i > -1; i--)
                dataGridView1.Columns[i].Width = (int)tam;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
