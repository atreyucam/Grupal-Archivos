using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Login
{
    public partial class FormLoginAdmin : Form
    {
        //Variables
        string user, password;

        public FormLoginAdmin()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------
        //Cambia el color cuando el usuario esta escribiendo.
        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Ingrese su usuario")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.LightGray;
            }
        }

        //----------------------------------------------------------------
        //Muestra que el campo no esta lleno.
        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.Text = "Ingrese su usuario";
                textBoxUser.ForeColor = Color.Red;
            }
        }

        //----------------------------------------------------------------
        //Cambia el color cuando el usuario esta escribiendo.
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Ingrese su contraseña")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        //----------------------------------------------------------------
        //Muestra que el campo no esta lleno.
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Ingrese su contraseña";
                textBoxPassword.ForeColor = Color.Red;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        //----------------------------------------------------------------
        //Valida el ingreso y muestra el menu del sistema de administrador
        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            user = textBoxUser.Text;
            password = textBoxPassword.Text;
            if ((user == "admin") && (password == "1234"))
            {
                Ventanas_de_Usuario.FormInicioAdministrador administrador = new Ventanas_de_Usuario.FormInicioAdministrador();
                administrador.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
                textBoxUser_Leave(sender, e);
                textBoxPassword_Leave(sender, e);
            }
        }
    }
}
