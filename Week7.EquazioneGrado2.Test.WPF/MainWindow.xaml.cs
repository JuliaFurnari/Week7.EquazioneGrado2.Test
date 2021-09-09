using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Week7.EquazioneGrado2.Core;

namespace Week7.EquazioneGrado2.Test.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Equation equation = new Equation();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }

        private void EquazioneDiSecondoGrado_Load(object sender, EventArgs e)
        {

        }




        private void txtValueB_TextChanged(object sender, EventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }




        private void txtValueC_TextChanged(object sender, EventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }




        private void txtValueA_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtValueX1.Clear();
            txtValueX2.Clear();
        }

        private void btnCalcola_Click_1(object sender, RoutedEventArgs e)
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
    }
}
