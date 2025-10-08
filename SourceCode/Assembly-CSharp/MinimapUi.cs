// Decompiled with JetBrains decompiler
// Type: MinimapUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000139")]
public class MinimapUi : MonoBehaviour
{
  [Token(Token = "0x4000924")]
  [FieldOffset(Offset = "0x20")]
  public Transform border;
  [Token(Token = "0x4000925")]
  [FieldOffset(Offset = "0x28")]
  public Transform[] directionLetters;
  [Token(Token = "0x4000926")]
  [FieldOffset(Offset = "0x30")]
  public RawImage jammer;
  [Token(Token = "0x4000927")]
  [FieldOffset(Offset = "0x38")]
  private Color jammerColor;
  [Token(Token = "0x4000928")]
  [FieldOffset(Offset = "0x48")]
  private Color jammerColorClear;

  [Token(Token = "0x60007CD")]
  [Address(RVA = "0x4BE920", Offset = "0x4BD520", Length = "0x3A5")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007CE")]
  [Address(RVA = "0x4BED60", Offset = "0x4BD960", Length = "0x245")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60007CF")]
  [Address(RVA = "0x4BF200", Offset = "0x4BDE00", Length = "0x32E")]
  private void Update()
  {
  }

  [Token(Token = "0x60007D0")]
  [Address(RVA = "0x4BECD0", Offset = "0x4BD8D0", Length = "0x89")]
  private bool IsJammed() => false;

  [Token(Token = "0x60007D1")]
  [Address(RVA = "0x4BEFB0", Offset = "0x4BDBB0", Length = "0xEB")]
  private void OnRotationUpdated(float y)
  {
  }

  [Token(Token = "0x60007D2")]
  [Address(RVA = "0x4BF140", Offset = "0x4BDD40", Length = "0xB3")]
  private void UpdateScale(float scale)
  {
  }

  [Token(Token = "0x60007D3")]
  [Address(RVA = "0x4BF0A0", Offset = "0x4BDCA0", Length = "0x95")]
  private void OnSettingUpdated(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x60007D4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MinimapUi()
  {
  }
}
