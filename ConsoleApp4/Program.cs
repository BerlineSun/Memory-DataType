Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"-----------------------------------------------------------------------------");
Console.WriteLine($"Type\tByte(s) of memory\t\t  Min\t\t\t\t  Max");
Console.WriteLine($"-----------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"sbyte{sizeof(sbyte),6}{sbyte.MinValue,34}{sbyte.MaxValue,32}");
Console.WriteLine($"byte{sizeof(byte),7}{byte.MinValue,34}{byte.MaxValue,32}");
Console.WriteLine($"short{sizeof(short),6}{short.MinValue,34}{short.MaxValue,32}");
Console.WriteLine($"ushort{sizeof(ushort),5}{ushort.MinValue,34}{ushort.MaxValue,32}");
Console.WriteLine($"int{sizeof(int),8}{int.MinValue,34}{int.MaxValue,32}");
Console.WriteLine($"uint{sizeof(uint),7}{uint.MinValue,34}{uint.MaxValue,32}");
Console.WriteLine($"long{sizeof(long),7}{long.MinValue,34}{long.MaxValue,32}");
Console.WriteLine($"ulong{sizeof(ulong),6}{ulong.MinValue,34}{ulong.MaxValue,32}");
Console.WriteLine($"float{sizeof(float),6}{float.MinValue,34}{float.MaxValue,32}");
Console.WriteLine($"double{sizeof(double),5}{double.MinValue,34}{double.MaxValue,32}");
Console.WriteLine($"decimal{sizeof(decimal),4}{decimal.MinValue,34}{decimal.MaxValue,32}");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"-----------------------------------------------------------------------------");
Console.ResetColor();