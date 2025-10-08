// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.PlayerPointerEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
  [Token(Token = "0x2000268")]
  public class PlayerPointerEventData : PointerEventData
  {
    [field: Token(Token = "0x4001178")]
    [field: FieldOffset(Offset = "0x180")]
    [Token(Token = "0x170002A4")]
    public int playerId { [Token(Token = "0x6001199"), Address(RVA = "0x3712B0", Offset = "0x36FEB0", Length = "0x7")] get; [Token(Token = "0x600119A"), Address(RVA = "0x371320", Offset = "0x36FF20", Length = "0x7")] set; }

    [field: Token(Token = "0x4001179")]
    [field: FieldOffset(Offset = "0x184")]
    [Token(Token = "0x170002A5")]
    public int inputSourceIndex { [Token(Token = "0x600119B"), Address(RVA = "0x371290", Offset = "0x36FE90", Length = "0x7")] get; [Token(Token = "0x600119C"), Address(RVA = "0x3712F0", Offset = "0x36FEF0", Length = "0x7")] set; }

    [field: Token(Token = "0x400117A")]
    [field: FieldOffset(Offset = "0x188")]
    [Token(Token = "0x170002A6")]
    public IMouseInputSource mouseSource { [Token(Token = "0x600119D"), Address(RVA = "0x3712A0", Offset = "0x36FEA0", Length = "0x8")] get; [Token(Token = "0x600119E"), Address(RVA = "0x371300", Offset = "0x36FF00", Length = "0x13")] set; }

    [field: Token(Token = "0x400117B")]
    [field: FieldOffset(Offset = "0x190")]
    [Token(Token = "0x170002A7")]
    public ITouchInputSource touchSource { [Token(Token = "0x600119F"), Address(RVA = "0x3712D0", Offset = "0x36FED0", Length = "0x8")] get; [Token(Token = "0x60011A0"), Address(RVA = "0x371340", Offset = "0x36FF40", Length = "0x13")] set; }

    [field: Token(Token = "0x400117C")]
    [field: FieldOffset(Offset = "0x198")]
    [Token(Token = "0x170002A8")]
    public PointerEventType sourceType { [Token(Token = "0x60011A1"), Address(RVA = "0x3712C0", Offset = "0x36FEC0", Length = "0x7")] get; [Token(Token = "0x60011A2"), Address(RVA = "0x371330", Offset = "0x36FF30", Length = "0x7")] set; }

    [field: Token(Token = "0x400117D")]
    [field: FieldOffset(Offset = "0x19C")]
    [Token(Token = "0x170002A9")]
    public int buttonIndex { [Token(Token = "0x60011A3"), Address(RVA = "0x371280", Offset = "0x36FE80", Length = "0x7")] get; [Token(Token = "0x60011A4"), Address(RVA = "0x3712E0", Offset = "0x36FEE0", Length = "0x7")] set; }

    [Token(Token = "0x60011A5")]
    [Address(RVA = "0x371250", Offset = "0x36FE50", Length = "0x2C")]
    public PlayerPointerEventData(EventSystem eventSystem)
      : base((EventSystem) null)
    {
    }

    [Token(Token = "0x60011A6")]
    [Address(RVA = "0x370FE0", Offset = "0x36FBE0", Length = "0x26C")]
    public override string ToString() => (string) null;
  }
}
