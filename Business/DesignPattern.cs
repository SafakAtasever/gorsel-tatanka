using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business
{
    public class DesignPattern
    {
        public static bool TCPattern(string tcKimlikNo)
        {
            // TC Kimlik Numarası 11 haneli olmalıdır.
            if (tcKimlikNo.Length != 11)
            {
                return false;
            }

            // TC Kimlik Numarası sadece rakamlardan oluşmalıdır.
            foreach (char c in tcKimlikNo)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // İlk hane 0 olamaz.
            if (tcKimlikNo[0] == '0')
            {
                return false;
            }

            // İlk 10 hane üzerinden kontrol işlemi yapılır.
            int[] digits = new int[11];
            for (int i = 0; i < 11; i++)
            {
                digits[i] = int.Parse(tcKimlikNo[i].ToString());
            }

            int oddSum = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
            int evenSum = digits[1] + digits[3] + digits[5] + digits[7];

            int tenthDigit = (oddSum * 7 - evenSum) % 10;
            int eleventhDigit = (oddSum + evenSum + digits[9]) % 10;

            return digits[9] == tenthDigit && digits[10] == eleventhDigit;
        }

        public static bool MailPattern(string email)
        {
            try
            {
                MailAddress emailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool TelPattern(string telNo)
        {
            // Telefon Numarası 10 haneli olmalıdır.
            if (telNo.Length != 10)
            {
                return false;
            }

            // Telefon Numarası sadece rakamlardan oluşmalıdır.
            foreach (char c in telNo)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // İlk hane 0 olamaz.
            if (telNo[0] == '0')
            {
                return false;
            }

            return true;
        }

        public static bool CinsPattern(string cinsiyet)
        {
            if ((cinsiyet == "Erkek") || (cinsiyet == "Kadın"))
                return true;
            return false;
        }

        public static bool NumberHandler(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b') { e.Handled = false; return true; }
            else { e.Handled = true; return false; }
        }
    }
}
