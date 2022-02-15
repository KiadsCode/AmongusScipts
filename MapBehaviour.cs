using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020C RID: 524
[Token(Token = "0x200020C")]
public class MapBehaviour : MonoBehaviour
{
	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00004BC0 File Offset: 0x00002DC0
	[Token(Token = "0x170001BF")]
	public bool IsOpen
	{
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x6E5170", Offset = "0x6E4570", VA = "0x106E5170")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00004BD8 File Offset: 0x00002DD8
	[Token(Token = "0x170001C0")]
	public bool IsOpenStopped
	{
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x6E5130", Offset = "0x6E4530", VA = "0x106E5130")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x6E47D0", Offset = "0x6E3BD0", VA = "0x106E47D0")]
	private void Awake()
	{
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x6E4AC0", Offset = "0x6E3EC0", VA = "0x106E4AC0")]
	private void GenericShow()
	{
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x6E4F10", Offset = "0x6E4310", VA = "0x106E4F10")]
	public void ShowSabotageMap()
	{
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x6E4D30", Offset = "0x6E4130", VA = "0x106E4D30")]
	public void ShowNormalMap()
	{
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x6E4C90", Offset = "0x6E4090", VA = "0x106E4C90")]
	public void ShowCountOverlay()
	{
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x6E4900", Offset = "0x6E3D00", VA = "0x106E4900")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x6E4820", Offset = "0x6E3C20", VA = "0x106E4820")]
	public void Close()
	{
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public MapBehaviour()
	{
	}

	// Token: 0x04000BB8 RID: 3000
	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x0")]
	public static MapBehaviour Instance;

	// Token: 0x04000BB9 RID: 3001
	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0xC")]
	public AlphaPulse ColorControl;

	// Token: 0x04000BBA RID: 3002
	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer HerePoint;

	// Token: 0x04000BBB RID: 3003
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x14")]
	public MapCountOverlay countOverlay;

	// Token: 0x04000BBC RID: 3004
	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x18")]
	public InfectedOverlay infectedOverlay;

	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x1C")]
	public MapTaskOverlay taskOverlay;

	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x20")]
	private SpecialInputHandler specialInputHandler;
}
