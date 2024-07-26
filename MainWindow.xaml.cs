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

namespace TempFileDeleter
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



        private void TempCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.temp = true;
        }

        private void TempCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.temp = false;
        }

        private void DownloadsCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.down = true;
        }

        private void DownloadsCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.down = false;
        }

        private void RecycleBinCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.bin = true;
        }

        private void RecycleBinCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.bin = false;
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonFunctions.DeleteButton();
            this.TempCheckBox.IsChecked = false;
            this.DownloadsCheckBox.IsChecked = false;
            this.RecycleBinCheckBox.IsChecked = false;


        }
    }
}
