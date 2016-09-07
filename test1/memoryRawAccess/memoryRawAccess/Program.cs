using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace memoryRawAccess
{
    //public struct MEMORY_BASIC_INFORMATION
    //{
    //    public uint BaseAddress;
    //    public uint AllocationBase;
    //    public uint AllocationProtect;  // see MemoryAccessEnum
    //    public uint RegionSize;
    //    public uint State;
    //    public uint Protect;    // see MemoryAccessEnum
    //    public uint Type;
    //}
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public uint AllocationProtect;
        public IntPtr RegionSize;
        public PageState State;
        public AllocationProtect Protect;
        public PageType Type;
    }
    public enum AllocationProtect : uint
    {
        PAGE_EXECUTE = 0x00000010,
        PAGE_EXECUTE_READ = 0x00000020,
        PAGE_EXECUTE_READWRITE = 0x00000040,
        PAGE_EXECUTE_WRITECOPY = 0x00000080,
        PAGE_NOACCESS = 0x00000001,
        PAGE_READONLY = 0x00000002,
        PAGE_READWRITE = 0x00000004,
        PAGE_WRITECOPY = 0x00000008,
        PAGE_GUARD = 0x00000100,
        PAGE_NOCACHE = 0x00000200,
        PAGE_WRITECOMBINE = 0x00000400
    }

    public enum PageState : uint
    {
        MEM_COMMIT = 0x1000,
        MEM_FREE = 0x10000,
        MEM_RESERVE = 0x2000
    }
    public enum PageType : uint
    {
        MEM_IMAGE = 0x1000000,
        MEM_MAPPED = 0x40000,
        MEM_PRIVATE = 0x20000
    }

    class Program
    {
        static void Main(string[] args)
        {

            var query = Encoding.Unicode.GetBytes("HelloWorld");

            const int PROCESS_QUERY_INFORMATION = 0x0400;
            const int MEM_COMMIT = 0x00001000;
            const int PAGE_READWRITE = 0x04;
            const int PROCESS_WM_READ = 0x0010;

            var processs =  Process.GetProcesses();

            var process = processs.FirstOrDefault(p => p.ProcessName == "notepad");
            var processHandle = InvokeHelper.OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ, false, process.Id);

            var allMemoryRegions = GetMemoryRegions(processHandle);

            var allAllocatedRegions = allMemoryRegions.Where(r => r.State == PageState.MEM_COMMIT).ToList();

            var rwMemoryRegions =
                allAllocatedRegions.Where(
                    r => r.Protection == AllocationProtect.PAGE_READWRITE).ToList();


            var result = rwMemoryRegions.SelectMany(r => r.FindBytes(query)).ToList();



            foreach (var address in result)
            {
                var buffer = new byte[query.Length];
                IntPtr bytesRead;

                InvokeHelper.ReadProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out bytesRead);

                Console.WriteLine($"Result found at 0x{address:X8}, value: {Encoding.Unicode.GetString(buffer)}");
            }

            //int bytesRead = 0;
            //byte[] buffer = new byte[24]; //'Hello World!' takes 12*2 bytes because of Unicode 


            //// 0x0046A3B8 is the address where I found the string, replace it with what you found
            //InvokeHelper.ReadProcessMemory((int)processHandle, 0x0046A3B8, buffer, buffer.Length, ref bytesRead);

            //Console.WriteLine(Encoding.Unicode.GetString(buffer) +
            //   " (" + bytesRead.ToString() + "bytes)");
            //Console.ReadLine();
        }

        

        public static IEnumerable<MemoryRegion> GetMemoryRegions(IntPtr processHandle)
        {
            unsafe
            {
                uint bytesRead = 0;
                var list = new List<MemoryRegion>();
                ulong address = 0x00000000;
                do
                {
                    var info = new MEMORY_BASIC_INFORMATION();
                    bytesRead = InvokeHelper.VirtualQueryEx(processHandle, address, ref info, sizeof(MEMORY_BASIC_INFORMATION));

                    if (bytesRead <= 0)
                        continue;

                    var region = new MemoryRegion(processHandle)
                    {
                        Address = address,
                        Size = (ulong)info.RegionSize,
                        Protection = info.Protect,
                        State = info.State,
                        Information = info
                    };

                    list.Add(region);
                    address += (ulong)info.RegionSize;
                } while (bytesRead > 0);
                return list;
            }
        }
    }
}
