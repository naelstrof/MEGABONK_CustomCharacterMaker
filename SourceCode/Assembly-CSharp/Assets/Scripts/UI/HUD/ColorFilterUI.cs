// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.HUD.ColorFilterUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Objects;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.HUD
{
  [Token(Token = "0x20002FE")]
  public class ColorFilterUI : MonoBehaviour
  {
    [Token(Token = "0x4001459")]
    [FieldOffset(Offset = "0x20")]
    public CanvasGroup group;
    [Token(Token = "0x400145A")]
    [FieldOffset(Offset = "0x28")]
    public RawImage i_color;
    [Token(Token = "0x400145B")]
    [FieldOffset(Offset = "0x30")]
    private bool usingFilter;
    [Token(Token = "0x400145C")]
    [FieldOffset(Offset = "0x34")]
    private float fadeSeconds;
    [Token(Token = "0x400145D")]
    [FieldOffset(Offset = "0x38")]
    private float interpValue;

    [Token(Token = "0x60015A0")]
    [Address(RVA = "0x3A3D70", Offset = "0x3A2970", Length = "0x216")]
    private void Awake()
    {
    }

    [Token(Token = "0x60015A1")]
    [Address(RVA = "0x3A3F90", Offset = "0x3A2B90", Length = "0x216")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60015A2")]
    [Address(RVA = "0x3A41B0", Offset = "0x3A2DB0", Length = "0xAE")]
    private void OnFilterEnter(ColorFilter filter)
    {
    }

    [Token(Token = "0x60015A3")]
    [Address(RVA = "0x3A4260", Offset = "0x3A2E60", Length = "0x5")]
    private void OnFilterExit(ColorFilter filter)
    {
    }

    [Token(Token = "0x60015A4")]
    [Address(RVA = "0x3A4270", Offset = "0x3A2E70", Length = "0xE7")]
    private void Update()
    {
    }

    [Token(Token = "0x60015A5")]
    [Address(RVA = "0x3A4360", Offset = "0x3A2F60", Length = "0xE")]
    public ColorFilterUI()
    {
    }
  }
}
