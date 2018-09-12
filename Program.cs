using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace C__keylogger
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            const int SW_HIDE = 0;
            var hideMe = GetConsoleWindow();
            ShowWindow(hideMe, SW_HIDE);
            //Console.WriteLine("Hello World!");
            Process cmd = new Process();
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)] //kernel32:It handles memory management, input/output operations, and interrupts
        private static extern IntPtr GetModuleHandle(string lpModuleName); //about Extern: The extern modifier is typically used in conjunction with a DllImport attribute, allowing external methods to be implemented by DLLs (Dynamic Link Libraries). 

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
    }
}
