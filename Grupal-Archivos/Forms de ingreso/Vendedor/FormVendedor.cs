using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Grupal_Archivos.Forms_de_ingreso.Vendedor
{
    public partial class FormVendedor : Form
    {
        public FormVendedor()
        {
            InitializeComponent();
            dataSetTienda.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }
        //--------------------------------------------------------------------
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            object[] arrayVendedor = new object[9];
            arrayVendedor[0] = txtCedula.Text;
            arrayVendedor[1] = textBoxUserName.Text;
            arrayVendedor[2] = txtNombre.Text;
            arrayVendedor[3] = txtApellido.Text;
            arrayVendedor[4] = textBoxPassword.Text;
            arrayVendedor[5] = cmbEdad.Text;
            arrayVendedor[6] = txtCelular.Text;
            arrayVendedor[7] = txtCorreo.Text;
            arrayVendedor[8] = cmbGenero.Text;
            dataSetTienda.TablaVendedor.Rows.Add(arrayVendedor);
            dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            MessageBox.Show("Vendedor registrado");
            limpiarFormulario();
        }

        public void limpiarFormulario()
        {
            txtCedula.Text = "";
            textBoxUserName.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            textBoxPassword.Text = "";
            cmbEdad.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            cmbGenero.Text = "";
        }

        //--------------------------------------------------------------------
        //--- VALIDACIONES DEL FORM CLIENTE 
        //--------------------------------------------------------------------
        //---Validacion del nombre - txtNombre
        /*  Permite el ingreso de solo letras.
         * */
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido, solo letras.");

            }
        }

        //--------------------------------------------------------------------
        //---Validacion del apellido - txtApellido
        /*  Permite el ingreso de solo letras.
         * */
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido, solo letras.");
            }
        }

        //--------------------------------------------------------------------
        //---Validacion de la Cedula - txtCedula
        /*  Permite comprobar si la cedula ingresada es valido.
         * */
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                var rgx = new Regex(@"^[0-9]{10}$");
                if (rgx.IsMatch(txtCedula.Text))
                {
                    MessageBox.Show("Cedula Ecuatoriana");
                }
                else
                {
                    MessageBox.Show("La cedula ingresada no es correcta.");
                }
            }
        }

        //--------------------------------------------------------------------
        //---Validacion del Celular - txtCelular
        /*  Permite comprobar si el numero celular es valido.
         * */
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                var rgx = new Regex(@"^[0-9]{10}$");
                if (rgx.IsMatch(txtCelular.Text))
                {
                    MessageBox.Show("numero Ecuatoriano");
                }
                else
                {
                    MessageBox.Show("El numero ingresado no es correcto.");
                }
            }
        }
        //--------------------------------------------------------------------
        public void contenido()
        {
            txtCedula.Visible = false;
            textBoxUserName.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            textBoxPassword.Visible = false;
            cmbEdad.Visible = false;
            txtCelular.Visible = false;
            txtCorreo.Visible = false;
            cmbGenero.Visible = false;
            txtCedula.Visible = false;
            textBoxUserName.Visible = false;
            textBoxPassword.Visible = false;
            cmbEdad.Visible = false;
            cmbGenero.Visible = false;
            dataGridView1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            buttonBuscar.Visible = false;
            buttonEditar.Visible = false;
            buttonEliminar.Visible = false;
            buttonGuardar.Visible = false;
        }

        //--------------------------------------------------------------------
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            contenido();
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new Forms_de_busqueda.Vendedor.FormBusquedaVendedor();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }
        //--------------------------------------------------------------------
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            contenido();
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new Forms_de_busqueda.Vendedor.FormBusquedaEliminarVendedor();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }


        //--------------------------------------------------------------------
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            contenido();
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new Forms_de_busqueda.Vendedor.FormBusquedaEditarVendedor();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }
    }
}
