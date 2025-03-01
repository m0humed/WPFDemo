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
using System.Windows.Threading;

namespace Demo
{
    /// <summary>
    /// Interaction logic for CustomProps.xaml
    /// </summary>
    public partial class CustomProps : Window
    {
        public CustomProps()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1),DispatcherPriority.Normal 
                , delegate {
                    int newValue = 10;
                   if (Counter == int.MaxValue)
                        newValue = 0;
                   else
                        newValue = ++Counter;
                   
                    SetValue(CounterProperty, newValue);


                },Dispatcher);

        }



        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Counteroperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counteroperty", typeof(int), typeof(CustomProps), new PropertyMetadata(0));


    }
}
