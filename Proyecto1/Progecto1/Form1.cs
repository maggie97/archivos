using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progecto1
{
    public partial class Form1 : Form
    {
        List<Editor> ediciones;
        TabControl tabCtrl;
        public Form1()
        {
            ediciones =  new List<Editor>();
            tabCtrl = null;
            InitializeComponent();
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabCtrl != null)
            try
            {
                tabCtrl = new TabControl();
                TabPage tabEntidades = new TabPage("Entidades");
                TabPage tabAtributos = new TabPage("Atributos");
                TabPage tabArchivoV = new TabPage("Archivo Rec");
                TabPage tabArchivoT = new TabPage("Archivo Texto");
                tabEntidades.BackColor = tabAtributos.BackColor =
                    tabArchivoV.BackColor = tabArchivoT.BackColor = Color.White;
                tabCtrl.Alignment = TabAlignment.Left;
                tabCtrl.Controls.Add(tabEntidades);
                tabCtrl.Controls.Add(tabAtributos);
                tabCtrl.Controls.Add(tabArchivoV);
                tabCtrl.Controls.Add(tabArchivoT);
                tabCtrl.Location = new Point(0, 24);
                tabCtrl.Name = "Editor" + ediciones.Count;
                tabCtrl.SelectedIndex = 0;
                tabCtrl.Size = new Size(ClientSize.Width, ClientSize.Height);

                Controls.Add(tabCtrl);
            }
            catch
            {
                
            }
            
        }
    }
}
