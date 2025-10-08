// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Other.Water.WaterFilterUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Other.Water
{
  [Token(Token = "0x200041F")]
  public class WaterFilterUI : MonoBehaviour
  {
    [Token(Token = "0x4001AED")]
    [FieldOffset(Offset = "0x20")]
    public CanvasGroup group;
    [Token(Token = "0x4001AEE")]
    [FieldOffset(Offset = "0x28")]
    public RawImage i_color;
    [Token(Token = "0x4001AEF")]
    [FieldOffset(Offset = "0x30")]
    private bool usingFilter;
    [Token(Token = "0x4001AF0")]
    [FieldOffset(Offset = "0x34")]
    private float fadeSeconds;

    [Token(Token = "0x6001DB8")]
    [Address(RVA = "0x455440", Offset = "0x454040", Length = "0x216")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001DB9")]
    [Address(RVA = "0x455660", Offset = "0x454260", Length = "0x216")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001DBA")]
    [Address(RVA = "0x455880", Offset = "0x454480", Length = "0xA8")]
    private void OnFilterEnter(global::Water filter)
    {
    }

    [Token(Token = "0x6001DBB")]
    [Address(RVA = "0x3A4260", Offset = "0x3A2E60", Length = "0x5")]
    private void OnFilterExit(global::Water filter)
    {
    }

    [Token(Token = "0x6001DBC")]
    [Address(RVA = "0x455930", Offset = "0x454530", Length = "0xD2")]
    private void Update()
    {
    }

    [Token(Token = "0x6001DBD")]
    [Address(RVA = "0x455A10", Offset = "0x454610", Length = "0xE")]
    public WaterFilterUI()
    {
    }
  }
}
