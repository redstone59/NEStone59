using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEStone59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MOSEmulator emulator = new MOSEmulator();
            Console.WriteLine(emulator.flags);

            emulator.SetProcessorFlag(ProcessorFlags.InterruptDisable, true);
            Console.WriteLine(emulator.flags);
            Console.WriteLine(emulator.GetProcessorFlag(ProcessorFlags.InterruptDisable));

            emulator.SetProcessorFlag(ProcessorFlags.InterruptDisable, false);
            Console.WriteLine(emulator.flags);
            Console.WriteLine(emulator.GetProcessorFlag(ProcessorFlags.InterruptDisable));

            HangOnEnd();
        }

        static void HangOnEnd()
        {
            Console.WriteLine("\n-- end of program --");
            while (true) ;
        }
    }
}
