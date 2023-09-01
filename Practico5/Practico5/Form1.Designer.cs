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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            TFoto = new TextBox();
            TSaldo = new TextBox();
            textBox3 = new TextBox();
            RMujer = new RadioButton();
            RHombre = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            LSaldo = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BFoto = new Button();
            LSexo = new Label();
            LFecha = new Label();
            LApellido = new Label();
            LNombre = new Label();
            BAgregar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Fecha_Nacimientro = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // TFoto
            // 
            TFoto.Location = new Point(91, 202);
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(316, 33);
            TFoto.TabIndex = 15;
            TFoto.TextChanged += TFoto_TextChanged;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(91, 163);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(316, 33);
            TSaldo.TabIndex = 14;
            TSaldo.TextChanged += TSaldo_TextChanged;
            TSaldo.KeyPress += TSaldo_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(477, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 13;
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
            RMujer.CheckedChanged += RMujer_CheckedChanged;
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
            RHombre.CheckedChanged += RHombre_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Ink Free", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(239, 95);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(93, 21);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
            // TApellido
            // 
            TApellido.Location = new Point(111, 52);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(296, 33);
            TApellido.TabIndex = 8;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            TApellido.Leave += TApellido_Leave;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(112, 11);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(295, 33);
            TNombre.TabIndex = 7;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            TNombre.Leave += TNombre_Leave;
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
            BFoto.Click += BFoto_Click;
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
            BAgregar.Text = "Guardar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\User\\source\\repos\\tallerProg2\\Practico5\\Practico5\\Practico5\\bin\\Debug\\Fotos\\milanesaa.png";
            pictureBox1.Location = new Point(441, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Fecha_Nacimientro, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 157);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle1.Font = new Font("Impact", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Apellido.DefaultCellStyle = dataGridViewCellStyle1;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Fecha_Nacimientro
            // 
            Fecha_Nacimientro.HeaderText = "Fecha Nacimiento";
            Fecha_Nacimientro.Name = "Fecha_Nacimientro";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
            Eliminar.ToolTipText = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Formulario con Grid";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Fecha_Nacimientro;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}