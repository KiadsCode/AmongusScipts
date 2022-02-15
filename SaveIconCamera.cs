using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CC RID: 972
[Token(Token = "0x20003CC")]
[Attribute(Name = "RequireComponent", RVA = "0xDE830", Offset = "0xDDC30")]
public class SaveIconCamera : DestroyableSingleton<SaveIconCamera>
{
	// Token: 0x06001434 RID: 5172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001434")]
	[Address(RVA = "0x582E80", Offset = "0x582280", VA = "0x10582E80")]
	private new void Awake()
	{
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001435")]
	[Address(RVA = "0x583830", Offset = "0x582C30", VA = "0x10583830")]
	private void Start()
	{
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001436")]
	[Address(RVA = "0x582F10", Offset = "0x582310", VA = "0x10582F10")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001437")]
	[Address(RVA = "0x5838F0", Offset = "0x582CF0", VA = "0x105838F0")]
	[Attribute(Name = "ContextMenu", RVA = "0xDE880", Offset = "0xDDC80")]
	private void TestIcon()
	{
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001438")]
	[Address(RVA = "0x583670", Offset = "0x582A70", VA = "0x10583670")]
	public static byte[] RenderSaveIcon()
	{
		return null;
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001439")]
	[Address(RVA = "0x583060", Offset = "0x582460", VA = "0x10583060")]
	private byte[] RenderSaveIconLocal()
	{
		return null;
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143A")]
	[Address(RVA = "0x583970", Offset = "0x582D70", VA = "0x10583970")]
	public SaveIconCamera()
	{
	}

	// Token: 0x040014DB RID: 5339
	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x10")]
	private Camera cam;

	// Token: 0x040014DC RID: 5340
	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x14")]
	public ConditionalRenderTexture platformRenderTextures;

	// Token: 0x040014DD RID: 5341
	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x18")]
	private RenderTexture targetTexture;

	// Token: 0x040014DE RID: 5342
	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0x1C")]
	public PlayerControl saveIconDummy;

	// Token: 0x040014DF RID: 5343
	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask layerToRenderWith;

	// Token: 0x040014E0 RID: 5344
	[Token(Token = "0x40014E0")]
	[FieldOffset(Offset = "0x24")]
	private int layerIndex;

	// Token: 0x040014E1 RID: 5345
	[Token(Token = "0x40014E1")]
	[FieldOffset(Offset = "0x0")]
	private static object lockObject;

	// Token: 0x040014E2 RID: 5346
	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0x4")]
	private static bool needsRender;

	// Token: 0x040014E3 RID: 5347
	[Token(Token = "0x40014E3")]
	[FieldOffset(Offset = "0x8")]
	private static byte[] renderedPNG;
}
