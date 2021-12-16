using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace GasStation
{
    public class SendingEmail
    {
        public static void Send(string email)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("oil.city723@gmail.com", "OilCity");
                // кому отправляем
                //MailAddress to = new MailAddress("di-di-diasha@mail.ru");
                MailAddress to = new MailAddress($"{email}");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Чек";
                // текст письма
                if (GasStation.DopPrice != 0 && GasStation.Discount == 0)
                {
                    m.Body = $"Тип топлива: {GasStation.SelectedGasType}" +
                         $"<br> Количество литров: {GasStation.AmountOfGasoline}" +
                         $"<br> Номер ТРК: {GasStation.SelectedPetrolPump}" +
                         $"<br> Дата покупки: {GasStation.date} " +
                         $"<br> Топливо на сумму: {GasStation.Price} ₽" +
                         $"<br> Дополнительные товары на сумму: {GasStation.DopPriceAll} ₽" +
                         $"<br> -------------------------------------" +
                         $"<br> Итог к оплате: {GasStation.AllPrice} ₽";
                }
                else if (GasStation.DopPrice != 0 && GasStation.Discount != 0)
                {
                    m.Body = $"Тип топлива: {GasStation.SelectedGasType}" +
                     $"<br> Количество литров: {GasStation.AmountOfGasoline}" +
                     $"<br> Номер ТРК: {GasStation.SelectedPetrolPump}" +
                     $"<br> Дата покупки: {GasStation.date} " +
                     $"<br> Топливо на сумму: {GasStation.Price} ₽" +
                     $"<br> Дополнительные товары на сумму: {GasStation.DopPriceAll} ₽" +
                     $"<br> Скидка по карте: {GasStation.AmountDiscount} ₽" +
                     $"<br> -------------------------------------" +
                     $"<br> Итог к оплате: {GasStation.AllPrice} ₽";
                }
                else if (GasStation.DopPrice == 0 && GasStation.Discount != 0)
                {
                    m.Body = $"Тип топлива: {GasStation.SelectedGasType}" +
                     $"<br> Количество литров: {GasStation.AmountOfGasoline}" +
                     $"<br> Номер ТРК: {GasStation.SelectedPetrolPump}" +
                     $"<br> Дата покупки: {GasStation.date} " +
                     $"<br> Топливо на сумму: {GasStation.Price} ₽" +
                     $"<br> Скидка по карте: {GasStation.AmountDiscount} ₽" +
                     $"<br> -------------------------------------" +
                     $"<br> Итог к оплате: {GasStation.AllPrice} ₽";
                }
                else
                {
                    m.Body = $"Тип топлива: {GasStation.SelectedGasType}" +
                        $"<br> Количество литров: {GasStation.AmountOfGasoline}" +
                        $"<br> Номер ТРК: {GasStation.SelectedPetrolPump}" +
                        $"<br> Дата покупки: {GasStation.date}" +
                        $"<br> Топливо на сумму: {GasStation.Price} ₽" +
                        $"<br> -------------------------------------" +
                        $"<br> Итог к оплате: {GasStation.AllPrice} ₽";
                }
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("oil.city723@gmail.com", "GasStation723");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Чек был отправлен на указанный вами e-mail.", "OilCity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
