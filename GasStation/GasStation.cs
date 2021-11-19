using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GasStation
{
    class GasStation
    {
        // контейнер ключ-значение с бензином и его ценам
        static public Dictionary<string, double> GasTypes = new Dictionary<string, double>(5) { { "АИ-92", 45.9 }, { "АИ-95", 50.2 } };

        // значения для работы с определенным клиентом
        static public double AmountOfGasoline = 0;
        static public double AmountOfMoney = 0;
        static public double RequiredMoney = 0;
        static public double LoadedGasoline = 0;
        static public string SelectedGasType = "";
        static public double Price = 0;
        static public string Mail = "";
        static public double DopPrice = 0;
        static public string Hash = "a49bd5aeeb94ae40198993992f8a7f93";
        static public double AllPrice = 0;
        static public DateTime date = DateTime.Now;

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
