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
            arrayCliente[0] = txtNombre.Text;
            arrayCliente[1] = txtApellido.Text;
            arrayCliente[2] = txtCedula.Text;
            arrayCliente[3] = cmbCiudad.Text;
            arrayCliente[4] = cmbEdad.Text;
            arrayCliente[5] = txtDireccion.Text;
            arrayCliente[6] = txtFecha.Text;
            arrayCliente[7] = txtCorreo.Text;
            arrayCliente[8] = cmbGenero.Text;
            arrayCliente[9] = txtCedula.Text;
            dataSetTienda1.TablaClientes.Rows.Add(arrayCliente);
            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
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
        //---Validacion de la Cedula - txtCedula
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
        //--------------------------------------------------------------------

    }
}
