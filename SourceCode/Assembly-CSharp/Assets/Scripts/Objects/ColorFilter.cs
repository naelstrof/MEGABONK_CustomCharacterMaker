// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Objects.ColorFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Objects
{
  [Token(Token = "0x2000339")]
  public class ColorFilter : MonoBehaviour
  {
    [Token(Token = "0x40015F8")]
    [FieldOffset(Offset = "0x20")]
    public Color color;
    [Token(Token = "0x40015F9")]
    public static Action<ColorFilter> A_FilterEnter;
    [Token(Token = "0x40015FA")]
    public static Action<ColorFilter> A_FilterExit;

    [Token(Token = "0x600172D")]
    [Address(RVA = "0x3CA870", Offset = "0x3C9470", Length = "0x96")]
    private void OnTriggerEnter(Collider c)
    {
    }

    [Token(Token = "0x600172E")]
    [Address(RVA = "0x3CA910", Offset = "0x3C9510", Length = "0x97")]
    private void OnTriggerExit(Collider c)
    {
    }

    [Token(Token = "0x600172F")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public ColorFilter()
    {
    }
  }
}
