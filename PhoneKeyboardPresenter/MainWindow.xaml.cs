
using System.Windows;


namespace PhoneKeyboardPresenter
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var sequence = new SequensePresenter();
            MessageBox.Show(sequence.TranslateToSequense(textBox.Text.ToUpper()));
        }
    }
}
