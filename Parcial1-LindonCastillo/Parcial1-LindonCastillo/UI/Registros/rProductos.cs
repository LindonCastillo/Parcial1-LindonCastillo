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

        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Productos Producto;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            Producto = LlenarClase();

            if(ProductoId_numericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(Producto);
            }
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            
                paso = ProductosBLL.Modificar(Producto);
                MessageBox.Show("Se modifico con Exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool paso2 = false;
                Modificaciones modificaciones = new Modificaciones();
                modificaciones = LlenarClase2();
                paso2 = ModificacionesBLL.Guardar(modificaciones);

            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(ProductoId_numericUpDown.Text, out id);

            Limpiar();
            try
            {
                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este Usuario", "No Hubo Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error eliminando");
            }

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Productos Producto;
            int id = Convert.ToInt32(ProductoId_numericUpDown.Value);

            Limpiar();

            Producto = ProductosBLL.Buscar(id);

            if(Producto != null)
            {
                LlenarCampos(Producto);
                MessageBox.Show("Producto Encontrado!","Exito!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto No Encontrado!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Productos LlenarClase()
        {
            Productos productos = new Productos();

            productos.ProductoId = Convert.ToInt32(ProductoId_numericUpDown.Value);
            productos.Descripcion = Convert.ToString(Descripcion_textBox.Text.Trim());
            productos.Existencia = Convert.ToInt32(Existencia_numericUpDown.Value);
            productos.Costo = Convert.ToDecimal(Costo_numericUpDown.Value);
            productos.ValorInventario = Existencia_numericUpDown.Value * Costo_numericUpDown.Value;

            return productos;
        }

        private Modificaciones LlenarClase2()
        {
            Modificaciones modificaciones = new Modificaciones();
            modificaciones.ProductoId = Convert.ToInt32(ProductoId_numericUpDown.Value);
            modificaciones.Descripcion = Convert.ToString(Descripcion_textBox.Text);
            modificaciones.FechaModific = DateTime.Now;

            return modificaciones;
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

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
                
                errorProvider.SetError(Descripcion_textBox, "No deje el campo Descripción vacío");
                Descripcion_textBox.Focus();
                paso = false;
            }

            if(Existencia_numericUpDown.Value < 0)
            {
                errorProvider.SetError(Existencia_numericUpDown, "El valor de este campo no puede menor que 0");
                Existencia_numericUpDown.Focus();
                paso = false;
            }
            
            if(Costo_numericUpDown.Value == 0)
            {
                errorProvider.SetError(Costo_numericUpDown, "El valor de este campo no puede ser igual a 0");
                Costo_numericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private decimal CalcularInventario()
        {
            int existencia = Convert.ToInt32(Existencia_numericUpDown.Value);
            decimal costo = Convert.ToDecimal(Costo_numericUpDown.Value);
            decimal valor = existencia*costo;

            return valor;
        }

        private void Existencia_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventario_textBox.Text = Convert.ToString(CalcularInventario());
        }

        private void Costo_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventario_textBox.Text = Convert.ToString(CalcularInventario());
        }
    }
}
