using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class Datos : Form
    {
        Conexion conn = new Conexion();
        public Datos()
        {
            InitializeComponent();
            formatTitle();
            CargarDatos();
           formatTable();
        }
        private void formatTitle()
        {
            tbTitulo.Font = new Font("Amaranth", 15);
            tbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            tbTitulo.Text = "Vista de datos";

        }
        private void CargarDatos()
        {
            dgvDatos.DataSource = conn.Registros();
        }
        private void formatTable()
        {
            dgvDatos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.RowsDefaultCellStyle.Font = new Font("arial", 12);
            dgvDatos.RowsDefaultCellStyle.BackColor = Color.FromArgb(11, 30, 46);
            dgvDatos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(11, 30, 46); 
            dgvDatos.RowsDefaultCellStyle.ForeColor = Color.White; 
            dgvDatos.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvDatos.RowTemplate.Height = 26;
            dgvDatos.RowsDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
        }
    }
}
