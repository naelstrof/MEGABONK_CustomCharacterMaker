// Decompiled with JetBrains decompiler
// Type: DebugUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x200011F")]
public class DebugUI : MonoBehaviour
{
  [Token(Token = "0x4000887")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_fps;
  [Token(Token = "0x4000888")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_speed;
  [Token(Token = "0x4000889")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_ram;
  [Token(Token = "0x400088A")]
  [FieldOffset(Offset = "0x38")]
  private float fpsTimer;
  [Token(Token = "0x400088B")]
  [FieldOffset(Offset = "0x3C")]
  private int frameCount;
  [Token(Token = "0x400088C")]
  [FieldOffset(Offset = "0x40")]
  private float fpsUpdateInterval;
  [Token(Token = "0x400088D")]
  [FieldOffset(Offset = "0x48")]
  private float[] speedSamples;
  [Token(Token = "0x400088E")]
  [FieldOffset(Offset = "0x50")]
  private int speedSampleIndex;
  [Token(Token = "0x400088F")]
  [FieldOffset(Offset = "0x54")]
  private float sampleSpeedInterval;
  [Token(Token = "0x4000890")]
  [FieldOffset(Offset = "0x58")]
  private float sampleRamInterval;

  [Token(Token = "0x6000730")]
  [Address(RVA = "0x4B44E0", Offset = "0x4B30E0", Length = "0x3F6")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000731")]
  [Address(RVA = "0x4B48E0", Offset = "0x4B34E0", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000732")]
  [Address(RVA = "0x4B4A30", Offset = "0x4B3630", Length = "0x18F")]
  private void OnSettingUpdated(string setting, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x6000733")]
  [Address(RVA = "0x4B4FF0", Offset = "0x4B3BF0", Length = "0xFE")]
  private void Update()
  {
  }

  [Token(Token = "0x6000734")]
  [Address(RVA = "0x4B4FF0", Offset = "0x4B3BF0", Length = "0xFE")]
  private void UpdateFps()
  {
  }

  [Token(Token = "0x6000735")]
  [Address(RVA = "0x4B4D30", Offset = "0x4B3930", Length = "0x2B1")]
  private void SampleSpeed()
  {
  }

  [Token(Token = "0x6000736")]
  [Address(RVA = "0x4B4BC0", Offset = "0x4B37C0", Length = "0x163")]
  private void SampleRam()
  {
  }

  [Token(Token = "0x6000737")]
  [Address(RVA = "0x4B50F0", Offset = "0x4B3CF0", Length = "0x6A")]
  public DebugUI()
  {
  }
}
