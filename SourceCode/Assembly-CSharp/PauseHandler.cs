// Decompiled with JetBrains decompiler
// Type: PauseHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired;
using Steamworks;
using UnityEngine;

[Token(Token = "0x200015D")]
public class PauseHandler : MonoBehaviour
{
  [Token(Token = "0x4000A47")]
  [FieldOffset(Offset = "0x20")]
  protected Callback<GameOverlayActivated_t> m_GameOverlayActivated;
  [Token(Token = "0x4000A48")]
  [FieldOffset(Offset = "0x28")]
  public PauseUi pauseUi;

  [Token(Token = "0x60008D0")]
  [Address(RVA = "0x4DBA60", Offset = "0x4DA660", Length = "0x15A")]
  private void Start()
  {
  }

  [Token(Token = "0x60008D1")]
  [Address(RVA = "0x4DB980", Offset = "0x4DA580", Length = "0xAF")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60008D2")]
  [Address(RVA = "0x4DB8B0", Offset = "0x4DA4B0", Length = "0xCF")]
  private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
  {
  }

  [Token(Token = "0x60008D3")]
  [Address(RVA = "0x4DBA30", Offset = "0x4DA630", Length = "0x27")]
  private void OnGameOverlayActivated(GameOverlayActivated_t pCallback)
  {
  }

  [Token(Token = "0x60008D4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PauseHandler()
  {
  }
}
