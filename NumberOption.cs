using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x0200046A RID: 1130
[Token(Token = "0x200046A")]
public class NumberOption : OptionBehaviour
{
	// Token: 0x0600180E RID: 6158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180E")]
	[Address(RVA = "0x77B430", Offset = "0x77A830", VA = "0x1077B430")]
	public void OnEnable()
	{
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x77B1E0", Offset = "0x77A5E0", VA = "0x1077B1E0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001810")]
	[Address(RVA = "0x77B3C0", Offset = "0x77A7C0", VA = "0x1077B3C0")]
	public void Increase()
	{
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001811")]
	[Address(RVA = "0x77B170", Offset = "0x77A570", VA = "0x1077B170")]
	public void Decrease()
	{
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x000078F0 File Offset: 0x00005AF0
	[Token(Token = "0x6001812")]
	[Address(RVA = "0x77B390", Offset = "0x77A790", VA = "0x1077B390", Slot = "4")]
	public override float GetFloat()
	{
		return 0f;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x00007908 File Offset: 0x00005B08
	[Token(Token = "0x6001813")]
	[Address(RVA = "0x77B3A0", Offset = "0x77A7A0", VA = "0x1077B3A0", Slot = "5")]
	public override int GetInt()
	{
		return 0;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001814")]
	[Address(RVA = "0x77B660", Offset = "0x77AA60", VA = "0x1077B660")]
	public NumberOption()
	{
	}

	// Token: 0x0400182F RID: 6191
	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro TitleText;

	// Token: 0x04001830 RID: 6192
	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro ValueText;

	// Token: 0x04001831 RID: 6193
	[Token(Token = "0x4001831")]
	[FieldOffset(Offset = "0x1C")]
	public float Value;

	// Token: 0x04001832 RID: 6194
	[Token(Token = "0x4001832")]
	[FieldOffset(Offset = "0x20")]
	private float oldValue;

	// Token: 0x04001833 RID: 6195
	[Token(Token = "0x4001833")]
	[FieldOffset(Offset = "0x24")]
	public float Increment;

	// Token: 0x04001834 RID: 6196
	[Token(Token = "0x4001834")]
	[FieldOffset(Offset = "0x28")]
	public FloatRange ValidRange;

	// Token: 0x04001835 RID: 6197
	[Token(Token = "0x4001835")]
	[FieldOffset(Offset = "0x2C")]
	public string FormatString;

	// Token: 0x04001836 RID: 6198
	[Token(Token = "0x4001836")]
	[FieldOffset(Offset = "0x30")]
	public bool ZeroIsInfinity;

	// Token: 0x04001837 RID: 6199
	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0x34")]
	public NumberSuffixes SuffixType;
}
