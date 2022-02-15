using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C7 RID: 199
[Token(Token = "0x20000C7")]
public class DestroyableSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x060004AB RID: 1195 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x170000B4")]
	public static bool InstanceExists
	{
		[Token(Token = "0x60004AB")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AC")]
	public virtual void Awake()
	{
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B5")]
	public static T Instance
	{
		[Token(Token = "0x60004AD")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AE")]
	public virtual void OnDestroy()
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AF")]
	public DestroyableSingleton()
	{
	}

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x0")]
	public bool DontDestroy;
}
