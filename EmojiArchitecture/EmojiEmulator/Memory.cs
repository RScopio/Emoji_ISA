using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;

namespace EmojiEmulator
{
    public class Memory
    {
        //span is a ref struct which cannot be put on the heap
        private ushort[] memory = new ushort[0xFFFF + 1];

        public Memory(ReadOnlySpan<byte> programData)
        {
            //span is pointer and length
            Span<ushort> programSpace = memory.AsSpan().Slice(0x8000); //programSpace[0] == memory[8000]

            Span<byte> programSpaceBytes = MemoryMarshal.AsBytes(programSpace); //cast down
            Span<int> programSpaceInt = MemoryMarshal.Cast<ushort, int>(programSpace); //cast up

            Span<byte> test = MemoryMarshal.AsBytes(programSpace);
            programData.CopyTo(test); //copies programData into test which is part of program space which is part of memory[]
        }

        public Span<ushort> GetMemoryMappedIO()
        {
            return memory.AsSpan().Slice(0, 128); //length is in ushorts
        }

        public ReadOnlySpan<byte> ProgramSpace => MemoryMarshal.AsBytes(memory.AsSpan().Slice(0x8000));
        public ref ushort this[int index] => ref memory[index];
    }
}
