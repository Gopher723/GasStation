﻿using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace GasStation
{
    public partial class CashReceipt : Form
    {
        public CashReceipt()
        {
            InitializeComponent();
            label6.Text = GasStation.Price + " ₽";
            label4.Text = GasStation.SelectedGasType.ToString();
            label5.Text = GasStation.AmountOfGasoline.ToString();
            label8.Text = DateTime.Now.ToString(); 
            labelOilPrice.Text = GasStation.Price + " ₽";
            label13.Text = GasStation.SelectedPetrolPump.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GasStation.date = DateTime.Parse(label8.Text);
            this.Close();
            Refueling frm = new Refueling();
            frm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EnteringMail frm = new EnteringMail();
                frm.ShowDialog();

                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("oil.city723@gmail.com", "OilCity");
                // кому отправляем
                //MailAddress to = new MailAddress("di-di-diasha@mail.ru");
                MailAddress to = new MailAddress($"{GasStation.Mail}");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Чек";
                // текст письма
                if (GasStation.DopPrice != 0)
                {
                    m.Body = $"Тип топлива: {label4.Text} ₽ " +
                         $"<br> Количество литров: {label5.Text} " +
                         $"<br> Номер ТРК: {label13.Text}" +
                         $"<br> Дата покупки: {label8.Text} " +
                         $"<br> Топливо на сумму: {labelOilPrice.Text}" +
                         $"<br> {label9.Text} {labelDopPrice.Text}" +
                         $"<br> -------------------------------------" +
                         $"<br> Итог к оплате: {label6.Text}";
                }
                else
                {
                    m.Body = $"Тип топлива: {label4.Text} ₽ " +
                        $"<br> Количество литров: {label5.Text} " +
                        $"<br> Номер ТРК: {label13.Text}" +
                        $"<br> Дата покупки: {label8.Text} " +
                        $"<br> Топливо на сумму: {labelOilPrice.Text}" +
                        $"<br> -------------------------------------" +
                        $"<br> Итог к оплате: {label6.Text}";
                }

                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("oil.city723@gmail.com", "GasStation723");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Чек был отправлен на указанный вами e-mail.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdditionalProducts frm = new AdditionalProducts();
            frm.ShowDialog();
            if(GasStation.DopPrice != 0)
            {
                label9.Text = "Доп. товары\nна сумму:";
                labelDopPrice.Text = GasStation.DopPrice + " ₽";
            }
            label6.Text = GasStation.Price + GasStation.DopPrice + " ₽";
            this.Show();
        }
    }
}
