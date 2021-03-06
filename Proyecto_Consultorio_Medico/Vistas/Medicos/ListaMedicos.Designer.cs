﻿namespace Proyecto_Consultorio_Medico.Vistas.Medicos
{
    partial class ListaMedicos
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
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbFiltroEspecialidades = new System.Windows.Forms.ComboBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Size = new System.Drawing.Size(58, 19);
            // 
            // panelHeader
            // 
            this.panelHeader.Size = new System.Drawing.Size(785, 55);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(45, 109);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(35, 13);
            this.lblFiltrar.TabIndex = 8;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // cbFiltroEspecialidades
            // 
            this.cbFiltroEspecialidades.FormattingEnabled = true;
            this.cbFiltroEspecialidades.Location = new System.Drawing.Point(113, 106);
            this.cbFiltroEspecialidades.Name = "cbFiltroEspecialidades";
            this.cbFiltroEspecialidades.Size = new System.Drawing.Size(209, 21);
            this.cbFiltroEspecialidades.TabIndex = 9;
            this.cbFiltroEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cbFiltroEspecialidades_SelectedIndexChanged);
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(405, 123);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(129, 13);
            this.lblDetalles.TabIndex = 10;
            this.lblDetalles.Text = "(Doble click para detalles)";
            // 
            // ListaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(785, 321);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.cbFiltroEspecialidades);
            this.Controls.Add(this.lblFiltrar);
            this.Name = "ListaMedicos";
            this.Text = "ListaMedicos";
            this.Load += new System.EventHandler(this.ListaMedicos_Load);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblFiltrar, 0);
            this.Controls.SetChildIndex(this.cbFiltroEspecialidades, 0);
            this.Controls.SetChildIndex(this.lblDetalles, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbFiltroEspecialidades;
        private System.Windows.Forms.Label lblDetalles;
    }
}