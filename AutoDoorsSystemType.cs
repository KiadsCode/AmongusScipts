using System;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000487 RID: 1159
[Token(Token = "0x2000487")]
public class AutoDoorsSystemType : ISystemType, IActivatable, RunTimer, IDoorSystem
{
	// Token: 0x17000380 RID: 896
	// (get) Token: 0x060018AA RID: 6314 RVA: 0x00007B90 File Offset: 0x00005D90
	[Token(Token = "0x17000380")]
	public bool IsActive
	{
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x54EC50", Offset = "0x54E050", VA = "0x1054EC50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x060018AB RID: 6315 RVA: 0x00007BA8 File Offset: 0x00005DA8
	[Token(Token = "0x17000381")]
	public bool IsDirty
	{
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x54ED60", Offset = "0x54E160", VA = "0x1054ED60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x54E890", Offset = "0x54DC90", VA = "0x1054E890", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x54EA20", Offset = "0x54DE20", VA = "0x1054EA20", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x54E730", Offset = "0x54DB30", VA = "0x1054E730", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x54EB90", Offset = "0x54DF90", VA = "0x1054EB90")]
	public void SetDoor(AutoOpenDoor door, bool open)
	{
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x54E670", Offset = "0x54DA70", VA = "0x1054E670", Slot = "12")]
	public void CloseDoorsOfType(SystemTypes room)
	{
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00007BC0 File Offset: 0x00005DC0
	[Token(Token = "0x60018B3")]
	[Address(RVA = "0x54E960", Offset = "0x54DD60", VA = "0x1054E960", Slot = "11")]
	public float GetTimer(SystemTypes room)
	{
		return 0f;
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public AutoDoorsSystemType()
	{
	}

	// Token: 0x040018D1 RID: 6353
	[Token(Token = "0x40018D1")]
	[FieldOffset(Offset = "0x8")]
	private uint dirtyBits;

	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x370940", Offset = "0x36FD40", VA = "0x10370940")]
		internal bool <get_IsActive>b__2_0(PlainDoor b)
		{
			return default(bool);
		}

		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AutoDoorsSystemType.<>c <>9;

		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x4")]
		public static Func<PlainDoor, bool> <>9__2_0;
	}
}
