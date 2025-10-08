// Decompiled with JetBrains decompiler
// Type: FadeInOnEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018A")]
public class FadeInOnEnable : MonoBehaviour
{
  [Token(Token = "0x4000B4C")]
  [FieldOffset(Offset = "0x20")]
  public RawImage cg;
  [Token(Token = "0x4000B4D")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI text;

  [Token(Token = "0x60009EA")]
  [Address(RVA = "0x4ECAA0", Offset = "0x4EB6A0", Length = "0xD7")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60009EB")]
  [Address(RVA = "0x4ECB80", Offset = "0x4EB780", Length = "0x15A")]
  private void Update()
  {
  }

  [Token(Token = "0x60009EC")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public FadeInOnEnable()
  {
  }
}
