using Parcial1_LindonCastillo.BLL;
using Parcial1_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_LindonCastillo.UI.Consultas
{
    public partial class cValorInventarioTotal : Form
    {
        public cValorInventarioTotal()
        {
            InitializeComponent();
        }

        private void Actualizar_button_Click(object sender, EventArgs e)
        {
            var listado = new List<Productos>();
            listado = ProductosBLL.GetList(p => true);

            decimal valorTotal = 0;

            foreach(var i in listado)
            {
                var temp = i.ValorInventario;
                valorTotal += temp;
                
            }

            ValorInventarioTotal_textBox.Text = Convert.ToString(valorTotal);
        }
    }
}
