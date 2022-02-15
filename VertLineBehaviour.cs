using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200034B RID: 843
[Token(Token = "0x200034B")]
[Attribute(Name = "RequireComponent", RVA = "0xE7C70", Offset = "0xE7070")]
[Attribute(Name = "RequireComponent", RVA = "0xE7C70", Offset = "0xE7070")]
public class VertLineBehaviour : MonoBehaviour
{
	// Token: 0x170002C1 RID: 705
	// (set) Token: 0x06001267 RID: 4711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C1")]
	public Color color
	{
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x7AED50", Offset = "0x7AE150", VA = "0x107AED50")]
		set
		{
		}
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x7AE6B0", Offset = "0x7ADAB0", VA = "0x107AE6B0")]
	public void Awake()
	{
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x7AEC40", Offset = "0x7AE040", VA = "0x107AEC40")]
	public void Update()
	{
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x7AE900", Offset = "0x7ADD00", VA = "0x107AE900")]
	public void SetAlive()
	{
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x7AEB00", Offset = "0x7ADF00", VA = "0x107AEB00")]
	public void SetDead()
	{
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126C")]
	[Address(RVA = "0x7AED10", Offset = "0x7AE110", VA = "0x107AED10")]
	public VertLineBehaviour()
	{
	}

	// Token: 0x04001290 RID: 4752
	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0xC")]
	public int NumPoints;

	// Token: 0x04001291 RID: 4753
	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange Width;

	// Token: 0x04001292 RID: 4754
	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0x14")]
	public FloatRange Height;

	// Token: 0x04001293 RID: 4755
	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x18")]
	private Mesh mesh;

	// Token: 0x04001294 RID: 4756
	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x1C")]
	private MeshRenderer rend;

	// Token: 0x04001295 RID: 4757
	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0x20")]
	private Vector3[] vecs;

	// Token: 0x04001296 RID: 4758
	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x24")]
	public float Duration;

	// Token: 0x04001297 RID: 4759
	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x28")]
	private float timer;

	// Token: 0x04001298 RID: 4760
	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x2C")]
	public int Offset;

	// Token: 0x04001299 RID: 4761
	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x30")]
	public int beats;

	// Token: 0x0400129A RID: 4762
	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x34")]
	public int beatPadding;
}
