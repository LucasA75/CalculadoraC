
using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operacion = "";
        float resultadoOperacion = 0f;
        string lastOperation = "";
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operacion += "3";
            pantalla.Text = operacion;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operacion += "4";
            pantalla.Text = operacion;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion += "9";
            pantalla.Text = operacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion += "1";
            pantalla.Text = operacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion += "2";
            pantalla.Text = operacion;
        }



        private void button12_Click(object sender, EventArgs e)
        {
            operacion += "5";
            pantalla.Text = operacion;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operacion += "6";
            pantalla.Text = operacion;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacion += "7";
            pantalla.Text = operacion;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion += "8";
            pantalla.Text = operacion;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacion += "0";
            pantalla.Text = operacion;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (operacion.Length > 0)
            {
                string operacionConCaracterEliminado = operacion.Substring(0, operacion.Length - 1);
                operacion = operacionConCaracterEliminado.Trim();
                pantalla.Text = operacion;
            }
            else
            {
                MessageBox.Show("No puedes borrar, porque no hay numeros que borrar");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            operacion += ",";
            pantalla.Text = operacion;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operacion != "")
            {
                resultado.Text = String.Empty;
                actualizarUltimaOperacion(operacion);
                resultadoOperacion = float.Parse(operacion);
                resultado.Text += resultadoOperacion;
                lastOperation = resultadoOperacion.ToString(); ;
                ultimaOperacion.Text = lastOperation;
                limpiarPantalla();
            }
            else
            {
                MessageBox.Show("Ingresa un valor antes");
            }
        }

        private bool textoVacio(string text)
        {
            if(!string.IsNullOrWhiteSpace(text)){
                return true;
            }
            return false;
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            lastOperation = string.Empty;
            resultado.Text = string.Empty;
            resultadoOperacion = 0;
            ultimaOperacion.Text = string.Empty;
        }
        private void limpiarPantalla()
        {
            pantalla.Text = String.Empty;
            operacion = String.Empty;
        }

        private void actualizarUltimaOperacion(string operacion)
        {
            if (Regex.IsMatch(lastOperation, "^[0-9]+$") || lastOperation == "")
            {
                lastOperation += operacion;
                ultimaOperacion.Text = lastOperation;
            }
            else
            {
                ultimaOperacion.Text = $"{resultadoOperacion}{operacion}";
            }
        }
        private void sumar_Click(object sender, EventArgs e)
        {
            if (this.textoVacio(operacion) || resultadoOperacion != 0f)
            {
            resultado.Text = String.Empty;
            actualizarUltimaOperacion($"+{operacion}");
            float suma = sumarNumeros(float.Parse(operacion), resultadoOperacion);
            resultadoOperacion = suma;
            resultado.Text += suma;
            limpiarPantalla();
            }
            else MessageBox.Show("Ingresa un valor porfavor");
          
        }

        private float sumarNumeros(float primerNumero, float segundoNumero)
        {
            return primerNumero + segundoNumero;
        }


        private void restar_Click(object sender, EventArgs e)
        {
            if (this.textoVacio(operacion) || resultadoOperacion != 0f)
            {
                resultado.Text = String.Empty;
                actualizarUltimaOperacion($"-{operacion}");
                float resta = restarNumeros(resultadoOperacion, float.Parse(operacion));
                resultadoOperacion = resta;
                resultado.Text += resta;
                limpiarPantalla();
            }
            else MessageBox.Show("Ingresa un valor porfavor");
        }

        private float restarNumeros(float primerNumero, float segundoNumero)
        {
            return primerNumero - segundoNumero;
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (this.textoVacio(operacion) || resultadoOperacion != 0f)
            {
                resultado.Text = String.Empty;
                actualizarUltimaOperacion($"*{operacion}");
                float multiplicacion = multiplicarNumeros(float.Parse(operacion), resultadoOperacion);
                resultadoOperacion = multiplicacion;
                resultado.Text += multiplicacion;
                limpiarPantalla();
            }
            else
            {
                MessageBox.Show("Ingresa un valor para multiplicar antes");
            }
        }

        private float multiplicarNumeros(float primerNumero, float segundoNumero)
        {
            return primerNumero * segundoNumero;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            if (resultadoOperacion != 0 && operacion != "0" && this.textoVacio(operacion) || resultadoOperacion != 0f)
            {
                resultado.Text = String.Empty;
                actualizarUltimaOperacion($"/{operacion}");
                float division = dividirNumeros(resultadoOperacion, float.Parse(operacion));
                resultadoOperacion = division;
                resultado.Text += division;
                limpiarPantalla();
            }
            else
            {
                MessageBox.Show("Ingresa un valor para dividir antes");
            }
        }

        private float dividirNumeros(float primerNumero, float segundoNumero)
        {
            return primerNumero / segundoNumero;
        }

    }
}