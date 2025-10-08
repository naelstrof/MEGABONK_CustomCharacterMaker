// Decompiled with JetBrains decompiler
// Type: DynamicWindows
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000129")]
public class DynamicWindows : MonoBehaviour
{
  [Token(Token = "0x40008C0")]
  [FieldOffset(Offset = "0x20")]
  public Transform contentParent;
  [Token(Token = "0x40008C1")]
  [FieldOffset(Offset = "0x28")]
  public Transform overlay;
  [Token(Token = "0x40008C2")]
  [FieldOffset(Offset = "0x30")]
  public GameObject dynamicWindowPrefab;
  [Token(Token = "0x40008C3")]
  [FieldOffset(Offset = "0x38")]
  public GameObject dynamicWindowPromptPrefab;

  [Token(Token = "0x6000764")]
  [Address(RVA = "0x4B5370", Offset = "0x4B3F70", Length = "0x8E")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000765")]
  [Address(RVA = "0x4B55C0", Offset = "0x4B41C0", Length = "0x8E")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000766")]
  [Address(RVA = "0x4B5700", Offset = "0x4B4300", Length = "0xD8")]
  private void Update()
  {
  }

  [Token(Token = "0x6000767")]
  [Address(RVA = "0x4B5650", Offset = "0x4B4250", Length = "0xA7")]
  private void OnNewSceneLoaded(Scene scene, LoadSceneMode mode)
  {
  }

  [Token(Token = "0x6000768")]
  [Address(RVA = "0x4B54E0", Offset = "0x4B40E0", Length = "0xDD")]
  public void NewWindow(string header, string content)
  {
  }

  [Token(Token = "0x6000769")]
  [Address(RVA = "0x4B5400", Offset = "0x4B4000", Length = "0xDB")]
  public void NewWindowPrompt(string header, string content, Action A_Accept)
  {
  }

  [Token(Token = "0x600076A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DynamicWindows()
  {
  }
}
