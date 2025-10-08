// Decompiled with JetBrains decompiler
// Type: DisableOutOfCameraRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000033")]
public class DisableOutOfCameraRange : MonoBehaviour
{
  [Token(Token = "0x400018F")]
  [FieldOffset(Offset = "0x20")]
  private float repeatTime;
  [Token(Token = "0x4000190")]
  [FieldOffset(Offset = "0x24")]
  public float range;
  [Token(Token = "0x4000191")]
  [FieldOffset(Offset = "0x28")]
  private float sqrRange;
  [Token(Token = "0x4000192")]
  [FieldOffset(Offset = "0x2C")]
  private bool isVisible;
  [Token(Token = "0x4000193")]
  [FieldOffset(Offset = "0x2D")]
  public bool useXZVector;
  [Token(Token = "0x4000194")]
  [FieldOffset(Offset = "0x30")]
  public GameObject[] objectsToUse;

  [Token(Token = "0x6000173")]
  [Address(RVA = "0x35A5D0", Offset = "0x3591D0", Length = "0xC0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000174")]
  [Address(RVA = "0x35A5C0", Offset = "0x3591C0", Length = "0x7")]
  private void SlowUpdate()
  {
  }

  [Token(Token = "0x6000175")]
  [Address(RVA = "0x35A2C0", Offset = "0x358EC0", Length = "0x238")]
  private void CheckVisibility()
  {
  }

  [Token(Token = "0x6000176")]
  [Address(RVA = "0x35A500", Offset = "0x359100", Length = "0x5D")]
  private void Hide()
  {
  }

  [Token(Token = "0x6000177")]
  [Address(RVA = "0x35A560", Offset = "0x359160", Length = "0x5D")]
  private void Show()
  {
  }

  [Token(Token = "0x6000178")]
  [Address(RVA = "0x35A6A0", Offset = "0x3592A0", Length = "0x15")]
  public DisableOutOfCameraRange()
  {
  }
}
