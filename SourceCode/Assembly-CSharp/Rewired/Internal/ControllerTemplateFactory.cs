// Decompiled with JetBrains decompiler
// Type: Rewired.Internal.ControllerTemplateFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Rewired.Internal
{
  [Token(Token = "0x2000267")]
  public static class ControllerTemplateFactory
  {
    [Token(Token = "0x4001176")]
    private static readonly System.Type[] _defaultTemplateTypes;
    [Token(Token = "0x4001177")]
    private static readonly System.Type[] _defaultTemplateInterfaceTypes;

    [Token(Token = "0x170002A2")]
    public static System.Type[] templateTypes
    {
      [Token(Token = "0x6001195"), Address(RVA = "0x36D640", Offset = "0x36C240", Length = "0x4E")] get => (System.Type[]) null;
    }

    [Token(Token = "0x170002A3")]
    public static System.Type[] templateInterfaceTypes
    {
      [Token(Token = "0x6001196"), Address(RVA = "0x36D5F0", Offset = "0x36C1F0", Length = "0x4F")] get => (System.Type[]) null;
    }

    [Token(Token = "0x6001197")]
    [Address(RVA = "0x36CCD0", Offset = "0x36B8D0", Length = "0x366")]
    public static IControllerTemplate Create(Guid typeGuid, object payload) => (IControllerTemplate) null;

    [Token(Token = "0x6001198")]
    [Address(RVA = "0x36D040", Offset = "0x36BC40", Length = "0x5A0")]
    static ControllerTemplateFactory()
    {
    }
  }
}
