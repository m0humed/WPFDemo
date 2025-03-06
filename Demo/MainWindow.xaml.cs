using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.Resources["Dynamic"] = new SolidColorBrush(Colors.Blue);
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        this.Resources["Dynamic"] = new SolidColorBrush(Colors.Red);

    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
        Triggers tr = new Triggers();
        tr.Show();
    }

    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
        Panels pl = new Panels();
        pl.Show();
    }

    private void Button_Click_4(object sender, RoutedEventArgs e)
    {
        CustomProps cp = new CustomProps();
        cp.Show();
    }

    private void Button_Click_5(object sender, RoutedEventArgs e)
    {
        Binding b = new Binding();
        b.Show();
    }

    private void Button_Click_6(object sender, RoutedEventArgs e)
    {
        ControlTemplate ct = new ControlTemplate();
        ct.Show();
    }

    private void Button_Click_7(object sender, RoutedEventArgs e)
    {
        DataControl data = new DataControl();
        data.Show();
    }

    private void Button_Click_8(object sender, RoutedEventArgs e)
    {
        _ٌRoutEvent re = new _ٌRoutEvent();
        re.Show();
    }

    private void Button_Click_9(object sender, RoutedEventArgs e)
    {
        iNotify ino = new iNotify();
        ino.Show();
    }
}