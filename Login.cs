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
    public partial class Login : Form
    {
        Conexion conn = new Conexion();
        public Login()
        {
            InitializeComponent();
            formatTitle();
        }
        private void formatTitle()
        {
            tbTitulo.Font = new Font("Amaranth", 15);
            tbTitulo.TextAlign = ContentAlignment.MiddleCenter;

        }
        private void Loguear()
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (conn.Login(user, pass))
            {
                Datos dt = new Datos();
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Favor revise los datos" +
                    "\ne intente nuevamente");
            }
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            Loguear();
        }
    }
}
