using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x02000473 RID: 1139
[Token(Token = "0x2000473")]
public class StringOption : OptionBehaviour
{
	// Token: 0x0600184D RID: 6221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x764140", Offset = "0x763540", VA = "0x10764140")]
	public void OnEnable()
	{
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184E")]
	[Address(RVA = "0x764010", Offset = "0x763410", VA = "0x10764010")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184F")]
	[Address(RVA = "0x7640D0", Offset = "0x7634D0", VA = "0x107640D0")]
	public void Increase()
	{
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x763FA0", Offset = "0x7633A0", VA = "0x10763FA0")]
	public void Decrease()
	{
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x000079F8 File Offset: 0x00005BF8
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00", Slot = "5")]
	public override int GetInt()
	{
		return 0;
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x6D5450", Offset = "0x6D4850", VA = "0x106D5450")]
	public StringOption()
	{
	}

	// Token: 0x04001870 RID: 6256
	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro TitleText;

	// Token: 0x04001871 RID: 6257
	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro ValueText;

	// Token: 0x04001872 RID: 6258
	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x1C")]
	public StringNames[] Values;

	// Token: 0x04001873 RID: 6259
	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x20")]
	public int Value;

	// Token: 0x04001874 RID: 6260
	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0x24")]
	private int oldValue;
}
