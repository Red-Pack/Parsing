using System.Linq;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using System.Windows.Input;

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
                ArgumentParse parserstring = new(pars);
                List<Token> tokens = parserstring.Parsing();

                foreach (Token token in tokens)
                {
                    Console.WriteLine(token);
                }
            }



        }
    }
}

