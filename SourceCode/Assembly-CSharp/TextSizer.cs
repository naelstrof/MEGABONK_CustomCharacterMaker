// Decompiled with JetBrains decompiler
// Type: TextSizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x2000201")]
public class TextSizer : MonoBehaviour
{
  [Token(Token = "0x4000E16")]
  [FieldOffset(Offset = "0x20")]
  public TMP_Text Text;
  [Token(Token = "0x4000E17")]
  [FieldOffset(Offset = "0x28")]
  public bool ResizeTextObject;
  [Token(Token = "0x4000E18")]
  [FieldOffset(Offset = "0x2C")]
  public Vector2 Padding;
  [Token(Token = "0x4000E19")]
  [FieldOffset(Offset = "0x34")]
  public Vector2 MaxSize;
  [Token(Token = "0x4000E1A")]
  [FieldOffset(Offset = "0x3C")]
  public Vector2 MinSize;
  [Token(Token = "0x4000E1B")]
  [FieldOffset(Offset = "0x44")]
  public TextSizer.Mode ControlAxes;
  [Token(Token = "0x4000E1C")]
  [FieldOffset(Offset = "0x48")]
  private string _lastText;
  [Token(Token = "0x4000E1D")]
  [FieldOffset(Offset = "0x50")]
  private TextSizer.Mode _lastControlAxes;
  [Token(Token = "0x4000E1E")]
  [FieldOffset(Offset = "0x54")]
  private Vector2 _lastSize;
  [Token(Token = "0x4000E1F")]
  [FieldOffset(Offset = "0x5C")]
  private bool _forceRefresh;
  [Token(Token = "0x4000E20")]
  [FieldOffset(Offset = "0x5D")]
  private bool _isTextNull;
  [Token(Token = "0x4000E21")]
  [FieldOffset(Offset = "0x60")]
  private RectTransform _textRectTransform;
  [Token(Token = "0x4000E22")]
  [FieldOffset(Offset = "0x68")]
  private RectTransform _selfRectTransform;

  [Token(Token = "0x1700007C")]
  protected virtual float MinX
  {
    [Token(Token = "0x6000D2C"), Address(RVA = "0x530D60", Offset = "0x52F960", Length = "0x45")] get => 0.0f;
  }

  [Token(Token = "0x1700007D")]
  protected virtual float MinY
  {
    [Token(Token = "0x6000D2D"), Address(RVA = "0x530DB0", Offset = "0x52F9B0", Length = "0x45")] get => 0.0f;
  }

  [Token(Token = "0x1700007E")]
  protected virtual float MaxX
  {
    [Token(Token = "0x6000D2E"), Address(RVA = "0x530CC0", Offset = "0x52F8C0", Length = "0x45")] get => 0.0f;
  }

  [Token(Token = "0x1700007F")]
  protected virtual float MaxY
  {
    [Token(Token = "0x6000D2F"), Address(RVA = "0x530D10", Offset = "0x52F910", Length = "0x45")] get => 0.0f;
  }

  [Token(Token = "0x6000D30")]
  [Address(RVA = "0x5308D0", Offset = "0x52F4D0", Length = "0x11")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D31")]
  [Address(RVA = "0x530C80", Offset = "0x52F880", Length = "0x7")]
  protected virtual void Update()
  {
  }

  [Token(Token = "0x6000D32")]
  [Address(RVA = "0x5308F0", Offset = "0x52F4F0", Length = "0x2B5")]
  public void Recalculate()
  {
  }

  [Token(Token = "0x6000D33")]
  [Address(RVA = "0x530BB0", Offset = "0x52F7B0", Length = "0xC4")]
  public virtual void Refresh()
  {
  }

  [Token(Token = "0x6000D34")]
  [Address(RVA = "0x5308D0", Offset = "0x52F4D0", Length = "0x11")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000D35")]
  [Address(RVA = "0x530C90", Offset = "0x52F890", Length = "0x24")]
  public TextSizer()
  {
  }

  [Flags]
  [Token(Token = "0x2000202")]
  public enum Mode
  {
    [Token(Token = "0x4000E24")] None = 0,
    [Token(Token = "0x4000E25")] Horizontal = 1,
    [Token(Token = "0x4000E26")] Vertical = 2,
    [Token(Token = "0x4000E27")] Both = Vertical | Horizontal, // 0x00000003
  }
}
