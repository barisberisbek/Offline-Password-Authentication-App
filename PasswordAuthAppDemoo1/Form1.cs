using System;
using System.Linq;
using System.Windows.Forms;
using OtpNet;

namespace PasswordAuthAppDemoo1
{
    public partial class Form1 : Form
    {
        private Totp totp1;
        private Hotp hotp1;
        private Totp totp2;
        private Hotp hotp2;
        private string secretKey1 = "JBSWY3DPEHPK3PXP"; 
        private string secretKey2 = "KRSXG5A=";
        private int counter = 0; 
        private int timeLeft = 60;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            GenerateNewPassword();
        }

        private void GenerateNewPassword()
        {
            var base32Bytes1 = Base32Encoding.ToBytes(secretKey1);
            var base32Bytes2 = Base32Encoding.ToBytes(secretKey2);
            totp1 = new Totp(base32Bytes1, step: 60);
            hotp1 = new Hotp(base32Bytes1);
            totp2 = new Totp(base32Bytes2, step: 60);
            hotp2 = new Hotp(base32Bytes2);

            string totpPassword1 = Base64Encode(totp1.ComputeTotp());
            string hotpPassword1 = Base64Encode(hotp1.ComputeHOTP(counter));
            labelGeneratedPassword.Text = $"TOTP1: {totpPassword1} \nHOTP1: {hotpPassword1}";
            timeLeft = 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                labelTimer.Text = $"Kalan Süre: {timeLeft} sn";
            }
            else
            {
                GenerateNewPassword();
                counter++;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var base32Bytes1 = Base32Encoding.ToBytes(secretKey1);
            var base32Bytes2 = Base32Encoding.ToBytes(secretKey2);
            totp1 = new Totp(base32Bytes1, step: 60);
            hotp1 = new Hotp(base32Bytes1);
            totp2 = new Totp(base32Bytes2, step: 60);
            hotp2 = new Hotp(base32Bytes2);

            string enteredPassword = txtEnteredPassword.Text;
            bool isTotp1Valid = VerifyBase64Totp(totp1, enteredPassword);
            bool isHotp1Valid = VerifyBase64Hotp(hotp1, enteredPassword);
            bool isTotp2Valid = VerifyBase64Totp(totp2, enteredPassword);
            bool isHotp2Valid = VerifyBase64Hotp(hotp2, enteredPassword);

            if (isTotp1Valid || isTotp2Valid)
            {
                labelResult.Text = "Doğru TOTP şifresi";
                labelResult.ForeColor = System.Drawing.Color.Green;
            }
            else if (isHotp1Valid || isHotp2Valid)
            {
                labelResult.Text = "Doğru HOTP şifresi";
                labelResult.ForeColor = System.Drawing.Color.Green;
                counter++;
            }
            else
            {
                labelResult.Text = "Yanlış şifre";
                labelResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool VerifyBase64Totp(Totp totp, string base64Totp)
        {
            string decodedTotp = Base64Decode(base64Totp);
            var verificationWindow = new VerificationWindow(previous: 1, future: 1);
            return totp.VerifyTotp(decodedTotp, out long timeStepMatched, verificationWindow);
        }

        private bool VerifyBase64Hotp(Hotp hotp, string base64Hotp)
        {
            string decodedHotp = Base64Decode(base64Hotp);
            for (int i = -1; i <= 1; i++)
            {
                if (hotp.VerifyHotp(decodedHotp, counter + i))
                {
                    return true;
                }
            }
            return false;
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            //null
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //null
        }
    }
}
