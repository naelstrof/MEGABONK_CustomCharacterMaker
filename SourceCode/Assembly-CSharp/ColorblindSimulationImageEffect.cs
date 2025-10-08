// Decompiled with JetBrains decompiler
// Type: ColorblindSimulationImageEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x200022B")]
public class ColorblindSimulationImageEffect : MonoBehaviour
{
  [Token(Token = "0x4000F35")]
  [FieldOffset(Offset = "0x20")]
  public Material material;
  [Token(Token = "0x4000F36")]
  [FieldOffset(Offset = "0x28")]
  public ColorDeficiencyType selectedDeficiency;
  [Token(Token = "0x4000F37")]
  [FieldOffset(Offset = "0x2C")]
  private ColorDeficiencyType currentDeficiency;

  [Token(Token = "0x6000E19")]
  [Address(RVA = "0x51F270", Offset = "0x51DE70", Length = "0xCC")]
  private void OnRenderImage(RenderTexture src, RenderTexture dest)
  {
  }

  [Token(Token = "0x6000E1A")]
  [Address(RVA = "0x51F340", Offset = "0x51DF40", Length = "0x12F")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E1B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ColorblindSimulationImageEffect()
  {
  }
}
