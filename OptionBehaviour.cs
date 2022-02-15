using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200046B RID: 1131
[Token(Token = "0x200046B")]
public abstract class OptionBehaviour : MonoBehaviour
{
	// Token: 0x06001815 RID: 6165 RVA: 0x00007920 File Offset: 0x00005B20
	[Token(Token = "0x6001815")]
	[Address(RVA = "0x77D4F0", Offset = "0x77C8F0", VA = "0x1077D4F0", Slot = "4")]
	public virtual float GetFloat()
	{
		return 0f;
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x00007938 File Offset: 0x00005B38
	[Token(Token = "0x6001816")]
	[Address(RVA = "0x77D520", Offset = "0x77C920", VA = "0x1077D520", Slot = "5")]
	public virtual int GetInt()
	{
		return 0;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x00007950 File Offset: 0x00005B50
	[Token(Token = "0x6001817")]
	[Address(RVA = "0x77D4C0", Offset = "0x77C8C0", VA = "0x1077D4C0", Slot = "6")]
	public virtual bool GetBool()
	{
		return default(bool);
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001818")]
	[Address(RVA = "0x77D550", Offset = "0x77C950", VA = "0x1077D550")]
	public void SetAsPlayer()
	{
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001819")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	protected OptionBehaviour()
	{
	}

	// Token: 0x04001838 RID: 6200
	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0xC")]
	public StringNames Title;

	// Token: 0x04001839 RID: 6201
	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x10")]
	public Action<OptionBehaviour> OnValueChanged;
}
