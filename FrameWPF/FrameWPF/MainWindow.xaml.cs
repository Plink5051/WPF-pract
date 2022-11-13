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

namespace FrameWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PictureButton_Click(object sender, RoutedEventArgs e)
        {
            PictureFrame.Navigate(new ImageWIndow());
        }

        private void OpenWindowButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonClose BC = new ButtonClose();
            BC.Show();
            this.Close();
        }

        private void RoundButton_Click(object sender, RoutedEventArgs e)
        {
            PictureFrame.Navigate(new RoundPage());
        }
    }
}
