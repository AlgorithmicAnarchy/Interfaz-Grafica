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

namespace SueldoNetoEmpleadoWPF
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double pph = double.Parse(txtGananciasH.Text);
            double htb = double.Parse(txtPagoH.Text);

            double descuentoAFP = 2.87;
            double descuentoSFS = 3.04;
            double descuentoAFPxSFS = descuentoAFP + descuentoSFS;

            double sueldoBruto = pph * htb;

            double sueldoNeto = sueldoBruto - (sueldoBruto * (descuentoAFPxSFS / 100));

            netoyatusabe.Text = sueldoNeto.ToString();


        }
    }
}