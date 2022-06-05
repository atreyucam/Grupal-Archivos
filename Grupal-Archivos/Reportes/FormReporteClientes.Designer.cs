namespace Grupal_Archivos.Reportes
{
    partial class FormReporteClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetTienda = new Grupal_Archivos.DataSetTienda();
            this.tablaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Grupal_Archivos.Reportes.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1243, 975);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetTienda
            // 
            this.dataSetTienda.DataSetName = "DataSetTienda";
            this.dataSetTienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaClientesBindingSource
            // 
            this.tablaClientesBindingSource.DataMember = "TablaClientes";
            this.tablaClientesBindingSource.DataSource = this.dataSetTienda;
            // 
            // FormReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 975);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteClientes";
            this.Text = "FormReporteClientes";
            this.Load += new System.EventHandler(this.FormReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tablaClientesBindingSource;
        private DataSetTienda dataSetTienda;
    }
}