using System;
using System.Linq;

namespace SimpleStringUtils
{
    public class StringUtils
    {
        public string Reverse(string s)
        {
            if (s == "")
            {
                throw new InvalidOperationException("Input cannot be empty");
            }

            var reversedArray = s.Reverse().ToArray();
            return new string(reversedArray);
        }
    }
}