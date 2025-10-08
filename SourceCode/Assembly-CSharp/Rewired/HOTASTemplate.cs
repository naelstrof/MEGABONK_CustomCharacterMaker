// Decompiled with JetBrains decompiler
// Type: Rewired.HOTASTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired
{
  [Token(Token = "0x2000240")]
  public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
  {
    [Token(Token = "0x4000FBF")]
    public static readonly Guid typeGuid;
    [Token(Token = "0x4000FC0")]
    public const int elementId_stickX = 0;
    [Token(Token = "0x4000FC1")]
    public const int elementId_stickY = 1;
    [Token(Token = "0x4000FC2")]
    public const int elementId_stickRotate = 2;
    [Token(Token = "0x4000FC3")]
    public const int elementId_stickMiniStick1X = 78;
    [Token(Token = "0x4000FC4")]
    public const int elementId_stickMiniStick1Y = 79;
    [Token(Token = "0x4000FC5")]
    public const int elementId_stickMiniStick1Press = 80;
    [Token(Token = "0x4000FC6")]
    public const int elementId_stickMiniStick2X = 81;
    [Token(Token = "0x4000FC7")]
    public const int elementId_stickMiniStick2Y = 82;
    [Token(Token = "0x4000FC8")]
    public const int elementId_stickMiniStick2Press = 83;
    [Token(Token = "0x4000FC9")]
    public const int elementId_stickTrigger = 3;
    [Token(Token = "0x4000FCA")]
    public const int elementId_stickTriggerStage2 = 4;
    [Token(Token = "0x4000FCB")]
    public const int elementId_stickPinkyButton = 5;
    [Token(Token = "0x4000FCC")]
    public const int elementId_stickPinkyTrigger = 154;
    [Token(Token = "0x4000FCD")]
    public const int elementId_stickButton1 = 6;
    [Token(Token = "0x4000FCE")]
    public const int elementId_stickButton2 = 7;
    [Token(Token = "0x4000FCF")]
    public const int elementId_stickButton3 = 8;
    [Token(Token = "0x4000FD0")]
    public const int elementId_stickButton4 = 9;
    [Token(Token = "0x4000FD1")]
    public const int elementId_stickButton5 = 10;
    [Token(Token = "0x4000FD2")]
    public const int elementId_stickButton6 = 11;
    [Token(Token = "0x4000FD3")]
    public const int elementId_stickButton7 = 12;
    [Token(Token = "0x4000FD4")]
    public const int elementId_stickButton8 = 13;
    [Token(Token = "0x4000FD5")]
    public const int elementId_stickButton9 = 14;
    [Token(Token = "0x4000FD6")]
    public const int elementId_stickButton10 = 15;
    [Token(Token = "0x4000FD7")]
    public const int elementId_stickBaseButton1 = 18;
    [Token(Token = "0x4000FD8")]
    public const int elementId_stickBaseButton2 = 19;
    [Token(Token = "0x4000FD9")]
    public const int elementId_stickBaseButton3 = 20;
    [Token(Token = "0x4000FDA")]
    public const int elementId_stickBaseButton4 = 21;
    [Token(Token = "0x4000FDB")]
    public const int elementId_stickBaseButton5 = 22;
    [Token(Token = "0x4000FDC")]
    public const int elementId_stickBaseButton6 = 23;
    [Token(Token = "0x4000FDD")]
    public const int elementId_stickBaseButton7 = 24;
    [Token(Token = "0x4000FDE")]
    public const int elementId_stickBaseButton8 = 25;
    [Token(Token = "0x4000FDF")]
    public const int elementId_stickBaseButton9 = 26;
    [Token(Token = "0x4000FE0")]
    public const int elementId_stickBaseButton10 = 27;
    [Token(Token = "0x4000FE1")]
    public const int elementId_stickBaseButton11 = 161;
    [Token(Token = "0x4000FE2")]
    public const int elementId_stickBaseButton12 = 162;
    [Token(Token = "0x4000FE3")]
    public const int elementId_stickHat1Up = 28;
    [Token(Token = "0x4000FE4")]
    public const int elementId_stickHat1UpRight = 29;
    [Token(Token = "0x4000FE5")]
    public const int elementId_stickHat1Right = 30;
    [Token(Token = "0x4000FE6")]
    public const int elementId_stickHat1DownRight = 31;
    [Token(Token = "0x4000FE7")]
    public const int elementId_stickHat1Down = 32;
    [Token(Token = "0x4000FE8")]
    public const int elementId_stickHat1DownLeft = 33;
    [Token(Token = "0x4000FE9")]
    public const int elementId_stickHat1Left = 34;
    [Token(Token = "0x4000FEA")]
    public const int elementId_stickHat1Up_Left = 35;
    [Token(Token = "0x4000FEB")]
    public const int elementId_stickHat2Up = 36;
    [Token(Token = "0x4000FEC")]
    public const int elementId_stickHat2Up_right = 37;
    [Token(Token = "0x4000FED")]
    public const int elementId_stickHat2Right = 38;
    [Token(Token = "0x4000FEE")]
    public const int elementId_stickHat2Down_Right = 39;
    [Token(Token = "0x4000FEF")]
    public const int elementId_stickHat2Down = 40;
    [Token(Token = "0x4000FF0")]
    public const int elementId_stickHat2Down_Left = 41;
    [Token(Token = "0x4000FF1")]
    public const int elementId_stickHat2Left = 42;
    [Token(Token = "0x4000FF2")]
    public const int elementId_stickHat2Up_Left = 43;
    [Token(Token = "0x4000FF3")]
    public const int elementId_stickHat3Up = 84;
    [Token(Token = "0x4000FF4")]
    public const int elementId_stickHat3Up_Right = 85;
    [Token(Token = "0x4000FF5")]
    public const int elementId_stickHat3Right = 86;
    [Token(Token = "0x4000FF6")]
    public const int elementId_stickHat3Down_Right = 87;
    [Token(Token = "0x4000FF7")]
    public const int elementId_stickHat3Down = 88;
    [Token(Token = "0x4000FF8")]
    public const int elementId_stickHat3Down_Left = 89;
    [Token(Token = "0x4000FF9")]
    public const int elementId_stickHat3Left = 90;
    [Token(Token = "0x4000FFA")]
    public const int elementId_stickHat3Up_Left = 91;
    [Token(Token = "0x4000FFB")]
    public const int elementId_stickHat4Up = 92;
    [Token(Token = "0x4000FFC")]
    public const int elementId_stickHat4Up_Right = 93;
    [Token(Token = "0x4000FFD")]
    public const int elementId_stickHat4Right = 94;
    [Token(Token = "0x4000FFE")]
    public const int elementId_stickHat4Down_Right = 95;
    [Token(Token = "0x4000FFF")]
    public const int elementId_stickHat4Down = 96;
    [Token(Token = "0x4001000")]
    public const int elementId_stickHat4Down_Left = 97;
    [Token(Token = "0x4001001")]
    public const int elementId_stickHat4Left = 98;
    [Token(Token = "0x4001002")]
    public const int elementId_stickHat4Up_Left = 99;
    [Token(Token = "0x4001003")]
    public const int elementId_mode1 = 44;
    [Token(Token = "0x4001004")]
    public const int elementId_mode2 = 45;
    [Token(Token = "0x4001005")]
    public const int elementId_mode3 = 46;
    [Token(Token = "0x4001006")]
    public const int elementId_throttle1Axis = 49;
    [Token(Token = "0x4001007")]
    public const int elementId_throttle2Axis = 155;
    [Token(Token = "0x4001008")]
    public const int elementId_throttle1MinDetent = 166;
    [Token(Token = "0x4001009")]
    public const int elementId_throttle2MinDetent = 167;
    [Token(Token = "0x400100A")]
    public const int elementId_throttleButton1 = 50;
    [Token(Token = "0x400100B")]
    public const int elementId_throttleButton2 = 51;
    [Token(Token = "0x400100C")]
    public const int elementId_throttleButton3 = 52;
    [Token(Token = "0x400100D")]
    public const int elementId_throttleButton4 = 53;
    [Token(Token = "0x400100E")]
    public const int elementId_throttleButton5 = 54;
    [Token(Token = "0x400100F")]
    public const int elementId_throttleButton6 = 55;
    [Token(Token = "0x4001010")]
    public const int elementId_throttleButton7 = 56;
    [Token(Token = "0x4001011")]
    public const int elementId_throttleButton8 = 57;
    [Token(Token = "0x4001012")]
    public const int elementId_throttleButton9 = 58;
    [Token(Token = "0x4001013")]
    public const int elementId_throttleButton10 = 59;
    [Token(Token = "0x4001014")]
    public const int elementId_throttleBaseButton1 = 60;
    [Token(Token = "0x4001015")]
    public const int elementId_throttleBaseButton2 = 61;
    [Token(Token = "0x4001016")]
    public const int elementId_throttleBaseButton3 = 62;
    [Token(Token = "0x4001017")]
    public const int elementId_throttleBaseButton4 = 63;
    [Token(Token = "0x4001018")]
    public const int elementId_throttleBaseButton5 = 64;
    [Token(Token = "0x4001019")]
    public const int elementId_throttleBaseButton6 = 65;
    [Token(Token = "0x400101A")]
    public const int elementId_throttleBaseButton7 = 66;
    [Token(Token = "0x400101B")]
    public const int elementId_throttleBaseButton8 = 67;
    [Token(Token = "0x400101C")]
    public const int elementId_throttleBaseButton9 = 68;
    [Token(Token = "0x400101D")]
    public const int elementId_throttleBaseButton10 = 69;
    [Token(Token = "0x400101E")]
    public const int elementId_throttleBaseButton11 = 132;
    [Token(Token = "0x400101F")]
    public const int elementId_throttleBaseButton12 = 133;
    [Token(Token = "0x4001020")]
    public const int elementId_throttleBaseButton13 = 134;
    [Token(Token = "0x4001021")]
    public const int elementId_throttleBaseButton14 = 135;
    [Token(Token = "0x4001022")]
    public const int elementId_throttleBaseButton15 = 136;
    [Token(Token = "0x4001023")]
    public const int elementId_throttleSlider1 = 70;
    [Token(Token = "0x4001024")]
    public const int elementId_throttleSlider2 = 71;
    [Token(Token = "0x4001025")]
    public const int elementId_throttleSlider3 = 72;
    [Token(Token = "0x4001026")]
    public const int elementId_throttleSlider4 = 73;
    [Token(Token = "0x4001027")]
    public const int elementId_throttleDial1 = 74;
    [Token(Token = "0x4001028")]
    public const int elementId_throttleDial2 = 142;
    [Token(Token = "0x4001029")]
    public const int elementId_throttleDial3 = 143;
    [Token(Token = "0x400102A")]
    public const int elementId_throttleDial4 = 144;
    [Token(Token = "0x400102B")]
    public const int elementId_throttleMiniStickX = 75;
    [Token(Token = "0x400102C")]
    public const int elementId_throttleMiniStickY = 76;
    [Token(Token = "0x400102D")]
    public const int elementId_throttleMiniStickPress = 77;
    [Token(Token = "0x400102E")]
    public const int elementId_throttleWheel1Forward = 145;
    [Token(Token = "0x400102F")]
    public const int elementId_throttleWheel1Back = 146;
    [Token(Token = "0x4001030")]
    public const int elementId_throttleWheel1Press = 147;
    [Token(Token = "0x4001031")]
    public const int elementId_throttleWheel2Forward = 148;
    [Token(Token = "0x4001032")]
    public const int elementId_throttleWheel2Back = 149;
    [Token(Token = "0x4001033")]
    public const int elementId_throttleWheel2Press = 150;
    [Token(Token = "0x4001034")]
    public const int elementId_throttleWheel3Forward = 151;
    [Token(Token = "0x4001035")]
    public const int elementId_throttleWheel3Back = 152;
    [Token(Token = "0x4001036")]
    public const int elementId_throttleWheel3Press = 153;
    [Token(Token = "0x4001037")]
    public const int elementId_throttleHat1Up = 100;
    [Token(Token = "0x4001038")]
    public const int elementId_throttleHat1Up_Right = 101;
    [Token(Token = "0x4001039")]
    public const int elementId_throttleHat1Right = 102;
    [Token(Token = "0x400103A")]
    public const int elementId_throttleHat1Down_Right = 103;
    [Token(Token = "0x400103B")]
    public const int elementId_throttleHat1Down = 104;
    [Token(Token = "0x400103C")]
    public const int elementId_throttleHat1Down_Left = 105;
    [Token(Token = "0x400103D")]
    public const int elementId_throttleHat1Left = 106;
    [Token(Token = "0x400103E")]
    public const int elementId_throttleHat1Up_Left = 107;
    [Token(Token = "0x400103F")]
    public const int elementId_throttleHat2Up = 108;
    [Token(Token = "0x4001040")]
    public const int elementId_throttleHat2Up_Right = 109;
    [Token(Token = "0x4001041")]
    public const int elementId_throttleHat2Right = 110;
    [Token(Token = "0x4001042")]
    public const int elementId_throttleHat2Down_Right = 111;
    [Token(Token = "0x4001043")]
    public const int elementId_throttleHat2Down = 112;
    [Token(Token = "0x4001044")]
    public const int elementId_throttleHat2Down_Left = 113;
    [Token(Token = "0x4001045")]
    public const int elementId_throttleHat2Left = 114;
    [Token(Token = "0x4001046")]
    public const int elementId_throttleHat2Up_Left = 115;
    [Token(Token = "0x4001047")]
    public const int elementId_throttleHat3Up = 116;
    [Token(Token = "0x4001048")]
    public const int elementId_throttleHat3Up_Right = 117;
    [Token(Token = "0x4001049")]
    public const int elementId_throttleHat3Right = 118;
    [Token(Token = "0x400104A")]
    public const int elementId_throttleHat3Down_Right = 119;
    [Token(Token = "0x400104B")]
    public const int elementId_throttleHat3Down = 120;
    [Token(Token = "0x400104C")]
    public const int elementId_throttleHat3Down_Left = 121;
    [Token(Token = "0x400104D")]
    public const int elementId_throttleHat3Left = 122;
    [Token(Token = "0x400104E")]
    public const int elementId_throttleHat3Up_Left = 123;
    [Token(Token = "0x400104F")]
    public const int elementId_throttleHat4Up = 124;
    [Token(Token = "0x4001050")]
    public const int elementId_throttleHat4Up_Right = 125;
    [Token(Token = "0x4001051")]
    public const int elementId_throttleHat4Right = 126;
    [Token(Token = "0x4001052")]
    public const int elementId_throttleHat4Down_Right = 127;
    [Token(Token = "0x4001053")]
    public const int elementId_throttleHat4Down = 128;
    [Token(Token = "0x4001054")]
    public const int elementId_throttleHat4Down_Left = 129;
    [Token(Token = "0x4001055")]
    public const int elementId_throttleHat4Left = 130;
    [Token(Token = "0x4001056")]
    public const int elementId_throttleHat4Up_Left = 131;
    [Token(Token = "0x4001057")]
    public const int elementId_leftPedal = 168;
    [Token(Token = "0x4001058")]
    public const int elementId_rightPedal = 169;
    [Token(Token = "0x4001059")]
    public const int elementId_slidePedals = 170;
    [Token(Token = "0x400105A")]
    public const int elementId_stick = 171;
    [Token(Token = "0x400105B")]
    public const int elementId_stickMiniStick1 = 172;
    [Token(Token = "0x400105C")]
    public const int elementId_stickMiniStick2 = 173;
    [Token(Token = "0x400105D")]
    public const int elementId_stickHat1 = 174;
    [Token(Token = "0x400105E")]
    public const int elementId_stickHat2 = 175;
    [Token(Token = "0x400105F")]
    public const int elementId_stickHat3 = 176;
    [Token(Token = "0x4001060")]
    public const int elementId_stickHat4 = 177;
    [Token(Token = "0x4001061")]
    public const int elementId_throttle1 = 178;
    [Token(Token = "0x4001062")]
    public const int elementId_throttle2 = 179;
    [Token(Token = "0x4001063")]
    public const int elementId_throttleMiniStick = 180;
    [Token(Token = "0x4001064")]
    public const int elementId_throttleHat1 = 181;
    [Token(Token = "0x4001065")]
    public const int elementId_throttleHat2 = 182;
    [Token(Token = "0x4001066")]
    public const int elementId_throttleHat3 = 183;
    [Token(Token = "0x4001067")]
    public const int elementId_throttleHat4 = 184;

    [Token(Token = "0x170001C8")]
    IControllerTemplateButton IHOTASTemplate.stickTrigger
    {
      [Token(Token = "0x6000F87"), Address(RVA = "0x524BE0", Offset = "0x5237E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C9")]
    IControllerTemplateButton IHOTASTemplate.stickTriggerStage2
    {
      [Token(Token = "0x6000F88"), Address(RVA = "0x524BA0", Offset = "0x5237A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001CA")]
    IControllerTemplateButton IHOTASTemplate.stickPinkyButton
    {
      [Token(Token = "0x6000F89"), Address(RVA = "0x524B20", Offset = "0x523720", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001CB")]
    IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger
    {
      [Token(Token = "0x6000F8A"), Address(RVA = "0x524B60", Offset = "0x523760", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001CC")]
    IControllerTemplateButton IHOTASTemplate.stickButton1
    {
      [Token(Token = "0x6000F8B"), Address(RVA = "0x524760", Offset = "0x523360", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001CD")]
    IControllerTemplateButton IHOTASTemplate.stickButton2
    {
      [Token(Token = "0x6000F8C"), Address(RVA = "0x5247A0", Offset = "0x5233A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001CE")]
    IControllerTemplateButton IHOTASTemplate.stickButton3
    {
      [Token(Token = "0x6000F8D"), Address(RVA = "0x5247E0", Offset = "0x5233E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001CF")]
    IControllerTemplateButton IHOTASTemplate.stickButton4
    {
      [Token(Token = "0x6000F8E"), Address(RVA = "0x524820", Offset = "0x523420", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D0")]
    IControllerTemplateButton IHOTASTemplate.stickButton5
    {
      [Token(Token = "0x6000F8F"), Address(RVA = "0x524860", Offset = "0x523460", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D1")]
    IControllerTemplateButton IHOTASTemplate.stickButton6
    {
      [Token(Token = "0x6000F90"), Address(RVA = "0x5248A0", Offset = "0x5234A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D2")]
    IControllerTemplateButton IHOTASTemplate.stickButton7
    {
      [Token(Token = "0x6000F91"), Address(RVA = "0x5248E0", Offset = "0x5234E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D3")]
    IControllerTemplateButton IHOTASTemplate.stickButton8
    {
      [Token(Token = "0x6000F92"), Address(RVA = "0x524920", Offset = "0x523520", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D4")]
    IControllerTemplateButton IHOTASTemplate.stickButton9
    {
      [Token(Token = "0x6000F93"), Address(RVA = "0x524960", Offset = "0x523560", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D5")]
    IControllerTemplateButton IHOTASTemplate.stickButton10
    {
      [Token(Token = "0x6000F94"), Address(RVA = "0x524720", Offset = "0x523320", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D6")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton1
    {
      [Token(Token = "0x6000F95"), Address(RVA = "0x5244E0", Offset = "0x5230E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D7")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton2
    {
      [Token(Token = "0x6000F96"), Address(RVA = "0x524520", Offset = "0x523120", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D8")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton3
    {
      [Token(Token = "0x6000F97"), Address(RVA = "0x524560", Offset = "0x523160", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001D9")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton4
    {
      [Token(Token = "0x6000F98"), Address(RVA = "0x5245A0", Offset = "0x5231A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001DA")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton5
    {
      [Token(Token = "0x6000F99"), Address(RVA = "0x5245E0", Offset = "0x5231E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001DB")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton6
    {
      [Token(Token = "0x6000F9A"), Address(RVA = "0x524620", Offset = "0x523220", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001DC")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton7
    {
      [Token(Token = "0x6000F9B"), Address(RVA = "0x524660", Offset = "0x523260", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001DD")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton8
    {
      [Token(Token = "0x6000F9C"), Address(RVA = "0x5246A0", Offset = "0x5232A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001DE")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton9
    {
      [Token(Token = "0x6000F9D"), Address(RVA = "0x5246E0", Offset = "0x5232E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001DF")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton10
    {
      [Token(Token = "0x6000F9E"), Address(RVA = "0x524420", Offset = "0x523020", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E0")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton11
    {
      [Token(Token = "0x6000F9F"), Address(RVA = "0x524460", Offset = "0x523060", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E1")]
    IControllerTemplateButton IHOTASTemplate.stickBaseButton12
    {
      [Token(Token = "0x6000FA0"), Address(RVA = "0x5244A0", Offset = "0x5230A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E2")]
    IControllerTemplateButton IHOTASTemplate.mode1
    {
      [Token(Token = "0x6000FA1"), Address(RVA = "0x5242E0", Offset = "0x522EE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E3")]
    IControllerTemplateButton IHOTASTemplate.mode2
    {
      [Token(Token = "0x6000FA2"), Address(RVA = "0x524320", Offset = "0x522F20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E4")]
    IControllerTemplateButton IHOTASTemplate.mode3
    {
      [Token(Token = "0x6000FA3"), Address(RVA = "0x524360", Offset = "0x522F60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E5")]
    IControllerTemplateButton IHOTASTemplate.throttleButton1
    {
      [Token(Token = "0x6000FA4"), Address(RVA = "0x5250E0", Offset = "0x523CE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E6")]
    IControllerTemplateButton IHOTASTemplate.throttleButton2
    {
      [Token(Token = "0x6000FA5"), Address(RVA = "0x525120", Offset = "0x523D20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E7")]
    IControllerTemplateButton IHOTASTemplate.throttleButton3
    {
      [Token(Token = "0x6000FA6"), Address(RVA = "0x525160", Offset = "0x523D60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E8")]
    IControllerTemplateButton IHOTASTemplate.throttleButton4
    {
      [Token(Token = "0x6000FA7"), Address(RVA = "0x5251A0", Offset = "0x523DA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001E9")]
    IControllerTemplateButton IHOTASTemplate.throttleButton5
    {
      [Token(Token = "0x6000FA8"), Address(RVA = "0x5251E0", Offset = "0x523DE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001EA")]
    IControllerTemplateButton IHOTASTemplate.throttleButton6
    {
      [Token(Token = "0x6000FA9"), Address(RVA = "0x525220", Offset = "0x523E20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001EB")]
    IControllerTemplateButton IHOTASTemplate.throttleButton7
    {
      [Token(Token = "0x6000FAA"), Address(RVA = "0x525260", Offset = "0x523E60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001EC")]
    IControllerTemplateButton IHOTASTemplate.throttleButton8
    {
      [Token(Token = "0x6000FAB"), Address(RVA = "0x5252A0", Offset = "0x523EA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001ED")]
    IControllerTemplateButton IHOTASTemplate.throttleButton9
    {
      [Token(Token = "0x6000FAC"), Address(RVA = "0x5252E0", Offset = "0x523EE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001EE")]
    IControllerTemplateButton IHOTASTemplate.throttleButton10
    {
      [Token(Token = "0x6000FAD"), Address(RVA = "0x5250A0", Offset = "0x523CA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001EF")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton1
    {
      [Token(Token = "0x6000FAE"), Address(RVA = "0x524E60", Offset = "0x523A60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F0")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton2
    {
      [Token(Token = "0x6000FAF"), Address(RVA = "0x524EA0", Offset = "0x523AA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F1")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton3
    {
      [Token(Token = "0x6000FB0"), Address(RVA = "0x524EE0", Offset = "0x523AE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F2")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton4
    {
      [Token(Token = "0x6000FB1"), Address(RVA = "0x524F20", Offset = "0x523B20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F3")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton5
    {
      [Token(Token = "0x6000FB2"), Address(RVA = "0x524F60", Offset = "0x523B60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F4")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton6
    {
      [Token(Token = "0x6000FB3"), Address(RVA = "0x524FA0", Offset = "0x523BA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F5")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton7
    {
      [Token(Token = "0x6000FB4"), Address(RVA = "0x524FE0", Offset = "0x523BE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F6")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton8
    {
      [Token(Token = "0x6000FB5"), Address(RVA = "0x525020", Offset = "0x523C20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F7")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton9
    {
      [Token(Token = "0x6000FB6"), Address(RVA = "0x525060", Offset = "0x523C60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F8")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton10
    {
      [Token(Token = "0x6000FB7"), Address(RVA = "0x524CE0", Offset = "0x5238E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001F9")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton11
    {
      [Token(Token = "0x6000FB8"), Address(RVA = "0x524D20", Offset = "0x523920", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001FA")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton12
    {
      [Token(Token = "0x6000FB9"), Address(RVA = "0x524D60", Offset = "0x523960", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001FB")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton13
    {
      [Token(Token = "0x6000FBA"), Address(RVA = "0x524DA0", Offset = "0x5239A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001FC")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton14
    {
      [Token(Token = "0x6000FBB"), Address(RVA = "0x524DE0", Offset = "0x5239E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001FD")]
    IControllerTemplateButton IHOTASTemplate.throttleBaseButton15
    {
      [Token(Token = "0x6000FBC"), Address(RVA = "0x524E20", Offset = "0x523A20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001FE")]
    IControllerTemplateAxis IHOTASTemplate.throttleSlider1
    {
      [Token(Token = "0x6000FBD"), Address(RVA = "0x525560", Offset = "0x524160", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x170001FF")]
    IControllerTemplateAxis IHOTASTemplate.throttleSlider2
    {
      [Token(Token = "0x6000FBE"), Address(RVA = "0x5255A0", Offset = "0x5241A0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000200")]
    IControllerTemplateAxis IHOTASTemplate.throttleSlider3
    {
      [Token(Token = "0x6000FBF"), Address(RVA = "0x5255E0", Offset = "0x5241E0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000201")]
    IControllerTemplateAxis IHOTASTemplate.throttleSlider4
    {
      [Token(Token = "0x6000FC0"), Address(RVA = "0x525620", Offset = "0x524220", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000202")]
    IControllerTemplateAxis IHOTASTemplate.throttleDial1
    {
      [Token(Token = "0x6000FC1"), Address(RVA = "0x525320", Offset = "0x523F20", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000203")]
    IControllerTemplateAxis IHOTASTemplate.throttleDial2
    {
      [Token(Token = "0x6000FC2"), Address(RVA = "0x525360", Offset = "0x523F60", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000204")]
    IControllerTemplateAxis IHOTASTemplate.throttleDial3
    {
      [Token(Token = "0x6000FC3"), Address(RVA = "0x5253A0", Offset = "0x523FA0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000205")]
    IControllerTemplateAxis IHOTASTemplate.throttleDial4
    {
      [Token(Token = "0x6000FC4"), Address(RVA = "0x5253E0", Offset = "0x523FE0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000206")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward
    {
      [Token(Token = "0x6000FC5"), Address(RVA = "0x5256A0", Offset = "0x5242A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000207")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel1Back
    {
      [Token(Token = "0x6000FC6"), Address(RVA = "0x525660", Offset = "0x524260", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000208")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel1Press
    {
      [Token(Token = "0x6000FC7"), Address(RVA = "0x5256E0", Offset = "0x5242E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000209")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward
    {
      [Token(Token = "0x6000FC8"), Address(RVA = "0x525760", Offset = "0x524360", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700020A")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel2Back
    {
      [Token(Token = "0x6000FC9"), Address(RVA = "0x525720", Offset = "0x524320", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700020B")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel2Press
    {
      [Token(Token = "0x6000FCA"), Address(RVA = "0x5257A0", Offset = "0x5243A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700020C")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward
    {
      [Token(Token = "0x6000FCB"), Address(RVA = "0x525820", Offset = "0x524420", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700020D")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel3Back
    {
      [Token(Token = "0x6000FCC"), Address(RVA = "0x5257E0", Offset = "0x5243E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700020E")]
    IControllerTemplateButton IHOTASTemplate.throttleWheel3Press
    {
      [Token(Token = "0x6000FCD"), Address(RVA = "0x525860", Offset = "0x524460", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700020F")]
    IControllerTemplateAxis IHOTASTemplate.leftPedal
    {
      [Token(Token = "0x6000FCE"), Address(RVA = "0x5242A0", Offset = "0x522EA0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000210")]
    IControllerTemplateAxis IHOTASTemplate.rightPedal
    {
      [Token(Token = "0x6000FCF"), Address(RVA = "0x5243A0", Offset = "0x522FA0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000211")]
    IControllerTemplateAxis IHOTASTemplate.slidePedals
    {
      [Token(Token = "0x6000FD0"), Address(RVA = "0x5243E0", Offset = "0x522FE0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000212")]
    IControllerTemplateStick IHOTASTemplate.stick
    {
      [Token(Token = "0x6000FD1"), Address(RVA = "0x524C20", Offset = "0x523820", Length = "0x3E")] get => (IControllerTemplateStick) null;
    }

    [Token(Token = "0x17000213")]
    IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1
    {
      [Token(Token = "0x6000FD2"), Address(RVA = "0x524AA0", Offset = "0x5236A0", Length = "0x3E")] get => (IControllerTemplateThumbStick) null;
    }

    [Token(Token = "0x17000214")]
    IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2
    {
      [Token(Token = "0x6000FD3"), Address(RVA = "0x524AE0", Offset = "0x5236E0", Length = "0x3E")] get => (IControllerTemplateThumbStick) null;
    }

    [Token(Token = "0x17000215")]
    IControllerTemplateHat IHOTASTemplate.stickHat1
    {
      [Token(Token = "0x6000FD4"), Address(RVA = "0x5249A0", Offset = "0x5235A0", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x17000216")]
    IControllerTemplateHat IHOTASTemplate.stickHat2
    {
      [Token(Token = "0x6000FD5"), Address(RVA = "0x5249E0", Offset = "0x5235E0", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x17000217")]
    IControllerTemplateHat IHOTASTemplate.stickHat3
    {
      [Token(Token = "0x6000FD6"), Address(RVA = "0x524A20", Offset = "0x523620", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x17000218")]
    IControllerTemplateHat IHOTASTemplate.stickHat4
    {
      [Token(Token = "0x6000FD7"), Address(RVA = "0x524A60", Offset = "0x523660", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x17000219")]
    IControllerTemplateThrottle IHOTASTemplate.throttle1
    {
      [Token(Token = "0x6000FD8"), Address(RVA = "0x524C60", Offset = "0x523860", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700021A")]
    IControllerTemplateThrottle IHOTASTemplate.throttle2
    {
      [Token(Token = "0x6000FD9"), Address(RVA = "0x524CA0", Offset = "0x5238A0", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700021B")]
    IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick
    {
      [Token(Token = "0x6000FDA"), Address(RVA = "0x525520", Offset = "0x524120", Length = "0x3E")] get => (IControllerTemplateThumbStick) null;
    }

    [Token(Token = "0x1700021C")]
    IControllerTemplateHat IHOTASTemplate.throttleHat1
    {
      [Token(Token = "0x6000FDB"), Address(RVA = "0x525420", Offset = "0x524020", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x1700021D")]
    IControllerTemplateHat IHOTASTemplate.throttleHat2
    {
      [Token(Token = "0x6000FDC"), Address(RVA = "0x525460", Offset = "0x524060", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x1700021E")]
    IControllerTemplateHat IHOTASTemplate.throttleHat3
    {
      [Token(Token = "0x6000FDD"), Address(RVA = "0x5254A0", Offset = "0x5240A0", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x1700021F")]
    IControllerTemplateHat IHOTASTemplate.throttleHat4
    {
      [Token(Token = "0x6000FDE"), Address(RVA = "0x5254E0", Offset = "0x5240E0", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x6000FDF")]
    [Address(RVA = "0x522A60", Offset = "0x521660", Length = "0x8")]
    public HOTASTemplate(object payload)
      : base((object) null)
    {
    }

    [Token(Token = "0x6000FE0")]
    [Address(RVA = "0x5258A0", Offset = "0x5244A0", Length = "0x63")]
    static HOTASTemplate()
    {
    }
  }
}
