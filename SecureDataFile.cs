using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000451 RID: 1105
[Token(Token = "0x2000451")]
public class SecureDataFile
{
	// Token: 0x1700036B RID: 875
	// (get) Token: 0x0600178F RID: 6031 RVA: 0x000077D0 File Offset: 0x000059D0
	// (set) Token: 0x06001790 RID: 6032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700036B")]
	public bool Loaded
	{
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x28A640", Offset = "0x289A40", VA = "0x1028A640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x58E690", Offset = "0x58DA90", VA = "0x1058E690")]
	public SecureDataFile(string filePath)
	{
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x58DDD0", Offset = "0x58D1D0", VA = "0x1058DDD0")]
	public void LoadData(Action<BinaryReader> performRead)
	{
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x58E210", Offset = "0x58D610", VA = "0x1058E210")]
	public void SaveData(params object[] items)
	{
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001794")]
	[Address(RVA = "0x58DD30", Offset = "0x58D130", VA = "0x1058DD30")]
	public void Delete()
	{
	}

	// Token: 0x040017A5 RID: 6053
	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Loaded>k__BackingField;

	// Token: 0x040017A6 RID: 6054
	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0xC")]
	private string filePath;
}
