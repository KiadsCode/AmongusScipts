using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000246 RID: 582
[Token(Token = "0x2000246")]
public class ProgressTracker : MonoBehaviour
{
	// Token: 0x06000CFD RID: 3325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x5117A0", Offset = "0x510BA0", VA = "0x105117A0")]
	public void Start()
	{
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x511370", Offset = "0x510770", VA = "0x10511370")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ProgressTracker()
	{
	}

	// Token: 0x04000CD8 RID: 3288
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0xC")]
	public MeshRenderer TileParent;

	// Token: 0x04000CD9 RID: 3289
	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x10")]
	private float curValue;

	// Token: 0x02000247 RID: 583
	[Token(Token = "0x2000247")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x799750", Offset = "0x798B50", VA = "0x10799750")]
		internal bool <FixedUpdate>b__3_0(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ProgressTracker.<>c <>9;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x4")]
		public static Func<GameData.PlayerInfo, bool> <>9__3_0;
	}
}
