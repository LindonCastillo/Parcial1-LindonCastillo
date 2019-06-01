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
    public partial class cModificaciones : Form
    {
        public cModificaciones()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            var listado = new List<Modificaciones>();

            if(Criterio_textBox.Text.Trim().Length > 0)
            {
                switch(Filtro_comboBox.SelectedIndex)
                {
                    case 0:
                        listado = ModificacionesBLL.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(Criterio_textBox.Text);
                        listado = ModificacionesBLL.GetList(p => p.ProductoId == id);
                        break;

                    case 2:
                        listado = ModificacionesBLL.GetList(p => p.Descripcion.Contains(Criterio_textBox.Text));
                        break;

                }

            }
            else
            {
                listado = ModificacionesBLL.GetList(p => true);
            }

            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = listado;
        }
    }
}
