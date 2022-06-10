using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Grupal_Archivos.Forms_de_ingreso.RelacionVenta
{
    public partial class FormGenerarVenta : Form
    {
        public FormGenerarVenta()
        {
            InitializeComponent();
            dataSetTienda.ReadXml(Application.StartupPath + "datosTiendaAseoPersonal");
            textBoxNombre.Enabled = false;
            textBoxApellido.Enabled = false;

        }

        public void setNombre(string valor) { textBoxNombre.Text = valor; }
        public void setApellido(string valor) { textBoxApellido.Text = valor; }
        public void setValorr(string valor) { labelValor.Text = valor; }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                var rgx = new Regex(@"^[0-9]{10}$");
                if (rgx.IsMatch(textBox2.Text))
                {
                    MessageBox.Show("Cedula Ecuatoriana");
                    DataRow[] data;
                    data = dataSetTienda.TablaClientes.Select("Cedula='" + textBox2.Text + "'");
                    if (data.Length > 0)
                    {
                        MessageBox.Show("Encontrado");
                        setNombre(data[0]["Nombre"].ToString());
                        setApellido(data[0]["Apellido"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("No existe el item, por favor registra al cliente");
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("La cedula ingresada no es correcta.");
                }
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valor, valor2;

                DataRow[] data;
                data = dataSetTienda.TablaProductos.Select("stockProducto='" + textBoxCantidad.Text + "'");
                if (data.Length > 0)
                {
                    valor = Int32.Parse(data.ToString());
                    valor2 = Int32.Parse(textBoxCantidad.ToString());
                    if (valor2 > valor)
                    {
                        MessageBox.Show("supera el stock");
                    }
                    else
                    {
                        MessageBox.Show("no supera el stock");
                    }
                }
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            object[] arrayVenta = new object[6];
            arrayVenta[0] = textBox1.Text;
            arrayVenta[1] = comboBox1.Text;
            arrayVenta[2] = comboBox2.Text;
            arrayVenta[3] = comboBox4.Text;
            arrayVenta[4] = textBoxCantidad.Text;
            arrayVenta[5] = labelValor.Text;
            dataSetTienda.TablaCompra.Rows.Add(arrayVenta);
            dataSetTienda.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            MessageBox.Show("Producto registrado");

        }
    }
}
