using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubForm
{
    public partial class Login : Form
    {
        private UserServices _userServices;
        public Login()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void icocerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("USUARIO"))
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals("CONTRASEÑA"))
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.DarkGray;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals(""))
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.ForeColor = Color.DimGray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var clave = txtClave.Text;
            var result = _userServices.LoginUser(user,clave);
            if (result != null)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }
        }
    }
}
