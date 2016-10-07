using System;
using System.Runtime.InteropServices;

namespace memoryRawAccess
{
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

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    public static class InvokeHelper
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        //[DllImport("Kernel32.Dll")]
        //public static extern bool ReadProcessMemory(
        //    IntPtr processHandle, 
        //    ulong address, 
        //    byte[] buffer, 
        //    uint size, 
        //    ref uint bytesRead);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            [Out] byte[] lpBuffer,
            int dwSize,
            out IntPtr lpNumberOfBytesRead);


        //[DllImport("kernel32.dll", SetLastError = true)]
        //static extern bool ReadProcessMemory(
        //    IntPtr hProcess,
        //    IntPtr lpBaseAddress,
        //    IntPtr lpBuffer,
        //    int dwSize,
        //    out IntPtr lpNumberOfBytesRead);


        [DllImport("Kernel32.Dll")]
        public static extern uint VirtualQueryEx(IntPtr processHandle, ulong address, 
            ref MEMORY_BASIC_INFORMATION memInfo, int memInfoLength);

        [DllImport("Kernel32.Dll")]
        public static extern uint GetLastError();
        [DllImport("Kernel32.Dll")]
        public static extern uint FormatMessage(uint dwFlags, uint lpSource, uint dwMessageId, uint dwLanguageId, byte[] lpBuffer, uint nSize, uint arguments);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}