// Decompiled with JetBrains decompiler
// Type: Window
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20001F2")]
public class Window : MonoBehaviour
{
  [Token(Token = "0x4000DD5")]
  [FieldOffset(Offset = "0x20")]
  protected MyButton savedBtn;
  [Token(Token = "0x4000DD6")]
  [FieldOffset(Offset = "0x28")]
  public MyButton startBtn;
  [Token(Token = "0x4000DD7")]
  [FieldOffset(Offset = "0x30")]
  public bool alwaysUseStartBtn;
  [Token(Token = "0x4000DD8")]
  [FieldOffset(Offset = "0x34")]
  public float openDelay;
  [Token(Token = "0x4000DD9")]
  [FieldOffset(Offset = "0x38")]
  public List<MyButton> allButtons;
  [Token(Token = "0x4000DDA")]
  [FieldOffset(Offset = "0x40")]
  public HashSet<GameObject> allButtonsHashed;
  [Token(Token = "0x4000DDB")]
  [FieldOffset(Offset = "0x48")]
  private bool isFocused;
  [Token(Token = "0x4000DDC")]
  public static Action A_WindowOpenedFirstTime;
  [Token(Token = "0x4000DDD")]
  [FieldOffset(Offset = "0x4C")]
  private float lastHadButtonTime;

  [Token(Token = "0x6000CD6")]
  [Address(RVA = "0x53F190", Offset = "0x53DD90", Length = "0x140")]
  protected void Awake()
  {
  }

  [Token(Token = "0x6000CD7")]
  [Address(RVA = "0x53F840", Offset = "0x53E440", Length = "0x140")]
  protected void OnDestroy()
  {
  }

  [Token(Token = "0x6000CD8")]
  [Address(RVA = "0x53F450", Offset = "0x53E050", Length = "0x1C9")]
  public void FindAllButtonsInWindow()
  {
  }

  [Token(Token = "0x6000CD9")]
  [Address(RVA = "0x53FA50", Offset = "0x53E650", Length = "0x70")]
  protected void Start()
  {
  }

  [Token(Token = "0x6000CDA")]
  [Address(RVA = "0x53FA00", Offset = "0x53E600", Length = "0x49")]
  protected void OnEnable()
  {
  }

  [Token(Token = "0x6000CDB")]
  [Address(RVA = "0x53F990", Offset = "0x53E590", Length = "0x67")]
  protected void OnDisable()
  {
  }

  [Token(Token = "0x6000CDC")]
  [Address(RVA = "0x53F2E0", Offset = "0x53DEE0", Length = "0x88")]
  public void Close()
  {
  }

  [Token(Token = "0x6000CDD")]
  [Address(RVA = "0x53F7B0", Offset = "0x53E3B0", Length = "0x84")]
  private void OnButtonHover(MyButton btn)
  {
  }

  [Token(Token = "0x6000CDE")]
  [Address(RVA = "0x53F620", Offset = "0x53E220", Length = "0x185")]
  public void FocusWindow()
  {
  }

  [Token(Token = "0x6000CDF")]
  [Address(RVA = "0x53F370", Offset = "0x53DF70", Length = "0xD5")]
  private void DelayedButtonFocus()
  {
  }

  [Token(Token = "0x6000CE0")]
  [Address(RVA = "0x53FAC0", Offset = "0x53E6C0", Length = "0x11E")]
  public void UnfocusWindow()
  {
  }

  [Token(Token = "0x6000CE1")]
  [Address(RVA = "0x53FBE0", Offset = "0x53E7E0", Length = "0x3BD")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CE2")]
  [Address(RVA = "0x53FFA0", Offset = "0x53EBA0", Length = "0x77")]
  public Window()
  {
  }
}
