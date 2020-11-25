using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace oop_uppgift
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

            if (e.Source is Button button)
            {

                switch (button.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "+":
                    case "-":
                    case "÷":
                    case "√":
                    case "^":
                    case "⋅":
                    case ",":

                        text_block.Text += button.Content;
                        break;

                    case "clear":
                        text_block.Text = "";
                        break;


                    case "Calc":

                        string[] list = text_block.Text.Split('+', '-', '÷', '⋅');
                        var value1 = Convert.ToDouble(list[0]);
                        var value2 = Convert.ToDouble(list[1]);


                        if (text_block.Text.Contains("+"))
                        {
                            var result = value1 + value2;

                        }

                        else if (text_block.Text.Contains(-))
                        {
                            var result = value1 - value2;

                        }

                        else if (text_block.Text.Contains(÷))
                        {
                            var result = value1 / value2;

                        }

                        else if (operation == "⋅")
                        {

                            var result = value1 * value2;

                        }


                        // var talet(string) = Text.split('+');
                        // tal1 = Convert.ToInt32(talet(string)[0])
                        break;

                }

            }
        }
    }

            }


      

 