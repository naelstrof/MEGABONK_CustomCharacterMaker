// Decompiled with JetBrains decompiler
// Type: SelectionArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001C2")]
public class SelectionArrow : MonoBehaviour
{
  [Token(Token = "0x4000CC2")]
  [FieldOffset(Offset = "0x20")]
  public RectTransform rectTransform;
  [Token(Token = "0x4000CC3")]
  [FieldOffset(Offset = "0x28")]
  private RectTransform selectedRect;
  [Token(Token = "0x4000CC4")]
  [FieldOffset(Offset = "0x30")]
  public Image renderer;
  [Token(Token = "0x4000CC5")]
  [FieldOffset(Offset = "0x38")]
  public RectTransform mask;
  [Token(Token = "0x4000CC6")]
  [FieldOffset(Offset = "0x40")]
  private Transform defaultParent;
  [Token(Token = "0x4000CC7")]
  public static SelectionArrow Instance;
  [Token(Token = "0x4000CC8")]
  [FieldOffset(Offset = "0x48")]
  public float sizeOffset;
  [Token(Token = "0x4000CC9")]
  [FieldOffset(Offset = "0x4C")]
  private Vector2 newSize;
  [Token(Token = "0x4000CCA")]
  [FieldOffset(Offset = "0x54")]
  private float fps;
  [Token(Token = "0x4000CCB")]
  [FieldOffset(Offset = "0x58")]
  private float nextUpdateTime;

  [Token(Token = "0x6000B5E")]
  [Address(RVA = "0x5119D0", Offset = "0x5105D0", Length = "0x43E")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B5F")]
  [Address(RVA = "0x5126E0", Offset = "0x5112E0", Length = "0x44")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B60")]
  [Address(RVA = "0x511F00", Offset = "0x510B00", Length = "0x8C")]
  private void FirstSelection()
  {
  }

  [Token(Token = "0x6000B61")]
  [Address(RVA = "0x512370", Offset = "0x510F70", Length = "0x353")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B62")]
  [Address(RVA = "0x511FC0", Offset = "0x510BC0", Length = "0x2F6")]
  private void OnButtonHover(MyButton btn)
  {
  }

  [Token(Token = "0x6000B63")]
  [Address(RVA = "0x5122C0", Offset = "0x510EC0", Length = "0xA8")]
  private void OnButtonHover(RectTransform button)
  {
  }

  [Token(Token = "0x6000B64")]
  [Address(RVA = "0x512730", Offset = "0x511330", Length = "0x15A")]
  private void UpdatePosition()
  {
  }

  [Token(Token = "0x6000B65")]
  [Address(RVA = "0x512890", Offset = "0x511490", Length = "0x143")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B66")]
  [Address(RVA = "0x511E10", Offset = "0x510A10", Length = "0xE9")]
  private void CheckVisibility()
  {
  }

  [Token(Token = "0x6000B67")]
  [Address(RVA = "0x5126D0", Offset = "0x5112D0", Length = "0xC")]
  public void Refresh()
  {
  }

  [Token(Token = "0x6000B68")]
  [Address(RVA = "0x511F90", Offset = "0x510B90", Length = "0x2B")]
  public void Hide()
  {
  }

  [Token(Token = "0x6000B69")]
  [Address(RVA = "0x5126D0", Offset = "0x5112D0", Length = "0xC")]
  private void OnResolutionChanged(int i)
  {
  }

  [Token(Token = "0x6000B6A")]
  [Address(RVA = "0x5126D0", Offset = "0x5112D0", Length = "0xC")]
  private void OnWindowOpened(Window window)
  {
  }

  [Token(Token = "0x6000B6B")]
  [Address(RVA = "0x5129E0", Offset = "0x5115E0", Length = "0x15")]
  public SelectionArrow()
  {
  }
}
