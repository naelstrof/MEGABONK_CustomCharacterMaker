// Decompiled with JetBrains decompiler
// Type: MenuAlerts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001BA")]
public class MenuAlerts : MonoBehaviour
{
  [Token(Token = "0x4000C96")]
  [FieldOffset(Offset = "0x20")]
  public GameObject alertUnlocks;
  [Token(Token = "0x4000C97")]
  [FieldOffset(Offset = "0x28")]
  public GameObject alertQuests;
  [Token(Token = "0x4000C98")]
  [FieldOffset(Offset = "0x30")]
  public GameObject alertShop;

  [Token(Token = "0x6000B2D")]
  [Address(RVA = "0x50C800", Offset = "0x50B400", Length = "0x138")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B2E")]
  [Address(RVA = "0x50C940", Offset = "0x50B540", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B2F")]
  [Address(RVA = "0x50CA80", Offset = "0x50B680", Length = "0x7")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000B30")]
  [Address(RVA = "0x50CA90", Offset = "0x50B690", Length = "0x443")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000B31")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MenuAlerts()
  {
  }
}
