
namespace CapaDiseño
{
    partial class BuscarDatosPersonal
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
            this.dgvBuscarPersonal = new System.Windows.Forms.DataGridView();
            this.txtBuscarPersonal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dgvBuscarPersonal.Location = new System.Drawing.Point(117, 118);
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
            this.dgvBuscarPersonal.TabIndex = 10;
            // 
            // txtBuscarPersonal
            // 
            this.txtBuscarPersonal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscarPersonal.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPersonal.Location = new System.Drawing.Point(328, 55);
            this.txtBuscarPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPersonal.MaxLength = 10;
            this.txtBuscarPersonal.Multiline = true;
            this.txtBuscarPersonal.Name = "txtBuscarPersonal";
            this.txtBuscarPersonal.Size = new System.Drawing.Size(537, 32);
            this.txtBuscarPersonal.TabIndex = 9;
            this.txtBuscarPersonal.Text = "Ingrese la cedula de un chofer";
            this.txtBuscarPersonal.Enter += new System.EventHandler(this.txtBuscarPersonal_Enter);
            this.txtBuscarPersonal.Leave += new System.EventHandler(this.txtBuscarPersonal_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(539, 580);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 37);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(210, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaDiseño.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(873, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BuscarDatosPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1208, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvBuscarPersonal);
            this.Controls.Add(this.txtBuscarPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarDatosPersonal";
            this.Text = "BuscarDatosPersonal";
            this.Load += new System.EventHandler(this.BuscarDatosPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBuscarPersonal;
        private System.Windows.Forms.TextBox txtBuscarPersonal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}