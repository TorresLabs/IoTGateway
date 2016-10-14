﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waher.Persistence.Attributes;

namespace Waher.Persistence.Files.Test.Classes
{
	public class Default
	{
		[DefaultValue(true)]
		public bool Boolean1 = true;
		[DefaultValue(false)]
		public bool Boolean2 = false;
		[DefaultValue(10)]
		public byte Byte = 10;
		[DefaultValue(10)]
		public short Short = 10;
		[DefaultValue(10)]
		public int Int = 10;
		[DefaultValue(10)]
		public long Long = 10;
		[DefaultValue(10)]
		public sbyte SByte = 10;
		[DefaultValue(10)]
		public ushort UShort = 10;
		[DefaultValue(10)]
		public uint UInt = 10;
		[DefaultValue(10)]
		public ulong ULong = 10;
		[DefaultValue('x')]
		public char Char = 'x';
		[DefaultValue(10)]
		public decimal Decimal = 10;
		[DefaultValue(10)]
		public double Double = 10;
		[DefaultValue(10)]
		public float Single = 10;
		[DefaultValueStringEmpty]
		public string String = string.Empty;
		[DefaultValueDateTimeMinValue]
		public DateTime DateTime = DateTime.MinValue;
		[DefaultValueTimeSpanMinValue]
		public TimeSpan TimeSpan = TimeSpan.MinValue;
		[DefaultValueGuidEmpty]
		public Guid Guid = Guid.Empty;
		[DefaultValue(NormalEnum.Option1)]
		public NormalEnum NormalEnum = NormalEnum.Option1;
		[DefaultValue(FlagsEnum.Option1 | FlagsEnum.Option2)]
		public FlagsEnum FlagsEnum = FlagsEnum.Option1 | FlagsEnum.Option2;

		public Default()
		{
		}
	}
}
