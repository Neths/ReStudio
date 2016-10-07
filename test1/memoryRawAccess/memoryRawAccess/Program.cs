using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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




    class Program
    {
        static void Main(string[] args)
        {
            var proc = Process.GetProcessesByName("notepad")[0];

            InvokeHelper.SetForegroundWindow(proc.MainWindowHandle);

            var rect = new Rect();
            InvokeHelper.GetWindowRect(proc.MainWindowHandle, ref rect);

            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

            bmp.Save("c:\\test.png", ImageFormat.Png);
        }

        //static void Main(string[] args)
        //{

        //    var query = Encoding.Unicode.GetBytes("HelloWorld");

        //    const int PROCESS_QUERY_INFORMATION = 0x0400;
        //    const int MEM_COMMIT = 0x00001000;
        //    const int PAGE_READWRITE = 0x04;
        //    const int PROCESS_WM_READ = 0x0010;

        //    var processs =  Process.GetProcesses();

        //    var process = processs.FirstOrDefault(p => p.ProcessName == "notepad");
        //    var processHandle = InvokeHelper.OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ, false, process.Id);

        //    var allMemoryRegions = GetMemoryRegions(processHandle);

        //    var allAllocatedRegions = allMemoryRegions.Where(r => r.State == PageState.MEM_COMMIT).ToList();

        //    var rwMemoryRegions =
        //        allAllocatedRegions.Where(
        //            r => r.Protection == AllocationProtect.PAGE_READWRITE).ToList();


        //    var result = rwMemoryRegions
        //        .Select(r => new { Region = r, Addresses = r.FindBytes(query).ToList() })
        //        .Where(t => t.Addresses.Any()).ToList();

        //    result.ForEach(t =>
        //    {
        //        Console.WriteLine($"Region address 0x{t.Region.Address:X8}");

        //        t.Addresses.ForEach(a =>
        //        {
        //            var buffer = new byte[query.Length];
        //            IntPtr bytesRead;

        //            InvokeHelper.ReadProcessMemory(processHandle, (IntPtr)a, buffer, buffer.Length, out bytesRead);

        //            Console.WriteLine($"Result found at 0x{a:X8}, value: {Encoding.Unicode.GetString(buffer)}");
        //        });
        //    });

        //    //int bytesRead = 0;
        //    //byte[] buffer = new byte[24]; //'Hello World!' takes 12*2 bytes because of Unicode 


        //    //// 0x0046A3B8 is the address where I found the string, replace it with what you found
        //    //InvokeHelper.ReadProcessMemory((int)processHandle, 0x0046A3B8, buffer, buffer.Length, ref bytesRead);

        //    //Console.WriteLine(Encoding.Unicode.GetString(buffer) +
        //    //   " (" + bytesRead.ToString() + "bytes)");
        //    //Console.ReadLine();
        //}



        //public static IEnumerable<MemoryRegion> GetMemoryRegions(IntPtr processHandle)
        //{
        //    unsafe
        //    {
        //        uint bytesRead = 0;
        //        var list = new List<MemoryRegion>();
        //        ulong address = 0x00000000;
        //        do
        //        {
        //            var info = new MEMORY_BASIC_INFORMATION();
        //            bytesRead = InvokeHelper.VirtualQueryEx(processHandle, address, ref info, sizeof(MEMORY_BASIC_INFORMATION));

        //            if (bytesRead <= 0)
        //                continue;

        //            var region = new MemoryRegion(processHandle)
        //            {
        //                Address = address,
        //                Size = (ulong)info.RegionSize,
        //                Protection = info.Protect,
        //                State = info.State,
        //                Information = info
        //            };

        //            list.Add(region);
        //            address += (ulong)info.RegionSize;
        //        } while (bytesRead > 0);
        //        return list;
        //    }
        //}
    }
}
