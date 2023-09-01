using System.Windows.Forms;

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
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.png|Todos los archivos|*.*";
            openFileDialog1.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openFileDialog1.FileName))
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;

                //ajusta el tamaño de la imagen en el picturebox
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                TFoto.Text = Path.GetFileName(openFileDialog1.FileName);
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

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
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

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //Esta funcion se encarga de agregar los datos de los campos a los registros del datagrid
            //Comprueba que ninguno de los campos este vacio
            //Si lo esta muestra una ventana que dice que se deben completar todos los campos
            if (TNombre.Text == "" || TApellido.Text == "" || TSaldo.Text == "" || TFoto.Text == "" || !RHombre.Checked && !RMujer.Checked)
            {
                string mensaje = "Complete todos los campos para continuar";
                string caption = "Campos sin completar";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                DialogResult resultado;
                resultado = MessageBox.Show(mensaje, caption, boton);
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                //se agregan los elementos a la fila
                dataGridView1.Rows[n].Cells[0].Value = TNombre.Text;
                dataGridView1.Rows[n].Cells[1].Value = TApellido.Text;
                dataGridView1.Rows[n].Cells[2].Value = dateTimePicker1.Text;


                if (RHombre.Checked)
                {
                    dataGridView1.Rows[n].Cells[3].Value = RHombre.Text;
                }
                else
                {
                    dataGridView1.Rows[n].Cells[3].Value = RMujer.Text;
                }

                //se crea el boton eliminar
                DataGridViewButtonCell botonBorrar = new DataGridViewButtonCell();
                botonBorrar.Value = "Eliminar";
                dataGridView1.Rows[n].Cells[4] = botonBorrar;

                dataGridView1.Rows[n].Cells[5].Value = TSaldo.Text;

                string saldo = TSaldo.Text;

                /*Codigo para generar para extraer la imagen y colocarla en la celda*/
                if (pictureBox1.Image != null)
                {
                    int thumbnailWidth = 80; //ancho de miniatura
                    int thumbnailHeight = 80; //altura de la miniatura

                    //se crea una miniatura del formulario 
                    Image thumbnail = pictureBox1.Image.GetThumbnailImage(thumbnailWidth, thumbnailHeight, null, IntPtr.Zero);

                    //crear una instancia de datagridviewimagecell
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();

                    //asignar la imagen en miniatura a la celda de la imagen
                    imageCell.Value = thumbnail;

                    dataGridView1.Rows[n].Cells[6] = imageCell;
                }

                dataGridView1.Rows[n].Cells[7].Value = TFoto.Text;

                //Cambia el color de la fila si el saldo es menor a 50
                decimal saldoNumero;
                if (decimal.TryParse(TSaldo.Text, out saldoNumero))
                {
                    if (saldoNumero < 50)
                    {
                        dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                //se limpian los text boxs
                TNombre.Clear();
                TApellido.Clear();
                dateTimePicker1.ResetText();
                TSaldo.Clear();
                TFoto.Clear();

                //
                string rutaImagen = "C:\\Users\\User\\source\\repos\\tallerProg2\\Practico5\\Practico5\\Practico5\\bin\\Debug\\Fotos\\milanesaa.png";
                pictureBox1.Image = Image.FromFile(rutaImagen);

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();

            }
        }

        private void TSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //se acepta un solo punto decimal en el campo de saldo
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Estas seguro que deseas borrar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}