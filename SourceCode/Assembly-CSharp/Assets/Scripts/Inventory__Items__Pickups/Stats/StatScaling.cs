// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Stats.StatScaling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.Stats
{
  [Token(Token = "0x2000385")]
  public static class StatScaling
  {
    [Token(Token = "0x6001921")]
    [Address(RVA = "0x4195B0", Offset = "0x4181B0", Length = "0x10")]
    public static float HyperbolicScaling(float input, float maxValue = 1f, float scaling = 0.5f) => 0.0f;

    [Token(Token = "0x6001922")]
    [Address(RVA = "0x4195C0", Offset = "0x4181C0", Length = "0x51")]
    private static float PowerScaling(
      float inputValue,
      float maxInputValue,
      float maxValue,
      float diminishingEffect)
    {
      return 0.0f;
    }
  }
}
