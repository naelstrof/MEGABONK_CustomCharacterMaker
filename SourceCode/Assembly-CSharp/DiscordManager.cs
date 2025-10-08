// Decompiled with JetBrains decompiler
// Type: DiscordManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Discord;
using UnityEngine;

[Token(Token = "0x2000020")]
public class DiscordManager : MonoBehaviour
{
  [Token(Token = "0x400012A")]
  public static bool ENABLED;
  [Token(Token = "0x400012B")]
  [FieldOffset(Offset = "0x20")]
  private bool isRunning;
  [Token(Token = "0x400012C")]
  [FieldOffset(Offset = "0x28")]
  private Discord.Discord discord;
  [Token(Token = "0x400012D")]
  public static DiscordManager Instance;
  [Token(Token = "0x400012E")]
  [FieldOffset(Offset = "0x30")]
  private float checkReconnectTimer;
  [Token(Token = "0x400012F")]
  [FieldOffset(Offset = "0x38")]
  private long appid;

  [Token(Token = "0x600010B")]
  [Address(RVA = "0x33CDE0", Offset = "0x33B9E0", Length = "0x163")]
  private void Awake()
  {
  }

  [Token(Token = "0x600010C")]
  [Address(RVA = "0x33CF50", Offset = "0x33BB50", Length = "0xC9")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600010D")]
  [Address(RVA = "0x33D0C0", Offset = "0x33BCC0", Length = "0x1F1")]
  public void UpdateActivity(Activity activity)
  {
  }

  [Token(Token = "0x600010E")]
  [Address(RVA = "0x33D2C0", Offset = "0x33BEC0", Length = "0x130")]
  private void Update()
  {
  }

  [Token(Token = "0x600010F")]
  [Address(RVA = "0x33D020", Offset = "0x33BC20", Length = "0x97")]
  private void TryReconnect()
  {
  }

  [Token(Token = "0x6000110")]
  [Address(RVA = "0x33D430", Offset = "0x33C030", Length = "0x1C")]
  public DiscordManager()
  {
  }

  [Token(Token = "0x6000111")]
  [Address(RVA = "0x33D3F0", Offset = "0x33BFF0", Length = "0x36")]
  static DiscordManager()
  {
  }
}
