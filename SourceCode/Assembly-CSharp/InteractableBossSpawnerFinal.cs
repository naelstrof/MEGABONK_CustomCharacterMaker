// Decompiled with JetBrains decompiler
// Type: InteractableBossSpawnerFinal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x200008F")]
public class InteractableBossSpawnerFinal : BaseInteractable
{
  [Token(Token = "0x400048D")]
  [FieldOffset(Offset = "0x58")]
  private bool done;
  [Token(Token = "0x400048E")]
  [FieldOffset(Offset = "0x60")]
  public GameObject preventObjectsSpawningHere;

  [Token(Token = "0x600039B")]
  [Address(RVA = "0x476770", Offset = "0x475370", Length = "0x20")]
  private new void Start()
  {
  }

  [Token(Token = "0x600039C")]
  [Address(RVA = "0x4766B0", Offset = "0x4752B0", Length = "0xBD")]
  public override bool Interact() => false;

  [Token(Token = "0x600039D")]
  [Address(RVA = "0x476610", Offset = "0x475210", Length = "0x4B")]
  private IEnumerator DoLoadNextStage() => (IEnumerator) null;

  [Token(Token = "0x600039E")]
  [Address(RVA = "0x476660", Offset = "0x475260", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x600039F")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableBossSpawnerFinal()
  {
  }
}
