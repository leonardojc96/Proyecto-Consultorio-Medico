using System;
using System.Windows.Forms;

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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantTurnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(1395, 55);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(758, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(617, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 28);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Dar turno";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(117, 101);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(158, 21);
            this.cmbEspecialidad.TabIndex = 12;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
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
            // dgvMedicos
            // 
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaApellido,
            this.ColumnaCantTurnos,
            this.ColumnaId});
            this.dgvMedicos.Location = new System.Drawing.Point(577, 74);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(625, 238);
            this.dgvMedicos.TabIndex = 18;
            this.dgvMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellClick);
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            // 
            // ColumnaApellido
            // 
            this.ColumnaApellido.HeaderText = "Apellido";
            this.ColumnaApellido.Name = "ColumnaApellido";
            // 
            // ColumnaCantTurnos
            // 
            this.ColumnaCantTurnos.HeaderText = "C. de Turnos";
            this.ColumnaCantTurnos.Name = "ColumnaCantTurnos";
            // 
            // ColumnaId
            // 
            this.ColumnaId.HeaderText = "N° identificacion";
            this.ColumnaId.Name = "ColumnaId";
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 892);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turnos";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbEspecialidad, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.dgvMedicos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaId;
    }
}