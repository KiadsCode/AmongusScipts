using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200050F RID: 1295
[Token(Token = "0x200050F")]
public class ArrowBehaviour : MonoBehaviour
{
	// Token: 0x06001B81 RID: 7041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x54BC50", Offset = "0x54B050", VA = "0x1054BC50")]
	public void Awake()
	{
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x54BCB0", Offset = "0x54B0B0", VA = "0x1054BCB0")]
	public void Update()
	{
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x00008B98 File Offset: 0x00006D98
	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x54BC90", Offset = "0x54B090", VA = "0x1054BC90")]
	private bool Between(float value, float min, float max)
	{
		return default(bool);
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B84")]
	[Address(RVA = "0x54C100", Offset = "0x54B500", VA = "0x1054C100")]
	public ArrowBehaviour()
	{
	}

	// Token: 0x04001F48 RID: 8008
	[Token(Token = "0x4001F48")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 target;

	// Token: 0x04001F49 RID: 8009
	[Token(Token = "0x4001F49")]
	[FieldOffset(Offset = "0x18")]
	public float perc;

	// Token: 0x04001F4A RID: 8010
	[Token(Token = "0x4001F4A")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public SpriteRenderer image;
}
