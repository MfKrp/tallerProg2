namespace Practico5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BFoto = new Button();
            LSexo = new Label();
            LFecha = new Label();
            LApellido = new Label();
            LNombre = new Label();
            BAgregar = new Button();
            pictureBox1 = new PictureBox();
            LSaldo = new Label();
            dateTimePicker1 = new DateTimePicker();
            RHombre = new RadioButton();
            RMujer = new RadioButton();
            textBox3 = new TextBox();
            TSaldo = new TextBox();
            TFoto = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(TFoto);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(RMujer);
            panel1.Controls.Add(RHombre);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(LSaldo);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(LSexo);
            panel1.Controls.Add(LFecha);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(BAgregar);
            panel1.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 270);
            panel1.TabIndex = 0;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(111, 52);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(296, 33);
            TApellido.TabIndex = 8;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(112, 11);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(295, 33);
            TNombre.TabIndex = 7;
            // 
            // BFoto
            // 
            BFoto.Font = new Font("Ink Free", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BFoto.ForeColor = SystemColors.ActiveCaptionText;
            BFoto.Location = new Point(17, 207);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(68, 23);
            BFoto.TabIndex = 6;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = true;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(14, 129);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(60, 26);
            LSexo.TabIndex = 4;
            LSexo.Text = "Sexo:";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(14, 91);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(219, 26);
            LFecha.TabIndex = 3;
            LFecha.Text = "Fecha de Nacimiento:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(14, 52);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(91, 26);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(14, 14);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(92, 26);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre:";
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            BAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(140, 241);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(115, 26);
            BAgregar.TabIndex = 0;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(441, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.Location = new Point(14, 166);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(68, 26);
            LSaldo.TabIndex = 9;
            LSaldo.Text = "Saldo:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Ink Free", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(239, 95);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(93, 21);
            dateTimePicker1.TabIndex = 10;
            // 
            // RHombre
            // 
            RHombre.AutoSize = true;
            RHombre.Font = new Font("Ink Free", 10F, FontStyle.Bold, GraphicsUnit.Point);
            RHombre.Location = new Point(91, 133);
            RHombre.Name = "RHombre";
            RHombre.Size = new Size(77, 22);
            RHombre.TabIndex = 11;
            RHombre.TabStop = true;
            RHombre.Text = "Hombre";
            RHombre.UseVisualStyleBackColor = true;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.Font = new Font("Ink Free", 10F, FontStyle.Bold, GraphicsUnit.Point);
            RMujer.Location = new Point(174, 133);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(64, 22);
            RMujer.TabIndex = 12;
            RMujer.TabStop = true;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(477, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 13;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(91, 163);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(316, 33);
            TSaldo.TabIndex = 14;
            // 
            // TFoto
            // 
            TFoto.Location = new Point(91, 202);
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(316, 33);
            TFoto.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Formulario con Grid";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BFoto;
        private Label LSexo;
        private Label LFecha;
        private Label LApellido;
        private Label LNombre;
        private Button BAgregar;
        private TextBox TApellido;
        private TextBox TNombre;
        private DateTimePicker dateTimePicker1;
        private Label LSaldo;
        private TextBox TFoto;
        private TextBox TSaldo;
        private TextBox textBox3;
        private RadioButton RMujer;
        private RadioButton RHombre;
        private OpenFileDialog openFileDialog1;
    }
}