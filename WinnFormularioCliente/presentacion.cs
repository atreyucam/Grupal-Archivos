using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinnFormularioCliente
{
    public partial class presentacion : Form
    {
        public presentacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml("C:\\Users\\59399\\source\\repos\\WinnFormularioCliente\\Archivo.xml");
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            dataSet1.ReadXml("C:\\Users\\59399\\source\\repos\\WinnFormularioCliente\\Archivo.xml");
        }
    }
}
