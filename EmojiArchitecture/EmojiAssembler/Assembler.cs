using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using EmojiLibrary;

namespace EmojiAssembler
{
    public static class Assembler
    {
        public static List<byte> Assemble(ReadOnlySpan<string> input)
        {
            var lines = new List<string>();
            var output = new List<byte>();
            var labels = new Dictionary<string, byte>();
            bool isProgMem = false;

            //clean comments, tag lables
            for (int i = 0; i < input.Length; i++)
            {
                if (lines[i].Trim() == "PROGMEM")
                {
                    isProgMem = true;
                    continue;
                }

                if (isProgMem)
                {
                    bool isValid = Regex.IsMatch(lines[i], "(.*):(\\s*)\"(.*)\"");

                    //label & comment
                    //comment
                    //label
                    //neither

                    var line = lines[i];
                }
                else
                {
                    //clear comments
                    var line = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries)[0].Trim();

                    //add labels
                    if (line.Contains(":"))
                    {
                        labels.Add(line.Split(':')[0], (byte)lines.Count);
                        continue;
                    }

                    lines.Add(line);
                }
            }

            //op code assembly
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                if (line.Length == 0) continue;

                if (line.Contains("PROGMEM:"))
                {
                    //progmem
                    isProgmem = true;
                }
                else if (line.Contains(":"))
                {
                    //label
                }
                //.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!EmojiInfo.OpCodes.ContainsKey(instruction[0]))
                {
                    throw new InvalidOperationException($"\nError: Invalid OpCode {instruction[0]} on line { i + 1 }");
                }

                byte[] bytes = new byte[4];

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
