namespace Proyecto_Consultorio_Medico.Vistas.TurnosGenerales
{
    partial class TurnosGeneral
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
            this.dgvTurnosGen = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosGen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(1370, 55);
            // 
            // dgvTurnosGen
            // 
            this.dgvTurnosGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosGen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medico,
            this.Consultorio,
            this.Especialidad});
            this.dgvTurnosGen.Location = new System.Drawing.Point(275, 145);
            this.dgvTurnosGen.Name = "dgvTurnosGen";
            this.dgvTurnosGen.Size = new System.Drawing.Size(576, 340);
            this.dgvTurnosGen.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Medico
            // 
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            // 
            // Consultorio
            // 
            this.Consultorio.HeaderText = "Consultorio";
            this.Consultorio.Name = "Consultorio";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(577, 583);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TurnosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 892);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTurnosGen);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TurnosGeneral";
            this.Text = "TurnosGeneral";
            this.Load += new System.EventHandler(this.TurnosGeneral_Load);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.dgvTurnosGen, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosGen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.Button btnSalir;
    }
}