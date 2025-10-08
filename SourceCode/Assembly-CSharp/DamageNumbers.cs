// Decompiled with JetBrains decompiler
// Type: DamageNumbers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000206")]
public class DamageNumbers : MonoBehaviour
{
  [Token(Token = "0x4000E32")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI damageText;
  [Token(Token = "0x4000E33")]
  [FieldOffset(Offset = "0x28")]
  private Vector3 randomDir;
  [Token(Token = "0x4000E34")]
  [FieldOffset(Offset = "0x34")]
  private Vector3 defaultScale;
  [Token(Token = "0x4000E35")]
  [FieldOffset(Offset = "0x40")]
  private float fadeTime;
  [Token(Token = "0x4000E36")]
  [FieldOffset(Offset = "0x44")]
  private float startFadeoutTime;
  [Token(Token = "0x4000E37")]
  [FieldOffset(Offset = "0x48")]
  private bool started;
  [Token(Token = "0x4000E38")]
  [FieldOffset(Offset = "0x50")]
  private IEnumerator shakeRoutine;
  [Token(Token = "0x4000E39")]
  private static StringBuilder sb;
  [Token(Token = "0x4000E3A")]
  [FieldOffset(Offset = "0x58")]
  private float moveMultiplier;
  [Token(Token = "0x4000E3B")]
  [FieldOffset(Offset = "0x5C")]
  private float speed;
  [Token(Token = "0x4000E3C")]
  [FieldOffset(Offset = "0x60")]
  private Vector3 moveDir;
  [Token(Token = "0x4000E3D")]
  private static string[] suffixes;
  [Token(Token = "0x4000E3E")]
  [FieldOffset(Offset = "0x6C")]
  private float desiredScale;

  [Token(Token = "0x6000D42")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void StartFadeOut()
  {
  }

  [Token(Token = "0x6000D43")]
  [Address(RVA = "0x5200B0", Offset = "0x51ECB0", Length = "0xB2")]
  public void SetDamage(float dmg, Color color, Vector3 position, int textSize = 24)
  {
  }

  [Token(Token = "0x6000D44")]
  [Address(RVA = "0x520170", Offset = "0x51ED70", Length = "0x451")]
  public void SetDamage(string text, Color color, Vector3 position, int textSize = 24)
  {
  }

  [Token(Token = "0x6000D45")]
  [Address(RVA = "0x5205D0", Offset = "0x51F1D0", Length = "0x2C2")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D46")]
  [Address(RVA = "0x51FDF0", Offset = "0x51E9F0", Length = "0x2BE")]
  public static string FormatDamageNumber(float number) => (string) null;

  [Token(Token = "0x6000D47")]
  [Address(RVA = "0x51FC40", Offset = "0x51E840", Length = "0x1AE")]
  private void DestroySelf()
  {
  }

  [Token(Token = "0x6000D48")]
  [Address(RVA = "0x520BA0", Offset = "0x51F7A0", Length = "0x2A")]
  public DamageNumbers()
  {
  }

  [Token(Token = "0x6000D49")]
  [Address(RVA = "0x5208A0", Offset = "0x51F4A0", Length = "0x2F3")]
  static DamageNumbers()
  {
  }
}
