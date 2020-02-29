using System;
using System.Text;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            var answer = Console.ReadLine();
            var output = new StringBuilder();
            var count = 0;
            foreach (char c in answer)
            {
                output.Append(Char.ToUpper(c));
                for (var i = 0; i < count; i++)
                    output.Append(Char.ToLower(c));
                count++;
                if (count < answer.Length)
                {
                    output.Append('-');
                }
            };
            Console.WriteLine($"Output: {output.ToString()}");
            Console.ReadLine();
        }
    }
}
