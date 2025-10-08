// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.CustomInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Utility
{
  [Token(Token = "0x20002DE")]
  public class CustomInput
  {
    [Token(Token = "0x6001514")]
    [Address(RVA = "0x389B90", Offset = "0x388790", Length = "0xC1")]
    public static bool CheckInputDown(int[] keyCodes) => false;

    [Token(Token = "0x6001515")]
    [Address(RVA = "0x389C60", Offset = "0x388860", Length = "0x62")]
    public static bool CheckInputUp(int[] keyCodes) => false;

    [Token(Token = "0x6001516")]
    [Address(RVA = "0x389CD0", Offset = "0x3888D0", Length = "0xC1")]
    public static bool CheckInputs(int[] keyCodes) => false;

    [Token(Token = "0x6001517")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public CustomInput()
    {
    }
  }
}
