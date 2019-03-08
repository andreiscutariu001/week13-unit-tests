using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleStringUtils;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new StringUtils();
            var x = utils.Reverse("ab-cd");
            Console.WriteLine(x);
        }
    }
}
