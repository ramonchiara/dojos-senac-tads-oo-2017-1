using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo20170329
{
    public class FizzBuzz
    {
        public string Converte(int n)
        {
            string saida = n + "";

            if (n % 15 == 0)
            {
                saida = "FizzBuzz";
            }
            else if (n % 3 == 0)
            {
                saida = "Fizz";
            }
            else if (n % 5 == 0)
            {
                saida = "Buzz";
            }

            return saida;
        }
    }
}
