using System.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DisplayStringExcept();
        }

        static void DisplayStringExcept()
        {
            var original = new List<string>()
            {
                "A","B","C","D","E"
            };

            Console.WriteLine($"original : { JsonConvert.SerializeObject(original)}");

            var remove = new List<string>()
            {
                "B","D","E"
            };

            Console.WriteLine($"remove : { JsonConvert.SerializeObject(remove)}");

            var result = original.Except(remove);

            Console.WriteLine($"result : { JsonConvert.SerializeObject(result)}");
        }
    }
}
