// Decompiled with JetBrains decompiler
// Type: LocalizationPreloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000D6")]
public class LocalizationPreloader : MonoBehaviour
{
  [Token(Token = "0x400072B")]
  [FieldOffset(Offset = "0x20")]
  private float startedLoadingTablesTime;
  [Token(Token = "0x400072C")]
  [FieldOffset(Offset = "0x28")]
  public List<string> tableNamesToPreload;
  [Token(Token = "0x400072D")]
  [FieldOffset(Offset = "0x30")]
  private float timeoutAtTime;
  [Token(Token = "0x400072E")]
  [FieldOffset(Offset = "0x34")]
  private bool startedLoading;

  [Token(Token = "0x600060B")]
  [Address(RVA = "0x49CFE0", Offset = "0x49BBE0", Length = "0x85")]
  private void Start()
  {
  }

  [Token(Token = "0x600060C")]
  [Address(RVA = "0x49CF70", Offset = "0x49BB70", Length = "0x67")]
  private IEnumerator LoadStringTablesCoroutine() => (IEnumerator) null;

  [Token(Token = "0x600060D")]
  [Address(RVA = "0x49D070", Offset = "0x49BC70", Length = "0x5E")]
  private void Update()
  {
  }

  [Token(Token = "0x600060E")]
  [Address(RVA = "0x49CF00", Offset = "0x49BB00", Length = "0x64")]
  private void LoadMain()
  {
  }

  [Token(Token = "0x600060F")]
  [Address(RVA = "0x49D0D0", Offset = "0x49BCD0", Length = "0x39F")]
  public LocalizationPreloader()
  {
  }
}
