// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.CharacterProgression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Saves___Serialization.Progression
{
  [Token(Token = "0x2000324")]
  public class CharacterProgression
  {
    [Token(Token = "0x4001557")]
    [FieldOffset(Offset = "0x10")]
    public int xp;
    [Token(Token = "0x4001558")]
    [FieldOffset(Offset = "0x14")]
    public int numRuns;
    [Token(Token = "0x4001559")]
    [FieldOffset(Offset = "0x18")]
    private float xpModifier;

    [Token(Token = "0x6001656")]
    [Address(RVA = "0x3A3C40", Offset = "0x3A2840", Length = "0x36")]
    public void OnRunFinished(int xp)
    {
    }

    [Token(Token = "0x6001657")]
    [Address(RVA = "0x3A3B90", Offset = "0x3A2790", Length = "0x4E")]
    public int GetRank() => 0;

    [Token(Token = "0x6001658")]
    [Address(RVA = "0x3A3BE0", Offset = "0x3A27E0", Length = "0x54")]
    public bool HasStar() => false;

    [Token(Token = "0x6001659")]
    [Address(RVA = "0x3A3C80", Offset = "0x3A2880", Length = "0xE")]
    public CharacterProgression()
    {
    }
  }
}
