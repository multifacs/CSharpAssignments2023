.method public hidebysig 
	instance char[] ToCharArray (
		int32 startIndex,
		int32 length
	) cil managed 
{
	// Method begins at RVA 0x53ba24
	// Header size: 12
	// Code size: 103 (0x67)
	.maxstack 3
	.locals (
		[0] char[]
	)

	IL_0000: ldarg.1
	IL_0001: ldc.i4.0
	IL_0002: blt.s IL_0018

	IL_0004: ldarg.1
	IL_0005: ldarg.0
	IL_0006: call instance int32 System.String::get_Length()
	IL_000b: bgt.s IL_0018

	IL_000d: ldarg.1
	IL_000e: ldarg.0
	IL_000f: call instance int32 System.String::get_Length()
	IL_0014: ldarg.2
	IL_0015: sub
	IL_0016: ble.s IL_0028

	IL_0018: ldstr "startIndex"
	IL_001d: call string System.SR::get_ArgumentOutOfRange_Index()
	IL_0022: newobj instance void System.ArgumentOutOfRangeException::.ctor(string, string)
	IL_0027: throw

	IL_0028: ldarg.2
	IL_0029: ldc.i4.0
	IL_002a: bgt.s IL_0045

	IL_002c: ldarg.2
	IL_002d: brtrue.s IL_0035

	IL_002f: call !!0[] System.Array::Empty<char>()
	IL_0034: ret

	IL_0035: ldstr "length"
	IL_003a: call string System.SR::get_ArgumentOutOfRange_Index()
	IL_003f: newobj instance void System.ArgumentOutOfRangeException::.ctor(string, string)
	IL_0044: throw

	IL_0045: ldarg.2
	IL_0046: newarr System.Char
	IL_004b: stloc.0
	IL_004c: ldloc.0
	IL_004d: call !!0& System.Runtime.InteropServices.MemoryMarshal::GetArrayDataReference<char>(!!0[])
	IL_0052: ldarg.0
	IL_0053: ldflda char System.String::_firstChar
	IL_0058: ldarg.1
	IL_0059: call !!0& Internal.Runtime.CompilerServices.Unsafe::Add<char>(!!0&, int32)
	IL_005e: ldarg.2
	IL_005f: conv.u
	IL_0060: call void System.Buffer::Memmove<char>(!!0&, !!0&, native uint)
	IL_0065: ldloc.0
	IL_0066: ret
} // end of method String::ToCharArray