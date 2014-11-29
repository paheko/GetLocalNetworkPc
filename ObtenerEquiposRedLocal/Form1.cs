using ObtenerEquiposRedLocal.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObtenerEquiposRedLocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void obtener_nombres_equipo_button_Click(object sender, EventArgs e)
        {
            NetworkBrowser nb = new NetworkBrowser();
            List<string> lista = new List<string>();
            foreach (string pc in nb.getNetworkComputers())
            {
                dataGridView1.Rows.Add(pc);
            }
            
        }
    }
}
