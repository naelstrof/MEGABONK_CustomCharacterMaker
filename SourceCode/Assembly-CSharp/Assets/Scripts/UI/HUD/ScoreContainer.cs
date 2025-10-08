// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.HUD.ScoreContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.UI.HUD
{
  [Token(Token = "0x2000301")]
  public class ScoreContainer
  {
    [Token(Token = "0x4001472")]
    [FieldOffset(Offset = "0x10")]
    public string header;
    [Token(Token = "0x4001473")]
    [FieldOffset(Offset = "0x18")]
    public string description;
    [Token(Token = "0x4001474")]
    [FieldOffset(Offset = "0x20")]
    public bool isPositive;

    [Token(Token = "0x60015B0")]
    [Address(RVA = "0x3B7A80", Offset = "0x3B6680", Length = "0x61")]
    public ScoreContainer(string header, string description, bool isPositive)
    {
    }
  }
}
