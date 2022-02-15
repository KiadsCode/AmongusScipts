using System;
using Il2CppDummyDll;

namespace Rewired
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DE")]
		private IControllerTemplateAxis leftPedal
		{
			[Token(Token = "0x6001E07")]
			[Address(RVA = "0x3A7D30", Offset = "0x3A7130", VA = "0x103A7D30", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DF")]
		private IControllerTemplateAxis rightPedal
		{
			[Token(Token = "0x6001E08")]
			[Address(RVA = "0x3A7D70", Offset = "0x3A7170", VA = "0x103A7D70", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E0")]
		private IControllerTemplateAxis slide
		{
			[Token(Token = "0x6001E09")]
			[Address(RVA = "0x3A7DB0", Offset = "0x3A71B0", VA = "0x103A7DB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x3A7E50", Offset = "0x3A7250", VA = "0x103A7E50")]
		public FlightPedalsTemplate(object payload)
		{
		}

		// Token: 0x04002144 RID: 8516
		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x37B337A2")]
		public static readonly Guid typeGuid;

		// Token: 0x04002145 RID: 8517
		[Token(Token = "0x4002145")]
		public const int elementId_leftPedal = 0;

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		public const int elementId_rightPedal = 1;

		// Token: 0x04002147 RID: 8519
		[Token(Token = "0x4002147")]
		public const int elementId_slide = 2;
	}
}
