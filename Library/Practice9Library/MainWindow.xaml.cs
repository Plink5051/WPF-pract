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
using Library_Practice9;

namespace Practice9Library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileManager _fileManager;
        public MainWindow()
        {
            InitializeComponent();
            _fileManager = new FileManager();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                res.Text = Convert.ToString(Convert.ToInt32(a.Text) / Convert.ToInt32(b.Text));
                await _fileManager.WriteFile("Результат = " + res.Text);
            }
            catch (Exception ex)
            {
                await _fileManager.WriteFile(ex.Message);
            }
        }
    }
}
