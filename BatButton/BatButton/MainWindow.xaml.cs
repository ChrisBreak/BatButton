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

namespace BatButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //From the tutorial notes, animation declaration should be here

        public MainWindow()
        {
            InitializeComponent();
            this.KeyUp += MainWindow_KeyUp;

            /*The animations should be initialized here
             *
             * 
             *
             * 
             * 
             */




            /* Keybinding here
             * 
             * 
             * 
             * 
             */
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

    }
}
