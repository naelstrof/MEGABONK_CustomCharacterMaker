// Decompiled with JetBrains decompiler
// Type: Rewired.FlightYokeTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired
{
  [Token(Token = "0x2000241")]
  public sealed class FlightYokeTemplate : 
    ControllerTemplate,
    IFlightYokeTemplate,
    IControllerTemplate
  {
    [Token(Token = "0x4001068")]
    public static readonly Guid typeGuid;
    [Token(Token = "0x4001069")]
    public const int elementId_rotateYoke = 0;
    [Token(Token = "0x400106A")]
    public const int elementId_yokeZ = 1;
    [Token(Token = "0x400106B")]
    public const int elementId_leftPaddle = 59;
    [Token(Token = "0x400106C")]
    public const int elementId_rightPaddle = 60;
    [Token(Token = "0x400106D")]
    public const int elementId_lever1Axis = 2;
    [Token(Token = "0x400106E")]
    public const int elementId_lever1MinDetent = 64;
    [Token(Token = "0x400106F")]
    public const int elementId_lever2Axis = 3;
    [Token(Token = "0x4001070")]
    public const int elementId_lever2MinDetent = 65;
    [Token(Token = "0x4001071")]
    public const int elementId_lever3Axis = 4;
    [Token(Token = "0x4001072")]
    public const int elementId_lever3MinDetent = 66;
    [Token(Token = "0x4001073")]
    public const int elementId_lever4Axis = 5;
    [Token(Token = "0x4001074")]
    public const int elementId_lever4MinDetent = 67;
    [Token(Token = "0x4001075")]
    public const int elementId_lever5Axis = 6;
    [Token(Token = "0x4001076")]
    public const int elementId_lever5MinDetent = 68;
    [Token(Token = "0x4001077")]
    public const int elementId_leftGripButton1 = 7;
    [Token(Token = "0x4001078")]
    public const int elementId_leftGripButton2 = 8;
    [Token(Token = "0x4001079")]
    public const int elementId_leftGripButton3 = 9;
    [Token(Token = "0x400107A")]
    public const int elementId_leftGripButton4 = 10;
    [Token(Token = "0x400107B")]
    public const int elementId_leftGripButton5 = 11;
    [Token(Token = "0x400107C")]
    public const int elementId_leftGripButton6 = 12;
    [Token(Token = "0x400107D")]
    public const int elementId_rightGripButton1 = 13;
    [Token(Token = "0x400107E")]
    public const int elementId_rightGripButton2 = 14;
    [Token(Token = "0x400107F")]
    public const int elementId_rightGripButton3 = 15;
    [Token(Token = "0x4001080")]
    public const int elementId_rightGripButton4 = 16;
    [Token(Token = "0x4001081")]
    public const int elementId_rightGripButton5 = 17;
    [Token(Token = "0x4001082")]
    public const int elementId_rightGripButton6 = 18;
    [Token(Token = "0x4001083")]
    public const int elementId_centerButton1 = 19;
    [Token(Token = "0x4001084")]
    public const int elementId_centerButton2 = 20;
    [Token(Token = "0x4001085")]
    public const int elementId_centerButton3 = 21;
    [Token(Token = "0x4001086")]
    public const int elementId_centerButton4 = 22;
    [Token(Token = "0x4001087")]
    public const int elementId_centerButton5 = 23;
    [Token(Token = "0x4001088")]
    public const int elementId_centerButton6 = 24;
    [Token(Token = "0x4001089")]
    public const int elementId_centerButton7 = 25;
    [Token(Token = "0x400108A")]
    public const int elementId_centerButton8 = 26;
    [Token(Token = "0x400108B")]
    public const int elementId_wheel1Up = 53;
    [Token(Token = "0x400108C")]
    public const int elementId_wheel1Down = 54;
    [Token(Token = "0x400108D")]
    public const int elementId_wheel1Press = 55;
    [Token(Token = "0x400108E")]
    public const int elementId_wheel2Up = 56;
    [Token(Token = "0x400108F")]
    public const int elementId_wheel2Down = 57;
    [Token(Token = "0x4001090")]
    public const int elementId_wheel2Press = 58;
    [Token(Token = "0x4001091")]
    public const int elementId_leftGripHatUp = 27;
    [Token(Token = "0x4001092")]
    public const int elementId_leftGripHatUpRight = 28;
    [Token(Token = "0x4001093")]
    public const int elementId_leftGripHatRight = 29;
    [Token(Token = "0x4001094")]
    public const int elementId_leftGripHatDownRight = 30;
    [Token(Token = "0x4001095")]
    public const int elementId_leftGripHatDown = 31;
    [Token(Token = "0x4001096")]
    public const int elementId_leftGripHatDownLeft = 32;
    [Token(Token = "0x4001097")]
    public const int elementId_leftGripHatLeft = 33;
    [Token(Token = "0x4001098")]
    public const int elementId_leftGripHatUpLeft = 34;
    [Token(Token = "0x4001099")]
    public const int elementId_rightGripHatUp = 35;
    [Token(Token = "0x400109A")]
    public const int elementId_rightGripHatUpRight = 36;
    [Token(Token = "0x400109B")]
    public const int elementId_rightGripHatRight = 37;
    [Token(Token = "0x400109C")]
    public const int elementId_rightGripHatDownRight = 38;
    [Token(Token = "0x400109D")]
    public const int elementId_rightGripHatDown = 39;
    [Token(Token = "0x400109E")]
    public const int elementId_rightGripHatDownLeft = 40;
    [Token(Token = "0x400109F")]
    public const int elementId_rightGripHatLeft = 41;
    [Token(Token = "0x40010A0")]
    public const int elementId_rightGripHatUpLeft = 42;
    [Token(Token = "0x40010A1")]
    public const int elementId_consoleButton1 = 43;
    [Token(Token = "0x40010A2")]
    public const int elementId_consoleButton2 = 44;
    [Token(Token = "0x40010A3")]
    public const int elementId_consoleButton3 = 45;
    [Token(Token = "0x40010A4")]
    public const int elementId_consoleButton4 = 46;
    [Token(Token = "0x40010A5")]
    public const int elementId_consoleButton5 = 47;
    [Token(Token = "0x40010A6")]
    public const int elementId_consoleButton6 = 48;
    [Token(Token = "0x40010A7")]
    public const int elementId_consoleButton7 = 49;
    [Token(Token = "0x40010A8")]
    public const int elementId_consoleButton8 = 50;
    [Token(Token = "0x40010A9")]
    public const int elementId_consoleButton9 = 51;
    [Token(Token = "0x40010AA")]
    public const int elementId_consoleButton10 = 52;
    [Token(Token = "0x40010AB")]
    public const int elementId_mode1 = 61;
    [Token(Token = "0x40010AC")]
    public const int elementId_mode2 = 62;
    [Token(Token = "0x40010AD")]
    public const int elementId_mode3 = 63;
    [Token(Token = "0x40010AE")]
    public const int elementId_yoke = 69;
    [Token(Token = "0x40010AF")]
    public const int elementId_lever1 = 70;
    [Token(Token = "0x40010B0")]
    public const int elementId_lever2 = 71;
    [Token(Token = "0x40010B1")]
    public const int elementId_lever3 = 72;
    [Token(Token = "0x40010B2")]
    public const int elementId_lever4 = 73;
    [Token(Token = "0x40010B3")]
    public const int elementId_lever5 = 74;
    [Token(Token = "0x40010B4")]
    public const int elementId_leftGripHat = 75;
    [Token(Token = "0x40010B5")]
    public const int elementId_rightGripHat = 76;

    [Token(Token = "0x17000220")]
    IControllerTemplateButton IFlightYokeTemplate.leftPaddle
    {
      [Token(Token = "0x6000FE1"), Address(RVA = "0x5230B0", Offset = "0x521CB0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000221")]
    IControllerTemplateButton IFlightYokeTemplate.rightPaddle
    {
      [Token(Token = "0x6000FE2"), Address(RVA = "0x5234B0", Offset = "0x5220B0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000222")]
    IControllerTemplateButton IFlightYokeTemplate.leftGripButton1
    {
      [Token(Token = "0x6000FE3"), Address(RVA = "0x522EF0", Offset = "0x521AF0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000223")]
    IControllerTemplateButton IFlightYokeTemplate.leftGripButton2
    {
      [Token(Token = "0x6000FE4"), Address(RVA = "0x522F30", Offset = "0x521B30", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000224")]
    IControllerTemplateButton IFlightYokeTemplate.leftGripButton3
    {
      [Token(Token = "0x6000FE5"), Address(RVA = "0x522F70", Offset = "0x521B70", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000225")]
    IControllerTemplateButton IFlightYokeTemplate.leftGripButton4
    {
      [Token(Token = "0x6000FE6"), Address(RVA = "0x522FB0", Offset = "0x521BB0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000226")]
    IControllerTemplateButton IFlightYokeTemplate.leftGripButton5
    {
      [Token(Token = "0x6000FE7"), Address(RVA = "0x522FF0", Offset = "0x521BF0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000227")]
    IControllerTemplateButton IFlightYokeTemplate.leftGripButton6
    {
      [Token(Token = "0x6000FE8"), Address(RVA = "0x523030", Offset = "0x521C30", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000228")]
    IControllerTemplateButton IFlightYokeTemplate.rightGripButton1
    {
      [Token(Token = "0x6000FE9"), Address(RVA = "0x5232F0", Offset = "0x521EF0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000229")]
    IControllerTemplateButton IFlightYokeTemplate.rightGripButton2
    {
      [Token(Token = "0x6000FEA"), Address(RVA = "0x523330", Offset = "0x521F30", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700022A")]
    IControllerTemplateButton IFlightYokeTemplate.rightGripButton3
    {
      [Token(Token = "0x6000FEB"), Address(RVA = "0x523370", Offset = "0x521F70", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700022B")]
    IControllerTemplateButton IFlightYokeTemplate.rightGripButton4
    {
      [Token(Token = "0x6000FEC"), Address(RVA = "0x5233B0", Offset = "0x521FB0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700022C")]
    IControllerTemplateButton IFlightYokeTemplate.rightGripButton5
    {
      [Token(Token = "0x6000FED"), Address(RVA = "0x5233F0", Offset = "0x521FF0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700022D")]
    IControllerTemplateButton IFlightYokeTemplate.rightGripButton6
    {
      [Token(Token = "0x6000FEE"), Address(RVA = "0x523430", Offset = "0x522030", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700022E")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton1
    {
      [Token(Token = "0x6000FEF"), Address(RVA = "0x522A70", Offset = "0x521670", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700022F")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton2
    {
      [Token(Token = "0x6000FF0"), Address(RVA = "0x522AB0", Offset = "0x5216B0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000230")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton3
    {
      [Token(Token = "0x6000FF1"), Address(RVA = "0x522AF0", Offset = "0x5216F0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000231")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton4
    {
      [Token(Token = "0x6000FF2"), Address(RVA = "0x522B30", Offset = "0x521730", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000232")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton5
    {
      [Token(Token = "0x6000FF3"), Address(RVA = "0x522B70", Offset = "0x521770", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000233")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton6
    {
      [Token(Token = "0x6000FF4"), Address(RVA = "0x522BB0", Offset = "0x5217B0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000234")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton7
    {
      [Token(Token = "0x6000FF5"), Address(RVA = "0x522BF0", Offset = "0x5217F0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000235")]
    IControllerTemplateButton IFlightYokeTemplate.centerButton8
    {
      [Token(Token = "0x6000FF6"), Address(RVA = "0x522C30", Offset = "0x521830", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000236")]
    IControllerTemplateButton IFlightYokeTemplate.wheel1Up
    {
      [Token(Token = "0x6000FF7"), Address(RVA = "0x523570", Offset = "0x522170", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000237")]
    IControllerTemplateButton IFlightYokeTemplate.wheel1Down
    {
      [Token(Token = "0x6000FF8"), Address(RVA = "0x5234F0", Offset = "0x5220F0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000238")]
    IControllerTemplateButton IFlightYokeTemplate.wheel1Press
    {
      [Token(Token = "0x6000FF9"), Address(RVA = "0x523530", Offset = "0x522130", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000239")]
    IControllerTemplateButton IFlightYokeTemplate.wheel2Up
    {
      [Token(Token = "0x6000FFA"), Address(RVA = "0x523630", Offset = "0x522230", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700023A")]
    IControllerTemplateButton IFlightYokeTemplate.wheel2Down
    {
      [Token(Token = "0x6000FFB"), Address(RVA = "0x5235B0", Offset = "0x5221B0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700023B")]
    IControllerTemplateButton IFlightYokeTemplate.wheel2Press
    {
      [Token(Token = "0x6000FFC"), Address(RVA = "0x5235F0", Offset = "0x5221F0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700023C")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton1
    {
      [Token(Token = "0x6000FFD"), Address(RVA = "0x522CB0", Offset = "0x5218B0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700023D")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton2
    {
      [Token(Token = "0x6000FFE"), Address(RVA = "0x522CF0", Offset = "0x5218F0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700023E")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton3
    {
      [Token(Token = "0x6000FFF"), Address(RVA = "0x522D30", Offset = "0x521930", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700023F")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton4
    {
      [Token(Token = "0x6001000"), Address(RVA = "0x522D70", Offset = "0x521970", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000240")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton5
    {
      [Token(Token = "0x6001001"), Address(RVA = "0x522DB0", Offset = "0x5219B0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000241")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton6
    {
      [Token(Token = "0x6001002"), Address(RVA = "0x522DF0", Offset = "0x5219F0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000242")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton7
    {
      [Token(Token = "0x6001003"), Address(RVA = "0x522E30", Offset = "0x521A30", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000243")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton8
    {
      [Token(Token = "0x6001004"), Address(RVA = "0x522E70", Offset = "0x521A70", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000244")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton9
    {
      [Token(Token = "0x6001005"), Address(RVA = "0x522EB0", Offset = "0x521AB0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000245")]
    IControllerTemplateButton IFlightYokeTemplate.consoleButton10
    {
      [Token(Token = "0x6001006"), Address(RVA = "0x522C70", Offset = "0x521870", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000246")]
    IControllerTemplateButton IFlightYokeTemplate.mode1
    {
      [Token(Token = "0x6001007"), Address(RVA = "0x523230", Offset = "0x521E30", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000247")]
    IControllerTemplateButton IFlightYokeTemplate.mode2
    {
      [Token(Token = "0x6001008"), Address(RVA = "0x523270", Offset = "0x521E70", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000248")]
    IControllerTemplateButton IFlightYokeTemplate.mode3
    {
      [Token(Token = "0x6001009"), Address(RVA = "0x5232B0", Offset = "0x521EB0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000249")]
    IControllerTemplateYoke IFlightYokeTemplate.yoke
    {
      [Token(Token = "0x600100A"), Address(RVA = "0x523670", Offset = "0x522270", Length = "0x3E")] get => (IControllerTemplateYoke) null;
    }

    [Token(Token = "0x1700024A")]
    IControllerTemplateThrottle IFlightYokeTemplate.lever1
    {
      [Token(Token = "0x600100B"), Address(RVA = "0x5230F0", Offset = "0x521CF0", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700024B")]
    IControllerTemplateThrottle IFlightYokeTemplate.lever2
    {
      [Token(Token = "0x600100C"), Address(RVA = "0x523130", Offset = "0x521D30", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700024C")]
    IControllerTemplateThrottle IFlightYokeTemplate.lever3
    {
      [Token(Token = "0x600100D"), Address(RVA = "0x523170", Offset = "0x521D70", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700024D")]
    IControllerTemplateThrottle IFlightYokeTemplate.lever4
    {
      [Token(Token = "0x600100E"), Address(RVA = "0x5231B0", Offset = "0x521DB0", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700024E")]
    IControllerTemplateThrottle IFlightYokeTemplate.lever5
    {
      [Token(Token = "0x600100F"), Address(RVA = "0x5231F0", Offset = "0x521DF0", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700024F")]
    IControllerTemplateHat IFlightYokeTemplate.leftGripHat
    {
      [Token(Token = "0x6001010"), Address(RVA = "0x523070", Offset = "0x521C70", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x17000250")]
    IControllerTemplateHat IFlightYokeTemplate.rightGripHat
    {
      [Token(Token = "0x6001011"), Address(RVA = "0x523470", Offset = "0x522070", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x6001012")]
    [Address(RVA = "0x522A60", Offset = "0x521660", Length = "0x8")]
    public FlightYokeTemplate(object payload)
      : base((object) null)
    {
    }

    [Token(Token = "0x6001013")]
    [Address(RVA = "0x5236B0", Offset = "0x5222B0", Length = "0x63")]
    static FlightYokeTemplate()
    {
    }
  }
}
