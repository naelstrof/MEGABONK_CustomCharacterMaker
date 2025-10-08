// Decompiled with JetBrains decompiler
// Type: PauseUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200015E")]
public class PauseUi : MonoBehaviour
{
  [Token(Token = "0x4000A49")]
  [FieldOffset(Offset = "0x20")]
  public GameObject main;
  [Token(Token = "0x4000A4A")]
  [FieldOffset(Offset = "0x28")]
  public GameObject options;
  [Token(Token = "0x4000A4B")]
  [FieldOffset(Offset = "0x30")]
  private GameObject current;
  [Token(Token = "0x4000A4C")]
  [FieldOffset(Offset = "0x38")]
  public UpgradeInventoryUI inventory;
  [Token(Token = "0x4000A4D")]
  [FieldOffset(Offset = "0x40")]
  private bool wasGamePaused;

  [Token(Token = "0x60008D5")]
  [Address(RVA = "0x4DBBC0", Offset = "0x4DA7C0", Length = "0xC")]
  private void Awake()
  {
  }

  [Token(Token = "0x60008D6")]
  [Address(RVA = "0x4DC060", Offset = "0x4DAC60", Length = "0x19D")]
  public void Pause()
  {
  }

  [Token(Token = "0x60008D7")]
  [Address(RVA = "0x3563C0", Offset = "0x354FC0", Length = "0x26")]
  public void Resume()
  {
  }

  [Token(Token = "0x60008D8")]
  [Address(RVA = "0x4DBBD0", Offset = "0x4DA7D0", Length = "0x11E")]
  public bool CanPause() => false;

  [Token(Token = "0x60008D9")]
  [Address(RVA = "0x4DBCF0", Offset = "0x4DA8F0", Length = "0x1BF")]
  public void Exit()
  {
  }

  [Token(Token = "0x60008DA")]
  [Address(RVA = "0x4DBBC0", Offset = "0x4DA7C0", Length = "0xC")]
  public void GoToMain()
  {
  }

  [Token(Token = "0x60008DB")]
  [Address(RVA = "0x4DBEB0", Offset = "0x4DAAB0", Length = "0xC")]
  public void GoToOptions()
  {
  }

  [Token(Token = "0x60008DC")]
  [Address(RVA = "0x4DBEC0", Offset = "0x4DAAC0", Length = "0xA5")]
  private void GoToWindow(GameObject window)
  {
  }

  [Token(Token = "0x60008DD")]
  [Address(RVA = "0x4DC200", Offset = "0x4DAE00", Length = "0x1B3")]
  public void Restart()
  {
  }

  [Token(Token = "0x60008DE")]
  [Address(RVA = "0x4DC3C0", Offset = "0x4DAFC0", Length = "0x5C")]
  public void Toggle()
  {
  }

  [Token(Token = "0x60008DF")]
  [Address(RVA = "0x4DBFA0", Offset = "0x4DABA0", Length = "0x52")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60008E0")]
  [Address(RVA = "0x4DC000", Offset = "0x4DAC00", Length = "0x5D")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60008E1")]
  [Address(RVA = "0x4DBF70", Offset = "0x4DAB70", Length = "0x23")]
  public bool IsPaused() => false;

  [Token(Token = "0x60008E2")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PauseUi()
  {
  }
}
