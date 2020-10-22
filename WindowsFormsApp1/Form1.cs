using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Calculadora : Form
    {
        double numero1, numero2, resultado;
        bool banderanumero1 = false;
        //bool banderanumero2 = false;
        bool banderaOperacion = false;
        string operacionSeleccionada;


        public Calculadora()
        {
            InitializeComponent();
        }

        private double Operacion (string operacion) 
        {
            double resultado = 0.0;

            switch (operacion)
            {   
                case "suma":
                    resultado = numero1 + numero2;
                    break;

                case "resta":
                    resultado = numero1 - numero2;
                    break;

                case "multiplicacion":
                    resultado = numero1 * numero2;
                    break;

                case "division":
                    resultado = numero1 / numero2;
                    break;
            }
            return resultado;
        
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "0";
            }
            else { 
            tbpantalla.Text = tbpantalla.Text = "0";
            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "1";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "1";
            }
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "2";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "2";
            }
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "3";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "3";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "4";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "4";
            }

        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "5";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "5";
            }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "6";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "6";
            }
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "7";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "7";
            }
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "8";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "8";
            }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (tbpantalla.Text == "")
            {
                tbpantalla.Text = "9";
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text + "9";
            }
        }

        private void MENOS_Click(object sender, EventArgs e)
        {
            if (!banderanumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbpantalla.Text);
                tbpantalla.Text = "";
                banderanumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "resta";
            }
            
        }

        private void SUMA_Click(object sender, EventArgs e)
        {
            if (!banderanumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbpantalla.Text);
                tbpantalla.Text = "";
                banderanumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "suma";
            }
            
        }

        private void MULTIPLICACION_Click(object sender, EventArgs e)
        {
            if (!banderanumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbpantalla.Text);
                tbpantalla.Text = "";
                banderanumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "multiplicacion";
            }
           
        }

        private void DIVISION_Click(object sender, EventArgs e)
        {
            if (!banderanumero1 && !banderaOperacion)
            {
                numero1 = Convert.ToDouble(tbpantalla.Text);
                tbpantalla.Text = "";
                banderanumero1 = true;
                banderaOperacion = true;
                operacionSeleccionada = "division";
            }
           
        }

        private void BTNCLEAR_Click(object sender, EventArgs e)
        {
            tbpantalla.Text = "";
            limpiar();
            
        }

        private void limpiar ()
        {
            banderanumero1 = false;
            banderaOperacion = false;
            tbpantalla.Text = "";
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            if (banderanumero1 && banderaOperacion) 
            {
                numero2 = Convert.ToDouble(tbpantalla.Text);
                resultado = Operacion(operacionSeleccionada);
                tbpantalla.Text = resultado.ToString();
                
            }


        }



        private void tbpantalla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
