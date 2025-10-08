// Decompiled with JetBrains decompiler
// Type: ObjectStageMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x200007A")]
public class ObjectStageMaterial : MonoBehaviour
{
  [Token(Token = "0x40003CA")]
  [FieldOffset(Offset = "0x20")]
  public ObjectStageMaterial.StageMaterial[] stageMaterials;
  [Token(Token = "0x40003CB")]
  [FieldOffset(Offset = "0x28")]
  public MeshRenderer meshRenderer;

  [Token(Token = "0x6000308")]
  [Address(RVA = "0x46AD50", Offset = "0x469950", Length = "0x96")]
  private void Start()
  {
  }

  [Token(Token = "0x6000309")]
  [Address(RVA = "0x46ACC0", Offset = "0x4698C0", Length = "0x89")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x600030A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ObjectStageMaterial()
  {
  }

  [Token(Token = "0x200007B")]
  [Serializable]
  public class StageMaterial
  {
    [Token(Token = "0x40003CC")]
    [FieldOffset(Offset = "0x10")]
    public int stageIndex;
    [Token(Token = "0x40003CD")]
    [FieldOffset(Offset = "0x18")]
    public Material material;

    [Token(Token = "0x600030B")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public StageMaterial()
    {
    }
  }
}
