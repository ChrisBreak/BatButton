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
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace BatButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard deadParentsAnimation;
        Storyboard fallingWellAnimation;

        private MediaPlayer soundPlayer = new MediaPlayer();

        //From the tutorial notes, animation declaration should be here

        public MainWindow()
        {
            InitializeComponent();
            this.KeyUp += MainWindow_KeyUp;

            //thunder.Open(new Uri("Pictures/THUNDER.mp3", UriKind.Relative));
            //thunder.Volume += 0.2;

            //thunder.Open(new Uri("Pictures/THUNDER.mp3"));

            /*The animations should be initialized here
             *
             * 
             *
             * 
             * 
             */

            deadParentsAnimation = (Storyboard)Resources["parentsfade"];
            fallingWellAnimation = (Storyboard)Resources["batsFlying"];

            deadParentsAnimation.Completed += (s, e) =>
            {
                fallingWellAnimation.Begin();
            };
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }

        private void BatButton_Click(object sender, RoutedEventArgs e)
        {
            soundPlayer.Open(new Uri("../../Pictures/THUNDER.mp3", UriKind.RelativeOrAbsolute));
            //thunder.SpeedRatio = 0.8;
            soundPlayer.Play();
        }

        private void BatButton2_Click(object sender, RoutedEventArgs e)
        {
            soundPlayer.Open(new Uri("../../Pictures/gun-sound-effect-2.mp3", UriKind.RelativeOrAbsolute));
            //thunder.SpeedRatio = 0.8;
            soundPlayer.Play();
        }
    }
}
