﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    public partial class CashReceipt : Form
    {
        public CashReceipt()
        {
            InitializeComponent();
            label6.Text = GasStation.Price.ToString() + " ₽";
            label4.Text = GasStation.SelectedGasType.ToString();
            label5.Text = GasStation.AmountOfGasoline.ToString();
            label8.Text = DateTime.Now.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Refueling frm = new Refueling();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
            m.Body = $"Тип топлива: {label4.Text} ₽ " +
                     $"<br> Количество литров: {label5.Text} " +
                     $"<br> Дата покупки: {label8.Text} " +
                     $"<br> Сумма оплаты: {label6.Text}";
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

        private void button2_Click(object sender, EventArgs e)
        {
            AdditionalProducts frm = new AdditionalProducts();
            frm.ShowDialog();
        }
    }
}
