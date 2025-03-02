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
    /// Interaction logic for DataControl.xaml
    /// </summary>
    public partial class DataControl : Window
    {
        public DataControl()
        {
            InitializeComponent();

            var p1 = new Person { FirstName = "John", LastName = "Doe", Age = 42 };

            this.DataContext = p1;
        }
    }
}
