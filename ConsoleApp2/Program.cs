using System.Linq;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;

namespace Parsing
{
    internal class Program
    {
        static void Main()
        {

            Console.Write(">");
            string? pars = Console.ReadLine();
            if (pars != null)
            {
                string[] commands = pars.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string command in commands)
                {
                    Console.WriteLine($" Argument+ {command}");
                }
            }

        }

    }
}

