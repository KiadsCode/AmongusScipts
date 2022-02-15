using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000491 RID: 1169
[Token(Token = "0x2000491")]
public class StaticDoor : MonoBehaviour
{
	// Token: 0x17000388 RID: 904
	// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00007C98 File Offset: 0x00005E98
	// (set) Token: 0x060018E6 RID: 6374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000388")]
	public bool IsOpen
	{
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x27F3C0", Offset = "0x27E7C0", VA = "0x1027F3C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x27F3D0", Offset = "0x27E7D0", VA = "0x1027F3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x757660", Offset = "0x756A60", VA = "0x10757660")]
	public void SetOpen(bool isOpen)
	{
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public StaticDoor()
	{
	}

	// Token: 0x040018FD RID: 6397
	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0xC")]
	public Sprite OpenDoorImage;

	// Token: 0x040018FE RID: 6398
	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x10")]
	public Sprite CloseDoorImage;

	// Token: 0x040018FF RID: 6399
	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsOpen>k__BackingField;
}
