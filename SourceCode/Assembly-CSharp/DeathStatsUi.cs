// Decompiled with JetBrains decompiler
// Type: DeathStatsUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200014D")]
public class DeathStatsUi : MonoBehaviour
{
  [Token(Token = "0x40009C6")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_stats;
  [Token(Token = "0x40009C7")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_gold;
  [Token(Token = "0x40009C8")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_unlocks;
  [Token(Token = "0x40009C9")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_silver;
  [Token(Token = "0x40009CA")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_characterName;
  [Token(Token = "0x40009CB")]
  [FieldOffset(Offset = "0x48")]
  public RawImage i_character;
  [Token(Token = "0x40009CC")]
  [FieldOffset(Offset = "0x50")]
  public Transform weaponsParent;
  [Token(Token = "0x40009CD")]
  [FieldOffset(Offset = "0x58")]
  public Transform tomesParent;
  [Token(Token = "0x40009CE")]
  [FieldOffset(Offset = "0x60")]
  public Transform itemsParent;
  [Token(Token = "0x40009CF")]
  [FieldOffset(Offset = "0x68")]
  public GameObject inventoryItemPrefab;

  [Token(Token = "0x6000868")]
  [Address(RVA = "0x4D2180", Offset = "0x4D0D80", Length = "0x733")]
  private void Start()
  {
  }

  [Token(Token = "0x6000869")]
  [Address(RVA = "0x4D1AD0", Offset = "0x4D06D0", Length = "0x6AF")]
  private void ShowInventory()
  {
  }

  [Token(Token = "0x600086A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DeathStatsUi()
  {
  }
}
