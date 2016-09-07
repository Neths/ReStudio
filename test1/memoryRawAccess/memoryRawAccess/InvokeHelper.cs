using System;
using System.Runtime.InteropServices;

namespace memoryRawAccess
{
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
    }
}