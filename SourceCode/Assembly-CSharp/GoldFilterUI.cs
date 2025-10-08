// Decompiled with JetBrains decompiler
// Type: GoldFilterUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012D")]
public class GoldFilterUI : MonoBehaviour
{
  [Token(Token = "0x40008E2")]
  [FieldOffset(Offset = "0x20")]
  public CanvasGroup canvas;
  [Token(Token = "0x40008E3")]
  [FieldOffset(Offset = "0x28")]
  public RawImage goldenUi;
  [Token(Token = "0x40008E4")]
  [FieldOffset(Offset = "0x30")]
  public Transform lines1;
  [Token(Token = "0x40008E5")]
  [FieldOffset(Offset = "0x38")]
  public Transform lines2;
  [Token(Token = "0x40008E6")]
  [FieldOffset(Offset = "0x40")]
  private float timeLeft;

  [Token(Token = "0x6000788")]
  [Address(RVA = "0x4B8290", Offset = "0x4B6E90", Length = "0x121")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000789")]
  [Address(RVA = "0x4B83C0", Offset = "0x4B6FC0", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600078A")]
  [Address(RVA = "0x4B84F0", Offset = "0x4B70F0", Length = "0x2B")]
  private void OnPickup(Pickup pickup)
  {
  }

  [Token(Token = "0x600078B")]
  [Address(RVA = "0x4B8520", Offset = "0x4B7120", Length = "0x526")]
  private void Update()
  {
  }

  [Token(Token = "0x600078C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GoldFilterUI()
  {
  }
}
