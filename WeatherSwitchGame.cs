using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000355 RID: 853
[Token(Token = "0x2000355")]
public class WeatherSwitchGame : Minigame
{
	// Token: 0x06001299 RID: 4761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x7BACD0", Offset = "0x7BA0D0", VA = "0x107BACD0")]
	public void Start()
	{
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x7BA650", Offset = "0x7B9A50", VA = "0x107BA650", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x7BAE60", Offset = "0x7BA260", VA = "0x107BAE60")]
	private void Update()
	{
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x7BA970", Offset = "0x7B9D70", VA = "0x107BA970")]
	public void FlipSwitch(int i)
	{
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public WeatherSwitchGame()
	{
	}

	// Token: 0x040012DE RID: 4830
	[Token(Token = "0x40012DE")]
	[FieldOffset(Offset = "0x0")]
	public static StringNames[] ControlNames;

	// Token: 0x040012DF RID: 4831
	[Token(Token = "0x40012DF")]
	[FieldOffset(Offset = "0x30")]
	public WeatherControl[] Controls;

	// Token: 0x040012E0 RID: 4832
	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x34")]
	private WeatherNodeTask WeatherTask;

	// Token: 0x040012E1 RID: 4833
	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x38")]
	public Transform buttonGlyph;

	// Token: 0x040012E2 RID: 4834
	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 buttonGlyphOffset_Off;

	// Token: 0x040012E3 RID: 4835
	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 buttonGlyphOffset_On;

	// Token: 0x040012E4 RID: 4836
	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip SwitchSound;
}
