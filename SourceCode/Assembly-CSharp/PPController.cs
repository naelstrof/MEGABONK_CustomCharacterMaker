// Decompiled with JetBrains decompiler
// Type: PPController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200003A")]
public class PPController : MonoBehaviour
{
  [Token(Token = "0x40001B8")]
  [FieldOffset(Offset = "0x20")]
  private UnityEngine.Rendering.PostProcessing.Bloom bloom;
  [Token(Token = "0x40001B9")]
  [FieldOffset(Offset = "0x28")]
  private MotionBlur motionBlur;
  [Token(Token = "0x40001BA")]
  [FieldOffset(Offset = "0x30")]
  private AmbientOcclusion ao;

  [Token(Token = "0x60001A4")]
  [Address(RVA = "0x361800", Offset = "0x360400", Length = "0x203")]
  private void Awake()
  {
  }

  [Token(Token = "0x60001A5")]
  [Address(RVA = "0x361A10", Offset = "0x360610", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60001A6")]
  [Address(RVA = "0x361DB0", Offset = "0x3609B0", Length = "0x1C0")]
  private void Start()
  {
  }

  [Token(Token = "0x60001A7")]
  [Address(RVA = "0x361B60", Offset = "0x360760", Length = "0x15E")]
  private void OnSettingUpdated(string name, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x60001A8")]
  [Address(RVA = "0x361CF0", Offset = "0x3608F0", Length = "0x88")]
  public void SetBloom(int value)
  {
  }

  [Token(Token = "0x60001A9")]
  [Address(RVA = "0x361D80", Offset = "0x360980", Length = "0x29")]
  public void SetMotionBlur(int on)
  {
  }

  [Token(Token = "0x60001AA")]
  [Address(RVA = "0x361CC0", Offset = "0x3608C0", Length = "0x29")]
  public void SetAO(int on)
  {
  }

  [Token(Token = "0x60001AB")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PPController()
  {
  }
}
