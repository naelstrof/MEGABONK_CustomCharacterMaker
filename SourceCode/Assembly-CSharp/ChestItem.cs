// Decompiled with JetBrains decompiler
// Type: ChestItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000205")]
public class ChestItem : MonoBehaviour
{
  [Token(Token = "0x4000E2D")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000E2E")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_amountText;
  [Token(Token = "0x4000E2F")]
  [FieldOffset(Offset = "0x30")]
  public AudioClip clipPositive;
  [Token(Token = "0x4000E30")]
  [FieldOffset(Offset = "0x38")]
  public AudioClip clipNegative;
  [Token(Token = "0x4000E31")]
  [FieldOffset(Offset = "0x40")]
  public AudioSource audioSource;

  [Token(Token = "0x6000D40")]
  [Address(RVA = "0x51F160", Offset = "0x51DD60", Length = "0x10D")]
  public void Set(ItemData itemData, int amount)
  {
  }

  [Token(Token = "0x6000D41")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ChestItem()
  {
  }
}
