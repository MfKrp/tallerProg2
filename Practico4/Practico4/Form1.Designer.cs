namespace Practico4
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
            LBLista = new ListBox();
            LDesde = new Label();
            LHasta = new Label();
            BLista = new Label();
            BFunction = new Button();
            TDesde = new TextBox();
            THasta = new TextBox();
            BPares = new Button();
            BImpares = new Button();
            BPrimos = new Button();
            SuspendLayout();
            // 
            // LBLista
            // 
            LBLista.FormattingEnabled = true;
            LBLista.ItemHeight = 15;
            LBLista.Location = new Point(208, 42);
            LBLista.Name = "LBLista";
            LBLista.Size = new Size(344, 274);
            LBLista.TabIndex = 0;
            LBLista.SelectedIndexChanged += LBLista_SelectedIndexChanged;
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(30, 45);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 1;
            LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(30, 106);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 2;
            LHasta.Text = "Hasta";
            // 
            // BLista
            // 
            BLista.AutoSize = true;
            BLista.Location = new Point(334, 24);
            BLista.Name = "BLista";
            BLista.Size = new Size(99, 15);
            BLista.TabIndex = 3;
            BLista.Text = "Lista de Numeros";
            // 
            // BFunction
            // 
            BFunction.Location = new Point(30, 146);
            BFunction.Name = "BFunction";
            BFunction.Size = new Size(172, 23);
            BFunction.TabIndex = 4;
            BFunction.Text = "Generar Funcion";
            BFunction.UseVisualStyleBackColor = true;
            BFunction.Click += BFunction_Click;
            // 
            // TDesde
            // 
            TDesde.Location = new Point(75, 42);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(127, 23);
            TDesde.TabIndex = 5;
            TDesde.TextChanged += TDesde_TextChanged;
            // 
            // THasta
            // 
            THasta.Location = new Point(73, 103);
            THasta.Name = "THasta";
            THasta.Size = new Size(129, 23);
            THasta.TabIndex = 6;
            THasta.TextChanged += THasta_TextChanged;
            // 
            // BPares
            // 
            BPares.Location = new Point(30, 188);
            BPares.Name = "BPares";
            BPares.Size = new Size(172, 23);
            BPares.TabIndex = 7;
            BPares.Text = "Numeros Pares";
            BPares.UseVisualStyleBackColor = true;
            BPares.Click += BPares_Click;
            // 
            // BImpares
            // 
            BImpares.Location = new Point(30, 227);
            BImpares.Name = "BImpares";
            BImpares.Size = new Size(172, 23);
            BImpares.TabIndex = 8;
            BImpares.Text = "Numeros Impares";
            BImpares.UseVisualStyleBackColor = true;
            BImpares.Click += BImpares_Click;
            // 
            // BPrimos
            // 
            BPrimos.Location = new Point(30, 267);
            BPrimos.Name = "BPrimos";
            BPrimos.Size = new Size(172, 23);
            BPrimos.TabIndex = 9;
            BPrimos.Text = "Numeros Primos";
            BPrimos.UseVisualStyleBackColor = true;
            BPrimos.Click += BPrimos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 336);
            Controls.Add(BPrimos);
            Controls.Add(BImpares);
            Controls.Add(BPares);
            Controls.Add(THasta);
            Controls.Add(TDesde);
            Controls.Add(BFunction);
            Controls.Add(BLista);
            Controls.Add(LHasta);
            Controls.Add(LDesde);
            Controls.Add(LBLista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LBLista;
        private Label LDesde;
        private Label LHasta;
        private Label BLista;
        private Button BFunction;
        private TextBox TDesde;
        private TextBox THasta;
        private Button BPares;
        private Button BImpares;
        private Button BPrimos;
    }
}