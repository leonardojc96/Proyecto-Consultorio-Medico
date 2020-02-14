namespace Proyecto_Consultorio_Medico.Vistas.Plantillas
{
    partial class PlantillaInfo
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
            this.picBoxFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFoto
            // 
            this.picBoxFoto.Location = new System.Drawing.Point(604, 61);
            this.picBoxFoto.Name = "picBoxFoto";
            this.picBoxFoto.Size = new System.Drawing.Size(152, 122);
            this.picBoxFoto.TabIndex = 1;
            this.picBoxFoto.TabStop = false;
            // 
            // PlantillaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 373);
            this.Controls.Add(this.picBoxFoto);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlantillaInfo";
            this.Text = "PlantillaInfo";
            this.Load += new System.EventHandler(this.PlantillaInfo_Load);
            this.Controls.SetChildIndex(this.picBoxFoto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFoto;
    }
}