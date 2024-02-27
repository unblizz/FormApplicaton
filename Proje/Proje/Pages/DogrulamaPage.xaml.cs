using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Proje.Windows;

namespace Proje.Pages
{
    /// <summary>
    /// DogrulamaPage.xaml etkileşim mantığı
    /// </summary>
    public partial class DogrulamaPage : Page
    {
        public DogrulamaPage()
        {
            InitializeComponent();

        }
        private int gonderilenDogrulamaKodu;
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
            if (txtTCKimlik.Text.Length == 11)
            {
                CheckTCNumber();
            }
        }

        private void CheckTCNumber()
        {
            if (txtTCKimlik != null)
            {
                string tcNumber = txtTCKimlik.Text;
                if (!string.IsNullOrEmpty(tcNumber) && tcNumber.Length == 11)
                {
                    if (tcNumber.StartsWith("0") || int.Parse(tcNumber.Substring(tcNumber.Length - 1)) % 2 != 0)
                    {
                        MessageWindow.Show("Geçersiz TC Kimlik Numarası. Lütfen tekrar deneyin.", "Bir şeyler ters gitti!", false);
                        txtTCKimlik.Clear();
                    }
                }
            }
        }


        public void SendEmail(string _mail, string _body)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential("savronix@hotmail.com", "Erdem2006");
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.office365.com";
                smtpClient.EnableSsl = true;
                mailMessage.To.Add(_mail);
                mailMessage.From = new MailAddress("savronix@hotmail.com");
                mailMessage.Subject = "Doğrulama Kodunuz";
                mailMessage.Body = _body;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageWindow.Show(ex.Message, "Bir hata meydana geldi!", false);
            }


        }
        private async void btnDogrulamaGonder_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtMail.Text) && txtDogrulamaKodu.IsReadOnly == true && !string.IsNullOrEmpty(txtTCKimlik.Text))
                {
                    Random random = new Random();
                    string mail = txtMail.Text;
                    gonderilenDogrulamaKodu = random.Next(100000, 999999);
                    string dogrulamaKodu = gonderilenDogrulamaKodu.ToString();
                    await Application.Current.Dispatcher.Invoke(async () =>
                    {
                        txtButtonText.Visibility = Visibility.Hidden;
                        buttonProgressRing.Visibility = Visibility.Visible;
                        await Task.Run(() =>
                        {
                            SendEmail(mail, dogrulamaKodu);
                        });
                        txtButtonText.Visibility = Visibility.Visible;
                        buttonProgressRing.Visibility = Visibility.Hidden;
                        txtDogrulamaKodu.IsReadOnly = false;
                        txtButtonText.Text = "Devam Et";
                    });
                }
                else if (txtDogrulamaKodu.IsReadOnly == false)
                {
                    if (Convert.ToInt32(txtDogrulamaKodu.Text) == gonderilenDogrulamaKodu)
                    {
                        // Aktif pencereyi al
                        FrameService.Navigate(new BilgilerPage());
                    }
                    else
                    {
                        MessageWindow.Show("Doğrulama kodu yanlış", "", false);
                    }
                }
                else
                {
                    MessageWindow.Show("T.C. Kimlik ve Mail adresi boş bırakılamaz.", "Boş değerler var!", false);
                }
            }
            catch (Exception ex)
            {
                MessageWindow.Show(ex.Message, "Bir şeyler ters gitti!", false);
            }
        }
    }
}
