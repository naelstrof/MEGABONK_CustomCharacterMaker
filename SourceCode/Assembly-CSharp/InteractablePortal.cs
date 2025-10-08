// Decompiled with JetBrains decompiler
// Type: InteractablePortal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;

[Token(Token = "0x2000094")]
public class InteractablePortal : BaseInteractable
{
  [Token(Token = "0x40004B8")]
  [FieldOffset(Offset = "0x58")]
  private bool done;

  [Token(Token = "0x60003C4")]
  [Address(RVA = "0x478D50", Offset = "0x477950", Length = "0xBD")]
  public override bool Interact() => false;

  [Token(Token = "0x60003C5")]
  [Address(RVA = "0x478CB0", Offset = "0x4778B0", Length = "0x4B")]
  private IEnumerator DoLoadNextStage() => (IEnumerator) null;

  [Token(Token = "0x60003C6")]
  [Address(RVA = "0x478D00", Offset = "0x477900", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003C7")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractablePortal()
  {
  }
}
