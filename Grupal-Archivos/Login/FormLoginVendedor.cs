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
    public partial class FormLoginVendedor : Form
    {
        public FormLoginVendedor()
        {
            InitializeComponent();
            dataSetTienda1.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataRow[] comprobar;
            comprobar = dataSetTienda1.TablaVendedor.Select("UserName='" + textBoxUser.Text + "'");
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                if (textBoxUser.Text == comprobar.ToString())
                {
                    MessageBox.Show("vendedor registrado");
                }
                else
                {
                    comprobarCodigo(textBoxUser.Text);
                }
            }
        }
        public bool comprobarCodigo(string valor)
        {
            DataRow[] comprobar;
            comprobar = dataSetTienda1.TablaVendedor.Select("UserName='" + valor + "'");

            if (comprobar.Length > 0)
            {
                MessageBox.Show("vendedor registrado");
                return true;
            }
            else
            {
                MessageBox.Show("El vendedor no esta registrado");
                textBoxUser.Focus();
                return false;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataRow[] comprobar;
            comprobar = dataSetTienda1.TablaVendedor.Select("Password='" + textBoxPassword.Text + "'");
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                if (textBoxPassword.Text == comprobar.ToString())
                {
                    MessageBox.Show("vendedor registrado2");
                }
                else
                {
                    comprobarPassword(textBoxPassword.Text);
                }
                buttonAcceder.Focus();
            }
        }

        public bool comprobarPassword(string valor)
        {
            DataRow[] comprobar;
            comprobar = dataSetTienda1.TablaVendedor.Select("Password='" + valor + "'");

            if (comprobar.Length > 0)
            {
                MessageBox.Show("Ingreso exitoso");
                Ventanas_de_Usuario.FormInicioVendedor formInicioVendedor = new Ventanas_de_Usuario.FormInicioVendedor();
                formInicioVendedor.ShowDialog();
                return true;
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
                textBoxUser.Focus();
                return false;
            }
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
