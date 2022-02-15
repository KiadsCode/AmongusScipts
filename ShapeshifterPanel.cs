using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000448 RID: 1096
[Token(Token = "0x2000448")]
public class ShapeshifterPanel : MonoBehaviour
{
	// Token: 0x0600170A RID: 5898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170A")]
	[Address(RVA = "0x493BC0", Offset = "0x492FC0", VA = "0x10493BC0")]
	public void SetPlayer(int index, GameData.PlayerInfo playerInfo, Action onShift)
	{
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170B")]
	[Address(RVA = "0x493E40", Offset = "0x493240", VA = "0x10493E40")]
	public void ShapeShift()
	{
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ShapeshifterPanel()
	{
	}

	// Token: 0x04001755 RID: 5973
	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0xC")]
	public PoolablePlayer PlayerIcon;

	// Token: 0x04001756 RID: 5974
	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Background;

	// Token: 0x04001757 RID: 5975
	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro NameText;

	// Token: 0x04001758 RID: 5976
	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro LevelNumberText;

	// Token: 0x04001759 RID: 5977
	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0x1C")]
	public PassiveButton Button;

	// Token: 0x0400175A RID: 5978
	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x20")]
	private Action shapeshift;

	// Token: 0x0400175B RID: 5979
	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x24")]
	private GameData.PlayerInfo playerInfo;
}
