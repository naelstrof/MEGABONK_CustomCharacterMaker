// Decompiled with JetBrains decompiler
// Type: XpAndGoldHUD
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Inventory__Items__Pickups.Xp_and_Levels;
using UnityEngine;

[Token(Token = "0x2000140")]
public class XpAndGoldHUD : MonoBehaviour
{
  [Token(Token = "0x4000956")]
  [FieldOffset(Offset = "0x20")]
  public XpAndGoldText xpText;
  [Token(Token = "0x4000957")]
  [FieldOffset(Offset = "0x28")]
  public XpAndGoldText goldText;
  [Token(Token = "0x4000958")]
  [FieldOffset(Offset = "0x30")]
  public XpAndGoldText silverText;

  [Token(Token = "0x6000806")]
  [Address(RVA = "0x4CB080", Offset = "0x4C9C80", Length = "0x35E")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000807")]
  [Address(RVA = "0x4CB3E0", Offset = "0x4C9FE0", Length = "0x35E")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000808")]
  [Address(RVA = "0x4CB740", Offset = "0x4CA340", Length = "0x23")]
  private void OnGoldIncrease(PlayerInventory inv, int amount)
  {
  }

  [Token(Token = "0x6000809")]
  [Address(RVA = "0x4CB790", Offset = "0x4CA390", Length = "0x23")]
  private void OnXpIncrease(PlayerXp pXp, int amount)
  {
  }

  [Token(Token = "0x600080A")]
  [Address(RVA = "0x4CB770", Offset = "0x4CA370", Length = "0x1E")]
  private void OnSilverChange(int amount)
  {
  }

  [Token(Token = "0x600080B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public XpAndGoldHUD()
  {
  }
}
