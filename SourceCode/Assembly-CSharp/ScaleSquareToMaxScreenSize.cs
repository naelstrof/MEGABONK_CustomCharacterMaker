// Decompiled with JetBrains decompiler
// Type: ScaleSquareToMaxScreenSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000200")]
public class ScaleSquareToMaxScreenSize : MonoBehaviour
{
  [Token(Token = "0x4000E14")]
  [FieldOffset(Offset = "0x20")]
  private RectTransform rect;
  [Token(Token = "0x4000E15")]
  [FieldOffset(Offset = "0x28")]
  public CanvasScaler canvasScaler;

  [Token(Token = "0x6000D2A")]
  [Address(RVA = "0x52CBB0", Offset = "0x52B7B0", Length = "0x121")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000D2B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ScaleSquareToMaxScreenSize()
  {
  }
}
