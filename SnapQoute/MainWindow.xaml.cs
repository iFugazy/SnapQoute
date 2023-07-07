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

namespace SnapQoute
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

  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var _sqftAns = Convert.ToInt16(sqftAns.Text.ToString());
                double qouteAns = _3DCalc(_sqftAns);
                if (droneAns.Text.ToString() == "Yes")
                {
                    qouteAns += 75;
                }
            

                if (photographyAns.Text.ToString() == "Yes")
                {
                    qouteAns += 50;
                }
            
            
                answerBox.Content = qouteAns;
                }
                catch
                {
                    MessageBox.Show("Please enter valid information before submitting");

                }
           
            

        }

        public double _3DCalc(int squareft)
        {
            double _squareft = 0;

            if (squareft == 0)
            {
                MessageBox.Show("Please enter a valid square footage");
            }
            else if (squareft < 2500) 
            {
                _squareft += 250.00;
            }
            else if (squareft > 2500 && squareft < 4000)
            {
                _squareft += 350.00;
            }
            else
            {
                _squareft += 400.00;
            }

            return _squareft;
        }
    }
}
