using System;
using System.Runtime.InteropServices;

namespace C__keylogger
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            const int hidvalue = 0;
            var hideMe = GetConsoleWindow();
            Console.WriteLine("Hello World!");
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)] //kernel32:It handles memory management, input/output operations, and interrupts
        private static extern IntPtr GetModuleHandle(string lpModuleName); //about Extern: The extern modifier is typically used in conjunction with a DllImport attribute, allowing external methods to be implemented by DLLs (Dynamic Link Libraries). 

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
    }
}
