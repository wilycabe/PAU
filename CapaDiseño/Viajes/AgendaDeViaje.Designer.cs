
namespace CapaDiseño
{
    partial class AgendaDeViaje
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBuscarPersonal = new System.Windows.Forms.DataGridView();
            this.txtBuscarPersonal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaDiseño.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(868, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(203, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Buscar";
            // 
            // dgvBuscarPersonal
            // 
            this.dgvBuscarPersonal.AllowUserToAddRows = false;
            this.dgvBuscarPersonal.AllowUserToDeleteRows = false;
            this.dgvBuscarPersonal.AllowUserToResizeColumns = false;
            this.dgvBuscarPersonal.AllowUserToResizeRows = false;
            this.dgvBuscarPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscarPersonal.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvBuscarPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscarPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarPersonal.Location = new System.Drawing.Point(112, 135);
            this.dgvBuscarPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBuscarPersonal.MultiSelect = false;
            this.dgvBuscarPersonal.Name = "dgvBuscarPersonal";
            this.dgvBuscarPersonal.ReadOnly = true;
            this.dgvBuscarPersonal.RowHeadersVisible = false;
            this.dgvBuscarPersonal.RowHeadersWidth = 51;
            this.dgvBuscarPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBuscarPersonal.RowTemplate.Height = 24;
            this.dgvBuscarPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarPersonal.Size = new System.Drawing.Size(987, 422);
            this.dgvBuscarPersonal.TabIndex = 23;
            // 
            // txtBuscarPersonal
            // 
            this.txtBuscarPersonal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscarPersonal.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPersonal.Location = new System.Drawing.Point(323, 72);
            this.txtBuscarPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPersonal.MaxLength = 10;
            this.txtBuscarPersonal.Multiline = true;
            this.txtBuscarPersonal.Name = "txtBuscarPersonal";
            this.txtBuscarPersonal.Size = new System.Drawing.Size(537, 32);
            this.txtBuscarPersonal.TabIndex = 22;
            this.txtBuscarPersonal.Text = "Ingrese la cedula de un chofer";
            // 
            // AgendaDeViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1208, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBuscarPersonal);
            this.Controls.Add(this.txtBuscarPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgendaDeViaje";
            this.Text = "AgendaDeViaje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuscarPersonal;
        private System.Windows.Forms.TextBox txtBuscarPersonal;
    }
}