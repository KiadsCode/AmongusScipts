using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000236 RID: 566
[Token(Token = "0x2000236")]
public class PassiveButton : PassiveUiElement
{
	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00004F98 File Offset: 0x00003198
	[Token(Token = "0x170001D8")]
	public override bool HandleUp
	{
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x437E60", Offset = "0x437260", VA = "0x10437E60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x170001D9")]
	public override bool HandleDown
	{
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x437F90", Offset = "0x437390", VA = "0x10437F90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x170001DA")]
	public override bool HandleRepeat
	{
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x4378F0", Offset = "0x436CF0", VA = "0x104378F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x658B90", Offset = "0x657F90", VA = "0x10658B90")]
	private void OnEnable()
	{
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x658D10", Offset = "0x658110", VA = "0x10658D10", Slot = "11")]
	public override void ReceiveClickDown()
	{
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x658DF0", Offset = "0x6581F0", VA = "0x10658DF0", Slot = "12")]
	public override void ReceiveRepeatDown()
	{
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x658DD0", Offset = "0x6581D0", VA = "0x10658DD0", Slot = "13")]
	public override void ReceiveClickUp()
	{
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x658EF0", Offset = "0x6582F0", VA = "0x10658EF0")]
	public void SetButtonEnableState(bool enabled)
	{
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x658A90", Offset = "0x657E90", VA = "0x10658A90")]
	public void AddOnClickListeners(Action[] callbacks)
	{
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x658F70", Offset = "0x658370", VA = "0x10658F70")]
	public PassiveButton()
	{
	}

	// Token: 0x04000C9E RID: 3230
	[Token(Token = "0x4000C9E")]
	[FieldOffset(Offset = "0x34")]
	public Button.ButtonClickedEvent OnClick;

	// Token: 0x04000C9F RID: 3231
	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip ClickSound;

	// Token: 0x04000CA0 RID: 3232
	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0x3C")]
	public bool OnUp;

	// Token: 0x04000CA1 RID: 3233
	[Token(Token = "0x4000CA1")]
	[FieldOffset(Offset = "0x3D")]
	public bool OnDown;

	// Token: 0x04000CA2 RID: 3234
	[Token(Token = "0x4000CA2")]
	[FieldOffset(Offset = "0x3E")]
	public bool OnRepeat;

	// Token: 0x04000CA3 RID: 3235
	[Token(Token = "0x4000CA3")]
	[FieldOffset(Offset = "0x40")]
	public float RepeatDuration;

	// Token: 0x04000CA4 RID: 3236
	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x44")]
	private float repeatTimer;

	// Token: 0x04000CA5 RID: 3237
	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x48")]
	private bool checkedClickEvent;

	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass19_0
	{
		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass19_0()
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x3CA5E0", Offset = "0x3C99E0", VA = "0x103CA5E0")]
		internal void <AddOnClickListeners>b__0()
		{
		}

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x8")]
		public Action cbCopy;
	}
}
