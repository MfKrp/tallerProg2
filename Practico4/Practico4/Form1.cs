using System.Diagnostics.Eventing.Reader;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Funcion que lista los numeros sin ninguna restriccion
        private void BFunction_Click(object sender, EventArgs e)
        {
            LBLista.Items.Clear();
            //comprobacion de que los textbox no estan vacios
            if (TDesde.Text == "" || THasta.Text == "")
            {
                string message = "Completa todos los campos para continuar";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                int inicio = Int32.Parse(TDesde.Text);
                int final = Int32.Parse(THasta.Text);

                for (int i = inicio; i <= final; i++) //ciclo para recorrer
                {
                    LBLista.Items.Add(i);
                }
            }
        }

        private void TDesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void THasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void LBLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //funcion que lista los numeros impares en un rango determinado
        private void BImpares_Click(object sender, EventArgs e)
        {
            LBLista.Items.Clear();
            //comprobacion de que los textbox no estan vacios
            if (TDesde.Text == "" || THasta.Text == "")
            {
                string message = "Completa todos los campos para continuar";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                int inicio = Int32.Parse(TDesde.Text);
                int final = Int32.Parse(THasta.Text);

                for (int i = inicio; i <= final; i++) //ciclo para recorrer
                {
                    if ((i%2) != 0)
                    {
                        LBLista.Items.Add(i);
                    }
                }
            }
        }

        //funcion que lista los numeros primos en un rango definido
        private void BPrimos_Click(object sender, EventArgs e)
        {
            LBLista.Items.Clear();
            //comprobacion de que los textbox no estan vacios
            if (TDesde.Text == "" || THasta.Text == "")
            {
                string message = "Completa todos los campos para continuar";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                int inicio = Int32.Parse(TDesde.Text);
                int final = Int32.Parse(THasta.Text);
                int flag;

                for (int i = inicio; i <= final; i++)
                {
                    if (i == 1 || i == 0)
                        continue;

                    flag = 1;

                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }

                    if (flag == 1)
                    {
                        LBLista.Items.Add(i);
                    }
                }
            }
        }

        //funcion que lista los numeros pares en un rango definido
        private void BPares_Click(object sender, EventArgs e)
        {
            LBLista.Items.Clear();
            //comprobacion de que los textbox no estan vacios
            if (TDesde.Text == "" || THasta.Text == "")
            {
                string message = "Completa todos los campos para continuar";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                int inicio = Int32.Parse(TDesde.Text);
                int final = Int32.Parse(THasta.Text);

                for (int i = inicio; i <= final; i++) //ciclo para recorrer
                {
                    if ( (i % 2) == 0)
                    {
                        LBLista.Items.Add(i);
                    }
                }
            }
        }
    }
}