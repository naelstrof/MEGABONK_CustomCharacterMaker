// Decompiled with JetBrains decompiler
// Type: PickupEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A9")]
public class PickupEffect : MonoBehaviour
{
  [Token(Token = "0x4000549")]
  [FieldOffset(Offset = "0x20")]
  private float time;

  [Token(Token = "0x600043D")]
  [Address(RVA = "0x47FA00", Offset = "0x47E600", Length = "0xEB")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600043E")]
  [Address(RVA = "0x47F900", Offset = "0x47E500", Length = "0xFE")]
  private void DisableSelf()
  {
  }

  [Token(Token = "0x600043F")]
  [Address(RVA = "0x47FAF0", Offset = "0x47E6F0", Length = "0xE")]
  public PickupEffect()
  {
  }
}
