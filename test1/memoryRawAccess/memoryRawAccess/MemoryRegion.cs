using System;
using System.Collections;
using System.Collections.Generic;

namespace memoryRawAccess
{
    public class MemoryRegion
    {
        public ulong Address;
        public ulong Size;
        public AllocationProtect Protection;
        public MEMORY_BASIC_INFORMATION Information;
        public PageState State;

        private byte[] _buffer;

        public MemoryRegion(IntPtr processHandle)
        {
            ProcessHandle = processHandle;
        }

        public IntPtr ProcessHandle { get; private set; }

        public byte[] GetBytes()
        {
            if (Size >= 0x8000000)
                return new byte[0];

            var buffer = new byte[Size];
            IntPtr bytesRead;

            if (InvokeHelper.ReadProcessMemory(ProcessHandle, (IntPtr)Address, buffer, buffer.Length, out bytesRead))
                return buffer;

            Console.WriteLine($"[0x{Address:X8}]Error reading memory: {InvokeHelper.GetLastError()}");
            var buf = new byte[256];
            var bytes = InvokeHelper.FormatMessage(0x1000, 0, 6, 0, buf, 255, 0);
            if (bytes == 0)
            {
                Console.WriteLine($"[0x{Address:X8}]Error with FormatMessage(): {InvokeHelper.GetLastError()}");
            }
            else
            {
                Console.Write($"[0x{Address:X8}]Error message: {System.Text.Encoding.ASCII.GetString(buf, 0, (int) bytes)}");
            }
            return null;
        }

        public IEnumerable<ulong> FindBytes(byte[] searchBytes)
        {
            if (_buffer == null)
                _buffer = GetBytes();

            if (_buffer == null || searchBytes == null || searchBytes.Length == 0)
            {
                return new ulong[0];
            }
            var list = new List<ulong>();

            uint i;
            for (i = 0; i < _buffer.Length - searchBytes.Length; i++)
            {
                if (_buffer[i] == searchBytes[0])
                {
                    uint j;
                    for (j = 1; j < searchBytes.Length; j++)
                    {
                        if (_buffer[i + j] != searchBytes[j])
                            break;
                    }

                    if (j >= searchBytes.Length)
                    {
                        list.Add(i + Address);
                        if (list.Count >= 32768)
                            break;
                    }
                }
            }
            return list;
        }
    }
}