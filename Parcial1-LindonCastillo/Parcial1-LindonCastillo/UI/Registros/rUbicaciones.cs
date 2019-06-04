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
    public partial class rUbicaciones : Form
    {
        public rUbicaciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            Id_numericUpDown.Value = 0;
            Descripcion_textBox.Text = string.Empty;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(Descripcion_textBox.Text))
            {
                MessageBox.Show("No puede dejar el campo Descripción vacío", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = false;
            }

            return paso;
        }

        private Ubicaciones LlenarClase()
        {
            Ubicaciones Ubicacion = new Ubicaciones();

            Ubicacion.UbicacionId = Convert.ToInt32(Id_numericUpDown.Value);
            Ubicacion.Descripcion = Descripcion_textBox.Text;

            return Ubicacion;
        }

        private void LlenarCampos(Ubicaciones Ubicacion)
        {
            Id_numericUpDown.Value = Ubicacion.UbicacionId;
            Descripcion_textBox.Text = Ubicacion.Descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Ubicaciones ubicaciones = UbicacionesBLL.Buscar((int)Id_numericUpDown.Value);
            return (ubicaciones != null);
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Ubicaciones Ubicacion;

            if (!Validar())
            {
                return;
            }

            Ubicacion = LlenarClase();

            if (Id_numericUpDown.Value == 0)
            {
                paso = UbicacionesBLL.Guardar(Ubicacion);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicación que no existe", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = UbicacionesBLL.Modificar(Ubicacion);
                MessageBox.Show("Se modifico con Exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int id;
            int.TryParse(Id_numericUpDown.Text, out id);

            Limpiar();
            try
            {
                if (UbicacionesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta ubicación", "No Hubo Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error eliminando");
            }

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicaciones;
            int id = Convert.ToInt32(Id_numericUpDown.Value);

            Limpiar();

            ubicaciones = UbicacionesBLL.Buscar(id);

            if (ubicaciones != null)
            {
                LlenarCampos(ubicaciones);
                MessageBox.Show("Ubicación Encontrada!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ubicación No Encontrada!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
