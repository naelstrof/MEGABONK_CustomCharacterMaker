// Decompiled with JetBrains decompiler
// Type: Rewired.IRacingWheelTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Rewired
{
  [Token(Token = "0x2000239")]
  public interface IRacingWheelTemplate : IControllerTemplate
  {
    [Token(Token = "0x170000A2")]
    IControllerTemplateAxis wheel { [Token(Token = "0x6000E5D")] get; }

    [Token(Token = "0x170000A3")]
    IControllerTemplateAxis accelerator { [Token(Token = "0x6000E5E")] get; }

    [Token(Token = "0x170000A4")]
    IControllerTemplateAxis brake { [Token(Token = "0x6000E5F")] get; }

    [Token(Token = "0x170000A5")]
    IControllerTemplateAxis clutch { [Token(Token = "0x6000E60")] get; }

    [Token(Token = "0x170000A6")]
    IControllerTemplateButton shiftDown { [Token(Token = "0x6000E61")] get; }

    [Token(Token = "0x170000A7")]
    IControllerTemplateButton shiftUp { [Token(Token = "0x6000E62")] get; }

    [Token(Token = "0x170000A8")]
    IControllerTemplateButton wheelButton1 { [Token(Token = "0x6000E63")] get; }

    [Token(Token = "0x170000A9")]
    IControllerTemplateButton wheelButton2 { [Token(Token = "0x6000E64")] get; }

    [Token(Token = "0x170000AA")]
    IControllerTemplateButton wheelButton3 { [Token(Token = "0x6000E65")] get; }

    [Token(Token = "0x170000AB")]
    IControllerTemplateButton wheelButton4 { [Token(Token = "0x6000E66")] get; }

    [Token(Token = "0x170000AC")]
    IControllerTemplateButton wheelButton5 { [Token(Token = "0x6000E67")] get; }

    [Token(Token = "0x170000AD")]
    IControllerTemplateButton wheelButton6 { [Token(Token = "0x6000E68")] get; }

    [Token(Token = "0x170000AE")]
    IControllerTemplateButton wheelButton7 { [Token(Token = "0x6000E69")] get; }

    [Token(Token = "0x170000AF")]
    IControllerTemplateButton wheelButton8 { [Token(Token = "0x6000E6A")] get; }

    [Token(Token = "0x170000B0")]
    IControllerTemplateButton wheelButton9 { [Token(Token = "0x6000E6B")] get; }

    [Token(Token = "0x170000B1")]
    IControllerTemplateButton wheelButton10 { [Token(Token = "0x6000E6C")] get; }

    [Token(Token = "0x170000B2")]
    IControllerTemplateButton consoleButton1 { [Token(Token = "0x6000E6D")] get; }

    [Token(Token = "0x170000B3")]
    IControllerTemplateButton consoleButton2 { [Token(Token = "0x6000E6E")] get; }

    [Token(Token = "0x170000B4")]
    IControllerTemplateButton consoleButton3 { [Token(Token = "0x6000E6F")] get; }

    [Token(Token = "0x170000B5")]
    IControllerTemplateButton consoleButton4 { [Token(Token = "0x6000E70")] get; }

    [Token(Token = "0x170000B6")]
    IControllerTemplateButton consoleButton5 { [Token(Token = "0x6000E71")] get; }

    [Token(Token = "0x170000B7")]
    IControllerTemplateButton consoleButton6 { [Token(Token = "0x6000E72")] get; }

    [Token(Token = "0x170000B8")]
    IControllerTemplateButton consoleButton7 { [Token(Token = "0x6000E73")] get; }

    [Token(Token = "0x170000B9")]
    IControllerTemplateButton consoleButton8 { [Token(Token = "0x6000E74")] get; }

    [Token(Token = "0x170000BA")]
    IControllerTemplateButton consoleButton9 { [Token(Token = "0x6000E75")] get; }

    [Token(Token = "0x170000BB")]
    IControllerTemplateButton consoleButton10 { [Token(Token = "0x6000E76")] get; }

    [Token(Token = "0x170000BC")]
    IControllerTemplateButton shifter1 { [Token(Token = "0x6000E77")] get; }

    [Token(Token = "0x170000BD")]
    IControllerTemplateButton shifter2 { [Token(Token = "0x6000E78")] get; }

    [Token(Token = "0x170000BE")]
    IControllerTemplateButton shifter3 { [Token(Token = "0x6000E79")] get; }

    [Token(Token = "0x170000BF")]
    IControllerTemplateButton shifter4 { [Token(Token = "0x6000E7A")] get; }

    [Token(Token = "0x170000C0")]
    IControllerTemplateButton shifter5 { [Token(Token = "0x6000E7B")] get; }

    [Token(Token = "0x170000C1")]
    IControllerTemplateButton shifter6 { [Token(Token = "0x6000E7C")] get; }

    [Token(Token = "0x170000C2")]
    IControllerTemplateButton shifter7 { [Token(Token = "0x6000E7D")] get; }

    [Token(Token = "0x170000C3")]
    IControllerTemplateButton shifter8 { [Token(Token = "0x6000E7E")] get; }

    [Token(Token = "0x170000C4")]
    IControllerTemplateButton shifter9 { [Token(Token = "0x6000E7F")] get; }

    [Token(Token = "0x170000C5")]
    IControllerTemplateButton shifter10 { [Token(Token = "0x6000E80")] get; }

    [Token(Token = "0x170000C6")]
    IControllerTemplateButton reverseGear { [Token(Token = "0x6000E81")] get; }

    [Token(Token = "0x170000C7")]
    IControllerTemplateButton select { [Token(Token = "0x6000E82")] get; }

    [Token(Token = "0x170000C8")]
    IControllerTemplateButton start { [Token(Token = "0x6000E83")] get; }

    [Token(Token = "0x170000C9")]
    IControllerTemplateButton systemButton { [Token(Token = "0x6000E84")] get; }

    [Token(Token = "0x170000CA")]
    IControllerTemplateButton horn { [Token(Token = "0x6000E85")] get; }

    [Token(Token = "0x170000CB")]
    IControllerTemplateDPad dPad { [Token(Token = "0x6000E86")] get; }
  }
}
