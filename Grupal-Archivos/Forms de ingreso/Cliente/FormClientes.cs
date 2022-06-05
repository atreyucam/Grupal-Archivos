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


namespace Grupal_Archivos
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();

            dataSetTienda1.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            object[] arrayCliente = new object[10];
            arrayCliente[0] = txtCedula.Text;
            arrayCliente[1] = txtNombre.Text;
            arrayCliente[2] = txtApellido.Text;
            arrayCliente[3] = cmbCiudad.Text;
            arrayCliente[4] = cmbEdad.Text;
            arrayCliente[5] = txtDireccion.Text;
            arrayCliente[6] = txtFecha.Text;
            arrayCliente[7] = txtCorreo.Text;
            arrayCliente[8] = cmbGenero.Text;
            arrayCliente[9] = txtCedula.Text;
            dataSetTienda1.TablaClientes.Rows.Add(arrayCliente);
            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            MessageBox.Show("Cliente registrado");
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
        //---Validacion de la fecha de nacimiento - txtFecha
        /*  Permite comprobar si el numero celular es valido.
         * */
        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        //--------------------------------------------------------------------
        //---Validacion de ciudad - cmbCiudad
        /*  Permite el ingreso de solo letras.
         * */
        private void cmbCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido, solo letras.");

            }
        }

        public void contenido()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            txtCedula.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            cmbEdad.Visible = false;
            txtFecha.Visible = false;
            cmbCiudad.Visible = false;
            txtDireccion.Visible = false;
            cmbGenero.Visible = false;
            txtCorreo.Visible = false;
            txtCelular.Visible = false;
            buttonBuscar.Visible = false;
            buttonEliminar.Visible = false;
            buttonGuardar.Visible = false;
            dataGridView1.Visible = false;
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
            ventana = new Forms_de_busqueda.Cliente.FormBusquedaEditarCliente();
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
            ventana = new Forms_de_busqueda.Cliente.FormBusquedaEliminarCliente();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            contenido();
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new Forms_de_busqueda.Cliente.FormBusquedaCliente();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }

        //--------------------------------------------------------------------

    }
}
