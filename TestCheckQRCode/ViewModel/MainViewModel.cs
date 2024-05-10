using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestCheckQRCode.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private string _Captcha;
        public string Captcha { get=>_Captcha; set { _Captcha = value;OnPropertyChanged(); } }
        private string _ResultCheckCaptcha;
        public string ResultCheckCaptcha { get=>_ResultCheckCaptcha; set { _ResultCheckCaptcha = value;OnPropertyChanged(); } }
        private string _UserCaptcha;
        public string UserCaptcha { get=>_UserCaptcha; set { _UserCaptcha = value;OnPropertyChanged(); } }
        public MainViewModel()
        {
            GenerateCaptcha();
            CheckCaptchaCommand = new RelayCommand<object>((p) => true, (p) => CheckCapt(p));
        }
        
        private void CheckCapt(object p)
        {
            if (UserCaptcha == Captcha)
            {
                ResultCheckCaptcha = "CAPTCHA đúng!";
                GenerateCaptcha();
            }
            else
            {
                ResultCheckCaptcha = "CAPTCHA sai. Vui lòng thử lại.";
                GenerateCaptcha();
            }
            UserCaptcha= "";
        }
        private void GenerateCaptcha()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-=.?/[],;'|_+@!#$%^&*";
            char[] captchaChars = new char[6];
            for (int i = 0; i < 6; i++)
            {
                captchaChars[i] = chars[random.Next(chars.Length)];
            }
            Captcha = new string(captchaChars);
        }
        public ICommand CheckCaptchaCommand { get; set; }
    }
}
