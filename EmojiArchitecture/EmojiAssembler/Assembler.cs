using System;
using System.Collections.Generic;
using System.Text;

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
                var instruction = new StringBuilder(lines[i]);
                //clear comment
                //remove line if empty
                //read op code
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
