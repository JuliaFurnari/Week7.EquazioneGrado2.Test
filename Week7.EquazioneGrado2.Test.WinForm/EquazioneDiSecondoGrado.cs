using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.EquazioneGrado2.Core;

namespace Week7.EquazioneGrado2.Test.WinForm
{
    public partial class EquazioneDiSecondoGrado : Form
    {
        private Equation equation = new Equation();
        public EquazioneDiSecondoGrado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }



        private void EquazioneDiSecondoGrado_Load(object sender, EventArgs e)
        {

        }


        private void btnUguale_Click(object sender, EventArgs e)
        {
            double[] risultato = equation.RisolviEquazioneDiSecondoGrado(double.Parse(txtValueA.Text), double.Parse(txtValueB.Text), double.Parse(txtValueC.Text));
            if (string.IsNullOrEmpty(txtValueA.Text) || string.IsNullOrEmpty(txtValueB.Text) || string.IsNullOrEmpty(txtValueC.Text))
            {
                txtValueX1.Text.DefaultIfEmpty();
            }
            else
            {
                if (risultato == null) 
                {
                    txtValueX1.Text = txtValueX2.Text = "Null";
                }
                else if (risultato.Length == 2)
                {
                    txtValueX1.Text = risultato[0].ToString();
                    txtValueX2.Text = risultato[1].ToString();
                }
                else 
                {
                    txtValueX1.Text = risultato[0].ToString();
                    txtValueX2.Text = risultato[0].ToString();
                }
                
            }
        }

        private void txtValueB_TextChanged(object sender, EventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }

        private void txtValueDelta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValueX1_TextChanged(object sender, EventArgs e)
        {
  
            
        }

        private void txtValueC_TextChanged(object sender, EventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
