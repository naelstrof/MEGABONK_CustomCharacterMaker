// Decompiled with JetBrains decompiler
// Type: Rewired.RacingWheelTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired
{
  [Token(Token = "0x200023F")]
  public sealed class RacingWheelTemplate : 
    ControllerTemplate,
    IRacingWheelTemplate,
    IControllerTemplate
  {
    [Token(Token = "0x4000F90")]
    public static readonly Guid typeGuid;
    [Token(Token = "0x4000F91")]
    public const int elementId_wheel = 0;
    [Token(Token = "0x4000F92")]
    public const int elementId_accelerator = 1;
    [Token(Token = "0x4000F93")]
    public const int elementId_brake = 2;
    [Token(Token = "0x4000F94")]
    public const int elementId_clutch = 3;
    [Token(Token = "0x4000F95")]
    public const int elementId_shiftDown = 4;
    [Token(Token = "0x4000F96")]
    public const int elementId_shiftUp = 5;
    [Token(Token = "0x4000F97")]
    public const int elementId_wheelButton1 = 6;
    [Token(Token = "0x4000F98")]
    public const int elementId_wheelButton2 = 7;
    [Token(Token = "0x4000F99")]
    public const int elementId_wheelButton3 = 8;
    [Token(Token = "0x4000F9A")]
    public const int elementId_wheelButton4 = 9;
    [Token(Token = "0x4000F9B")]
    public const int elementId_wheelButton5 = 10;
    [Token(Token = "0x4000F9C")]
    public const int elementId_wheelButton6 = 11;
    [Token(Token = "0x4000F9D")]
    public const int elementId_wheelButton7 = 12;
    [Token(Token = "0x4000F9E")]
    public const int elementId_wheelButton8 = 13;
    [Token(Token = "0x4000F9F")]
    public const int elementId_wheelButton9 = 14;
    [Token(Token = "0x4000FA0")]
    public const int elementId_wheelButton10 = 15;
    [Token(Token = "0x4000FA1")]
    public const int elementId_consoleButton1 = 16;
    [Token(Token = "0x4000FA2")]
    public const int elementId_consoleButton2 = 17;
    [Token(Token = "0x4000FA3")]
    public const int elementId_consoleButton3 = 18;
    [Token(Token = "0x4000FA4")]
    public const int elementId_consoleButton4 = 19;
    [Token(Token = "0x4000FA5")]
    public const int elementId_consoleButton5 = 20;
    [Token(Token = "0x4000FA6")]
    public const int elementId_consoleButton6 = 21;
    [Token(Token = "0x4000FA7")]
    public const int elementId_consoleButton7 = 22;
    [Token(Token = "0x4000FA8")]
    public const int elementId_consoleButton8 = 23;
    [Token(Token = "0x4000FA9")]
    public const int elementId_consoleButton9 = 24;
    [Token(Token = "0x4000FAA")]
    public const int elementId_consoleButton10 = 25;
    [Token(Token = "0x4000FAB")]
    public const int elementId_shifter1 = 26;
    [Token(Token = "0x4000FAC")]
    public const int elementId_shifter2 = 27;
    [Token(Token = "0x4000FAD")]
    public const int elementId_shifter3 = 28;
    [Token(Token = "0x4000FAE")]
    public const int elementId_shifter4 = 29;
    [Token(Token = "0x4000FAF")]
    public const int elementId_shifter5 = 30;
    [Token(Token = "0x4000FB0")]
    public const int elementId_shifter6 = 31;
    [Token(Token = "0x4000FB1")]
    public const int elementId_shifter7 = 32;
    [Token(Token = "0x4000FB2")]
    public const int elementId_shifter8 = 33;
    [Token(Token = "0x4000FB3")]
    public const int elementId_shifter9 = 34;
    [Token(Token = "0x4000FB4")]
    public const int elementId_shifter10 = 35;
    [Token(Token = "0x4000FB5")]
    public const int elementId_reverseGear = 44;
    [Token(Token = "0x4000FB6")]
    public const int elementId_select = 36;
    [Token(Token = "0x4000FB7")]
    public const int elementId_start = 37;
    [Token(Token = "0x4000FB8")]
    public const int elementId_systemButton = 38;
    [Token(Token = "0x4000FB9")]
    public const int elementId_horn = 43;
    [Token(Token = "0x4000FBA")]
    public const int elementId_dPadUp = 39;
    [Token(Token = "0x4000FBB")]
    public const int elementId_dPadRight = 40;
    [Token(Token = "0x4000FBC")]
    public const int elementId_dPadDown = 41;
    [Token(Token = "0x4000FBD")]
    public const int elementId_dPadLeft = 42;
    [Token(Token = "0x4000FBE")]
    public const int elementId_dPad = 45;

    [Token(Token = "0x1700019E")]
    IControllerTemplateAxis IRacingWheelTemplate.wheel
    {
      [Token(Token = "0x6000F5B"), Address(RVA = "0x52BCA0", Offset = "0x52A8A0", Length = "0x3B")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x1700019F")]
    IControllerTemplateAxis IRacingWheelTemplate.accelerator
    {
      [Token(Token = "0x6000F5C"), Address(RVA = "0x52B260", Offset = "0x529E60", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x170001A0")]
    IControllerTemplateAxis IRacingWheelTemplate.brake
    {
      [Token(Token = "0x6000F5D"), Address(RVA = "0x52B2A0", Offset = "0x529EA0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x170001A1")]
    IControllerTemplateAxis IRacingWheelTemplate.clutch
    {
      [Token(Token = "0x6000F5E"), Address(RVA = "0x52B2E0", Offset = "0x529EE0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x170001A2")]
    IControllerTemplateButton IRacingWheelTemplate.shiftDown
    {
      [Token(Token = "0x6000F5F"), Address(RVA = "0x52B6A0", Offset = "0x52A2A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A3")]
    IControllerTemplateButton IRacingWheelTemplate.shiftUp
    {
      [Token(Token = "0x6000F60"), Address(RVA = "0x52B6E0", Offset = "0x52A2E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A4")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton1
    {
      [Token(Token = "0x6000F61"), Address(RVA = "0x52BA60", Offset = "0x52A660", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A5")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton2
    {
      [Token(Token = "0x6000F62"), Address(RVA = "0x52BAA0", Offset = "0x52A6A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A6")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton3
    {
      [Token(Token = "0x6000F63"), Address(RVA = "0x52BAE0", Offset = "0x52A6E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A7")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton4
    {
      [Token(Token = "0x6000F64"), Address(RVA = "0x52BB20", Offset = "0x52A720", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A8")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton5
    {
      [Token(Token = "0x6000F65"), Address(RVA = "0x52BB60", Offset = "0x52A760", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001A9")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton6
    {
      [Token(Token = "0x6000F66"), Address(RVA = "0x52BBA0", Offset = "0x52A7A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001AA")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton7
    {
      [Token(Token = "0x6000F67"), Address(RVA = "0x52BBE0", Offset = "0x52A7E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001AB")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton8
    {
      [Token(Token = "0x6000F68"), Address(RVA = "0x52BC20", Offset = "0x52A820", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001AC")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton9
    {
      [Token(Token = "0x6000F69"), Address(RVA = "0x52BC60", Offset = "0x52A860", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001AD")]
    IControllerTemplateButton IRacingWheelTemplate.wheelButton10
    {
      [Token(Token = "0x6000F6A"), Address(RVA = "0x52BA20", Offset = "0x52A620", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001AE")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton1
    {
      [Token(Token = "0x6000F6B"), Address(RVA = "0x52B360", Offset = "0x529F60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001AF")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton2
    {
      [Token(Token = "0x6000F6C"), Address(RVA = "0x52B3A0", Offset = "0x529FA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B0")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton3
    {
      [Token(Token = "0x6000F6D"), Address(RVA = "0x52B3E0", Offset = "0x529FE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B1")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton4
    {
      [Token(Token = "0x6000F6E"), Address(RVA = "0x52B420", Offset = "0x52A020", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B2")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton5
    {
      [Token(Token = "0x6000F6F"), Address(RVA = "0x52B460", Offset = "0x52A060", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B3")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton6
    {
      [Token(Token = "0x6000F70"), Address(RVA = "0x52B4A0", Offset = "0x52A0A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B4")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton7
    {
      [Token(Token = "0x6000F71"), Address(RVA = "0x52B4E0", Offset = "0x52A0E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B5")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton8
    {
      [Token(Token = "0x6000F72"), Address(RVA = "0x52B520", Offset = "0x52A120", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B6")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton9
    {
      [Token(Token = "0x6000F73"), Address(RVA = "0x52B560", Offset = "0x52A160", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B7")]
    IControllerTemplateButton IRacingWheelTemplate.consoleButton10
    {
      [Token(Token = "0x6000F74"), Address(RVA = "0x52B320", Offset = "0x529F20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B8")]
    IControllerTemplateButton IRacingWheelTemplate.shifter1
    {
      [Token(Token = "0x6000F75"), Address(RVA = "0x52B760", Offset = "0x52A360", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001B9")]
    IControllerTemplateButton IRacingWheelTemplate.shifter2
    {
      [Token(Token = "0x6000F76"), Address(RVA = "0x52B7A0", Offset = "0x52A3A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001BA")]
    IControllerTemplateButton IRacingWheelTemplate.shifter3
    {
      [Token(Token = "0x6000F77"), Address(RVA = "0x52B7E0", Offset = "0x52A3E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001BB")]
    IControllerTemplateButton IRacingWheelTemplate.shifter4
    {
      [Token(Token = "0x6000F78"), Address(RVA = "0x52B820", Offset = "0x52A420", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001BC")]
    IControllerTemplateButton IRacingWheelTemplate.shifter5
    {
      [Token(Token = "0x6000F79"), Address(RVA = "0x52B860", Offset = "0x52A460", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001BD")]
    IControllerTemplateButton IRacingWheelTemplate.shifter6
    {
      [Token(Token = "0x6000F7A"), Address(RVA = "0x52B8A0", Offset = "0x52A4A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001BE")]
    IControllerTemplateButton IRacingWheelTemplate.shifter7
    {
      [Token(Token = "0x6000F7B"), Address(RVA = "0x52B8E0", Offset = "0x52A4E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001BF")]
    IControllerTemplateButton IRacingWheelTemplate.shifter8
    {
      [Token(Token = "0x6000F7C"), Address(RVA = "0x52B920", Offset = "0x52A520", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C0")]
    IControllerTemplateButton IRacingWheelTemplate.shifter9
    {
      [Token(Token = "0x6000F7D"), Address(RVA = "0x52B960", Offset = "0x52A560", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C1")]
    IControllerTemplateButton IRacingWheelTemplate.shifter10
    {
      [Token(Token = "0x6000F7E"), Address(RVA = "0x52B720", Offset = "0x52A320", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C2")]
    IControllerTemplateButton IRacingWheelTemplate.reverseGear
    {
      [Token(Token = "0x6000F7F"), Address(RVA = "0x52B620", Offset = "0x52A220", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C3")]
    IControllerTemplateButton IRacingWheelTemplate.select
    {
      [Token(Token = "0x6000F80"), Address(RVA = "0x52B660", Offset = "0x52A260", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C4")]
    IControllerTemplateButton IRacingWheelTemplate.start
    {
      [Token(Token = "0x6000F81"), Address(RVA = "0x52B9A0", Offset = "0x52A5A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C5")]
    IControllerTemplateButton IRacingWheelTemplate.systemButton
    {
      [Token(Token = "0x6000F82"), Address(RVA = "0x52B9E0", Offset = "0x52A5E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C6")]
    IControllerTemplateButton IRacingWheelTemplate.horn
    {
      [Token(Token = "0x6000F83"), Address(RVA = "0x52B5E0", Offset = "0x52A1E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x170001C7")]
    IControllerTemplateDPad IRacingWheelTemplate.dPad
    {
      [Token(Token = "0x6000F84"), Address(RVA = "0x52B5A0", Offset = "0x52A1A0", Length = "0x3E")] get => (IControllerTemplateDPad) null;
    }

    [Token(Token = "0x6000F85")]
    [Address(RVA = "0x522A60", Offset = "0x521660", Length = "0x8")]
    public RacingWheelTemplate(object payload)
      : base((object) null)
    {
    }

    [Token(Token = "0x6000F86")]
    [Address(RVA = "0x52BCE0", Offset = "0x52A8E0", Length = "0x63")]
    static RacingWheelTemplate()
    {
    }
  }
}
