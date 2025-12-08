using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios.Login;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //TODO: Código para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO: Lógica para mover el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO: Lógica para mover el formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //TODO: Lógica para el botón de Acceder
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtPassword.Text.Trim();

            //TODO: Validar que los campos no estén vacíos
            if (usuario == "" || contrasena == "" ||
                usuario == "Usuario" || contrasena == "Password")
            {
                MessageBox.Show("Debe completar usuario y contraseña.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            //TODO: Validar las credenciales usando la capa de negocio
            LoginNegocio login = new LoginNegocio();

            //TODO: Verificar si el login es válido
            bool valido = login.ValidarLogin(usuario, contrasena);

            //TODO: Mostrar mensaje según el resultado de la validación
            if (valido)
            {
                MessageBox.Show("Bienvenido " + usuario,
                                "Acceso concedido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                
                FormMenuPrincipal menu = new FormMenuPrincipal(1, usuario);
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtPassword.Clear();
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Focus();
            }
        }
    }
}
