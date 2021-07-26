
namespace CapaDiseño.Reportes.Form_Reportes_Secundarios
{
    partial class FormReporteChofer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_choferTableAdapter = new CapaDiseño.Reportes.Form_Reportes_Secundarios.DataSetPrincipalTableAdapters.Reporte_choferTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_choferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSChofer";
            reportDataSource1.Value = this.Reporte_choferBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDiseño.Reportes.RDLC.Chofer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_choferBindingSource
            // 
            this.Reporte_choferBindingSource.DataMember = "Reporte_chofer";
            this.Reporte_choferBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // Reporte_choferTableAdapter
            // 
            this.Reporte_choferTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteChofer";
            this.Text = "Reporte de Chofer";
            this.Load += new System.EventHandler(this.FormReporteChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_choferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource Reporte_choferBindingSource;
        private DataSetPrincipalTableAdapters.Reporte_choferTableAdapter Reporte_choferTableAdapter;
    }
}