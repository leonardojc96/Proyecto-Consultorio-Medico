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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(876, 55);
            // 
            // picBoxFoto
            // 
            this.picBoxFoto.Location = new System.Drawing.Point(12, 61);
            this.picBoxFoto.Name = "picBoxFoto";
            this.picBoxFoto.Size = new System.Drawing.Size(152, 122);
            this.picBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFoto.TabIndex = 1;
            this.picBoxFoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PlantillaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBoxFoto);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlantillaInfo";
            this.Text = "PlantillaInfo";
            this.Load += new System.EventHandler(this.PlantillaInfo_Load);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.picBoxFoto, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBoxFoto;
        private System.Windows.Forms.Button button1;
    }
}