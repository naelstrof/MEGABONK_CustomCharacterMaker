// Decompiled with JetBrains decompiler
// Type: InteractablePortalFinal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000096")]
public class InteractablePortalFinal : BaseInteractable
{
  [Token(Token = "0x40004BB")]
  [FieldOffset(Offset = "0x58")]
  private bool done;
  [Token(Token = "0x40004BC")]
  [FieldOffset(Offset = "0x60")]
  public GameObject cameraCircling;

  [Token(Token = "0x60003CE")]
  [Address(RVA = "0x478B20", Offset = "0x477720", Length = "0xCD")]
  public override bool Interact() => false;

  [Token(Token = "0x60003CF")]
  [Address(RVA = "0x478A60", Offset = "0x477660", Length = "0x67")]
  private IEnumerator DoFinishGame() => (IEnumerator) null;

  [Token(Token = "0x60003D0")]
  [Address(RVA = "0x478AD0", Offset = "0x4776D0", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003D1")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractablePortalFinal()
  {
  }
}
