// Decompiled with JetBrains decompiler
// Type: InventoryOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200016D")]
public class InventoryOverlay : MonoBehaviour
{
  [Token(Token = "0x4000A93")]
  [FieldOffset(Offset = "0x20")]
  public GameObject[] windows;
  [Token(Token = "0x4000A94")]
  [FieldOffset(Offset = "0x28")]
  public UpgradeInventoryUI inventoryUi;
  [Token(Token = "0x4000A95")]
  [FieldOffset(Offset = "0x30")]
  private bool active;

  [Token(Token = "0x6000933")]
  [Address(RVA = "0x4D4BF0", Offset = "0x4D37F0", Length = "0x222")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000934")]
  [Address(RVA = "0x4D4E20", Offset = "0x4D3A20", Length = "0x222")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000935")]
  [Address(RVA = "0x4D50C0", Offset = "0x4D3CC0", Length = "0x75")]
  private void OnWindowOpened()
  {
  }

  [Token(Token = "0x6000936")]
  [Address(RVA = "0x4D5050", Offset = "0x4D3C50", Length = "0x66")]
  private void OnWindowClosed()
  {
  }

  [Token(Token = "0x6000937")]
  [Address(RVA = "0x4D5140", Offset = "0x4D3D40", Length = "0xF6")]
  private void Update()
  {
  }

  [Token(Token = "0x6000938")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public InventoryOverlay()
  {
  }
}
