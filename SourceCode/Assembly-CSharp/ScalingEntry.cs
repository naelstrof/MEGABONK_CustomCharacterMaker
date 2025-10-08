// Decompiled with JetBrains decompiler
// Type: ScalingEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000127")]
public class ScalingEntry : MonoBehaviour
{
  [Token(Token = "0x40008B9")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_text;
  [Token(Token = "0x40008BA")]
  [FieldOffset(Offset = "0x28")]
  public RawImage parentSquare;
  [Token(Token = "0x40008BB")]
  [FieldOffset(Offset = "0x30")]
  public RawImage timeSquare;
  [Token(Token = "0x40008BC")]
  [FieldOffset(Offset = "0x38")]
  public RawImage stageSquare;
  [Token(Token = "0x40008BD")]
  [FieldOffset(Offset = "0x40")]
  public RawImage finalSwarmSquare;

  [Token(Token = "0x600075E")]
  [Address(RVA = "0x4C4900", Offset = "0x4C3500", Length = "0x3BB")]
  public void Set(string text, float timeM, float stageM, float finalM)
  {
  }

  [Token(Token = "0x600075F")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ScalingEntry()
  {
  }
}
