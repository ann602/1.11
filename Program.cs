using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть назву бренду:");
            string tbrand=Console.ReadLine();
            Console.Write("Введіть ціну:");
            string tprice=Console.ReadLine();
            Console.Write("Введіть вагу:");
            string tweight = Console.ReadLine();
            Console.Write("Введіть колір:");
            string tcolor=Console.ReadLine();
            Console.Write("Введіть діагональ екрана:");
            string tscreendiagonal = Console.ReadLine();
            Console.Write("Введіть частоту центрального процесора:");
            string cpufrequency = Console.ReadLine();
            Console.Write("Чи є sim-карта? (y-так, n-ні): ");
            ConsoleKeyInfo keyisthereasimcard = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Чи є слот для карти пам'яті? (y-так, n-ні): ");
            ConsoleKeyInfo keyisthereamemorycardslot = Console.ReadKey();
            Console.WriteLine();
            Tablet OurTablet=new Tablet();
            OurTablet.brand=tbrand;
            OurTablet.price = int.Parse(tprice);
            OurTablet.color = tcolor;
            OurTablet.weight = int.Parse(tweight);
            OurTablet.screendiagonal=double.Parse(tscreendiagonal);
            OurTablet.CPUfrequency=double.Parse(cpufrequency);
            OurTablet.isthereasimcard= keyisthereasimcard.Key==ConsoleKey.Y ? true : false;
            OurTablet.isthereamemorycardslot = keyisthereamemorycardslot.Key == ConsoleKey.Y ? true : false;
            double tdiscountedPrice10 = OurTablet.discountedPrice();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Дані про об'єкт: ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Бренд:" + OurTablet.brand);
            Console.WriteLine("Колір:" + OurTablet.color);
            Console.WriteLine("Вага:" + OurTablet.weight + " г");
            Console.WriteLine("Ціна:" + OurTablet.price + " грн");
            Console.WriteLine("Діагональ екрана:" + OurTablet.screendiagonal.ToString("0.0") + "''");
            Console.WriteLine("Частота центрального процесора:" + OurTablet.CPUfrequency.ToString("0.0") + " ГГц");
            Console.WriteLine(OurTablet.isthereasimcard ? "У мене є sim-карта." : "У мене немає sim-карти.");
            Console.WriteLine(OurTablet.isthereamemorycardslot ? "У мене є слот для карти пам'яті." : "У мене немає слота для карти пам'яті.");
            Console.WriteLine();
            Console.WriteLine("Ціна планшета зі знижкою:" + tdiscountedPrice10.ToString("0.00") + " грн");
            Console.ReadKey();
        }
    }
}
