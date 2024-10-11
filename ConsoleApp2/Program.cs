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
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"Аргументы = {arg}");
            }

        }

    }
}

