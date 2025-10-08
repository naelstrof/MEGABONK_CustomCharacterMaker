// Decompiled with JetBrains decompiler
// Type: LogsUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.UI.Menu.Windows;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001AB")]
public class LogsUi : MonoBehaviour
{
  [Token(Token = "0x4000C15")]
  [FieldOffset(Offset = "0x20")]
  public RectTransform content;
  [Token(Token = "0x4000C16")]
  [FieldOffset(Offset = "0x28")]
  public RectTransform entryPrefab;
  [Token(Token = "0x4000C17")]
  [FieldOffset(Offset = "0x30")]
  private List<MyButtonLog> logEntries;
  [Token(Token = "0x4000C18")]
  [FieldOffset(Offset = "0x38")]
  private int page;
  [Token(Token = "0x4000C19")]
  [FieldOffset(Offset = "0x3C")]
  private int maxPages;
  [Token(Token = "0x4000C1A")]
  [FieldOffset(Offset = "0x40")]
  private int entriesPerPage;
  [Token(Token = "0x4000C1B")]
  [FieldOffset(Offset = "0x48")]
  private List<EEnemy> enemies;
  [Token(Token = "0x4000C1C")]
  [FieldOffset(Offset = "0x50")]
  public TextMeshProUGUI t_pages;
  [Token(Token = "0x4000C1D")]
  [FieldOffset(Offset = "0x58")]
  public TextMeshProUGUI t_title;
  [Token(Token = "0x4000C1E")]
  [FieldOffset(Offset = "0x60")]
  public TabsExplicitNavigation entryNavigation;
  [Token(Token = "0x4000C1F")]
  [FieldOffset(Offset = "0x68")]
  private bool hasRefreshed;
  [Token(Token = "0x4000C20")]
  [FieldOffset(Offset = "0x70")]
  public LogsDisplayEnemy logDisplay;

  [Token(Token = "0x6000ABF")]
  [Address(RVA = "0x4F4410", Offset = "0x4F3010", Length = "0xDA")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000AC0")]
  [Address(RVA = "0x4F44F0", Offset = "0x4F30F0", Length = "0x5")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000AC1")]
  [Address(RVA = "0x4F4800", Offset = "0x4F3400", Length = "0x3E5")]
  private void TryInit()
  {
  }

  [Token(Token = "0x6000AC2")]
  [Address(RVA = "0x4F4730", Offset = "0x4F3330", Length = "0xCB")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000AC3")]
  [Address(RVA = "0x4F4500", Offset = "0x4F3100", Length = "0x22C")]
  private void OpenPage(int page, bool force = false)
  {
  }

  [Token(Token = "0x6000AC4")]
  [Address(RVA = "0x4F4400", Offset = "0x4F3000", Length = "0xE")]
  public void FlipPage(int direction)
  {
  }

  [Token(Token = "0x6000AC5")]
  [Address(RVA = "0x4F4BF0", Offset = "0x4F37F0", Length = "0xAD")]
  private void UpdatePageText()
  {
  }

  [Token(Token = "0x6000AC6")]
  [Address(RVA = "0x4F4CA0", Offset = "0x4F38A0", Length = "0x85")]
  public LogsUi()
  {
  }
}
