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
		// Method begins at RVA 0x2090
		// Header size: 12
		// Code size: 175 (0xaf)
		.maxstack 3
		.entrypoint
		.locals init (
			[0] string userInput,
			[1] string[] stringArray,
			[2] valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal> x,
			[3] valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal> y,
			[4] valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler
		)

		IL_0000: br IL_0095
		// loop start (head: IL_0095)
			IL_0005: nop
			.try
			{
				IL_0006: ldloc.0
				IL_0007: ldstr ","
				IL_000c: ldc.i4.0
				IL_000d: callvirt instance string[] [System.Runtime]System.String::Split(string, valuetype [System.Runtime]System.StringSplitOptions)
				IL_0012: stloc.1
				IL_0013: leave.s IL_0022
			} // end .try
			catch [System.Runtime]System.Object
			{
				IL_0015: pop
				IL_0016: ldstr "Wrong format"
				IL_001b: call void [System.Console]System.Console::WriteLine(string)
				IL_0020: leave.s IL_0095
			} // end handler

			IL_0022: nop
			.try
			{
				IL_0023: ldloc.1
				IL_0024: ldc.i4.0
				IL_0025: ldelem.ref
				IL_0026: call class [System.Runtime]System.Globalization.CultureInfo [System.Runtime]System.Globalization.CultureInfo::get_InvariantCulture()
				IL_002b: call valuetype [System.Runtime]System.Decimal [System.Runtime]System.Decimal::Parse(string, class [System.Runtime]System.IFormatProvider)
				IL_0030: newobj instance void valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>::.ctor(!0)
				IL_0035: stloc.2
				IL_0036: ldloc.1
				IL_0037: ldc.i4.1
				IL_0038: ldelem.ref
				IL_0039: call class [System.Runtime]System.Globalization.CultureInfo [System.Runtime]System.Globalization.CultureInfo::get_InvariantCulture()
				IL_003e: call valuetype [System.Runtime]System.Decimal [System.Runtime]System.Decimal::Parse(string, class [System.Runtime]System.IFormatProvider)
				IL_0043: newobj instance void valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>::.ctor(!0)
				IL_0048: stloc.3
				IL_0049: leave.s IL_0058
			} // end .try
			catch [System.Runtime]System.Object
			{
				IL_004b: pop
				IL_004c: ldstr "Wrong format"
				IL_0051: call void [System.Console]System.Console::WriteLine(string)
				IL_0056: leave.s IL_0095
			} // end handler

			IL_0058: ldloca.s 4
			IL_005a: ldc.i4.7
			IL_005b: ldc.i4.2
			IL_005c: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32, int32)
			IL_0061: ldloca.s 4
			IL_0063: ldstr "X: "
			IL_0068: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
			IL_006d: ldloca.s 4
			IL_006f: ldloc.2
			IL_0070: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>>(!!0)
			IL_0075: ldloca.s 4
			IL_0077: ldstr " Y: "
			IL_007c: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
			IL_0081: ldloca.s 4
			IL_0083: ldloc.3
			IL_0084: call instance void [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<valuetype [System.Runtime]System.Nullable`1<valuetype [System.Runtime]System.Decimal>>(!!0)
			IL_0089: ldloca.s 4
			IL_008b: call instance string [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
			IL_0090: call void [System.Console]System.Console::WriteLine(string)

			IL_0095: call string [System.Console]System.Console::ReadLine()
			IL_009a: dup
			IL_009b: stloc.0
			IL_009c: brfalse.s IL_00ae

			IL_009e: ldloc.0
			IL_009f: ldstr ""
			IL_00a4: call bool [System.Runtime]System.String::op_Inequality(string, string)
			IL_00a9: brtrue IL_0005
		// end loop

		IL_00ae: ret
	} // end of method Program::Main

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		// Method begins at RVA 0x2168
		// Header size: 1
		// Code size: 7 (0x7)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Object::.ctor()
		IL_0006: ret
	} // end of method Program::.ctor

} // end of class Program
