using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020E RID: 526
[Token(Token = "0x200020E")]
public class MapRoom : MonoBehaviour
{
	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C1")]
	public InfectedOverlay Parent
	{
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x6E64A0", Offset = "0x6E58A0", VA = "0x106E64A0")]
	public void Start()
	{
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x6E5E50", Offset = "0x6E5250", VA = "0x106E5E50")]
	public void OOBUpdate()
	{
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x6E6400", Offset = "0x6E5800", VA = "0x106E6400")]
	internal void SetSpecialActive(float perc)
	{
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x6E62E0", Offset = "0x6E56E0", VA = "0x106E62E0")]
	public void SabotageReactor()
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x6E6010", Offset = "0x6E5410", VA = "0x106E6010")]
	public void SabotageComms()
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x6E6250", Offset = "0x6E5650", VA = "0x106E6250")]
	public void SabotageOxygen()
	{
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x6E61C0", Offset = "0x6E55C0", VA = "0x106E61C0")]
	public void SabotageLights()
	{
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x6E6370", Offset = "0x6E5770", VA = "0x106E6370")]
	public void SabotageSeismic()
	{
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x6E60A0", Offset = "0x6E54A0", VA = "0x106E60A0")]
	public void SabotageDoors()
	{
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public MapRoom()
	{
	}

	// Token: 0x04000BC6 RID: 3014
	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private InfectedOverlay <Parent>k__BackingField;

	// Token: 0x04000BC7 RID: 3015
	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x10")]
	public SystemTypes room;

	// Token: 0x04000BC8 RID: 3016
	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer door;

	// Token: 0x04000BC9 RID: 3017
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer special;
}
