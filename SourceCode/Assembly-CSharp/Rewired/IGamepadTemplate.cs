// Decompiled with JetBrains decompiler
// Type: Rewired.IGamepadTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Rewired
{
  [Token(Token = "0x2000238")]
  public interface IGamepadTemplate : IControllerTemplate
  {
    [Token(Token = "0x17000085")]
    IControllerTemplateButton actionBottomRow1 { [Token(Token = "0x6000E40")] get; }

    [Token(Token = "0x17000086")]
    IControllerTemplateButton a { [Token(Token = "0x6000E41")] get; }

    [Token(Token = "0x17000087")]
    IControllerTemplateButton actionBottomRow2 { [Token(Token = "0x6000E42")] get; }

    [Token(Token = "0x17000088")]
    IControllerTemplateButton b { [Token(Token = "0x6000E43")] get; }

    [Token(Token = "0x17000089")]
    IControllerTemplateButton actionBottomRow3 { [Token(Token = "0x6000E44")] get; }

    [Token(Token = "0x1700008A")]
    IControllerTemplateButton c { [Token(Token = "0x6000E45")] get; }

    [Token(Token = "0x1700008B")]
    IControllerTemplateButton actionTopRow1 { [Token(Token = "0x6000E46")] get; }

    [Token(Token = "0x1700008C")]
    IControllerTemplateButton x { [Token(Token = "0x6000E47")] get; }

    [Token(Token = "0x1700008D")]
    IControllerTemplateButton actionTopRow2 { [Token(Token = "0x6000E48")] get; }

    [Token(Token = "0x1700008E")]
    IControllerTemplateButton y { [Token(Token = "0x6000E49")] get; }

    [Token(Token = "0x1700008F")]
    IControllerTemplateButton actionTopRow3 { [Token(Token = "0x6000E4A")] get; }

    [Token(Token = "0x17000090")]
    IControllerTemplateButton z { [Token(Token = "0x6000E4B")] get; }

    [Token(Token = "0x17000091")]
    IControllerTemplateButton leftShoulder1 { [Token(Token = "0x6000E4C")] get; }

    [Token(Token = "0x17000092")]
    IControllerTemplateButton leftBumper { [Token(Token = "0x6000E4D")] get; }

    [Token(Token = "0x17000093")]
    IControllerTemplateAxis leftShoulder2 { [Token(Token = "0x6000E4E")] get; }

    [Token(Token = "0x17000094")]
    IControllerTemplateAxis leftTrigger { [Token(Token = "0x6000E4F")] get; }

    [Token(Token = "0x17000095")]
    IControllerTemplateButton rightShoulder1 { [Token(Token = "0x6000E50")] get; }

    [Token(Token = "0x17000096")]
    IControllerTemplateButton rightBumper { [Token(Token = "0x6000E51")] get; }

    [Token(Token = "0x17000097")]
    IControllerTemplateAxis rightShoulder2 { [Token(Token = "0x6000E52")] get; }

    [Token(Token = "0x17000098")]
    IControllerTemplateAxis rightTrigger { [Token(Token = "0x6000E53")] get; }

    [Token(Token = "0x17000099")]
    IControllerTemplateButton center1 { [Token(Token = "0x6000E54")] get; }

    [Token(Token = "0x1700009A")]
    IControllerTemplateButton back { [Token(Token = "0x6000E55")] get; }

    [Token(Token = "0x1700009B")]
    IControllerTemplateButton center2 { [Token(Token = "0x6000E56")] get; }

    [Token(Token = "0x1700009C")]
    IControllerTemplateButton start { [Token(Token = "0x6000E57")] get; }

    [Token(Token = "0x1700009D")]
    IControllerTemplateButton center3 { [Token(Token = "0x6000E58")] get; }

    [Token(Token = "0x1700009E")]
    IControllerTemplateButton guide { [Token(Token = "0x6000E59")] get; }

    [Token(Token = "0x1700009F")]
    IControllerTemplateThumbStick leftStick { [Token(Token = "0x6000E5A")] get; }

    [Token(Token = "0x170000A0")]
    IControllerTemplateThumbStick rightStick { [Token(Token = "0x6000E5B")] get; }

    [Token(Token = "0x170000A1")]
    IControllerTemplateDPad dPad { [Token(Token = "0x6000E5C")] get; }
  }
}
