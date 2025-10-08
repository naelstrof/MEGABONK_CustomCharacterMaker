// Decompiled with JetBrains decompiler
// Type: ResetRunUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200013D")]
public class ResetRunUi : MonoBehaviour
{
  [Token(Token = "0x400093D")]
  [FieldOffset(Offset = "0x20")]
  public Transform content;
  [Token(Token = "0x400093E")]
  [FieldOffset(Offset = "0x28")]
  public Image progressBar;
  [Token(Token = "0x400093F")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI text;
  [Token(Token = "0x4000940")]
  [FieldOffset(Offset = "0x38")]
  private float startedHoldingTime;
  [Token(Token = "0x4000941")]
  [FieldOffset(Offset = "0x3C")]
  private bool holding;
  [Token(Token = "0x4000942")]
  [FieldOffset(Offset = "0x40")]
  private float holdTime;
  [Token(Token = "0x4000943")]
  [FieldOffset(Offset = "0x44")]
  private bool restarting;

  [Token(Token = "0x60007F3")]
  [Address(RVA = "0x4C1990", Offset = "0x4C0590", Length = "0x2DA")]
  private void Update()
  {
  }

  [Token(Token = "0x60007F4")]
  [Address(RVA = "0x4C1790", Offset = "0x4C0390", Length = "0xD2")]
  private void StartProgress()
  {
  }

  [Token(Token = "0x60007F5")]
  [Address(RVA = "0x4C1870", Offset = "0x4C0470", Length = "0x5B")]
  private void StopProgress()
  {
  }

  [Token(Token = "0x60007F6")]
  [Address(RVA = "0x4C18D0", Offset = "0x4C04D0", Length = "0xBC")]
  private void UpdateBar()
  {
  }

  [Token(Token = "0x60007F7")]
  [Address(RVA = "0x4C1C70", Offset = "0x4C0870", Length = "0xE")]
  public ResetRunUi()
  {
  }
}
