
namespace CapaDiseño.Reportes.Form_Reportes_Secundarios
{
    partial class FormReporteUsuario
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
            this.dataSetPrincipal = new CapaDiseño.Reportes.Form_Reportes_Secundarios.DataSetPrincipal();
            this.Reporte_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_usuarioTableAdapter = new CapaDiseño.Reportes.Form_Reportes_Secundarios.DataSetPrincipalTableAdapters.Reporte_usuarioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_usuarioBindingSource
            // 
            this.Reporte_usuarioBindingSource.DataMember = "Reporte_usuario";
            this.Reporte_usuarioBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // Reporte_usuarioTableAdapter
            // 
            this.Reporte_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSUsuario";
            reportDataSource1.Value = this.Reporte_usuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDiseño.Reportes.RDLC.Usuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteUsuario";
            this.Text = "Reporte de Usuario";
            this.Load += new System.EventHandler(this.FormReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource Reporte_usuarioBindingSource;
        private DataSetPrincipalTableAdapters.Reporte_usuarioTableAdapter Reporte_usuarioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}