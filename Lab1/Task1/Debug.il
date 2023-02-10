.class private auto ansi beforefieldinit Program
	extends [System.Runtime]System.Object
{
	// Methods
	.method private hidebysig static 
		void Main (
			string[] args
		) cil managed 
	{
		.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
			01 00 01 00 00
		)
		// Method begins at RVA 0x2094
		// Header size: 12
		// Code size: 197 (0xc5)
		.maxstack 3
		.entrypoint
		.locals init (
			[0] string userInput,
			[1] string[] stringArray,
			[2] valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal> x,
			[3] valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal> y,
			[4] valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler,
			[5] bool
		)

		IL_0000: nop
		IL_0001: br IL_00a4
		// loop start (head: IL_00a4)
			IL_0006: nop
			.try
			{
				IL_0007: nop
				IL_0008: ldloc.0
				IL_0009: ldstr ","
				IL_000e: ldc.i4.0
				IL_000f: callvirt instance string[] [System.Runtime]System.String::Split(string, valuetype [System.Runtime]System.StringSplitOptions)
				IL_0014: stloc.1
				IL_0015: nop
				IL_0016: leave.s IL_0027
			} // end .try
			catch [System.Runtime]System.Object
			{
				IL_0018: pop
				IL_0019: nop
				IL_001a: ldstr "Wrong format"
				IL_001f: call void [System.Console]System.Console::WriteLine(string)
				IL_0024: nop
				IL_0025: leave.s IL_00a4
			} // end handler

			IL_0027: nop
			.try
			{
				IL_0028: nop
				IL_0029: ldloc.1
				IL_002a: ldc.i4.0
				IL_002b: ldelem.ref
				IL_002c: call class [System.Runtime]System.Globalization.CultureInfo [System.Runtime]System.Globalization.CultureInfo::get_InvariantCulture()
				IL_0031: call valuetype [System.Runtime]System.Decimal [System.Runtime]System.Decimal::Parse(string, class [System.Runtime]System.IFormatProvider)
				IL_0036: newobj instance void valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>::.ctor(!0)
				IL_003b: stloc.2
				IL_003c: ldloc.1
				IL_003d: ldc.i4.1
				IL_003e: ldelem.ref
				IL_003f: call class [System.Runtime]System.Globalization.CultureInfo [System.Runtime]System.Globalization.CultureInfo::get_InvariantCulture()
				IL_0044: call valuetype [System.Runtime]System.Decimal [System.Runtime]System.Decimal::Parse(string, class [System.Runtime]System.IFormatProvider)
				IL_0049: newobj instance void valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>::.ctor(!0)
				IL_004e: stloc.3
				IL_004f: nop
				IL_0050: leave.s IL_0061
			} // end .try
			catch [System.Runtime]System.Object
			{
				IL_0052: pop
				IL_0053: nop
				IL_0054: ldstr "Wrong format"
				IL_0059: call void [System.Console]System.Console::WriteLine(string)
				IL_005e: nop
				IL_005f: leave.s IL_00a4
			} // end handler

			IL_0061: ldloca.s 4
			IL_0063: ldc.i4.7
			IL_0064: ldc.i4.2
			IL_0065: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32, int32)
			IL_006a: ldloca.s 4
			IL_006c: ldstr "X: "
			IL_0071: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
			IL_0076: nop
			IL_0077: ldloca.s 4
			IL_0079: ldloc.2
			IL_007a: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>>(!!0)
			IL_007f: nop
			IL_0080: ldloca.s 4
			IL_0082: ldstr " Y: "
			IL_0087: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
			IL_008c: nop
			IL_008d: ldloca.s 4
			IL_008f: ldloc.3
			IL_0090: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>>(!!0)
			IL_0095: nop
			IL_0096: ldloca.s 4
			IL_0098: call instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
			IL_009d: call void [System.Console]System.Console::WriteLine(string)
			IL_00a2: nop
			IL_00a3: nop

			IL_00a4: call string [System.Console]System.Console::ReadLine()
			IL_00a9: dup
			IL_00aa: stloc.0
			IL_00ab: brfalse.s IL_00ba

			IL_00ad: ldloc.0
			IL_00ae: ldstr ""
			IL_00b3: call bool [System.Runtime]System.String::op_Inequality(string, string)
			IL_00b8: br.s IL_00bb

			IL_00ba: ldc.i4.0

			IL_00bb: stloc.s 5
			IL_00bd: ldloc.s 5
			IL_00bf: brtrue IL_0006
		// end loop

		IL_00c4: ret
	} // end of method Program::Main

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		// Method begins at RVA 0x2184
		// Header size: 1
		// Code size: 8 (0x8)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Object::.ctor()
		IL_0006: nop
		IL_0007: ret
	} // end of method Program::.ctor

} // end of class Program
