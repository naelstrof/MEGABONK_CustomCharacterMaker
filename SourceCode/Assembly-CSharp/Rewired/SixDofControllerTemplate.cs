// Decompiled with JetBrains decompiler
// Type: Rewired.SixDofControllerTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired
{
  [Token(Token = "0x2000243")]
  public sealed class SixDofControllerTemplate : 
    ControllerTemplate,
    ISixDofControllerTemplate,
    IControllerTemplate
  {
    [Token(Token = "0x40010BA")]
    public static readonly Guid typeGuid;
    [Token(Token = "0x40010BB")]
    public const int elementId_positionX = 1;
    [Token(Token = "0x40010BC")]
    public const int elementId_positionY = 2;
    [Token(Token = "0x40010BD")]
    public const int elementId_positionZ = 0;
    [Token(Token = "0x40010BE")]
    public const int elementId_rotationX = 3;
    [Token(Token = "0x40010BF")]
    public const int elementId_rotationY = 5;
    [Token(Token = "0x40010C0")]
    public const int elementId_rotationZ = 4;
    [Token(Token = "0x40010C1")]
    public const int elementId_throttle1Axis = 6;
    [Token(Token = "0x40010C2")]
    public const int elementId_throttle1MinDetent = 50;
    [Token(Token = "0x40010C3")]
    public const int elementId_throttle2Axis = 7;
    [Token(Token = "0x40010C4")]
    public const int elementId_throttle2MinDetent = 51;
    [Token(Token = "0x40010C5")]
    public const int elementId_extraAxis1 = 8;
    [Token(Token = "0x40010C6")]
    public const int elementId_extraAxis2 = 9;
    [Token(Token = "0x40010C7")]
    public const int elementId_extraAxis3 = 10;
    [Token(Token = "0x40010C8")]
    public const int elementId_extraAxis4 = 11;
    [Token(Token = "0x40010C9")]
    public const int elementId_button1 = 12;
    [Token(Token = "0x40010CA")]
    public const int elementId_button2 = 13;
    [Token(Token = "0x40010CB")]
    public const int elementId_button3 = 14;
    [Token(Token = "0x40010CC")]
    public const int elementId_button4 = 15;
    [Token(Token = "0x40010CD")]
    public const int elementId_button5 = 16;
    [Token(Token = "0x40010CE")]
    public const int elementId_button6 = 17;
    [Token(Token = "0x40010CF")]
    public const int elementId_button7 = 18;
    [Token(Token = "0x40010D0")]
    public const int elementId_button8 = 19;
    [Token(Token = "0x40010D1")]
    public const int elementId_button9 = 20;
    [Token(Token = "0x40010D2")]
    public const int elementId_button10 = 21;
    [Token(Token = "0x40010D3")]
    public const int elementId_button11 = 22;
    [Token(Token = "0x40010D4")]
    public const int elementId_button12 = 23;
    [Token(Token = "0x40010D5")]
    public const int elementId_button13 = 24;
    [Token(Token = "0x40010D6")]
    public const int elementId_button14 = 25;
    [Token(Token = "0x40010D7")]
    public const int elementId_button15 = 26;
    [Token(Token = "0x40010D8")]
    public const int elementId_button16 = 27;
    [Token(Token = "0x40010D9")]
    public const int elementId_button17 = 28;
    [Token(Token = "0x40010DA")]
    public const int elementId_button18 = 29;
    [Token(Token = "0x40010DB")]
    public const int elementId_button19 = 30;
    [Token(Token = "0x40010DC")]
    public const int elementId_button20 = 31;
    [Token(Token = "0x40010DD")]
    public const int elementId_button21 = 55;
    [Token(Token = "0x40010DE")]
    public const int elementId_button22 = 56;
    [Token(Token = "0x40010DF")]
    public const int elementId_button23 = 57;
    [Token(Token = "0x40010E0")]
    public const int elementId_button24 = 58;
    [Token(Token = "0x40010E1")]
    public const int elementId_button25 = 59;
    [Token(Token = "0x40010E2")]
    public const int elementId_button26 = 60;
    [Token(Token = "0x40010E3")]
    public const int elementId_button27 = 61;
    [Token(Token = "0x40010E4")]
    public const int elementId_button28 = 62;
    [Token(Token = "0x40010E5")]
    public const int elementId_button29 = 63;
    [Token(Token = "0x40010E6")]
    public const int elementId_button30 = 64;
    [Token(Token = "0x40010E7")]
    public const int elementId_button31 = 65;
    [Token(Token = "0x40010E8")]
    public const int elementId_button32 = 66;
    [Token(Token = "0x40010E9")]
    public const int elementId_hat1Up = 32;
    [Token(Token = "0x40010EA")]
    public const int elementId_hat1UpRight = 33;
    [Token(Token = "0x40010EB")]
    public const int elementId_hat1Right = 34;
    [Token(Token = "0x40010EC")]
    public const int elementId_hat1DownRight = 35;
    [Token(Token = "0x40010ED")]
    public const int elementId_hat1Down = 36;
    [Token(Token = "0x40010EE")]
    public const int elementId_hat1DownLeft = 37;
    [Token(Token = "0x40010EF")]
    public const int elementId_hat1Left = 38;
    [Token(Token = "0x40010F0")]
    public const int elementId_hat1UpLeft = 39;
    [Token(Token = "0x40010F1")]
    public const int elementId_hat2Up = 40;
    [Token(Token = "0x40010F2")]
    public const int elementId_hat2UpRight = 41;
    [Token(Token = "0x40010F3")]
    public const int elementId_hat2Right = 42;
    [Token(Token = "0x40010F4")]
    public const int elementId_hat2DownRight = 43;
    [Token(Token = "0x40010F5")]
    public const int elementId_hat2Down = 44;
    [Token(Token = "0x40010F6")]
    public const int elementId_hat2DownLeft = 45;
    [Token(Token = "0x40010F7")]
    public const int elementId_hat2Left = 46;
    [Token(Token = "0x40010F8")]
    public const int elementId_hat2UpLeft = 47;
    [Token(Token = "0x40010F9")]
    public const int elementId_hat1 = 48;
    [Token(Token = "0x40010FA")]
    public const int elementId_hat2 = 49;
    [Token(Token = "0x40010FB")]
    public const int elementId_throttle1 = 52;
    [Token(Token = "0x40010FC")]
    public const int elementId_throttle2 = 53;
    [Token(Token = "0x40010FD")]
    public const int elementId_stick = 54;

    [Token(Token = "0x17000254")]
    IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1
    {
      [Token(Token = "0x6001019"), Address(RVA = "0x52E7A0", Offset = "0x52D3A0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000255")]
    IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2
    {
      [Token(Token = "0x600101A"), Address(RVA = "0x52E7E0", Offset = "0x52D3E0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000256")]
    IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3
    {
      [Token(Token = "0x600101B"), Address(RVA = "0x52E820", Offset = "0x52D420", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000257")]
    IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4
    {
      [Token(Token = "0x600101C"), Address(RVA = "0x52E860", Offset = "0x52D460", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000258")]
    IControllerTemplateButton ISixDofControllerTemplate.button1
    {
      [Token(Token = "0x600101D"), Address(RVA = "0x52E220", Offset = "0x52CE20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000259")]
    IControllerTemplateButton ISixDofControllerTemplate.button2
    {
      [Token(Token = "0x600101E"), Address(RVA = "0x52E4E0", Offset = "0x52D0E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700025A")]
    IControllerTemplateButton ISixDofControllerTemplate.button3
    {
      [Token(Token = "0x600101F"), Address(RVA = "0x52E5E0", Offset = "0x52D1E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700025B")]
    IControllerTemplateButton ISixDofControllerTemplate.button4
    {
      [Token(Token = "0x6001020"), Address(RVA = "0x52E620", Offset = "0x52D220", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700025C")]
    IControllerTemplateButton ISixDofControllerTemplate.button5
    {
      [Token(Token = "0x6001021"), Address(RVA = "0x52E660", Offset = "0x52D260", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700025D")]
    IControllerTemplateButton ISixDofControllerTemplate.button6
    {
      [Token(Token = "0x6001022"), Address(RVA = "0x52E6A0", Offset = "0x52D2A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700025E")]
    IControllerTemplateButton ISixDofControllerTemplate.button7
    {
      [Token(Token = "0x6001023"), Address(RVA = "0x52E6E0", Offset = "0x52D2E0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700025F")]
    IControllerTemplateButton ISixDofControllerTemplate.button8
    {
      [Token(Token = "0x6001024"), Address(RVA = "0x52E720", Offset = "0x52D320", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000260")]
    IControllerTemplateButton ISixDofControllerTemplate.button9
    {
      [Token(Token = "0x6001025"), Address(RVA = "0x52E760", Offset = "0x52D360", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000261")]
    IControllerTemplateButton ISixDofControllerTemplate.button10
    {
      [Token(Token = "0x6001026"), Address(RVA = "0x52DFA0", Offset = "0x52CBA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000262")]
    IControllerTemplateButton ISixDofControllerTemplate.button11
    {
      [Token(Token = "0x6001027"), Address(RVA = "0x52DFE0", Offset = "0x52CBE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000263")]
    IControllerTemplateButton ISixDofControllerTemplate.button12
    {
      [Token(Token = "0x6001028"), Address(RVA = "0x52E020", Offset = "0x52CC20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000264")]
    IControllerTemplateButton ISixDofControllerTemplate.button13
    {
      [Token(Token = "0x6001029"), Address(RVA = "0x52E060", Offset = "0x52CC60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000265")]
    IControllerTemplateButton ISixDofControllerTemplate.button14
    {
      [Token(Token = "0x600102A"), Address(RVA = "0x52E0A0", Offset = "0x52CCA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000266")]
    IControllerTemplateButton ISixDofControllerTemplate.button15
    {
      [Token(Token = "0x600102B"), Address(RVA = "0x52E0E0", Offset = "0x52CCE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000267")]
    IControllerTemplateButton ISixDofControllerTemplate.button16
    {
      [Token(Token = "0x600102C"), Address(RVA = "0x52E120", Offset = "0x52CD20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000268")]
    IControllerTemplateButton ISixDofControllerTemplate.button17
    {
      [Token(Token = "0x600102D"), Address(RVA = "0x52E160", Offset = "0x52CD60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000269")]
    IControllerTemplateButton ISixDofControllerTemplate.button18
    {
      [Token(Token = "0x600102E"), Address(RVA = "0x52E1A0", Offset = "0x52CDA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700026A")]
    IControllerTemplateButton ISixDofControllerTemplate.button19
    {
      [Token(Token = "0x600102F"), Address(RVA = "0x52E1E0", Offset = "0x52CDE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700026B")]
    IControllerTemplateButton ISixDofControllerTemplate.button20
    {
      [Token(Token = "0x6001030"), Address(RVA = "0x52E260", Offset = "0x52CE60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700026C")]
    IControllerTemplateButton ISixDofControllerTemplate.button21
    {
      [Token(Token = "0x6001031"), Address(RVA = "0x52E2A0", Offset = "0x52CEA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700026D")]
    IControllerTemplateButton ISixDofControllerTemplate.button22
    {
      [Token(Token = "0x6001032"), Address(RVA = "0x52E2E0", Offset = "0x52CEE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700026E")]
    IControllerTemplateButton ISixDofControllerTemplate.button23
    {
      [Token(Token = "0x6001033"), Address(RVA = "0x52E320", Offset = "0x52CF20", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x1700026F")]
    IControllerTemplateButton ISixDofControllerTemplate.button24
    {
      [Token(Token = "0x6001034"), Address(RVA = "0x52E360", Offset = "0x52CF60", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000270")]
    IControllerTemplateButton ISixDofControllerTemplate.button25
    {
      [Token(Token = "0x6001035"), Address(RVA = "0x52E3A0", Offset = "0x52CFA0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000271")]
    IControllerTemplateButton ISixDofControllerTemplate.button26
    {
      [Token(Token = "0x6001036"), Address(RVA = "0x52E3E0", Offset = "0x52CFE0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000272")]
    IControllerTemplateButton ISixDofControllerTemplate.button27
    {
      [Token(Token = "0x6001037"), Address(RVA = "0x52E420", Offset = "0x52D020", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000273")]
    IControllerTemplateButton ISixDofControllerTemplate.button28
    {
      [Token(Token = "0x6001038"), Address(RVA = "0x52E460", Offset = "0x52D060", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000274")]
    IControllerTemplateButton ISixDofControllerTemplate.button29
    {
      [Token(Token = "0x6001039"), Address(RVA = "0x52E4A0", Offset = "0x52D0A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000275")]
    IControllerTemplateButton ISixDofControllerTemplate.button30
    {
      [Token(Token = "0x600103A"), Address(RVA = "0x52E520", Offset = "0x52D120", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000276")]
    IControllerTemplateButton ISixDofControllerTemplate.button31
    {
      [Token(Token = "0x600103B"), Address(RVA = "0x52E560", Offset = "0x52D160", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000277")]
    IControllerTemplateButton ISixDofControllerTemplate.button32
    {
      [Token(Token = "0x600103C"), Address(RVA = "0x52E5A0", Offset = "0x52D1A0", Length = "0x3E")] get => (IControllerTemplateButton) null;
    }

    [Token(Token = "0x17000278")]
    IControllerTemplateHat ISixDofControllerTemplate.hat1
    {
      [Token(Token = "0x600103D"), Address(RVA = "0x52E8A0", Offset = "0x52D4A0", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x17000279")]
    IControllerTemplateHat ISixDofControllerTemplate.hat2
    {
      [Token(Token = "0x600103E"), Address(RVA = "0x52E8E0", Offset = "0x52D4E0", Length = "0x3E")] get => (IControllerTemplateHat) null;
    }

    [Token(Token = "0x1700027A")]
    IControllerTemplateThrottle ISixDofControllerTemplate.throttle1
    {
      [Token(Token = "0x600103F"), Address(RVA = "0x52E960", Offset = "0x52D560", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700027B")]
    IControllerTemplateThrottle ISixDofControllerTemplate.throttle2
    {
      [Token(Token = "0x6001040"), Address(RVA = "0x52E9A0", Offset = "0x52D5A0", Length = "0x3E")] get => (IControllerTemplateThrottle) null;
    }

    [Token(Token = "0x1700027C")]
    IControllerTemplateStick6D ISixDofControllerTemplate.stick
    {
      [Token(Token = "0x6001041"), Address(RVA = "0x52E920", Offset = "0x52D520", Length = "0x3E")] get => (IControllerTemplateStick6D) null;
    }

    [Token(Token = "0x6001042")]
    [Address(RVA = "0x522A60", Offset = "0x521660", Length = "0x8")]
    public SixDofControllerTemplate(object payload)
      : base((object) null)
    {
    }

    [Token(Token = "0x6001043")]
    [Address(RVA = "0x52E9E0", Offset = "0x52D5E0", Length = "0x63")]
    static SixDofControllerTemplate()
    {
    }
  }
}
