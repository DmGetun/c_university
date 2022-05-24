using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> x = new Dictionary<int, string>(5);
            x.Add(1, "Брянск");
            x.Add(2, "Тула");
            x.Add(3, "Самара");
            x.Add(4, "Калуга");
            x.Add(5, "Псков");
            //
            foreach(KeyValuePair<int,string> keyValue in x)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            //
            string country = x[4];
            x[4] = "Spain";
            x.Remove(2);
        }
    }
}
