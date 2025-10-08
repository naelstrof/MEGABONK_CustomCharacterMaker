// Decompiled with JetBrains decompiler
// Type: Rewired.FlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired
{
  [Token(Token = "0x2000242")]
  public sealed class FlightPedalsTemplate : 
    ControllerTemplate,
    IFlightPedalsTemplate,
    IControllerTemplate
  {
    [Token(Token = "0x40010B6")]
    public static readonly Guid typeGuid;
    [Token(Token = "0x40010B7")]
    public const int elementId_leftPedal = 0;
    [Token(Token = "0x40010B8")]
    public const int elementId_rightPedal = 1;
    [Token(Token = "0x40010B9")]
    public const int elementId_slide = 2;

    [Token(Token = "0x17000251")]
    IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
    {
      [Token(Token = "0x6001014"), Address(RVA = "0x522930", Offset = "0x521530", Length = "0x3B")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000252")]
    IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
    {
      [Token(Token = "0x6001015"), Address(RVA = "0x522970", Offset = "0x521570", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x17000253")]
    IControllerTemplateAxis IFlightPedalsTemplate.slide
    {
      [Token(Token = "0x6001016"), Address(RVA = "0x5229B0", Offset = "0x5215B0", Length = "0x3E")] get => (IControllerTemplateAxis) null;
    }

    [Token(Token = "0x6001017")]
    [Address(RVA = "0x522A60", Offset = "0x521660", Length = "0x8")]
    public FlightPedalsTemplate(object payload)
      : base((object) null)
    {
    }

    [Token(Token = "0x6001018")]
    [Address(RVA = "0x5229F0", Offset = "0x5215F0", Length = "0x63")]
    static FlightPedalsTemplate()
    {
    }
  }
}
