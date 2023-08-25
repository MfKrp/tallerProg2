namespace Practico2
{
    public partial class Pequeño_Formulario : Form
    {
        public Pequeño_Formulario()
        {
            InitializeComponent();
        }

        private void LModificar_Click(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        } 

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //Se comprueba que alguno de los campos de texto esta vacio
            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "")
            {
                //si no estan completos todos los campos se arroja un mensaje de error
                string mensaje = "Debe completar todos los campos";
                string caption = "Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(mensaje, caption, button);
            } else //si estan todos completos ejecutar lo siguiente
            {
                string message = "Seguro que desea insertar un nuevo cliente?";
                string titulo = "Confirmar Insercion";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado;

                resultado = MessageBox.Show(message, titulo, botones);
                if (resultado == DialogResult.Yes)
                {
                    LModificar.Text = TNombre.Text + " " + TApellido.Text;

                    string mensajeConfirmacion = "El Cliente: " + TNombre.Text + " " + TApellido.Text + " se inserto correctamente";
                    string tituloConfirmacion = "Guardar";
                    MessageBoxButtons botonAceptar = MessageBoxButtons.OK;
                    DialogResult resultadoSi;

                    resultadoSi = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion, botonAceptar);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "")
            {
                //si no estan completos todos los campos se arroja un mensaje de error
                string mensaje = "Debe completar todos los campos";
                string caption = "Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(mensaje, caption, button);
            } else
            {
                string message = "Esta apunto de eliminar el cliente " + TNombre.Text + " " + TApellido.Text;
                string titulo = "Confirmar Eliminacion";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado;

                resultado = MessageBox.Show(message, titulo, botones);
                if (resultado == DialogResult.Yes)
                {

                    string mensajeConfirmacion = "El Cliente: " + TNombre.Text + " " + TApellido.Text + " ha sido eliminado";
                    string tituloConfirmacion = "Eliminar";
                    MessageBoxButtons botonAceptar = MessageBoxButtons.OK;
                    DialogResult resultadoSi;
                   
                    LModificar.Text = "Modificar";
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    
                    resultadoSi = MessageBox.Show(mensajeConfirmacion, tituloConfirmacion, botonAceptar);
                }
            }
        }
    }
}