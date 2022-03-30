using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Peso;
        double Altura;
        double Resultado;

        private void mskboxAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskboxAltura.Text, out Altura))
            {
                MessageBox.Show("Altura invalido");
            }
        }

        private void mskboxPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskboxPeso.Text, out Peso))
            {
                MessageBox.Show("Peso invalido");
                
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskboxPeso.Text, out Peso) || !double.TryParse(mskboxAltura.Text, out Altura))
            {


                MessageBox.Show("Valores de altura ou peso Errado");




            }
            else
            {

               
                Resultado = Peso / (Altura * Altura);

                Resultado = Math.Round(Resultado, 1);

                txtResultado.Text = Resultado.ToString();

            }

            if (Resultado <= 18.5 )
            {
                txtClassificacao.Text = "Abaixo do Peso";
            }
            else if (Resultado <= 24.9)
            {
                txtClassificacao.Text = "Peso normal";
            }
            else if (Resultado <= 29.9)
            {
                txtClassificacao.Text = "Excesso";
            }
            else if (Resultado <= 34.9)
            {
                txtClassificacao.Text = "Obesidade 1";
            }
            else if (Resultado <= 39.9)
            {
                txtClassificacao.Text = "Obesidade 2";
            }
            else if (Resultado > 40)
            {
                txtClassificacao.Text = "Obesidade 3";
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            mskboxPeso.Text = " ";
            mskboxAltura.Text = " ";
            txtClassificacao.Text = " ";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
