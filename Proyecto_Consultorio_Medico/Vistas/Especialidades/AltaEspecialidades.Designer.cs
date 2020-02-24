namespace Proyecto_Consultorio_Medico.Vistas.Especialidades
{
    partial class AltaEspecialidades
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
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // panelHeader
            // 
            this.panelHeader.Size = new System.Drawing.Size(781, 55);
            // 
            // AltaEspecialidades
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(781, 321);
            this.Name = "AltaEspecialidades";
            this.Text = "AltaEspecialidades";
            this.Load += new System.EventHandler(this.AltaEspecialidades_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}