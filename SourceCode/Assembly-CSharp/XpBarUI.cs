// Decompiled with JetBrains decompiler
// Type: XpBarUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Inventory__Items__Pickups.Xp_and_Levels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000142")]
public class XpBarUI : MonoBehaviour
{
  [Token(Token = "0x4000960")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_levelText;
  [Token(Token = "0x4000961")]
  [FieldOffset(Offset = "0x28")]
  public RawImage xpBar;
  [Token(Token = "0x4000962")]
  [FieldOffset(Offset = "0x30")]
  private Color defaultColor;
  [Token(Token = "0x4000963")]
  [FieldOffset(Offset = "0x40")]
  public Material rainbow;
  [Token(Token = "0x4000964")]
  [FieldOffset(Offset = "0x48")]
  private Material defaultMaterial;
  [Token(Token = "0x4000965")]
  [FieldOffset(Offset = "0x50")]
  private float desiredRatio;

  [Token(Token = "0x600080F")]
  [Address(RVA = "0x4CBC00", Offset = "0x4CA800", Length = "0x570")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000810")]
  [Address(RVA = "0x4CC180", Offset = "0x4CAD80", Length = "0x530")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000811")]
  [Address(RVA = "0x4CCA20", Offset = "0x4CB620", Length = "0x10B")]
  private void Start()
  {
  }

  [Token(Token = "0x6000812")]
  [Address(RVA = "0x4CC860", Offset = "0x4CB460", Length = "0xBA")]
  private void Refresh(PlayerXp playerXp)
  {
  }

  [Token(Token = "0x6000813")]
  [Address(RVA = "0x4CC920", Offset = "0x4CB520", Length = "0xFA")]
  private void SetLevelText(int level)
  {
  }

  [Token(Token = "0x6000814")]
  [Address(RVA = "0x4CC6C0", Offset = "0x4CB2C0", Length = "0x1E")]
  private void OnInventoryInitialized(PlayerInventory pInventory)
  {
  }

  [Token(Token = "0x6000815")]
  [Address(RVA = "0x4CC7B0", Offset = "0x4CB3B0", Length = "0xA9")]
  private void OnXpIncrease(PlayerXp pXp, int amount)
  {
  }

  [Token(Token = "0x6000816")]
  [Address(RVA = "0x4CCB30", Offset = "0x4CB730", Length = "0x28E")]
  private void Update()
  {
  }

  [Token(Token = "0x6000817")]
  [Address(RVA = "0x4CC6E0", Offset = "0x4CB2E0", Length = "0x8")]
  private void OnLevelUp(int level)
  {
  }

  [Token(Token = "0x6000818")]
  [Address(RVA = "0x4CC780", Offset = "0x4CB380", Length = "0x2E")]
  private void OnLevelupShow()
  {
  }

  [Token(Token = "0x6000819")]
  [Address(RVA = "0x4CC6F0", Offset = "0x4CB2F0", Length = "0x83")]
  private void OnLevelupHide()
  {
  }

  [Token(Token = "0x600081A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public XpBarUI()
  {
  }
}
