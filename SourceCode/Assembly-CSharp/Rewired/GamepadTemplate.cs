// Decompiled with JetBrains decompiler
// Type: Rewired.GamepadTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired
{
  [Token(Token = "0x200023E")]
  public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
  {
    [Token(Token = "0x4000F68")]
    public static readonly Guid typeGuid;
    [Token(Token = "0x4000F69")]
    public const int elementId_leftStickX = 0;
    [Token(Token = "0x4000F6A")]
    public const int elementId_leftStickY = 1;
    [Token(Token = "0x4000F6B")]
    public const int elementId_rightStickX = 2;
    [Token(Token = "0x4000F6C")]
    public const int elementId_rightStickY = 3;
    [Token(Token = "0x4000F6D")]
    public const int elementId_actionBottomRow1 = 4;
    [Token(Token = "0x4000F6E")]
    public const int elementId_a = 4;
    [Token(Token = "0x4000F6F")]
    public const int elementId_actionBottomRow2 = 5;
    [Token(Token = "0x4000F70")]
    public const int elementId_b = 5;
    [Token(Token = "0x4000F71")]
    public const int elementId_actionBottomRow3 = 6;
    [Token(Token = "0x4000F72")]
    public const int elementId_c = 6;
    [Token(Token = "0x4000F73")]
    public const int elementId_actionTopRow1 = 7;
    [Token(Token = "0x4000F74")]
    public const int elementId_x = 7;
    [Token(Token = "0x4000F75")]
    public const int elementId_actionTopRow2 = 8;
    [Token(Token = "0x4000F76")]
    public const int elementId_y = 8;
    [Token(Token = "0x4000F77")]
    public const int elementId_actionTopRow3 = 9;
    [Token(Token = "0x4000F78")]
    public const int elementId_z = 9;
    [Token(Token = "0x4000F79")]
    public const int elementId_leftShoulder1 = 10;
    [Token(Token = "0x4000F7A")]
    public const int elementId_leftBumper = 10;
    [Token(Token = "0x4000F7B")]
    public const int elementId_leftShoulder2 = 11;
    [Token(Token = "0x4000F7C")]
    public const int elementId_leftTrigger = 11;
    [Token(Token = "0x4000F7D")]
    public const int elementId_rightShoulder1 = 12;
    [Token(Token = "0x4000F7E")]
    public const int elementId_rightBumper = 12;
    [Token(Token = "0x4000F7F")]
    public const int elementId_rightShoulder2 = 13;
    [Token(Token = "0x4000F80")]
    public const int elementId_rightTrigger = 13;
    [Token(Token = "0x4000F81")]
    public const int elementId_center1 = 14;
    [Token(Token = "0x4000F82")]
    public const int elementId_back = 14;
    [Token(Token = "0x4000F83")]
    public const int elementId_center2 = 15;
    [Token(Token = "0x4000F84")]
    public const int elementId_start = 15;
    [Token(Token = "0x4000F85")]
    public const int elementId_center3 = 16;
    [Token(Token = "0x4000F86")]
    public const int elementId_guide = 16;
    [Token(Token = "0x4000F87")]
    public const int elementId_leftStickButton = 17;
    [Token(Token = "0x4000F88")]
    public const int elementId_rightStickButton = 18;
    [Token(Token = "0x4000F89")]
    public const int elementId_dPadUp = 19;
    [Token(Token = "0x4000F8A")]
    public const int elementId_dPadRight = 20;
    [Token(Token = "0x4000F8B")]
    public const int elementId_dPadDown = 21;
    [Token(Token = "0x4000F8C")]
    public const int elementId_dPadLeft = 22;
    [Token(Token = "0x4000F8D")]
    public const int elementId_leftStick = 23;
    [Token(Token = "0x4000F8E")]
    public const int elementId_rightStick = 24;
    [Token(Token = "0x4000F8F")]
    public const int elementId_dPad = 25;

    [Token(Token = "0x17000181")]
    IControllerTemplateButton IGamepadTemplate.actionBottomRow1
    {
      [Token(Token = "0x6000F3C"), Address(RVA = "0x523760", Offset = "0x522360", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000182")]
    IControllerTemplateButton IGamepadTemplate.a
    {
      [Token(Token = "0x6000F3D"), Address(RVA = "0x523720", Offset = "0x522320", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000183")]
    IControllerTemplateButton IGamepadTemplate.actionBottomRow2
    {
      [Token(Token = "0x6000F3E"), Address(RVA = "0x5237A0", Offset = "0x5223A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000184")]
    IControllerTemplateButton IGamepadTemplate.b
    {
      [Token(Token = "0x6000F3F"), Address(RVA = "0x5238E0", Offset = "0x5224E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000185")]
    IControllerTemplateButton IGamepadTemplate.actionBottomRow3
    {
      [Token(Token = "0x6000F40"), Address(RVA = "0x5237E0", Offset = "0x5223E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000186")]
    IControllerTemplateButton IGamepadTemplate.c
    {
      [Token(Token = "0x6000F41"), Address(RVA = "0x523960", Offset = "0x522560", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000187")]
    IControllerTemplateButton IGamepadTemplate.actionTopRow1
    {
      [Token(Token = "0x6000F42"), Address(RVA = "0x523820", Offset = "0x522420", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000188")]
    IControllerTemplateButton IGamepadTemplate.x
    {
      [Token(Token = "0x6000F43"), Address(RVA = "0x523DA0", Offset = "0x5229A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000189")]
    IControllerTemplateButton IGamepadTemplate.actionTopRow2
    {
      [Token(Token = "0x6000F44"), Address(RVA = "0x523860", Offset = "0x522460", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700018A")]
    IControllerTemplateButton IGamepadTemplate.y
    {
      [Token(Token = "0x6000F45"), Address(RVA = "0x523DE0", Offset = "0x5229E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700018B")]
    IControllerTemplateButton IGamepadTemplate.actionTopRow3
    {
      [Token(Token = "0x6000F46"), Address(RVA = "0x5238A0", Offset = "0x5224A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700018C")]
    IControllerTemplateButton IGamepadTemplate.z
    {
      [Token(Token = "0x6000F47"), Address(RVA = "0x523E20", Offset = "0x522A20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700018D")]
    IControllerTemplateButton IGamepadTemplate.leftShoulder1
    {
      [Token(Token = "0x6000F48"), Address(RVA = "0x523B20", Offset = "0x522720", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700018E")]
    IControllerTemplateButton IGamepadTemplate.leftBumper
    {
      [Token(Token = "0x6000F49"), Address(RVA = "0x523AE0", Offset = "0x5226E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700018F")]
    IControllerTemplateAxis IGamepadTemplate.leftShoulder2
    {
      [Token(Token = "0x6000F4A"), Address(RVA = "0x523B60", Offset = "0x522760", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000190")]
    IControllerTemplateAxis IGamepadTemplate.leftTrigger
    {
      [Token(Token = "0x6000F4B"), Address(RVA = "0x523BE0", Offset = "0x5227E0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000191")]
    IControllerTemplateButton IGamepadTemplate.rightShoulder1
    {
      [Token(Token = "0x6000F4C"), Address(RVA = "0x523C60", Offset = "0x522860", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000192")]
    IControllerTemplateButton IGamepadTemplate.rightBumper
    {
      [Token(Token = "0x6000F4D"), Address(RVA = "0x523C20", Offset = "0x522820", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000193")]
    IControllerTemplateAxis IGamepadTemplate.rightShoulder2
    {
      [Token(Token = "0x6000F4E"), Address(RVA = "0x523CA0", Offset = "0x5228A0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000194")]
    IControllerTemplateAxis IGamepadTemplate.rightTrigger
    {
      [Token(Token = "0x6000F4F"), Address(RVA = "0x523D20", Offset = "0x522920", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000195")]
    IControllerTemplateButton IGamepadTemplate.center1
    {
      [Token(Token = "0x6000F50"), Address(RVA = "0x5239A0", Offset = "0x5225A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000196")]
    IControllerTemplateButton IGamepadTemplate.back
    {
      [Token(Token = "0x6000F51"), Address(RVA = "0x523920", Offset = "0x522520", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000197")]
    IControllerTemplateButton IGamepadTemplate.center2
    {
      [Token(Token = "0x6000F52"), Address(RVA = "0x5239E0", Offset = "0x5225E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000198")]
    IControllerTemplateButton IGamepadTemplate.start
    {
      [Token(Token = "0x6000F53"), Address(RVA = "0x523D60", Offset = "0x522960", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000199")]
    IControllerTemplateButton IGamepadTemplate.center3
    {
      [Token(Token = "0x6000F54"), Address(RVA = "0x523A20", Offset = "0x522620", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700019A")]
    IControllerTemplateButton IGamepadTemplate.guide
    {
      [Token(Token = "0x6000F55"), Address(RVA = "0x523AA0", Offset = "0x5226A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700019B")]
    IControllerTemplateThumbStick IGamepadTemplate.leftStick
    {
      [Token(Token = "0x6000F56"), Address(RVA = "0x523BA0", Offset = "0x5227A0", Length = "0x3E")] get => (IControllerTemplateThumbStick) null;
    }

    [Token(Token = "0x1700019C")]
    IControllerTemplateThumbStick IGamepadTemplate.rightStick
    {
      [Token(Token = "0x6000F57"), Address(RVA = "0x523CE0", Offset = "0x5228E0", Length = "0x3E")] get => (IControllerTemplateThumbStick) null;
    }

    [Token(Token = "0x1700019D")]
    IControllerTemplateDPad IGamepadTemplate.dPad
    {
      [Token(Token = "0x6000F58"), Address(RVA = "0x523A60", Offset = "0x522660", Length = "0x3E")] get => (IControllerTemplateDPad) null;
    }

    [Token(Token = "0x6000F59")]
    [Address(RVA = "0x522A60", Offset = "0x521660", Length = "0x8")]
    public GamepadTemplate(object payload)
      : base((object) null)
    {
    }

    [Token(Token = "0x6000F5A")]
    [Address(RVA = "0x523E60", Offset = "0x522A60", Length = "0x63")]
    static GamepadTemplate()
    {
    }
  }
}
