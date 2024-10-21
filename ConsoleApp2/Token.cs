using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    public class Token
    {
        public string Key { get; set; }
        public string? Value { get; set; }

        public Token(string _key, string _value)
        {
            Key = _key;
            Value = _value;
        }

        public Token(string _key)
        {
            Key = _key;
            Value = null;
        }

        public override string ToString()
        {
            return Value == null ? $"Key: {Key}, No Value" : $"Key: {Key}, Value: {Value}";
        }
    }
}
