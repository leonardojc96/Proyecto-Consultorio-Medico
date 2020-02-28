namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    partial class AltaPacientes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label obraSocialLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label ultimaVisitaLabel;
            System.Windows.Forms.Label detallesLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.obraSocialTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.ultimaVisitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            obraSocialLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ultimaVisitaLabel = new System.Windows.Forms.Label();
            detallesLabel = new System.Windows.Forms.Label();
            this.panelAlta.SuspendLayout();
            this.panelLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlta
            // 
            this.panelAlta.Controls.Add(this.fechaIngresoDateTimePicker);
            this.panelAlta.Location = new System.Drawing.Point(115, 61);
            this.panelAlta.Size = new System.Drawing.Size(230, 175);
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
            this.btnEliminar.Location = new System.Drawing.Point(200, 524);
            // 
            // panelHeader
            // 
            this.panelHeader.Size = new System.Drawing.Size(749, 55);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(17, 18);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(31, 123);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 12;
            apellidoLabel.Text = "Apellido:";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new System.Drawing.Point(4, 170);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(63, 13);
            fechaNacLabel.TabIndex = 14;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(4, 126);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(78, 13);
            fechaIngresoLabel.TabIndex = 16;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(31, 149);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 18;
            dNILabel.Text = "DNI:";
            // 
            // obraSocialLabel
            // 
            obraSocialLabel.AutoSize = true;
            obraSocialLabel.Location = new System.Drawing.Point(4, 195);
            obraSocialLabel.Name = "obraSocialLabel";
            obraSocialLabel.Size = new System.Drawing.Size(65, 13);
            obraSocialLabel.TabIndex = 20;
            obraSocialLabel.Text = "Obra Social:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(31, 175);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 22;
            telefonoLabel.Text = "Telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(4, 223);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 24;
            direccionLabel.Text = "Direccion:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(4, 249);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 26;
            fotoLabel.Text = "Foto:";
            // 
            // ultimaVisitaLabel
            // 
            ultimaVisitaLabel.AutoSize = true;
            ultimaVisitaLabel.Location = new System.Drawing.Point(4, 276);
            ultimaVisitaLabel.Name = "ultimaVisitaLabel";
            ultimaVisitaLabel.Size = new System.Drawing.Size(67, 13);
            ultimaVisitaLabel.TabIndex = 28;
            ultimaVisitaLabel.Text = "Ultima Visita:";
            // 
            // detallesLabel
            // 
            detallesLabel.AutoSize = true;
            detallesLabel.Location = new System.Drawing.Point(4, 301);
            detallesLabel.Name = "detallesLabel";
            detallesLabel.Size = new System.Drawing.Size(48, 13);
            detallesLabel.TabIndex = 30;
            detallesLabel.Text = "Detalles:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(115, 94);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(115, 120);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 13;
            // 
            // fechaNacDateTimePicker
            // 
            this.fechaNacDateTimePicker.Location = new System.Drawing.Point(115, 241);
            this.fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            this.fechaNacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacDateTimePicker.TabIndex = 15;
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(0, 137);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 17;
            // 
            // dNITextBox
            // 
            this.dNITextBox.Location = new System.Drawing.Point(115, 146);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(200, 20);
            this.dNITextBox.TabIndex = 19;
            // 
            // obraSocialTextBox
            // 
            this.obraSocialTextBox.Location = new System.Drawing.Point(115, 267);
            this.obraSocialTextBox.Name = "obraSocialTextBox";
            this.obraSocialTextBox.Size = new System.Drawing.Size(200, 20);
            this.obraSocialTextBox.TabIndex = 21;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(115, 172);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 23;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(115, 295);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 25;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.Location = new System.Drawing.Point(115, 321);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(167, 20);
            this.fotoTextBox.TabIndex = 27;
            // 
            // ultimaVisitaDateTimePicker
            // 
            this.ultimaVisitaDateTimePicker.Location = new System.Drawing.Point(115, 347);
            this.ultimaVisitaDateTimePicker.Name = "ultimaVisitaDateTimePicker";
            this.ultimaVisitaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ultimaVisitaDateTimePicker.TabIndex = 29;
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(fechaNacLabel);
            this.panelLabels.Controls.Add(fechaIngresoLabel);
            this.panelLabels.Controls.Add(obraSocialLabel);
            this.panelLabels.Controls.Add(direccionLabel);
            this.panelLabels.Controls.Add(detallesLabel);
            this.panelLabels.Controls.Add(fotoLabel);
            this.panelLabels.Controls.Add(ultimaVisitaLabel);
            this.panelLabels.Controls.Add(nombreLabel);
            this.panelLabels.Location = new System.Drawing.Point(14, 79);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(97, 335);
            this.panelLabels.TabIndex = 32;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(117, 380);
            this.richTextBox1.MaxLength = 150;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 101);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(288, 319);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(34, 23);
            this.btnFoto.TabIndex = 34;
            this.btnFoto.Text = "...";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(382, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 157);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // AltaPacientes
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(766, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(this.ultimaVisitaDateTimePicker);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.fotoTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.fechaNacDateTimePicker);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.obraSocialTextBox);
            this.Controls.Add(this.panelLabels);
            this.Name = "AltaPacientes";
            this.Text = "AltaPacientes";
            this.Load += new System.EventHandler(this.AltaPacientes_Load);
            this.Controls.SetChildIndex(this.panelLabels, 0);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.panelAlta, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.obraSocialTextBox, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(apellidoLabel, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(this.apellidoTextBox, 0);
            this.Controls.SetChildIndex(this.fechaNacDateTimePicker, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(this.telefonoTextBox, 0);
            this.Controls.SetChildIndex(this.fotoTextBox, 0);
            this.Controls.SetChildIndex(telefonoLabel, 0);
            this.Controls.SetChildIndex(this.ultimaVisitaDateTimePicker, 0);
            this.Controls.SetChildIndex(this.dNITextBox, 0);
            this.Controls.SetChildIndex(dNILabel, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.btnFoto, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panelAlta.ResumeLayout(false);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacDateTimePicker;
        private System.Windows.Forms.TextBox obraSocialTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox fotoTextBox;
        private System.Windows.Forms.DateTimePicker ultimaVisitaDateTimePicker;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}