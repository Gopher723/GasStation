using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace GasStation
{
    class GasStation
    {
        // контейнер ключ-значение с бензином и его ценам
        static public Dictionary<string, double> GasTypes = new Dictionary<string, double> { { "АИ-92", 45.9 }, { "АИ-95", 50.2 } };      
        static public Dictionary<string, double> DiscountCard = new Dictionary<string, double> { { "563775876", 5 }, { "783564567", 3 }, { "562964486", 4 } };
        // значения для работы с определенным клиентом
        static public double AmountOfGasoline = 0; //количество литров
        static public int SelectedPetrolPump = 0; //номер колонки
        static public double LoadedGasoline = 0; //для залива топлива
        static public string SelectedGasType = ""; //тип топлива
        static public double Price = 0; //цена топлива
        static public string Mail = ""; //почта пользователя
        static public double DopPrice = 0; //цена за доп товары
        static public string Hash = "a49bd5aeeb94ae40198993992f8a7f93";
        static public double AllPrice = 0; //сумма покупки
        static public DateTime date = DateTime.Now; //дата покупки
        static public int receiptNumber = 0; //номер чека
        static public double Discount = 0; //процент скидки

        public static void InsertText(string path, string newText)
        {
            if (File.Exists(path))
            {
                string oldText = File.ReadAllText(path, System.Text.Encoding.Default);
                using (var sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(newText);
                    sw.WriteLine(oldText);
                }
            }
            else File.WriteAllText(path, newText, System.Text.Encoding.Default);
        }

        public static string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();
            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
            return hash;
        }
    }
}
