// Decompiled with JetBrains decompiler
// Type: TimeFreezeUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000171")]
public class TimeFreezeUi : MonoBehaviour
{
  [Token(Token = "0x4000AA4")]
  [FieldOffset(Offset = "0x20")]
  public RawImage swirl;
  [Token(Token = "0x4000AA5")]
  [FieldOffset(Offset = "0x28")]
  public RawImage vignette;
  [Token(Token = "0x4000AA6")]
  [FieldOffset(Offset = "0x30")]
  private bool isTimeFrozen;
  [Token(Token = "0x4000AA7")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource a_start;
  [Token(Token = "0x4000AA8")]
  [FieldOffset(Offset = "0x40")]
  public AudioSource a_end;
  [Token(Token = "0x4000AA9")]
  [FieldOffset(Offset = "0x48")]
  public AudioSource a_loop;

  [Token(Token = "0x6000949")]
  [Address(RVA = "0x4E1F20", Offset = "0x4E0B20", Length = "0x336")]
  private void Awake()
  {
  }

  [Token(Token = "0x600094A")]
  [Address(RVA = "0x4E22C0", Offset = "0x4E0EC0", Length = "0x336")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600094B")]
  [Address(RVA = "0x4E26F0", Offset = "0x4E12F0", Length = "0x22B")]
  private void RefreshTimeFreeze()
  {
  }

  [Token(Token = "0x600094C")]
  [Address(RVA = "0x4E2920", Offset = "0x4E1520", Length = "0xAC")]
  private void StartTimeFreeze()
  {
  }

  [Token(Token = "0x600094D")]
  [Address(RVA = "0x4E2260", Offset = "0x4E0E60", Length = "0x55")]
  private void EndTimeFreeze()
  {
  }

  [Token(Token = "0x600094E")]
  [Address(RVA = "0x4E2600", Offset = "0x4E1200", Length = "0x98")]
  private void OnStatusEffectAdded(EStatusEffect eStatusEffect, bool newEffect)
  {
  }

  [Token(Token = "0x600094F")]
  [Address(RVA = "0x4E26A0", Offset = "0x4E12A0", Length = "0x41")]
  private void OnStatusEffectRemoved(EStatusEffect eStatusEffect)
  {
  }

  [Token(Token = "0x6000950")]
  [Address(RVA = "0x4E29D0", Offset = "0x4E15D0", Length = "0xB0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000951")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TimeFreezeUi()
  {
  }
}
