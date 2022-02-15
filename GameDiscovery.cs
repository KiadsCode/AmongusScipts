using System;
using System.Collections.Generic;
using Hazel.Udp;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x20002C1")]
public class GameDiscovery : MonoBehaviour
{
	// Token: 0x06000FA0 RID: 4000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x3AE650", Offset = "0x3ADA50", VA = "0x103AE650")]
	public void Start()
	{
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x3AE6F0", Offset = "0x3ADAF0", VA = "0x103AE6F0")]
	public void Update()
	{
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x3AE500", Offset = "0x3AD900", VA = "0x103AE500")]
	private void Receive(BroadcastPacket packet)
	{
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x3AE220", Offset = "0x3AD620", VA = "0x103AE220")]
	private void CreateButtonForAddess(string fromAddress, string[] gameNameParts)
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x3AE930", Offset = "0x3ADD30", VA = "0x103AE930")]
	public GameDiscovery()
	{
	}

	// Token: 0x04000F74 RID: 3956
	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0xC")]
	public JoinGameButton ButtonPrefab;

	// Token: 0x04000F75 RID: 3957
	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x10")]
	public Transform ItemLocation;

	// Token: 0x04000F76 RID: 3958
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x14")]
	public float YStart;

	// Token: 0x04000F77 RID: 3959
	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x18")]
	public float YOffset;

	// Token: 0x04000F78 RID: 3960
	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x1C")]
	public Scroller TargetArea;

	// Token: 0x04000F79 RID: 3961
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, JoinGameButton> received;
}
