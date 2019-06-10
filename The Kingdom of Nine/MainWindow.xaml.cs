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

namespace The_Kingdom_of_Nine
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += Window_KeyDown;               
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { }
        //Esc for close 
        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            { this.Close(); }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_ClickStart(object sender, RoutedEventArgs e)
        {
            StartWindow st = new StartWindow();
            st.Show();
            this.Close();
         
        }
    }
}
