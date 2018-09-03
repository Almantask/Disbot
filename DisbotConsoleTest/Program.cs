using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disbot;

namespace DisbotConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask a question");
            var userText = Console.ReadLine();
            var bot = new CoreBot();
            bot.Add("Cause your mom is gay");
            var response = bot.PickResponse(userText);
            Console.WriteLine(response);
            Console.ReadKey();
        }
    }
}
