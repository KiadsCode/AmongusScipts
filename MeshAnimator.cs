using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031F RID: 799
[Token(Token = "0x200031F")]
public class MeshAnimator : MonoBehaviour
{
	// Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x7727E0", Offset = "0x771BE0", VA = "0x107727E0")]
	private void Start()
	{
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x772820", Offset = "0x771C20", VA = "0x10772820")]
	private void Update()
	{
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public MeshAnimator()
	{
	}

	// Token: 0x04001175 RID: 4469
	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0xC")]
	private MeshFilter filter;

	// Token: 0x04001176 RID: 4470
	[Token(Token = "0x4001176")]
	[FieldOffset(Offset = "0x10")]
	public Mesh[] Frames;

	// Token: 0x04001177 RID: 4471
	[Token(Token = "0x4001177")]
	[FieldOffset(Offset = "0x14")]
	public float frameRate;

	// Token: 0x04001178 RID: 4472
	[Token(Token = "0x4001178")]
	[FieldOffset(Offset = "0x18")]
	private float timer;

	// Token: 0x04001179 RID: 4473
	[Token(Token = "0x4001179")]
	[FieldOffset(Offset = "0x1C")]
	private int frameId;
}
