using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo c;
            do
            {
                c = Console.ReadKey();
            } while (!c.Modifiers.HasFlag(ConsoleModifiers.Control) || !c.Modifiers.HasFlag(ConsoleModifiers.Shift) || c.Key.ToString().ToUpper() != "F");
        }
    }
}
