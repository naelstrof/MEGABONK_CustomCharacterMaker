// Decompiled with JetBrains decompiler
// Type: XpAndGoldText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000141")]
public class XpAndGoldText : MonoBehaviour
{
  [Token(Token = "0x4000959")]
  [FieldOffset(Offset = "0x20")]
  public string prefix;
  [Token(Token = "0x400095A")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI text;
  [Token(Token = "0x400095B")]
  [FieldOffset(Offset = "0x30")]
  private float timeout;
  [Token(Token = "0x400095C")]
  [FieldOffset(Offset = "0x34")]
  private int amount;
  [Token(Token = "0x400095D")]
  [FieldOffset(Offset = "0x38")]
  private float startFadeTime;
  [Token(Token = "0x400095E")]
  [FieldOffset(Offset = "0x3C")]
  private float fadeTime;
  [Token(Token = "0x400095F")]
  [FieldOffset(Offset = "0x40")]
  private float timeToFade;

  [Token(Token = "0x600080C")]
  [Address(RVA = "0x4CB7C0", Offset = "0x4CA3C0", Length = "0x1A1")]
  public void Add(int amount)
  {
  }

  [Token(Token = "0x600080D")]
  [Address(RVA = "0x4CB970", Offset = "0x4CA570", Length = "0x265")]
  private void Update()
  {
  }

  [Token(Token = "0x600080E")]
  [Address(RVA = "0x4CBBE0", Offset = "0x4CA7E0", Length = "0x1C")]
  public XpAndGoldText()
  {
  }
}
