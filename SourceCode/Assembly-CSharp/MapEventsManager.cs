// Decompiled with JetBrains decompiler
// Type: MapEventsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000077")]
public class MapEventsManager : MonoBehaviour
{
  [Token(Token = "0x40003A6")]
  [FieldOffset(Offset = "0x20")]
  private Assets.Scripts.Game.MapGeneration.MapEvents.MapEvents mapEvents;

  [Token(Token = "0x60002FB")]
  [Address(RVA = "0x4692D0", Offset = "0x467ED0", Length = "0xBB")]
  private void Start()
  {
  }

  [Token(Token = "0x60002FC")]
  [Address(RVA = "0x4692B0", Offset = "0x467EB0", Length = "0x1B")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60002FD")]
  [Address(RVA = "0x469290", Offset = "0x467E90", Length = "0x1B")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60002FE")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapEventsManager()
  {
  }
}
