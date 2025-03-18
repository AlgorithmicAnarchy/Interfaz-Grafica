using System;
using System.Windows;
using System.Data;
using System.Windows.Controls;

namespace CalculadoraWPF
{
    public partial class MainWindow : Window
    {
        private string _currentInput = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            _currentInput += button.Content.ToString();
            txtDisplay.Text = _currentInput;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            _currentInput += " " + button.Content.ToString() + " ";
            txtDisplay.Text = _currentInput;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = string.Empty;
            txtDisplay.Text = _currentInput;
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dataTable = new DataTable();
                var result = dataTable.Compute(_currentInput, string.Empty);
                txtDisplay.Text = result.ToString();
                _currentInput = result.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
                _currentInput = string.Empty;
            }
        }
    }
}
