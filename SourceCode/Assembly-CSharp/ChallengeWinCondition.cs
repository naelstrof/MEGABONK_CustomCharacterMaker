// Decompiled with JetBrains decompiler
// Type: ChallengeWinCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Me/Progression/Challenge/", order = 1)]
[Token(Token = "0x2000224")]
public abstract class ChallengeWinCondition : ScriptableObject
{
  [Token(Token = "0x4000EFF")]
  [FieldOffset(Offset = "0x18")]
  public LocalizedString localizedString;

  [field: Token(Token = "0x4000F00")]
  [field: FieldOffset(Offset = "0x20")]
  [Token(Token = "0x17000080")]
  public bool completed { [Token(Token = "0x6000DD7"), Address(RVA = "0x36EB80", Offset = "0x36D780", Length = "0x5")] get; [Token(Token = "0x6000DD8"), Address(RVA = "0x386410", Offset = "0x385010", Length = "0x4")] private set; }

  [Token(Token = "0x6000DD9")]
  public abstract void Init();

  [Token(Token = "0x6000DDA")]
  public abstract void Cleanup();

  [Token(Token = "0x6000DDB")]
  [Address(RVA = "0x51EB40", Offset = "0x51D740", Length = "0x56")]
  public void ChallengeCompleted()
  {
  }

  [Token(Token = "0x6000DDC")]
  [Address(RVA = "0x51EBA0", Offset = "0x51D7A0", Length = "0x1D")]
  public string GetDescription() => (string) null;

  [Token(Token = "0x6000DDD")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  protected ChallengeWinCondition()
  {
  }
}
