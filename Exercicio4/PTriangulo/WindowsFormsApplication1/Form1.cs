using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double LadoA;
        double LadoB;
        double LadoC;
        double Resultado;

       

      

       

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out LadoA))
            {
                MessageBox.Show("Lado A não é numero");
                
            }
        }

        private void txtB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtB.Text, out LadoB))
            {
                MessageBox.Show("Lado B não é numero");

            }
        }

        private void txtC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtC.Text, out LadoC))
            {
                MessageBox.Show("Lado C não é numero");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (  (LadoA < (LadoB+LadoC))       && (LadoA > Math.Abs(LadoB-LadoC))  && (LadoB<(LadoA+LadoB))  &&   (LadoC<(LadoA+LadoB))  && (LadoC > Math.Abs(LadoA-LadoB)) && (LadoB > Math.Abs(LadoA-LadoC))    )
            {
                if (LadoA == LadoB && LadoB == LadoC && LadoC == LadoA )
                {
                    txtTipo.Text = "Equliatero";

                    
                }
                else if (LadoA == LadoB ||  LadoA == LadoC   || LadoC == LadoB )
                {
                    txtTipo.Text = "Isósceles";
                }
                else if (LadoA != LadoB && LadoA != LadoC && LadoB != LadoC)
	            {
                    txtTipo.Text = "Escaleno";
                }
            
            }
            else
            {
                MessageBox.Show("Valores invalidos");
            }
        }
        
    }
}
