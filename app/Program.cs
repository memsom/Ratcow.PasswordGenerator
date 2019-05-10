using System;

namespace Ratcow.PasswordGenerator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new BlocksEngine();
            for (var i = 0; i < 1000; i++)
            {
                var result = engine.Generate(12);

                Console.WriteLine(result);
            }

            //Console.WriteLine("-------------------------");

            //var engine2 = new Engine();
            //for (var i = 0; i < 1000; i++)
            //{
            //    var result = engine.Generate(12);

            //    Console.WriteLine(result);
            //}
        }
    }
}
