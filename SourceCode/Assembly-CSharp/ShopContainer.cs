// Decompiled with JetBrains decompiler
// Type: ShopContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001E2")]
public class ShopContainer : MonoBehaviour
{
  [Token(Token = "0x4000D7D")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000D7F")]
  [FieldOffset(Offset = "0x30")]
  public Transform levelsParent;
  [Token(Token = "0x4000D80")]
  [FieldOffset(Offset = "0x38")]
  public GameObject backgroundLocked;
  [Token(Token = "0x4000D81")]
  [FieldOffset(Offset = "0x40")]
  public GameObject backgroundUnlocked;
  [Token(Token = "0x4000D82")]
  [FieldOffset(Offset = "0x48")]
  public GameObject alert;

  [field: Token(Token = "0x4000D7E")]
  [field: FieldOffset(Offset = "0x28")]
  [Token(Token = "0x17000076")]
  public ShopItemData data { [Token(Token = "0x6000C7D"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get; [Token(Token = "0x6000C7E"), Address(RVA = "0x386DE0", Offset = "0x3859E0", Length = "0xD")] private set; }

  [Token(Token = "0x6000C7F")]
  [Address(RVA = "0x515EB0", Offset = "0x514AB0", Length = "0x222")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000C80")]
  [Address(RVA = "0x5160E0", Offset = "0x514CE0", Length = "0x227")]
  private void OnButtonSelect(ShopContainer shopBtn)
  {
  }

  [Token(Token = "0x6000C81")]
  [Address(RVA = "0x516310", Offset = "0x514F10", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C82")]
  [Address(RVA = "0x516750", Offset = "0x515350", Length = "0x2C0")]
  public void Set(ShopItemData shopItemData)
  {
  }

  [Token(Token = "0x6000C83")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Update()
  {
  }

  [Token(Token = "0x6000C84")]
  [Address(RVA = "0x516520", Offset = "0x515120", Length = "0x226")]
  private void RefreshLevel(bool isUnlocked)
  {
  }

  [Token(Token = "0x6000C85")]
  [Address(RVA = "0x516440", Offset = "0x515040", Length = "0xD4")]
  private void OnShopItemLevelChanged(ShopContainer shopContainer)
  {
  }

  [Token(Token = "0x6000C86")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ShopContainer()
  {
  }
}
