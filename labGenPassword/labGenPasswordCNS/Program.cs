using labGenPassword.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGenPasswordCNS
{
    class Program
    {
        static void Main(string[] args)
        {
            int iLen;
            int count;
            string upper;
            string spec;
            string number;
            bool bUpper = false, bSpec = false, bNumber = false;
            do
            {
                Console.WriteLine("Укажите длину пароля:");
                int.TryParse(Console.ReadLine(),out iLen);
                Console.WriteLine("Укажите количество паролей:");
                int.TryParse(Console.ReadLine(), out count);
                do
                {
                    Console.WriteLine("Использовать цифры?(y/n)");
                    number = Console.ReadLine();
                }
                while (number[0] != 'y' || number[0] != 'n');
                do
                {
                    Console.WriteLine("Использовать символы в верхнем регистре?(y/n)");
                    upper = Console.ReadLine();
                }
                while (upper[0] != 'y' || number[0] != 'n');
                do
                {
                    Console.WriteLine("Использовать спец. символы?(y/n)");
                    spec = Console.ReadLine();
                }
                while (spec[0] != 'y' || number[0] != 'n');

                bUpper = true ? upper == "y" : false;
                bSpec = true ? spec == "y" : false;
                bNumber = true ? number == "y" : false;
                if (iLen != 0)
                    for (int i = 0; i < count; i++)
                        Console.WriteLine("Ваш пароль: {0}", Utils.RandomStr(iLen, true, bUpper, bSpec, bNumber));
            }
            while (iLen != 0); 
        }
    }
}
