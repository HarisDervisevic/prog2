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


        long nummber1 = 0;
        long nummber2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }
   
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;

            if (e.Source is Button )
            {

                switch (Button.Content)
                {

                    case 1: "1";
                    case 2: "2";




                }

               // var talet(string) = Text.split('+');
               // tal1 = Convert.ToInt32(tealet(string)[0])




            }

        }
    }
}
