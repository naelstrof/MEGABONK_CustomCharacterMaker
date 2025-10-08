// Decompiled with JetBrains decompiler
// Type: StartBlackOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200016C")]
public class StartBlackOverlay : MonoBehaviour
{
  [Token(Token = "0x4000A91")]
  [FieldOffset(Offset = "0x20")]
  public RawImage overlay;
  [Token(Token = "0x4000A92")]
  [FieldOffset(Offset = "0x28")]
  private bool hasSubscribed;

  [Token(Token = "0x600092E")]
  [Address(RVA = "0x4DEAB0", Offset = "0x4DD6B0", Length = "0x159")]
  private void Start()
  {
  }

  [Token(Token = "0x600092F")]
  [Address(RVA = "0x4DEA70", Offset = "0x4DD670", Length = "0x3F")]
  private void OnGenerationComplete()
  {
  }

  [Token(Token = "0x6000930")]
  [Address(RVA = "0x4DB850", Offset = "0x4DA450", Length = "0x20")]
  private void HideBlackScreen()
  {
  }

  [Token(Token = "0x6000931")]
  [Address(RVA = "0x4DE940", Offset = "0x4DD540", Length = "0x12A")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000932")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public StartBlackOverlay()
  {
  }
}
