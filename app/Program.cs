using System;

namespace Ratcow.PasswordGenerator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            for (var i = 0; i < 10; i++)
            {
                var result = engine.Generate(12);

                Console.WriteLine(result);
            }
        }
    }
}
