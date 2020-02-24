namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    partial class Turnos
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
            this.txtTurnos = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(781, 55);
            // 
            // txtTurnos
            // 
            this.txtTurnos.Enabled = false;
            this.txtTurnos.Location = new System.Drawing.Point(241, 180);
            this.txtTurnos.Name = "txtTurnos";
            this.txtTurnos.Size = new System.Drawing.Size(66, 20);
            this.txtTurnos.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(758, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(187, 186);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 15;
            this.lblTurno.Text = "label2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(57, 187);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Turnos disponibles:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(617, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 28);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Dar turno";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(117, 101);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(158, 21);
            this.cmbEspecialidad.TabIndex = 12;
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(343, 101);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(167, 21);
            this.cmbMedicos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Medicos:";
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 321);
            this.Controls.Add(this.txtTurnos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turnos";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbMedicos, 0);
            this.Controls.SetChildIndex(this.cmbEspecialidad, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.lblTurno, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.txtTurnos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurnos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.Label label1;
    }
}