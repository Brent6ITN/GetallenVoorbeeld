using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetalLibrary;

namespace GetallenConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            controller _controller = new controller();

            Console.Write("Getal 1: ");
            _controller.setGetal1(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Getal 2: ");
            _controller.setGetal2(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("GGD: " + _controller.zoekGGD());

            Console.WriteLine("Druk op een knop om af te sluiten.");

            Console.ReadKey();

        }
    }
}
