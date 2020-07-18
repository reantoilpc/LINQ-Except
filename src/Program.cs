using System.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using src.Model;
using src.Infrastructure;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // 字串型別
            //DisplayStringExcept();

            // 自訂型別 User
            //DisplayUserExcept();

            // 自訂型別 Member 實作 IEquatable<T>
            //DisplayMemberExcept();

            // 自訂型別 User 自訂 UserComparer 實作 IEqualityComparer<T>
            DisplayUserExceptByComparer();
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
        static void DisplayUserExcept()
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
        static void DisplayMemberExcept()
        {
            var original = new List<Member>()
            {
                new Member{ Id = 1, Name = "Eric"},
                new Member{ Id = 2, Name = "Bell"},
                new Member{ Id = 3, Name = "Jane"},
                new Member{ Id = 4, Name = "Peter"},
                new Member{ Id = 5, Name = "Mary"},
            };

            Console.WriteLine($"original : { JsonConvert.SerializeObject(original)}");

            var remove = new List<Member>()
            {
                new Member{ Id = 2, Name = "Bell"},
                new Member{ Id = 3, Name = "Jane"},
                new Member{ Id = 4, Name = "Peter"},
            };

            Console.WriteLine($"remove : { JsonConvert.SerializeObject(remove)}");

            var result = original.Except(remove);

            Console.WriteLine($"result : { JsonConvert.SerializeObject(result)}");
        }
        static void DisplayUserExceptByComparer()
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

            var result = original.Except(remove, new UserComparer());

            Console.WriteLine($"result : { JsonConvert.SerializeObject(result)}");
        }
    }
}
