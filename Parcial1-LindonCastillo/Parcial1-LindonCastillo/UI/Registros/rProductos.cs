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

        private Productos LlenarClase()
        {
            Productos productos = new Productos();

            productos.ProductoId = Convert.ToInt32(ProductoId_numericUpDown.Value);
            productos.Descripcion = Convert.ToString(Descripcion_textBox.Text);
            productos.Existencia = Convert.ToInt32(Existencia_numericUpDown.Value);
            productos.Costo = Convert.ToDecimal(Costo_numericUpDown.Value);
            productos.ValorInventario = Convert.ToDecimal(ValorInventario_textBox.Text);

            return productos;
        }

        private void LlenarCampos(Productos productos)
        {
            ProductoId_numericUpDown.Value = productos.ProductoId;
            Descripcion_textBox.Text = productos.Descripcion;
            Existencia_numericUpDown.Value = productos.Existencia;
            Costo_numericUpDown.Value = Convert.ToDecimal(productos.Costo);
            ValorInventario_textBox.Text = Convert.ToString(productos.ValorInventario);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos productos = ProductosBLL.Buscar((int) ProductoId_numericUpDown.Value);
            return (productos != null);
        }
    }
}
