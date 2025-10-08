// Decompiled with JetBrains decompiler
// Type: SteamManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Steamworks;
using System;
using UnityEngine;

[Token(Token = "0x2000117")]
public class SteamManager : MonoBehaviour
{
  [Token(Token = "0x4000857")]
  protected static bool initialized;
  [Token(Token = "0x4000858")]
  protected static SteamManager Instance;
  [Token(Token = "0x4000859")]
  public static AppId_t APP_ID;
  [Token(Token = "0x400085A")]
  public static Action A_UpdateComponents;
  [Token(Token = "0x400085B")]
  public static Action A_Initialized;
  [Token(Token = "0x400085C")]
  public static ulong steamId;
  [Token(Token = "0x400085D")]
  public static Action<ulong> A_PlayerInformationArrived;

  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
  [Token(Token = "0x60006F8")]
  [Address(RVA = "0x4C6140", Offset = "0x4C4D40", Length = "0x7C")]
  private static void InitOnPlayMode()
  {
  }

  [Token(Token = "0x60006F9")]
  [Address(RVA = "0x4C6210", Offset = "0x4C4E10", Length = "0x535")]
  public virtual void Load()
  {
  }

  [Token(Token = "0x60006FA")]
  [Address(RVA = "0x4C6750", Offset = "0x4C5350", Length = "0x1AD")]
  protected virtual void OnDestroy()
  {
  }

  [Token(Token = "0x60006FB")]
  [Address(RVA = "0x4C6010", Offset = "0x4C4C10", Length = "0x125")]
  private void InitComponents()
  {
  }

  [Token(Token = "0x60006FC")]
  [Address(RVA = "0x4C5F40", Offset = "0x4C4B40", Length = "0xC4")]
  private void DestroyComponents()
  {
  }

  [Token(Token = "0x60006FD")]
  [Address(RVA = "0x4C6900", Offset = "0x4C5500", Length = "0x6E")]
  private void OnPersonaStateChange(PersonaStateChange_t param)
  {
  }

  [Token(Token = "0x60006FE")]
  [Address(RVA = "0x4C6970", Offset = "0x4C5570", Length = "0x96")]
  protected virtual void Update()
  {
  }

  [Token(Token = "0x60006FF")]
  [Address(RVA = "0x4C61C0", Offset = "0x4C4DC0", Length = "0x4E")]
  public static bool IsInitialized() => false;

  [Token(Token = "0x6000700")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public SteamManager()
  {
  }

  [Token(Token = "0x6000701")]
  [Address(RVA = "0x4C6A10", Offset = "0x4C5610", Length = "0x61")]
  static SteamManager()
  {
  }
}
