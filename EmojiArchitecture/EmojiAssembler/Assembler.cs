using System;
using System.Collections.Generic;
using System.Text;
using EmojiLibrary;

namespace EmojiAssembler
{
    public static class Assembler
    {
        public static List<byte> Assemble(ReadOnlySpan<string> lines)
        {
            var output = new List<byte>();
            var labels = new Dictionary<string, byte>();

            for (int i = 0; i < lines.Length; i++)
            {
                var instruction = lines[i].Split(';')[0].Trim().Split(' ');
                if (instruction.Length == 0) continue;
                if (!EmojiInfo.OpCodes.ContainsKey(instruction[0]))
                {
                    throw new InvalidOperationException($"\nError: Invalid OpCode {instruction[0]} on line { i + 1 }");
                }

                switch (EmojiInfo.OpCodes[instruction[0]].Format)
                {
                    case OpFormat.PPP:
                        break;
                    case OpFormat.PPR:
                        break;
                    case OpFormat.PRR:
                        break;
                    case OpFormat.RRR:
                        break;
                    case OpFormat.PV:
                        break;
                    case OpFormat.RV:
                        break;
                }

                //check if format valid
                //convert each argument
                //if label, store line number + 1
                //if found discovered label, replace with line number
                //if label not found yet, keep reference to line and change when label is found
            }

            return output;
        }
    }
}
