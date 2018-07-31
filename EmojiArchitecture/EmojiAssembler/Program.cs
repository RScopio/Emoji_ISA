using System;
using System.IO;
using EmojiLibrary;

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
                Console.WriteLine("Success.");
            }
            else
            {
                Console.WriteLine("Error: File not found.");
            }
        }
    }
}
