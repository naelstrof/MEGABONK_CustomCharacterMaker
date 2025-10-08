// Decompiled with JetBrains decompiler
// Type: CameraFadeObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200002F")]
public class CameraFadeObject : MonoBehaviour
{
  [Token(Token = "0x4000189")]
  [FieldOffset(Offset = "0x20")]
  public Renderer renderer;
  [Token(Token = "0x400018A")]
  [FieldOffset(Offset = "0x28")]
  private Material defaultMaterial;
  [Token(Token = "0x400018B")]
  [FieldOffset(Offset = "0x30")]
  public Material fadeMaterial;
  [Token(Token = "0x400018C")]
  [FieldOffset(Offset = "0x38")]
  private bool fading;
  [Token(Token = "0x400018D")]
  [FieldOffset(Offset = "0x3C")]
  private float stopFadeTime;

  [Token(Token = "0x6000167")]
  [Address(RVA = "0x355BF0", Offset = "0x3547F0", Length = "0x153")]
  private void Start()
  {
  }

  [Token(Token = "0x6000168")]
  [Address(RVA = "0x3559E0", Offset = "0x3545E0", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000169")]
  [Address(RVA = "0x355B10", Offset = "0x354710", Length = "0xDC")]
  private void OnFadeObject(GameObject go)
  {
  }

  [Token(Token = "0x600016A")]
  [Address(RVA = "0x355D80", Offset = "0x354980", Length = "0x85")]
  private void Update()
  {
  }

  [Token(Token = "0x600016B")]
  [Address(RVA = "0x355D50", Offset = "0x354950", Length = "0x29")]
  private void StopFade()
  {
  }

  [Token(Token = "0x600016C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CameraFadeObject()
  {
  }
}
