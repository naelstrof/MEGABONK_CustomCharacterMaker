// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.Controllers.InputTip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Utility.Controllers
{
  [Token(Token = "0x20002E8")]
  public class InputTip
  {
    [Token(Token = "0x40013D4")]
    [FieldOffset(Offset = "0x10")]
    public string tip;
    [Token(Token = "0x40013D5")]
    [FieldOffset(Offset = "0x18")]
    public string action;
    [Token(Token = "0x40013D6")]
    [FieldOffset(Offset = "0x20")]
    public float extraDelay;

    [Token(Token = "0x6001546")]
    [Address(RVA = "0x3AAEC0", Offset = "0x3A9AC0", Length = "0x61")]
    public InputTip(string tip, string action, float extraDelay)
    {
    }
  }
}
