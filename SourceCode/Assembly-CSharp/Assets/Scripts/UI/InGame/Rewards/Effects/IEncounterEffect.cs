// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.InGame.Rewards.Effects.IEncounterEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.UI.InGame.Rewards.Effects
{
  [Token(Token = "0x20002FD")]
  public interface IEncounterEffect
  {
    [Token(Token = "0x600159E")]
    string GetDescription();

    [Token(Token = "0x600159F")]
    void ApplyEffect();
  }
}
