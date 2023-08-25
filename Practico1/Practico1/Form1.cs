namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = TNombre.Text + " " + TApellido.Text;
            TMulti.Text = respuesta;
        }

        private void TMulti_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            TNombre.Clear();
            TApellido.Clear();
            TMulti.Clear();
        }
    }
}