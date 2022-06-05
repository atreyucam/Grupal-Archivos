﻿using System;
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
    public partial class FormMainLogin : Form
    {
        public FormMainLogin()
        {
            InitializeComponent();
            dataSetTienda1.WriteXml(Application.StartupPath + "datosTiendaAseoPersonal");
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new FormRol();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new FormRol();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ventana);
            panelMain.Tag = ventana;
            ventana.Show();
        }
    }
}
