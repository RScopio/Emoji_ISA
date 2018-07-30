using System;
using System.Collections.Generic;
using System.Text;

namespace EmojiEmulator
{
    class MemoryMappedIO
    {

        private Memory<ushort> memoryMapSpace;

        void func()
        {
            Span<ushort> data = memoryMapSpace.Span;

            data[0] = 42;

            
        }

    }
}
