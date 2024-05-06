using System;
using System.ComponentModel;

enum ProcessorFlags : byte
{
	Carry = 1 << 0,
	Zero = 1 << 1,
	InterruptDisable = 1 << 2,
	Decimal	= 1 << 3, // Ricoh 2A03 doesn't have this, but it can be modified.
	Break = 1 << 4, // I think that's what this is? https://www.nesdev.org/wiki/Status_flags#The_B_flag
	// The fifth bit is always pushed as 1.
	Overflow = 1 << 6,
	Negative = 1 << 7
}

namespace NEStone59
{
	internal class MOSEmulator
	{
		/*
		 * All register information and quotes taken from:
		 * http://www.6502.org/users/obelisk/6502/registers.html
		 * 
		 */
		public ushort programCounter; // "points to the next instruction to be executed."
		public byte stackPointer; // "holds the low 8 bits of the next location on the stack" (high byte always 0x01)

        public byte accumulator; // "used in all arithmetic and logical operations"
        public byte xRegister;
        public byte yRegister;

        public byte flags = 0;

		public MOSEmulator()
		{
			
		}

        public void SetProcessorFlag(ProcessorFlags flag, bool value)
		{
			if (value) flags |= (byte)flag;
			else flags &= (byte)~flag;
		}

        public bool GetProcessorFlag(ProcessorFlags flag)
		{
			return (flags & (byte)flag) > 1;
		}
	}
}