using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
public class RewindTapeMinigame : Minigame
{
	// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x4F6B90", Offset = "0x4F5F90", VA = "0x104F6B90", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x4F7D00", Offset = "0x4F7100", VA = "0x104F7D00")]
	private void UpdateText(TextMeshPro targetText, float targetTime)
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x4F7E10", Offset = "0x4F7210", VA = "0x104F7E10")]
	public void Update()
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x4F7CA0", Offset = "0x4F70A0", VA = "0x104F7CA0")]
	private void SetYPos(Transform t, float newYPos)
	{
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x4F7920", Offset = "0x4F6D20", VA = "0x104F7920")]
	public void Rewind()
	{
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x4F6E60", Offset = "0x4F6260", VA = "0x104F6E60")]
	public void FastForward()
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x4F71E0", Offset = "0x4F65E0", VA = "0x104F71E0")]
	public void Pause()
	{
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x4F75A0", Offset = "0x4F69A0", VA = "0x104F75A0")]
	public void Play()
	{
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x4F6D40", Offset = "0x4F6140", VA = "0x104F6D40", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public RewindTapeMinigame()
	{
	}

	// Token: 0x040003C3 RID: 963
	[Token(Token = "0x40003C3")]
	private const float MaxTime = 83544f;

	// Token: 0x040003C4 RID: 964
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x30")]
	private float targetTime;

	// Token: 0x040003C5 RID: 965
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x34")]
	private float currentTime;

	// Token: 0x040003C6 RID: 966
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer LeftWheel;

	// Token: 0x040003C7 RID: 967
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer LeftTape;

	// Token: 0x040003C8 RID: 968
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer RightWheel;

	// Token: 0x040003C9 RID: 969
	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer RightTape;

	// Token: 0x040003CA RID: 970
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshPro TargetText;

	// Token: 0x040003CB RID: 971
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x4C")]
	public TextMeshPro CurrentText;

	// Token: 0x040003CC RID: 972
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer RewindButton;

	// Token: 0x040003CD RID: 973
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x54")]
	public Sprite RewindNormal;

	// Token: 0x040003CE RID: 974
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x58")]
	public Sprite RewindDown;

	// Token: 0x040003CF RID: 975
	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x5C")]
	public SpriteRenderer FastFwdButton;

	// Token: 0x040003D0 RID: 976
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x60")]
	public Sprite FastFwdNormal;

	// Token: 0x040003D1 RID: 977
	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x64")]
	public Sprite FastFwdDown;

	// Token: 0x040003D2 RID: 978
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer PlayButton;

	// Token: 0x040003D3 RID: 979
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x6C")]
	public Sprite PlayNormal;

	// Token: 0x040003D4 RID: 980
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x70")]
	public Sprite PlayDown;

	// Token: 0x040003D5 RID: 981
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x74")]
	public SpriteRenderer PauseButton;

	// Token: 0x040003D6 RID: 982
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x78")]
	public Sprite PauseNormal;

	// Token: 0x040003D7 RID: 983
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x7C")]
	public Sprite PauseDown;

	// Token: 0x040003D8 RID: 984
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x80")]
	public SpriteRenderer RewindGlyph;

	// Token: 0x040003D9 RID: 985
	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x84")]
	public SpriteRenderer FastFwdGlyph;

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x88")]
	public SpriteRenderer PlayGlyph;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x8C")]
	public SpriteRenderer PauseGlyph;

	// Token: 0x040003DC RID: 988
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x90")]
	public float upGlyphYPos;

	// Token: 0x040003DD RID: 989
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x94")]
	public float pressedGlyphYPos;

	// Token: 0x040003DE RID: 990
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x98")]
	public Color upGlyphColor;

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0xA8")]
	public Color pressedGlyphColor;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0xB8")]
	private float direction;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0xBC")]
	public AudioClip buttonSound;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0xC0")]
	public AudioClip playStartSound;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0xC4")]
	public AudioClip playLoopSound;

	// Token: 0x040003E4 RID: 996
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0xC8")]
	public AudioClip playStopSound;

	// Token: 0x040003E5 RID: 997
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0xCC")]
	private AudioSource loopSound;
}
