using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
