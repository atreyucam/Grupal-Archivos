using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinnFormularioCliente
{
    public partial class Cliente : Form
    {
        string cant;
        int cat;

        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml("C:\\Users\\59399\\source\\repos\\WinnFormularioCliente\\Archivo.xml");
            object[] vec = new object[10];
            vec[0] = txtNombre.Text;
            vec[1] = txtApellido.Text;
            vec[2] = txtCedula.Text;
            vec[3] = cmbCiudad.Text;
            vec[4] = cmbEdad.Text;
            vec[5] = txtDireccion.Text;
            vec[6] = txtFecha.Text;
            vec[7] = txtCorreo.Text;
            vec[8] = cmbGenero.Text;
            vec[9] = txtCedula.Text;
            dataSet11.TblDatos.Rows.Add(vec);
            dataSet11.WriteXml("C:\\Users\\59399\\source\\repos\\WinnFormularioCliente\\Archivo.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presentacion objPre = new presentacion();
              objPre.ShowDialog();
            
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                
            }
            
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

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
                    MessageBox.Show("Falso");
                }
            }

            

        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

                var rgx = new Regex(@"^[0-9]{10}$");
                if (rgx.IsMatch(txtCedula.Text))
                {
                    MessageBox.Show("Numero Ecuatoriano");
                }
                else
                {
                    MessageBox.Show("Ningun numero ecuatoriano ");
                }
            }
        }
    }
}
