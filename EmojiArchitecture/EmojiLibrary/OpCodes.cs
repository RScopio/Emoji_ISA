using System;

namespace EmojiLibrary
{
    public enum OpCodes
    {
        //Special Ops
        nop = 0x00,
        loadprog,

        //Math
        inc = 0x10,
        dec,
        add,
        sub,
        mul,
        div,
        mod,

        //Logic
        xor = 0x20,
        or,
        and,
        not,
        shl,
        shr,

        //Flow
        ret = 0x30,
        lt,
        lteq,
        eq,
        call,
        br,
        brz,
        brnz,

        //Memory
        push = 0x40,
        pop,
        mov,
        store,

        //Indirects
        calli = 0x50,
        bri,
        brzi,
        brnzi,
        loadi,
        storei
    }
}
