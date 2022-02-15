using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000477 RID: 1143
[Token(Token = "0x2000477")]
public class LightSource : MonoBehaviour
{
	// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600185D")]
	[Address(RVA = "0x6DF720", Offset = "0x6DEB20", VA = "0x106DF720")]
	private void Start()
	{
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600185E")]
	[Address(RVA = "0x6DFD30", Offset = "0x6DF130", VA = "0x106DFD30")]
	private void UpdateShadowType()
	{
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600185F")]
	[Address(RVA = "0x6DFF30", Offset = "0x6DF330", VA = "0x106DFF30")]
	private void Update()
	{
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001860")]
	[Address(RVA = "0x6DEA50", Offset = "0x6DDE50", VA = "0x106DEA50")]
	private void GenerateShadowmap()
	{
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001861")]
	[Address(RVA = "0x6DD020", Offset = "0x6DC420", VA = "0x106DD020")]
	private void ClearEdges()
	{
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001862")]
	[Address(RVA = "0x6DFC90", Offset = "0x6DF090", VA = "0x106DFC90")]
	private void UpdateOccMesh()
	{
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001863")]
	[Address(RVA = "0x6DD780", Offset = "0x6DCB80", VA = "0x106DD780")]
	private void DrawOcclusion(float effectiveRadius)
	{
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x6DD5B0", Offset = "0x6DC9B0", VA = "0x106DD5B0")]
	private void DebugDrawRadius(Vector2 center, float radius)
	{
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x6DDBF0", Offset = "0x6DCFF0", VA = "0x106DDBF0")]
	private void GPUShadows(Vector2 myPos)
	{
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x6DCE00", Offset = "0x6DC200", VA = "0x106DCE00")]
	private void AddEdgeNoGeom(Vector3 a, Vector3 b)
	{
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001867")]
	[Address(RVA = "0x6DC900", Offset = "0x6DBD00", VA = "0x106DC900")]
	private void AddEdgeInternal(Vector3 a, Vector3 b, Vector2 uv)
	{
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001868")]
	[Address(RVA = "0x6DC490", Offset = "0x6DB890", VA = "0x106DC490")]
	private void AddEdgeDefault(Vector3 a, Vector3 b)
	{
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x6DEC30", Offset = "0x6DE030", VA = "0x106DEC30")]
	private void RaycastShadows(Vector2 myPos)
	{
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600186A")]
	[Address(RVA = "0x6DFB60", Offset = "0x6DEF60", VA = "0x106DFB60")]
	private void TestBothSides(Vector2 myPos)
	{
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600186B")]
	[Address(RVA = "0x6DD0E0", Offset = "0x6DC4E0", VA = "0x106DD0E0")]
	private void CreateVert(Vector2 myPos, ref Vector2 del)
	{
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600186C")]
	[Address(RVA = "0x6DEB60", Offset = "0x6DDF60", VA = "0x106DEB60")]
	private LightSource.VertInfo GetEmptyVert()
	{
		return null;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00007A28 File Offset: 0x00005C28
	[Token(Token = "0x600186D")]
	[Address(RVA = "0x6E02C0", Offset = "0x6DF6C0", VA = "0x106E02C0")]
	private static float length(float x, float y)
	{
		return 0f;
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00007A40 File Offset: 0x00005C40
	[Token(Token = "0x600186E")]
	[Address(RVA = "0x6E0320", Offset = "0x6DF720", VA = "0x106E0320")]
	public static float pseudoAngle(float dx, float dy)
	{
		return 0f;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600186F")]
	[Address(RVA = "0x6E00F0", Offset = "0x6DF4F0", VA = "0x106E00F0")]
	public LightSource()
	{
	}

	// Token: 0x0400187E RID: 6270
	[Token(Token = "0x400187E")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<GameObject, NoShadowBehaviour> NoShadows;

	// Token: 0x0400187F RID: 6271
	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<GameObject, OneWayShadows> OneWayShadows;

	// Token: 0x04001880 RID: 6272
	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	private GameObject child;

	// Token: 0x04001881 RID: 6273
	[Token(Token = "0x4001881")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	private Vector2[] requiredDels;

	// Token: 0x04001882 RID: 6274
	[Token(Token = "0x4001882")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	private Mesh myMesh;

	// Token: 0x04001883 RID: 6275
	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x18")]
	public int MinRays;

	// Token: 0x04001884 RID: 6276
	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x1C")]
	public float LightRadius;

	// Token: 0x04001885 RID: 6277
	[Token(Token = "0x4001885")]
	[FieldOffset(Offset = "0x20")]
	public Material Material;

	// Token: 0x04001886 RID: 6278
	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x24")]
	private RaycastHit2D[] buffer;

	// Token: 0x04001887 RID: 6279
	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0x28")]
	private Collider2D[] hits;

	// Token: 0x04001888 RID: 6280
	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x2C")]
	private ContactFilter2D filter;

	// Token: 0x04001889 RID: 6281
	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x48")]
	public bool useGPUShadow;

	// Token: 0x0400188A RID: 6282
	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0x49")]
	private bool oldUseGPUShadow;

	// Token: 0x0400188B RID: 6283
	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 del;

	// Token: 0x0400188C RID: 6284
	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 tan;

	// Token: 0x0400188D RID: 6285
	[Token(Token = "0x400188D")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 side;

	// Token: 0x0400188E RID: 6286
	[Token(Token = "0x400188E")]
	private const float twopi = 6.2831855f;

	// Token: 0x0400188F RID: 6287
	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0x64")]
	public Mesh occluderMesh;

	// Token: 0x04001890 RID: 6288
	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x68")]
	private List<Vector3> occVerts;

	// Token: 0x04001891 RID: 6289
	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0x6C")]
	private List<Vector3> occNorms;

	// Token: 0x04001892 RID: 6290
	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x70")]
	private List<Vector2> occUVs;

	// Token: 0x04001893 RID: 6291
	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x74")]
	private List<int> occTris;

	// Token: 0x04001894 RID: 6292
	[Token(Token = "0x4001894")]
	[FieldOffset(Offset = "0x78")]
	public Mesh lightChildMesh;

	// Token: 0x04001895 RID: 6293
	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x7C")]
	private MeshFilter lightChildMeshFilter;

	// Token: 0x04001896 RID: 6294
	[Token(Token = "0x4001896")]
	[FieldOffset(Offset = "0x80")]
	public Material shadowCasterMaterialPrefab;

	// Token: 0x04001897 RID: 6295
	[Token(Token = "0x4001897")]
	[FieldOffset(Offset = "0x84")]
	private Material shadowCasterMaterial;

	// Token: 0x04001898 RID: 6296
	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0x88")]
	private CommandBuffer cb;

	// Token: 0x04001899 RID: 6297
	[Token(Token = "0x4001899")]
	[FieldOffset(Offset = "0x8C")]
	private LightSource.AddEdgeDelegate AddEdge;

	// Token: 0x0400189A RID: 6298
	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0x90")]
	private bool noGeomSupport;

	// Token: 0x0400189B RID: 6299
	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xE03A0", Offset = "0xDF7A0")]
	public int shadowmapResolution;

	// Token: 0x0400189C RID: 6300
	[Token(Token = "0x400189C")]
	[FieldOffset(Offset = "0x98")]
	public RenderTextureFormat preferredRTFormat;

	// Token: 0x0400189D RID: 6301
	[Token(Token = "0x400189D")]
	[FieldOffset(Offset = "0x9C")]
	private RenderTexture shadowTexture;

	// Token: 0x0400189E RID: 6302
	[Token(Token = "0x400189E")]
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	private List<LightSource.VertInfo> verts;

	// Token: 0x0400189F RID: 6303
	[Token(Token = "0x400189F")]
	[FieldOffset(Offset = "0xA4")]
	[HideInInspector]
	private int vertCount;

	// Token: 0x040018A0 RID: 6304
	[Token(Token = "0x40018A0")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3[] vec;

	// Token: 0x040018A1 RID: 6305
	[Token(Token = "0x40018A1")]
	[FieldOffset(Offset = "0xAC")]
	private Vector2[] uvs;

	// Token: 0x040018A2 RID: 6306
	[Token(Token = "0x40018A2")]
	[FieldOffset(Offset = "0xB0")]
	private int[] triangles;

	// Token: 0x040018A3 RID: 6307
	[Token(Token = "0x40018A3")]
	[FieldOffset(Offset = "0xB4")]
	public float tol;

	// Token: 0x040018A4 RID: 6308
	[Token(Token = "0x40018A4")]
	[FieldOffset(Offset = "0xB8")]
	private List<RaycastHit2D> lightHits;

	// Token: 0x02000478 RID: 1144
	// (Invoke) Token: 0x06001872 RID: 6258
	[Token(Token = "0x2000478")]
	public delegate void AddEdgeDelegate(Vector3 a, Vector3 b);

	// Token: 0x02000479 RID: 1145
	[Token(Token = "0x2000479")]
	private class VertInfo
	{
		// Token: 0x06001875 RID: 6261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x5B6450", Offset = "0x5B5850", VA = "0x105B6450")]
		internal void Complete(float x, float y)
		{
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x5B63D0", Offset = "0x5B57D0", VA = "0x105B63D0")]
		internal void Complete(Vector2 point)
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public VertInfo()
		{
		}

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x8")]
		public float Angle;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 Position;
	}

	// Token: 0x0200047A RID: 1146
	[Token(Token = "0x200047A")]
	private class AngleComparer : IComparer<LightSource.VertInfo>
	{
		// Token: 0x06001878 RID: 6264 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x5A6310", Offset = "0x5A5710", VA = "0x105A6310", Slot = "4")]
		public int Compare(LightSource.VertInfo x, LightSource.VertInfo y)
		{
			return 0;
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public AngleComparer()
		{
		}

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x346A344B")]
		public static readonly LightSource.AngleComparer Instance;
	}

	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	private class HitDepthComparer : IComparer<RaycastHit2D>
	{
		// Token: 0x0600187B RID: 6267 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x5A65C0", Offset = "0x5A59C0", VA = "0x105A65C0", Slot = "4")]
		public int Compare(RaycastHit2D x, RaycastHit2D y)
		{
			return 0;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public HitDepthComparer()
		{
		}

		// Token: 0x040018A8 RID: 6312
		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x3475346F")]
		public static readonly LightSource.HitDepthComparer Instance;
	}
}
