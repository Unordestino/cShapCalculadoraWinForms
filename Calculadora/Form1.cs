using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        double total;
        double ultimoNumero;
        string operador;

        private void Limpar() {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            txtresult.Text = "0";
        }

        private void Calcular() {
            switch (operador) {
                case "+":
                    total += ultimoNumero;
                    break;

                case "-":
                    total -= ultimoNumero;
                    break;

                case "/":
                    total /= ultimoNumero;
                    break;

                case "X":
                    total *= ultimoNumero;
                    break;
            }

            ultimoNumero = 0;
            txtresult.Text = total.ToString();

        }

        public Form1() {
            InitializeComponent();
            Limpar();
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            Limpar();
        }

        private void gerarNumero(object sender, EventArgs e) {
            if (ultimoNumero == 0) {
                txtresult.Text = (sender as Button).Text;
            } else {
                txtresult.Text += (sender as Button).Text;
            }
            ultimoNumero = Convert.ToDouble(txtresult.Text);
        }

        private void operadores(object sender, EventArgs e) {
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = (sender as Button).Text;
        }

        private void btResult_Click(object sender, EventArgs e) {
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = "+";
            total = 0;
        }
    }
}
