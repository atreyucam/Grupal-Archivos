using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_Archivos.Forms_de_ingreso
{
    public partial class FormEditarProducto : Form
    {
        public FormEditarProducto()
        {
            InitializeComponent();
            textBoxCodigo.Enabled = false;
        }

        public void setCodigo(string valor) { textBoxCodigo.Text = valor; }
        public void setTipo(string valor) { comboBoxTipo.Text = valor; }
        public void setSubtipo(string valor) { comboBoxSubtipo.Text = valor; }
        public void setMarca(string valor) { comboBoxMarca.Text = valor; }
        public void setNombre(string valor) { textBoxNombre.Text = valor; }
        public void setStock(string valor) { textBoxStock.Text = valor; }
        public void setPrecio(string valor) { textBoxPrecio.Text = valor; }
        public void setDescripcion(string valor) { richTextBoxDescripcion.Text = valor; }

        //gets
        public string getTipo() { return comboBoxTipo.Text; }
        public string getSubtipo() { return comboBoxSubtipo.Text; }
        public string getMarca() { return comboBoxMarca.Text; }
        public string getNombre() { return textBoxNombre.Text; }
        public string getStock() { return textBoxStock.Text; }
        public string getPrecio() { return textBoxPrecio.Text; }
        public string getDescripcion() { return richTextBoxDescripcion.Text; }

        //-----------------------------------------------------------------------------------
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void comboBoxSubtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubtipo.Text = "";
            comboBoxMarca.Text = "";
            if (comboBoxTipo.Text == "CABELLO")
            {
                itemsCabello();
                itemsMarcaCabello();
            }
            else if (comboBoxTipo.Text == "ASEO BUCAL")
            {
                itemsAseoBucal();
                itemsMarcaAseoBucal();
            }
            else if (comboBoxTipo.Text == "ASEO CORPORAL")
            {
                itemsAseoColporal();
                itemsAseoCorporal();
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
        public void itemsMarcaCabello()
        {
            comboBoxMarca.Items.Clear();
            comboBoxMarca.Items.Add("AFRO LOVE");
            comboBoxMarca.Items.Add("ANEA");
            comboBoxMarca.Items.Add("REVLON");
            comboBoxMarca.Items.Add("TAHE");
            comboBoxMarca.Items.Add("WELLA");
            comboBoxMarca.Items.Add("TIO NACHO");
            comboBoxMarca.Items.Add("SIBEL");
        }
        public void itemsMarcaAseoBucal()
        {
            comboBoxMarca.Items.Clear();
            comboBoxMarca.Items.Add("COLGATE");
            comboBoxMarca.Items.Add("DIENTECITOS");
            comboBoxMarca.Items.Add("LISTERINE");
            comboBoxMarca.Items.Add("CLEANDENT");
            comboBoxMarca.Items.Add("DENTALWASH");
        }
        public void itemsAseoCorporal()
        {
            comboBoxMarca.Items.Clear();
            comboBoxMarca.Items.Add("CUERPITO");
            comboBoxMarca.Items.Add("LIMPIOSANO");
            comboBoxMarca.Items.Add("DOVE");
            comboBoxMarca.Items.Add("SIBEL");
            comboBoxMarca.Items.Add("WASHBODY");
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
        //---Validacion del precio - textBoxPrecio
        /*  Permite controlar el ingreso del valor del producto.
         *  Solo acepta valores decimales superiores a 0.
         * */
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Caracter invalido, solo acepta valores enteros positivos.");
            }
            else
            {
                if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
                {
                    if (Int32.Parse(textBoxPrecio.Text) < 1)
                    {
                        MessageBox.Show("Quiere poner gratis el producto? Usted esta loco?!");
                    }
                }
            }
            // Comprueba que no exista otro punto decimal.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar un punto decimal.");
            }
        }
        //--------------------------------------------------------------------
        //---Validacion del nombre - textBoxNombre
        /*  Permite ingresar unicamente el nombre en mayusculas
         * */
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        //--------------------------------------------------------------------
        //---Validacion del descripcion - richTextBoxDescripcion
        /*  Permite ingresar unicamente solo 100 caracteres
         * */
        ErrorProvider errorP = new ErrorProvider();

        private void richTextBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                if (richTextBoxDescripcion.MaxLength >= 100)
                {
                    errorP.SetError(richTextBoxDescripcion, "No se admiten más palabras");
                }
            }
        }
        //--------------------------------------------------------------------
        //---Validacion de la marca - comboBoxMarca
        /*  Permite mostrar en una lista las marcas registradas, sino existe
         *  lo guarda temporalmente en la lista para el resgistro de la marca.
         * */

        private void comboBoxMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                if (comboBoxTipo.Text == "CABELLO")
                {
                    if (comprobarMarca(comboBoxMarca.Text) == false)
                    {
                        nuevaMarca(comboBoxMarca.Text);
                    }
                }
                else if (comboBoxTipo.Text == "ASEO BUCAL")
                {
                    if (comprobarMarca(comboBoxMarca.Text) == false)
                    {
                        nuevaMarca(comboBoxMarca.Text);
                    }
                }
                else if (comboBoxTipo.Text == "ASEO CORPORAL")
                {
                    if (comprobarMarca(comboBoxMarca.Text) == false)
                    {
                        nuevaMarca(comboBoxMarca.Text);
                    }
                }
            }
        }
        public bool comprobarMarca(string valor)
        {
            int index = comboBoxMarca.FindString(valor);
            if (index == 0)
            {
                MessageBox.Show("item encontrado");
                return true;
            }
            else
            {
                MessageBox.Show("Nueva marca registrada.");
                return false;
            }
        }
        public void nuevaMarca(string valor)
        {
            comboBoxMarca.Items.Add(valor);
        }
    }
}
