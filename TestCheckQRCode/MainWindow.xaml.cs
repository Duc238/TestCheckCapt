using System.ComponentModel;
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

namespace TestCheckQRCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string captcha;

        //public string Captcha
        //{
        //    get { return captcha; }
        //    set
        //    {
        //        captcha = value;
        //        OnPropertyChanged(nameof(Captcha));
        //    }
        //}
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = this;
            //GenerateCaptcha();
        }
        //private void GenerateCaptcha()
        //{
        //    Random random = new Random();
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        //    char[] captchaChars = new char[6];
        //    for (int i = 0; i < 6; i++)
        //    {
        //        captchaChars[i] = chars[random.Next(chars.Length)];
        //    }
        //    Captcha = new string(captchaChars);
        //}

        //private void CheckCaptcha_Click(object sender, RoutedEventArgs e)
        //{
        //    if (captchaTextBox.Text == Captcha)
        //    {
        //        resultTextBlock.Text = "CAPTCHA đúng!";
        //        GenerateCaptcha();
        //    }
        //    else
        //    {
        //        resultTextBlock.Text = "CAPTCHA sai. Vui lòng thử lại.";
        //        GenerateCaptcha();
        //    }
        //    captchaTextBox.Text = "";
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}