using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parsing
{
    internal class ArgumentParse(string _pars)
    {
        List<Token> tokens = [];
        string pars = _pars;

        public List<Token> Parsing()
        {
            string target = "";
            //string[] commands = pars.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //string pattern = @"(-{1,2}\w+)(?:=(\""[^\""]*\""|\S+))?|(\S+)";
            // (?<arg>-{ 1,1}\w)(=""(.*?)""){0,}| (?< arg > -{ 2,2}\w +)(= ""(.*?)""){ 0,}| (?< arg > -{ 0,1}\w +)(= ""(\d)""){ 0,}
            //var pattern = @"(?<arg>-{1,2}\w+)=(\""{2}(?<value>.*?)\""{2}|(?<value>\d+))|(?<value>[^\s]+)";
            //var pattern = @"(?<arg>--?\w+)(=(?<value>""{2}(.*?)""{2}|(?<value>\w+)))?|(?<value>[^\s]+)";
            //string pattern = @"(?<arg>-{1,2}\w+)?<value>(?:=(\""[^\""]*\""|\S+))?|?<value>(\S+)";
            string pattern = @"(?<arg>--?\w+)(=(?<value>""[^""]*""|\w+))?|(?<value>[^\s]+)";
            ;

            var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            string result = regex.Replace(pars, target);
            MatchCollection matches = regex.Matches(pars);



            foreach (Match command in matches)
            {
                //string argument = command.Groups[1].Success ? command.Groups[1].Value : command.Groups[2].Value;

                //Console.WriteLine($" Argument: {command.Value}");
                //Console.WriteLine($" Argument: {argument}");

                if (command.Groups["arg"].Success)
                {
                    string _key = command.Groups["arg"].Value;
                    if (command.Groups["value"].Success)
                    {
                        string _value = command.Groups["value"].Value.Trim('"');
                        tokens.Add(new Token(_key, _value));
                    }
                    else tokens.Add(new Token(_key));
                }

            }
            return tokens;
        }
    }
}
