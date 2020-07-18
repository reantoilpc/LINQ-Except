using System.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using src.Model;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // 字串型別
            //DisplayStringExcept();

            // 自訂型別 
            DisplayClassExcept();
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
        static void DisplayClassExcept()
        {
            var original = new List<User>()
            {
                new User{ Id = 1, Name = "Eric"},
                new User{ Id = 2, Name = "Bell"},
                new User{ Id = 3, Name = "Jane"},
                new User{ Id = 4, Name = "Peter"},
                new User{ Id = 5, Name = "Mary"},
            };

            Console.WriteLine($"original : { JsonConvert.SerializeObject(original)}");

            var remove = new List<User>()
            {
                new User{ Id = 2, Name = "Bell"},
                new User{ Id = 3, Name = "Jane"},
                new User{ Id = 4, Name = "Peter"},
            };

            Console.WriteLine($"remove : { JsonConvert.SerializeObject(remove)}");

            var result = original.Except(remove);

            Console.WriteLine($"result : { JsonConvert.SerializeObject(result)}");
        }
    }
}
