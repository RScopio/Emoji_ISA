using System;
using System.Collections.Generic;

namespace EmojiLibrary
{
    public enum OpFormat
    {
        PPP,
        PPR,
        PRR,
        RRR,
        PV,
        RV
    }

    public static class EmojiInfo
    {
        public static readonly Dictionary<string, (byte OpCode, OpFormat Format)> OpCodes = new Dictionary<string, (byte OpCode, OpFormat Format)>()
        {
            //Special Ops
            { "⛔", (0x00, OpFormat.PPP) },//nop
            { "📟", (0x01, OpFormat.RV) },//loadprog

            //Math
            { "👆", (0x10, OpFormat.PPR) },//inc
            { "👇", (0x11, OpFormat.PPR) },//dec
            { "➕", (0x12, OpFormat.RRR) },//add
            { "➖", (0x13, OpFormat.RRR) },//sub
            { "✖", (0x14, OpFormat.RRR) },//mult
            { "➗", (0x15, OpFormat.RRR) },//div
            { "🥟", (0x16, OpFormat.RRR) },//mod

            //Logic
            { "⭕", (0x20, OpFormat.RRR) },//xor
            { "🅾", (0x21, OpFormat.RRR) },//or
            { "🅰", (0x22, OpFormat.RRR) },//and
            { "❗", (0x23, OpFormat.RRR) },//not
            { "⏪", (0x24, OpFormat.RRR) },//shift left
            { "⏩", (0x25, OpFormat.RRR) },//shift right

            //Flow 
            { "☎", (0x30, OpFormat.PPP) },//return
            { "🌑", (0x31, OpFormat.RRR) },//less than
            { "🌓", (0x32, OpFormat.RRR) },//less than or equal
            { "🌕", (0x33, OpFormat.RRR) },//equal
            { "📞", (0x34, OpFormat.PV) },//call
            { "🌿", (0x35, OpFormat.PV) },//branch
            { "🍂", (0x36, OpFormat.RV) },//branch if zero (false)
            { "🍃", (0x37, OpFormat.RV) },//branch if not zero (true)

            //Memory
            { "📌", (0x40, OpFormat.PPR) },//push
            { "🍿", (0x41, OpFormat.PPR) },//pop
            { "🎬", (0x42, OpFormat.PRR) },//mov
            { "🏪", (0x43, OpFormat.RV) },//store
            { "💩", (0x44, OpFormat.RV) },//load
            { "💎", (0x45, OpFormat.RV) },//set

            //Indirects
            {"📱", (0x50, OpFormat.PPR) },//calli
            {"🔜", (0x51, OpFormat.PPR) },//branchi
            {"🔄", (0x52, OpFormat.PRR) },//branch if zero i
            {"🔀", (0x53, OpFormat.PRR) },//branch if not zero i
            {"⬆", (0x54, OpFormat.PRR) },//loadi
            {"⬇", (0x55, OpFormat.PRR) },//storei
        };
    }
}
