using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetIntFromConsole());
        Console.WriteLine();
    }

    static int GetIntFromConsole()
    {
        int digitToOut = 0;
        bool isRun = true;

        while (isRun)
        {
            Console.Write("Введите число: ");
            string digitFromConsole = Console.ReadLine();
            isRun = !int.TryParse(digitFromConsole, out digitToOut);
        }

        return digitToOut;
    }
}