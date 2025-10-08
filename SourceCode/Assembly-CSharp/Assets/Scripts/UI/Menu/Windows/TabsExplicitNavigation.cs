// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.Menu.Windows.TabsExplicitNavigation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Menu.Windows
{
  [Token(Token = "0x20002F1")]
  public class TabsExplicitNavigation : MonoBehaviour
  {
    [Token(Token = "0x4001424")]
    [FieldOffset(Offset = "0x20")]
    public Selectable topButton;
    [Token(Token = "0x4001425")]
    [FieldOffset(Offset = "0x28")]
    public Selectable[] bottomButtons;
    [Token(Token = "0x4001426")]
    [FieldOffset(Offset = "0x30")]
    public Transform content;
    [Token(Token = "0x4001427")]
    [FieldOffset(Offset = "0x38")]
    public bool manualRefresh;

    [Token(Token = "0x600155F")]
    [Address(RVA = "0x3BFDA0", Offset = "0x3BE9A0", Length = "0xE")]
    private void Start()
    {
    }

    [Token(Token = "0x6001560")]
    [Address(RVA = "0x3BF600", Offset = "0x3BE200", Length = "0x639")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6001561")]
    [Address(RVA = "0x3BFC40", Offset = "0x3BE840", Length = "0x15D")]
    private void SetNavigation(
      Selectable parent,
      Selectable toButton,
      TabsExplicitNavigation.NavDirection direction)
    {
    }

    [Token(Token = "0x6001562")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public TabsExplicitNavigation()
    {
    }

    [Token(Token = "0x20002F2")]
    private enum NavDirection
    {
      [Token(Token = "0x4001429")] Up,
      [Token(Token = "0x400142A")] Down,
      [Token(Token = "0x400142B")] Left,
      [Token(Token = "0x400142C")] Right,
    }
  }
}
