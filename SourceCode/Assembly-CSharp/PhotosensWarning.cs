// Decompiled with JetBrains decompiler
// Type: PhotosensWarning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000120")]
public class PhotosensWarning : MonoBehaviour
{
  [Token(Token = "0x4000891")]
  [FieldOffset(Offset = "0x20")]
  public GameObject window;
  [Token(Token = "0x4000892")]
  [FieldOffset(Offset = "0x28")]
  public CanvasGroup cg;
  [Token(Token = "0x4000893")]
  [FieldOffset(Offset = "0x30")]
  public MyButton btn;

  [Token(Token = "0x6000738")]
  [Address(RVA = "0x4C1620", Offset = "0x4C0220", Length = "0x168")]
  private void Start()
  {
  }

  [Token(Token = "0x6000739")]
  [Address(RVA = "0x4C1270", Offset = "0x4BFE70", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600073A")]
  [Address(RVA = "0x4C13B0", Offset = "0x4BFFB0", Length = "0x1FB")]
  private void OnSavesLoaded()
  {
  }

  [Token(Token = "0x600073B")]
  [Address(RVA = "0x4C15B0", Offset = "0x4C01B0", Length = "0x67")]
  private IEnumerator ShowWarning() => (IEnumerator) null;

  [Token(Token = "0x600073C")]
  [Address(RVA = "0x4C11B0", Offset = "0x4BFDB0", Length = "0xB5")]
  public void Confirm()
  {
  }

  [Token(Token = "0x600073D")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PhotosensWarning()
  {
  }
}
