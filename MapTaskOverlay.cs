using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020F RID: 527
[Token(Token = "0x200020F")]
public class MapTaskOverlay : MonoBehaviour
{
	// Token: 0x06000BC5 RID: 3013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x6E6A10", Offset = "0x6E5E10", VA = "0x106E6A10")]
	public void Show()
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x6E6C80", Offset = "0x6E6080", VA = "0x106E6C80")]
	public void Update()
	{
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x6E66D0", Offset = "0x6E5AD0", VA = "0x106E66D0")]
	private void SetIconLocation(PlayerTask task)
	{
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x6E6550", Offset = "0x6E5950", VA = "0x106E6550")]
	public void Hide()
	{
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x6E6DD0", Offset = "0x6E61D0", VA = "0x106E6DD0")]
	public MapTaskOverlay()
	{
	}

	// Token: 0x04000BCA RID: 3018
	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0xC")]
	public ObjectPoolBehavior icons;

	// Token: 0x04000BCB RID: 3019
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, PooledMapIcon> data;
}
