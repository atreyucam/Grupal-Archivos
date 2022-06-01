using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos
{
    public partial class FormProductos : Form
    {
        //variables
        string fechaElaboracion, fechaCaducidad;

        public FormProductos()
        {
            InitializeComponent();
            dataSetTienda1.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            fechaElaboracion = comboBoxDiaElaboracion.Text +"/"+ comboBoxMesElaboracion.Text + "/"+ comboBoxYearElaboracion.Text;
            fechaCaducidad = comboBoxDiaCaducidad.Text + "/" + comboBoxMesCaducidad.Text + "/" + comboBoxYearCaducidad.Text;

            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            object[] arrayProducto = new object[10];
            arrayProducto[0] = textBoxCodigo.Text;
            arrayProducto[1] = comboBoxTipo.Text;
            arrayProducto[2] = comboBoxSubtipo.Text;
            arrayProducto[3] = textBoxMarca.Text;
            arrayProducto[4] = textBoxNombre.Text;
            arrayProducto[5] = richTextBoxDescripcion.Text;
            arrayProducto[6] = textBoxStock.Text;
            arrayProducto[7] = fechaElaboracion;
            arrayProducto[8] = fechaCaducidad;
            arrayProducto[9] = textBoxPrecio.Text;
            dataSetTienda1.TablaProductos.Rows.Add(arrayProducto);
            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            MessageBox.Show("Producto registrado");

        }
        //--------------------------------------------------------------------
        //--- VALIDACIONES DEL FORM PRODUCTO 
        //--------------------------------------------------------------------

        //---Validacion del Codigo - texboxCodigo
        /*  Permite revisar en el dataset si existe ya el codigo.
         *  Permite comprobar que el codigo no supere los 6 digitos.
         *  Permite el ingreso de caracteres alfanumericos.
         * */
        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                if (textBoxCodigo.TextLength > 6)
                {
                    MessageBox.Show("Su codigo pasa de 6 digitos");
                }
                else
                {
                    comprobarCodigo(textBoxCodigo.Text);
                }
            }
        }
        public bool comprobarCodigo(string valor)
        {
            DataRow[] comprobar;
            comprobar = dataSetTienda1.TablaProductos.Select("codigoProducto='" + valor + "'");

            if (comprobar.Length > 0)
            {
                MessageBox.Show("El codigo ya esta registrado");
                return true;
            }
            else
            {
                comboBoxTipo.Focus();
                return false;
            }
        }
        //--------------------------------------------------------------------

        //---Validacion del tipo y subtipo - comboboxTipo y comboBoxSubtipo
        /*  Permite Seleccionar su subtipo dependiendo que tipo selccione.
         *  
         * */
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubtipo.Text = "";
            if (comboBoxTipo.Text == "CABELLO")
            {
                itemsCabello();
            }
            else if (comboBoxTipo.Text == "ASEO BUCAL")
            {
                itemsAseoBucal();
            }
            else if (comboBoxTipo.Text == "ASEO CORPORAL")
            {
                itemsAseoColporal();
            }
        }
        public void itemsCabello()
        {
            comboBoxSubtipo.Items.Clear();
            comboBoxSubtipo.Items.Add("Shampoo");
            comboBoxSubtipo.Items.Add("Acondicionador");
        }
        public void itemsAseoBucal()
        {
            comboBoxSubtipo.Items.Clear();
            comboBoxSubtipo.Items.Add("Pasta dental");
            comboBoxSubtipo.Items.Add("Hilo dental");
        }
        public void itemsAseoColporal()
        {
            comboBoxSubtipo.Items.Clear();
            comboBoxSubtipo.Items.Add("Jabon");
            comboBoxSubtipo.Items.Add("Exfoliante");
        }

        //--------------------------------------------------------------------

        //---Validacion del stock - textboxStock
        /*  Permite Ingresar solo numeros enteros positivos.
         *  Permite controlar el minimo que es 1.
         *  Permite controlar el maximo que es 250.
         *  Permite informar que el stock esta vacio.
         * */
        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido, solo acepta numeros enteros positivos.");
            }
            else
            {
                if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                {
                    if (Int32.Parse(textBoxStock.Text) > 250)
                    {
                        MessageBox.Show("Usted para el limite de la bodega, 250 items");
                    }
                    else if (Int32.Parse(textBoxStock.Text) < 1)
                    {
                        MessageBox.Show("El stock esta vacio. Consulte el proximo abastecimiento de stock");
                    }
                }
            }
        }
        //--------------------------------------------------------------------

    }

}
