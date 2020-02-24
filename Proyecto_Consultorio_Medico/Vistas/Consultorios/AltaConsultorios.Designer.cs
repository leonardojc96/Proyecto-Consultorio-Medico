namespace Proyecto_Consultorio_Medico.Vistas.Consultorios
{
    partial class AltaConsultorios
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
            System.Windows.Forms.Label id_EspecialidadLabel;
            System.Windows.Forms.Label nombreLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            id_EspecialidadLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.panelAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlta
            // 
            this.panelAlta.Controls.Add(this.cbEspecialidades);
            this.panelAlta.Controls.Add(id_EspecialidadLabel);
            this.panelAlta.Controls.Add(nombreLabel);
            this.panelAlta.Controls.Add(this.nombreTextBox);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // id_EspecialidadLabel
            // 
            id_EspecialidadLabel.AutoSize = true;
            id_EspecialidadLabel.Location = new System.Drawing.Point(69, 118);
            id_EspecialidadLabel.Name = "id_EspecialidadLabel";
            id_EspecialidadLabel.Size = new System.Drawing.Size(70, 13);
            id_EspecialidadLabel.TabIndex = 0;
            id_EspecialidadLabel.Text = "Especialidad:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(3, 144);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(116, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Numero de consultorio:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(179, 141);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(52, 20);
            this.nombreTextBox.TabIndex = 3;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(179, 110);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(154, 21);
            this.cbEspecialidades.TabIndex = 4;
            // 
            // AltaConsultorios
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(798, 321);
            this.Name = "AltaConsultorios";
            this.Text = "AltaConsultorios";
            this.Load += new System.EventHandler(this.AltaConsultorios_Load);
            this.panelAlta.ResumeLayout(false);
            this.panelAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}