// Decompiled with JetBrains decompiler
// Type: Rewired.IFlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Rewired
{
  [Token(Token = "0x200023C")]
  public interface IFlightPedalsTemplate : IControllerTemplate
  {
    [Token(Token = "0x17000155")]
    IControllerTemplateAxis leftPedal { [Token(Token = "0x6000F10")] get; }

    [Token(Token = "0x17000156")]
    IControllerTemplateAxis rightPedal { [Token(Token = "0x6000F11")] get; }

    [Token(Token = "0x17000157")]
    IControllerTemplateAxis slide { [Token(Token = "0x6000F12")] get; }
  }
}
