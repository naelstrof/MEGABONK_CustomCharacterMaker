// Decompiled with JetBrains decompiler
// Type: GenericImageEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x200022C")]
public class GenericImageEffect : MonoBehaviour
{
  [Token(Token = "0x4000F38")]
  [FieldOffset(Offset = "0x20")]
  public Material material;

  [Token(Token = "0x6000E1C")]
  [Address(RVA = "0x523ED0", Offset = "0x522AD0", Length = "0xCC")]
  private void OnRenderImage(RenderTexture src, RenderTexture dest)
  {
  }

  [Token(Token = "0x6000E1D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GenericImageEffect()
  {
  }
}
