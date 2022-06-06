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

namespace PatternPrinter
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
            if (!string.IsNullOrWhiteSpace(InputNum.Text))
            {
                int n = Convert.ToInt32(InputNum.Text);
                switch (n)
                {
                    case 1:
                        OutputWin.Text = String.Empty;
                        OutputWin.Text = "          *       \n"+
                                         "         * *      \n"+
                                         "    * * *   * * * \n"+
                                         "      *       *   \n"+
                                         "       *  *  *    \n"+
                                         "      * *   * *   \n"+
                                         "     *         *  \n";
                        InputNum.Clear();
                        break;
                    case 2:
                        OutputWin.Text = String.Empty;
                        OutputWin.Text = "            *         \n"+
                                         "           ***        \n"+
                                         "          *****       \n"+
                                         "         *******      \n"+
                                         "          *****       \n"+
                                         "           ***        \n"+
                                         "            *         \n";
                        InputNum.Clear();
                        break;
                    case 3:
                        OutputWin.Text = String.Empty;
                        OutputWin.Text = "*  *  *  *  *  *  *  *  *  *  *  *  *\n*  *  *  *  *  *  *  *  *  *  *  *  *\n*  *  *  *  *  *  *  *  *  *  *  *  *\n*  *  *  *  *  *  *  *  *  *  *  *  *\n*  *  *  *  *  *  *  *  *  *  *  *  *\n*  *  *  *  *  *  *  *  *  *  *  *  *\n*  *  *  *  *  *  *  *  *  *  *  *  *\n";
                        InputNum.Clear();
                        break;
                    case 4:
                        OutputWin.Text = String.Empty;
                        OutputWin.Text = "*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n*   *   *   *   *   *   *   *   *   *\n";
                        InputNum.Clear();
                        break;
                    case 5:
                        OutputWin.Text = String.Empty;
                        OutputWin.Text = "            *         \n" +
                                         "           ***        \n" +
                                         "          *****       \n" +
                                         "         *******      \n";
                        InputNum.Clear();
                        break;
                    default:
                        OutputWin.Text = String.Empty;
                        OutputWin.Text = "Enter Correct Value";
                        InputNum.Clear();
                        break;

                }
            }
            
        }
    }
}
