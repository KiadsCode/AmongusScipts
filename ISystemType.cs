using System;
using Hazel;
using Il2CppDummyDll;

// Token: 0x020004BD RID: 1213
[Token(Token = "0x20004BD")]
public interface ISystemType
{
	// Token: 0x170003BD RID: 957
	// (get) Token: 0x060019CF RID: 6607
	[Token(Token = "0x170003BD")]
	bool IsDirty { [Token(Token = "0x60019CF")] get; }

	// Token: 0x060019D0 RID: 6608
	[Token(Token = "0x60019D0")]
	void Detoriorate(float deltaTime);

	// Token: 0x060019D1 RID: 6609
	[Token(Token = "0x60019D1")]
	void RepairDamage(PlayerControl player, byte amount);

	// Token: 0x060019D2 RID: 6610
	[Token(Token = "0x60019D2")]
	void UpdateSystem(PlayerControl player, MessageReader msgReader);

	// Token: 0x060019D3 RID: 6611
	[Token(Token = "0x60019D3")]
	void Serialize(MessageWriter writer, bool initialState);

	// Token: 0x060019D4 RID: 6612
	[Token(Token = "0x60019D4")]
	void Deserialize(MessageReader reader, bool initialState);
}
