// Decompiled with JetBrains decompiler
// Type: ChallengeModifierSmolBoi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Progression/Challenge/ChallengeModifiers/Smol boi", order = 1)]
[Token(Token = "0x2000221")]
public class ChallengeModifierSmolBoi : ChallengeModifier
{
  [Token(Token = "0x6000DC9")]
  [Address(RVA = "0x51DF60", Offset = "0x51CB60", Length = "0x139")]
  public override void Init()
  {
  }

  [Token(Token = "0x6000DCA")]
  [Address(RVA = "0x51DE20", Offset = "0x51CA20", Length = "0x139")]
  public override void Cleanup()
  {
  }

  [Token(Token = "0x6000DCB")]
  [Address(RVA = "0x51E0A0", Offset = "0x51CCA0", Length = "0xE5")]
  private void OnPlayerInit(PlayerInventory obj)
  {
  }

  [Token(Token = "0x6000DCC")]
  [Address(RVA = "0x36C7E0", Offset = "0x36B3E0", Length = "0x7")]
  public ChallengeModifierSmolBoi()
  {
  }
}
