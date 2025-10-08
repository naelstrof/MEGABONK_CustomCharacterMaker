// Decompiled with JetBrains decompiler
// Type: Rewired.IFlightYokeTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Rewired
{
  [Token(Token = "0x200023B")]
  public interface IFlightYokeTemplate : IControllerTemplate
  {
    [Token(Token = "0x17000124")]
    IControllerTemplateButton leftPaddle { [Token(Token = "0x6000EDF")] get; }

    [Token(Token = "0x17000125")]
    IControllerTemplateButton rightPaddle { [Token(Token = "0x6000EE0")] get; }

    [Token(Token = "0x17000126")]
    IControllerTemplateButton leftGripButton1 { [Token(Token = "0x6000EE1")] get; }

    [Token(Token = "0x17000127")]
    IControllerTemplateButton leftGripButton2 { [Token(Token = "0x6000EE2")] get; }

    [Token(Token = "0x17000128")]
    IControllerTemplateButton leftGripButton3 { [Token(Token = "0x6000EE3")] get; }

    [Token(Token = "0x17000129")]
    IControllerTemplateButton leftGripButton4 { [Token(Token = "0x6000EE4")] get; }

    [Token(Token = "0x1700012A")]
    IControllerTemplateButton leftGripButton5 { [Token(Token = "0x6000EE5")] get; }

    [Token(Token = "0x1700012B")]
    IControllerTemplateButton leftGripButton6 { [Token(Token = "0x6000EE6")] get; }

    [Token(Token = "0x1700012C")]
    IControllerTemplateButton rightGripButton1 { [Token(Token = "0x6000EE7")] get; }

    [Token(Token = "0x1700012D")]
    IControllerTemplateButton rightGripButton2 { [Token(Token = "0x6000EE8")] get; }

    [Token(Token = "0x1700012E")]
    IControllerTemplateButton rightGripButton3 { [Token(Token = "0x6000EE9")] get; }

    [Token(Token = "0x1700012F")]
    IControllerTemplateButton rightGripButton4 { [Token(Token = "0x6000EEA")] get; }

    [Token(Token = "0x17000130")]
    IControllerTemplateButton rightGripButton5 { [Token(Token = "0x6000EEB")] get; }

    [Token(Token = "0x17000131")]
    IControllerTemplateButton rightGripButton6 { [Token(Token = "0x6000EEC")] get; }

    [Token(Token = "0x17000132")]
    IControllerTemplateButton centerButton1 { [Token(Token = "0x6000EED")] get; }

    [Token(Token = "0x17000133")]
    IControllerTemplateButton centerButton2 { [Token(Token = "0x6000EEE")] get; }

    [Token(Token = "0x17000134")]
    IControllerTemplateButton centerButton3 { [Token(Token = "0x6000EEF")] get; }

    [Token(Token = "0x17000135")]
    IControllerTemplateButton centerButton4 { [Token(Token = "0x6000EF0")] get; }

    [Token(Token = "0x17000136")]
    IControllerTemplateButton centerButton5 { [Token(Token = "0x6000EF1")] get; }

    [Token(Token = "0x17000137")]
    IControllerTemplateButton centerButton6 { [Token(Token = "0x6000EF2")] get; }

    [Token(Token = "0x17000138")]
    IControllerTemplateButton centerButton7 { [Token(Token = "0x6000EF3")] get; }

    [Token(Token = "0x17000139")]
    IControllerTemplateButton centerButton8 { [Token(Token = "0x6000EF4")] get; }

    [Token(Token = "0x1700013A")]
    IControllerTemplateButton wheel1Up { [Token(Token = "0x6000EF5")] get; }

    [Token(Token = "0x1700013B")]
    IControllerTemplateButton wheel1Down { [Token(Token = "0x6000EF6")] get; }

    [Token(Token = "0x1700013C")]
    IControllerTemplateButton wheel1Press { [Token(Token = "0x6000EF7")] get; }

    [Token(Token = "0x1700013D")]
    IControllerTemplateButton wheel2Up { [Token(Token = "0x6000EF8")] get; }

    [Token(Token = "0x1700013E")]
    IControllerTemplateButton wheel2Down { [Token(Token = "0x6000EF9")] get; }

    [Token(Token = "0x1700013F")]
    IControllerTemplateButton wheel2Press { [Token(Token = "0x6000EFA")] get; }

    [Token(Token = "0x17000140")]
    IControllerTemplateButton consoleButton1 { [Token(Token = "0x6000EFB")] get; }

    [Token(Token = "0x17000141")]
    IControllerTemplateButton consoleButton2 { [Token(Token = "0x6000EFC")] get; }

    [Token(Token = "0x17000142")]
    IControllerTemplateButton consoleButton3 { [Token(Token = "0x6000EFD")] get; }

    [Token(Token = "0x17000143")]
    IControllerTemplateButton consoleButton4 { [Token(Token = "0x6000EFE")] get; }

    [Token(Token = "0x17000144")]
    IControllerTemplateButton consoleButton5 { [Token(Token = "0x6000EFF")] get; }

    [Token(Token = "0x17000145")]
    IControllerTemplateButton consoleButton6 { [Token(Token = "0x6000F00")] get; }

    [Token(Token = "0x17000146")]
    IControllerTemplateButton consoleButton7 { [Token(Token = "0x6000F01")] get; }

    [Token(Token = "0x17000147")]
    IControllerTemplateButton consoleButton8 { [Token(Token = "0x6000F02")] get; }

    [Token(Token = "0x17000148")]
    IControllerTemplateButton consoleButton9 { [Token(Token = "0x6000F03")] get; }

    [Token(Token = "0x17000149")]
    IControllerTemplateButton consoleButton10 { [Token(Token = "0x6000F04")] get; }

    [Token(Token = "0x1700014A")]
    IControllerTemplateButton mode1 { [Token(Token = "0x6000F05")] get; }

    [Token(Token = "0x1700014B")]
    IControllerTemplateButton mode2 { [Token(Token = "0x6000F06")] get; }

    [Token(Token = "0x1700014C")]
    IControllerTemplateButton mode3 { [Token(Token = "0x6000F07")] get; }

    [Token(Token = "0x1700014D")]
    IControllerTemplateYoke yoke { [Token(Token = "0x6000F08")] get; }

    [Token(Token = "0x1700014E")]
    IControllerTemplateThrottle lever1 { [Token(Token = "0x6000F09")] get; }

    [Token(Token = "0x1700014F")]
    IControllerTemplateThrottle lever2 { [Token(Token = "0x6000F0A")] get; }

    [Token(Token = "0x17000150")]
    IControllerTemplateThrottle lever3 { [Token(Token = "0x6000F0B")] get; }

    [Token(Token = "0x17000151")]
    IControllerTemplateThrottle lever4 { [Token(Token = "0x6000F0C")] get; }

    [Token(Token = "0x17000152")]
    IControllerTemplateThrottle lever5 { [Token(Token = "0x6000F0D")] get; }

    [Token(Token = "0x17000153")]
    IControllerTemplateHat leftGripHat { [Token(Token = "0x6000F0E")] get; }

    [Token(Token = "0x17000154")]
    IControllerTemplateHat rightGripHat { [Token(Token = "0x6000F0F")] get; }
  }
}
