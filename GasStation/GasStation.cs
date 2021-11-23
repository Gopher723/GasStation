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
        static public Dictionary<string, double> GasTypes = new Dictionary<string, double>(5) { { "АИ-92", 45.9 }, { "АИ-95", 50.2 } };
        //static public Dictionary<string, double> PetrolPump = new Dictionary<string, double>     {{"1-95",100}, {"1-92",100}, {"2-95",100}, {"2-92",100},
        //                                                                                          {"3-95",100}, {"3-92",100}, {"4-95",100}, {"4-92",100},
        //                                                                                          {"5-95",100}, {"5-92",100}, {"6-95",100}, {"6-92",100}};
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
