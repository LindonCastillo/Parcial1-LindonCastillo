using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_LindonCastillo.UI.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ProductoId_numericUpDown.Value = 0;
            Descripcion_textBox.Text = string.Empty;
            Existencia_numericUpDown.Value = 0;
            Costo_numericUpDown.Value = 0;
            ValorInventario_textBox.Text = "0";

        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {

        }
    }
}
