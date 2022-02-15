using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x0200035A RID: 858
[Token(Token = "0x200035A")]
public class ActiveInputManager : DestroyableSingleton<ActiveInputManager>
{
	// Token: 0x170002CA RID: 714
	// (get) Token: 0x060012BA RID: 4794 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x170002CA")]
	private static ActiveInputManager.InputType PlatformDefault
	{
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x542230", Offset = "0x541630", VA = "0x10542230")]
		get
		{
			return ActiveInputManager.InputType.Joystick;
		}
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x541A70", Offset = "0x540E70", VA = "0x10541A70")]
	private void Start()
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x5421A0", Offset = "0x5415A0", VA = "0x105421A0")]
	private void Update()
	{
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002CB")]
	public Rewired.Controller CurrentController
	{
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x2786E0", Offset = "0x277AE0", VA = "0x102786E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x541810", Offset = "0x540C10", VA = "0x10541810")]
	private void OnLastActiveControllerChanged(Player player, Rewired.Controller controller)
	{
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x541B20", Offset = "0x540F20", VA = "0x10541B20")]
	public void UpdateActiveControlType()
	{
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00006570 File Offset: 0x00004770
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x541A60", Offset = "0x540E60", VA = "0x10541A60")]
	private bool ShouldEnableTouch()
	{
		return default(bool);
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x5421E0", Offset = "0x5415E0", VA = "0x105421E0")]
	public ActiveInputManager()
	{
	}

	// Token: 0x040012FC RID: 4860
	[Token(Token = "0x40012FC")]
	[FieldOffset(Offset = "0x10")]
	public ActiveInputManager.InputType testCurrentControlType;

	// Token: 0x040012FD RID: 4861
	[Token(Token = "0x40012FD")]
	[FieldOffset(Offset = "0x0")]
	public static ActiveInputManager.InputType currentControlType;

	// Token: 0x040012FE RID: 4862
	[Token(Token = "0x40012FE")]
	[FieldOffset(Offset = "0x18")]
	public double kChangeTime;

	// Token: 0x040012FF RID: 4863
	[Token(Token = "0x40012FF")]
	[FieldOffset(Offset = "0x20")]
	public double mChangeTime;

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x28")]
	public double jChangeTime;

	// Token: 0x04001301 RID: 4865
	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x30")]
	public double tChangeTime;

	// Token: 0x04001302 RID: 4866
	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 lastMousePosition;

	// Token: 0x04001303 RID: 4867
	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0x4")]
	public static Action CurrentInputSourceChanged;

	// Token: 0x04001304 RID: 4868
	[Token(Token = "0x4001304")]
	[FieldOffset(Offset = "0x40")]
	private Rewired.Controller lastUsedController;

	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	public enum InputType
	{
		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		Joystick,
		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		Keyboard,
		// Token: 0x04001308 RID: 4872
		[Token(Token = "0x4001308")]
		Touch
	}
}
