using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_LindonCastillo.UI.Registros;
using Parcial1_LindonCastillo.UI.Consultas;


namespace Parcial1_LindonCastillo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rproducto = new rProductos();
            rproducto.Show();
        }

        private void ValorDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cValorInventarioTotal cvalorinventario = new cValorInventarioTotal();
            cvalorinventario.Show();
        }
    }
}
