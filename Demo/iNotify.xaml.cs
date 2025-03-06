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
    /// Interaction logic for iNotify.xaml
    /// </summary>
    public partial class iNotify : Window
    {
        public iNotify()
        {
            InitializeComponent();
            Car c = new Car() { Model = "BMW" , 
            Color = "Black"
             ,Year = "2020"
            };
           
            this.DataContext = c;

        }
    }
}
