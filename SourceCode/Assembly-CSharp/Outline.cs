// Decompiled with JetBrains decompiler
// Type: Outline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[Token(Token = "0x200022E")]
public class Outline : MonoBehaviour
{
  [Token(Token = "0x4000F3E")]
  private static HashSet<Mesh> registeredMeshes;
  [SerializeField]
  [Token(Token = "0x4000F3F")]
  [FieldOffset(Offset = "0x20")]
  private Outline.Mode outlineMode;
  [SerializeField]
  [Token(Token = "0x4000F40")]
  [FieldOffset(Offset = "0x24")]
  private Color outlineColor;
  [SerializeField]
  [Range(0.0f, 10f)]
  [Token(Token = "0x4000F41")]
  [FieldOffset(Offset = "0x34")]
  private float outlineWidth;
  [Header("Optional")]
  [SerializeField]
  [Tooltip("Precompute enabled: Per-vertex calculations are performed in the editor and serialized with the object. Precompute disabled: Per-vertex calculations are performed at runtime in Awake(). This may cause a pause for large meshes.")]
  [Token(Token = "0x4000F42")]
  [FieldOffset(Offset = "0x38")]
  private bool precomputeOutline;
  [SerializeField]
  [HideInInspector]
  [Token(Token = "0x4000F43")]
  [FieldOffset(Offset = "0x40")]
  private List<Mesh> bakeKeys;
  [SerializeField]
  [HideInInspector]
  [Token(Token = "0x4000F44")]
  [FieldOffset(Offset = "0x48")]
  private List<Outline.ListVector3> bakeValues;
  [Token(Token = "0x4000F45")]
  [FieldOffset(Offset = "0x50")]
  private Renderer[] renderers;
  [Token(Token = "0x4000F46")]
  [FieldOffset(Offset = "0x58")]
  private Material outlineMaskMaterial;
  [Token(Token = "0x4000F47")]
  [FieldOffset(Offset = "0x60")]
  private Material outlineFillMaterial;
  [Token(Token = "0x4000F48")]
  [FieldOffset(Offset = "0x68")]
  private bool needsUpdate;

  [Token(Token = "0x17000082")]
  public Outline.Mode OutlineMode
  {
    [Token(Token = "0x6000E1E"), Address(RVA = "0x52B180", Offset = "0x529D80", Length = "0x4")] get => new Outline.Mode();
    [Token(Token = "0x6000E1F"), Address(RVA = "0x52B1A0", Offset = "0x529DA0", Length = "0x8")] set
    {
    }
  }

  [Token(Token = "0x17000083")]
  public Color OutlineColor
  {
    [Token(Token = "0x6000E20"), Address(RVA = "0x52B170", Offset = "0x529D70", Length = "0xB")] get => new Color();
    [Token(Token = "0x6000E21"), Address(RVA = "0x52B190", Offset = "0x529D90", Length = "0xC")] set
    {
    }
  }

  [Token(Token = "0x17000084")]
  public float OutlineWidth
  {
    [Token(Token = "0x6000E22"), Address(RVA = "0x415A60", Offset = "0x414660", Length = "0x6")] get => 0.0f;
    [Token(Token = "0x6000E23"), Address(RVA = "0x52B1B0", Offset = "0x529DB0", Length = "0xA")] set
    {
    }
  }

  [Token(Token = "0x6000E24")]
  [Address(RVA = "0x529930", Offset = "0x528530", Length = "0x23F")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000E25")]
  [Address(RVA = "0x52A460", Offset = "0x529060", Length = "0x1B4")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000E26")]
  [Address(RVA = "0x52A620", Offset = "0x529220", Length = "0x10B")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000E27")]
  [Address(RVA = "0x52AFF0", Offset = "0x529BF0", Length = "0x12")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E28")]
  [Address(RVA = "0x52A340", Offset = "0x528F40", Length = "0x118")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000E29")]
  [Address(RVA = "0x52A2D0", Offset = "0x528ED0", Length = "0x61")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000E2A")]
  [Address(RVA = "0x529B70", Offset = "0x528770", Length = "0x20C")]
  private void Bake()
  {
  }

  [Token(Token = "0x6000E2B")]
  [Address(RVA = "0x529E10", Offset = "0x528A10", Length = "0x4B1")]
  public void LoadSmoothNormals()
  {
  }

  [Token(Token = "0x6000E2C")]
  [Address(RVA = "0x52A730", Offset = "0x529330", Length = "0x6C6")]
  private List<Vector3> SmoothNormals(Mesh mesh) => (List<Vector3>) null;

  [Token(Token = "0x6000E2D")]
  [Address(RVA = "0x529D80", Offset = "0x528980", Length = "0x89")]
  private void CombineSubmeshes(Mesh mesh, Material[] materials)
  {
  }

  [Token(Token = "0x6000E2E")]
  [Address(RVA = "0x52AE00", Offset = "0x529A00", Length = "0x1E8")]
  private void UpdateMaterialProperties()
  {
  }

  [Token(Token = "0x6000E2F")]
  [Address(RVA = "0x52B0A0", Offset = "0x529CA0", Length = "0xCF")]
  public Outline()
  {
  }

  [Token(Token = "0x6000E30")]
  [Address(RVA = "0x52B010", Offset = "0x529C10", Length = "0x84")]
  static Outline()
  {
  }

  [Token(Token = "0x200022F")]
  public enum Mode
  {
    [Token(Token = "0x4000F4A")] OutlineAll,
    [Token(Token = "0x4000F4B")] OutlineVisible,
    [Token(Token = "0x4000F4C")] OutlineHidden,
    [Token(Token = "0x4000F4D")] OutlineAndSilhouette,
    [Token(Token = "0x4000F4E")] SilhouetteOnly,
  }

  [Token(Token = "0x2000230")]
  [Serializable]
  private class ListVector3
  {
    [Token(Token = "0x4000F4F")]
    [FieldOffset(Offset = "0x10")]
    public List<Vector3> data;

    [Token(Token = "0x6000E31")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public ListVector3()
    {
    }
  }
}
