using System;
using System.IO;
using System.Linq;

namespace EmojiAssembler
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                var data = Assembler.Assemble(lines);
                File.WriteAllBytes("output.emoji", data.ToArray());
                Console.WriteLine("\nSuccess");
            }
            else
            {
                Console.WriteLine("\nError: File not found.");
            }
        }
    }
}
