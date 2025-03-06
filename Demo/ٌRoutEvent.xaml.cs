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
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for _ٌRoutEvent.xaml
    /// </summary>
    public partial class _ٌRoutEvent : Window
    {
        public _ٌRoutEvent()
        {
            InitializeComponent();
        }

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Title = "BTN";
        }

        private void EL1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Title="EL1 MouseDown";
        }

        private void Ellipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "Ellipse_PreviewMouseDown";
            

        }
    }
}
