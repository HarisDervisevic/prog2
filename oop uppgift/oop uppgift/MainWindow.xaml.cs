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

        //Metoden tar in input från användaren och lägger in det i text_block, varierar 
        //beroende på vilken knapp användaren tryckt på
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
                    case "√":
                    case "÷":
                    case "^":
                    case "⋅":
                    case ",":

                        text_block.Text += button.Content;
                        break;

                        //Sätter mitt textblock till tomt om det finns något skrivet

                    case "clear":
                        if(text_block.Text != "")
                        {
                            text_block.Text = " ";
                        }
                        else
                        {
                            Console.WriteLine("Nothing to delete");
                        }
                        break;


                        //Om det finns något skrivet så kommer den att beräkna det, kommer ej krascha ifall text_blocket är tomt

                    case "Calc":

                        if(text_block.Text != " ")
                        {
                            text_block.Text = calculations.calculation(text_block.Text);
                        }

                        else 
                        {
                            Console.WriteLine("Nothing to calculate");
                        }
                        

                        break;

                        /*
                    case "√":
                        text_block.Text += button.Content;
                        text_block.Text = calculations.Squrt_function(text_block.Text);

                        break;
                        */


                }

            }
        }
    }

            }


      

 