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
        int posicion;
        
        public FormProductos()
        {
            InitializeComponent();
            dataSetTienda1.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");

        }

        public void limpiar()
        {
            textBoxCodigo.Clear();
            comboBoxTipo.Text = "";
            comboBoxSubtipo.Text = "";
            comboBoxMarca.Text = "";
            textBoxNombre.Clear();
            richTextBoxDescripcion.Clear();
            textBoxStock.Clear();
            comboBoxDiaCaducidad.Text = "";
            comboBoxDiaElaboracion.Text = "";
            comboBoxMesCaducidad.Text = "";
            comboBoxMesElaboracion.Text = "";
            comboBoxYearCaducidad.Text = "";
            comboBoxYearElaboracion.Text = "";
            textBoxPrecio.Clear();
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
            arrayProducto[3] = comboBoxMarca.Text;
            arrayProducto[4] = textBoxNombre.Text;
            arrayProducto[5] = richTextBoxDescripcion.Text;
            arrayProducto[6] = textBoxStock.Text;
            arrayProducto[7] = fechaElaboracion;
            arrayProducto[8] = fechaCaducidad;
            arrayProducto[9] = textBoxPrecio.Text;
            dataSetTienda1.TablaProductos.Rows.Add(arrayProducto);
            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            MessageBox.Show("Producto registrado");
            limpiar();
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
        public void contenido()
        {
            textBoxCodigo.Visible = false;
            comboBoxTipo.Visible = false;
            comboBoxSubtipo.Visible = false;
            comboBoxMarca.Visible = false;
            textBoxNombre.Visible = false;
            richTextBoxDescripcion.Visible = false;
            textBoxStock.Visible = false;
            textBoxPrecio.Visible = false;
            comboBoxDiaCaducidad.Visible = false;
            comboBoxDiaElaboracion.Visible = false;
            comboBoxMesCaducidad.Visible = false;
            comboBoxMesElaboracion.Visible = false;
            comboBoxYearCaducidad.Visible = false;
            comboBoxYearElaboracion.Visible = false;
            dataGridView1.Visible = false;

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
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;

            buttonBuscar.Visible = false;
            buttonGuardar.Visible = false;
            buttonEditar.Visible = false;
            buttonEliminar.Visible = false;
        }

        //--------------------------------------------------------------------
        //Permite abrir una nueva ventana que permite buscar el producto.
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            contenido();
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }

            Form ventana;
            ventana = new Forms_de_busqueda.FormBusquedaProductos();
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
            ventana = new Forms_de_busqueda.FormBusquedaEliminarProducto();
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
            ventana = new Forms_de_busqueda.FormBusquedaEditarProducto();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }
        //--------------------------------------------------------------------
       
    }

}
