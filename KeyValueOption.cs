using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

// Token: 0x02000464 RID: 1124
[Token(Token = "0x2000464")]
public class KeyValueOption : OptionBehaviour
{
	// Token: 0x060017FE RID: 6142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017FE")]
	[Address(RVA = "0x6D52D0", Offset = "0x6D46D0", VA = "0x106D52D0")]
	public void OnEnable()
	{
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x6D5170", Offset = "0x6D4570", VA = "0x106D5170")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001800")]
	[Address(RVA = "0x6D5260", Offset = "0x6D4660", VA = "0x106D5260")]
	public void Increase()
	{
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001801")]
	[Address(RVA = "0x6D5100", Offset = "0x6D4500", VA = "0x106D5100")]
	public void Decrease()
	{
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x000078D8 File Offset: 0x00005AD8
	[Token(Token = "0x6001802")]
	[Address(RVA = "0x6D51F0", Offset = "0x6D45F0", VA = "0x106D51F0", Slot = "5")]
	public override int GetInt()
	{
		return 0;
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001803")]
	[Address(RVA = "0x6D5450", Offset = "0x6D4850", VA = "0x106D5450")]
	public KeyValueOption()
	{
	}

	// Token: 0x04001813 RID: 6163
	[Token(Token = "0x4001813")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro TitleText;

	// Token: 0x04001814 RID: 6164
	[Token(Token = "0x4001814")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro ValueText;

	// Token: 0x04001815 RID: 6165
	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0x1C")]
	public List<KeyValuePair<string, int>> Values;

	// Token: 0x04001816 RID: 6166
	[Token(Token = "0x4001816")]
	[FieldOffset(Offset = "0x20")]
	private int Selected;

	// Token: 0x04001817 RID: 6167
	[Token(Token = "0x4001817")]
	[FieldOffset(Offset = "0x24")]
	private int oldValue;
}
