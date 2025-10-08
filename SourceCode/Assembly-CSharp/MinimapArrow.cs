// Decompiled with JetBrains decompiler
// Type: MinimapArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000137")]
public class MinimapArrow : MonoBehaviour
{
  [Token(Token = "0x4000922")]
  [FieldOffset(Offset = "0x20")]
  public Transform target;
  [Token(Token = "0x4000923")]
  [FieldOffset(Offset = "0x28")]
  public MeshRenderer meshRenderer;

  [Token(Token = "0x60007C7")]
  [Address(RVA = "0x4BE720", Offset = "0x4BD320", Length = "0x7")]
  private void Update()
  {
  }

  [Token(Token = "0x60007C8")]
  [Address(RVA = "0x4BE170", Offset = "0x4BCD70", Length = "0x5A5")]
  private void UpdateBossArrow()
  {
  }

  [Token(Token = "0x60007C9")]
  [Address(RVA = "0x4BE150", Offset = "0x4BCD50", Length = "0x1D")]
  private bool IsVisible() => false;

  [Token(Token = "0x60007CA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MinimapArrow()
  {
  }
}
