namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null)
            {
                TFoto.Text = pictureBox1.ImageLocation;
            }
        }

        private void TFoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_Leave(object sender, EventArgs e)
        {
            if (TNombre.Text != "")
            {
                string text = TNombre.Text;
                string primeraLetra = text.Substring(0, 1).ToUpper() + text.Substring(1);
                TNombre.Text = primeraLetra;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_Leave(object sender, EventArgs e)
        {
            /*Metodo substring
                SubString (donde empezar, longitud de extraccion)
             */
            if (TApellido.Text != "")
            {
                string text = TApellido.Text;
                string primeraLetra = text.Substring(0, 1).ToUpper() + text.Substring(1);
                TApellido.Text = primeraLetra;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //Esta funcion se encarga de agregar los datos de los campos a los registros del datagrid
            //Comprueba que ninguno de los campos este vacio
            //Si lo esta muestra una ventana que dice que se deben completar todos los campos
            if (TNombre.Text == "" || TApellido.Text == "" || TSaldo.Text == "" || TFoto.Text == "")
            {
                string mensaje = "Complete todos los campos para continuar";
                string caption = "Campos sin completar";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                DialogResult resultado;
                resultado = MessageBox.Show(mensaje, caption, boton);
            }
            else
            {
                string nombre = TNombre.Text;
                string apellido = TApellido.Text;
                string fecha = dateTimePicker1.Value.ToString();
                string sexo;
                if (RHombre.Checked)
                {
                    sexo = RHombre.Text;
                }
                else
                {
                    sexo = RMujer.Text;
                }
                string saldo = TSaldo.Text;
                string rutaFoto = TFoto.Text;

                //codigo para generar la imagen y colocarla en el datagrid
                Bitmap img;
                img = new Bitmap(@"C:\Users\matias\source\repos\Practico5\Practico5\bin\Debug\Fotos\milanesaa.png");

                DataGridView dgv = new DataGridView();
                this.Controls.Add(dgv);
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

                string[] row = { nombre, apellido, fecha, sexo, "eliminar", img,saldo, rutaFoto};
                dataGridView1.Rows.Add(row);
            }
        }

        private void TSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}