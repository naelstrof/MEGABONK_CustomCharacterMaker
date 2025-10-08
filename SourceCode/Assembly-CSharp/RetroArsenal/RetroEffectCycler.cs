// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroEffectCycler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RetroArsenal
{
  [Token(Token = "0x2000459")]
  public class RetroEffectCycler : MonoBehaviour
  {
    [Token(Token = "0x4001C93")]
    [FieldOffset(Offset = "0x20")]
    public List<GameObject> listOfEffects;
    [Token(Token = "0x4001C94")]
    [FieldOffset(Offset = "0x28")]
    private int effectIndex;
    [Header("Spawn Settings")]
    [SerializeField]
    [Space(10f)]
    [Token(Token = "0x4001C95")]
    [FieldOffset(Offset = "0x2C")]
    public float loopLength;
    [Token(Token = "0x4001C96")]
    [FieldOffset(Offset = "0x30")]
    public float startDelay;
    [Token(Token = "0x4001C97")]
    [FieldOffset(Offset = "0x34")]
    public bool disableLights;
    [Token(Token = "0x4001C98")]
    [FieldOffset(Offset = "0x35")]
    public bool disableSound;
    [Token(Token = "0x4001C99")]
    [FieldOffset(Offset = "0x36")]
    public bool autoMode;
    [Header("UI Elements")]
    [Token(Token = "0x4001C9A")]
    [FieldOffset(Offset = "0x38")]
    public Text effectNameText;
    [Token(Token = "0x4001C9B")]
    [FieldOffset(Offset = "0x40")]
    private GameObject currentEffect;

    [Token(Token = "0x6001F6B")]
    [Address(RVA = "0x4504C0", Offset = "0x44F0C0", Length = "0xAC")]
    private void Start()
    {
    }

    [Token(Token = "0x6001F6C")]
    [Address(RVA = "0x450330", Offset = "0x44EF30", Length = "0x7B")]
    public void PlayEffect()
    {
    }

    [Token(Token = "0x6001F6D")]
    [Address(RVA = "0x4502C0", Offset = "0x44EEC0", Length = "0x65")]
    public void NextEffect()
    {
    }

    [Token(Token = "0x6001F6E")]
    [Address(RVA = "0x4503B0", Offset = "0x44EFB0", Length = "0x62")]
    public void PreviousEffect()
    {
    }

    [Token(Token = "0x6001F6F")]
    [Address(RVA = "0x450570", Offset = "0x44F170", Length = "0x11")]
    public void ToggleAutoMode()
    {
    }

    [Token(Token = "0x6001F70")]
    [Address(RVA = "0x450420", Offset = "0x44F020", Length = "0x94")]
    private void RestartEffect()
    {
    }

    [Token(Token = "0x6001F71")]
    [Address(RVA = "0x450250", Offset = "0x44EE50", Length = "0x67")]
    private IEnumerator EffectLoop() => (IEnumerator) null;

    [Token(Token = "0x6001F72")]
    [Address(RVA = "0x450590", Offset = "0x44F190", Length = "0x146")]
    private void UpdateEffectUI()
    {
    }

    [Token(Token = "0x6001F73")]
    [Address(RVA = "0x4506E0", Offset = "0x44F2E0", Length = "0x102")]
    private void Update()
    {
    }

    [Token(Token = "0x6001F74")]
    [Address(RVA = "0x4507F0", Offset = "0x44F3F0", Length = "0x1F")]
    public RetroEffectCycler()
    {
    }
  }
}
