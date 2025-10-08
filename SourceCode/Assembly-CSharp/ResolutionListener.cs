// Decompiled with JetBrains decompiler
// Type: ResolutionListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001D4")]
public class ResolutionListener : MonoBehaviour
{
  [Token(Token = "0x4000D29")]
  [FieldOffset(Offset = "0x20")]
  private float timeout;
  [Token(Token = "0x4000D2A")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI timerText;
  [Token(Token = "0x4000D2B")]
  [FieldOffset(Offset = "0x30")]
  private Action<int> revertAction;
  [Token(Token = "0x4000D2C")]
  [FieldOffset(Offset = "0x38")]
  private Action<int> acceptAction;
  [Token(Token = "0x4000D2D")]
  [FieldOffset(Offset = "0x40")]
  private int oldValue;
  [Token(Token = "0x4000D2E")]
  [FieldOffset(Offset = "0x44")]
  private int newValue;
  [Token(Token = "0x4000D2F")]
  [FieldOffset(Offset = "0x48")]
  public GameObject content;
  [Token(Token = "0x4000D30")]
  public static ResolutionListener Instance;

  [Token(Token = "0x6000C08")]
  [Address(RVA = "0x511590", Offset = "0x510190", Length = "0xD3")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000C09")]
  [Address(RVA = "0x511690", Offset = "0x510290", Length = "0x8F")]
  public void NewResolution(
    int newResolution,
    int oldResolution,
    Action<int> revert,
    Action<int> accept)
  {
  }

  [Token(Token = "0x6000C0A")]
  [Address(RVA = "0x511810", Offset = "0x510410", Length = "0x1BE")]
  private void Update()
  {
  }

  [Token(Token = "0x6000C0B")]
  [Address(RVA = "0x511720", Offset = "0x510320", Length = "0xE0")]
  public void Response(bool r)
  {
  }

  [Token(Token = "0x6000C0C")]
  [Address(RVA = "0x511670", Offset = "0x510270", Length = "0x1D")]
  private bool IsActive() => false;

  [Token(Token = "0x6000C0D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ResolutionListener()
  {
  }
}
