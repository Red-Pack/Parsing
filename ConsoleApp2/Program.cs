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
                string target = "";
                //string[] commands = pars.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string pattern = @"(-{1,2}\w+)(?:=(\""[^\""]*\""|\S+))?|(\S+)";
                // (?<arg>-{ 1,1}\w)(=""(.*?)""){0,}| (?< arg > -{ 2,2}\w +)(= ""(.*?)""){ 0,}| (?< arg > -{ 0,1}\w +)(= ""(\d)""){ 0,}

                var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                string result = regex.Replace(pars, target);
                MatchCollection matches = regex.Matches(pars);



                foreach (Match command in matches)
                {
                    //string argument = command.Groups[1].Success ? command.Groups[1].Value : command.Groups[2].Value;

                    Console.WriteLine($" Argument: {command.Value}");
                    //Console.WriteLine($" Argument: {argument}");
                }
            }



        }
    }
}

