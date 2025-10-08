// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.Mouse.ToolTipsText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI.Mouse
{
  [Token(Token = "0x20002EE")]
  public class ToolTipsText : MonoBehaviour
  {
    [Token(Token = "0x4001418")]
    [FieldOffset(Offset = "0x20")]
    private TMP_Text tmpTextBox;
    [Token(Token = "0x4001419")]
    [FieldOffset(Offset = "0x28")]
    private Canvas canvas;
    [Token(Token = "0x400141A")]
    [FieldOffset(Offset = "0x30")]
    private UnityEngine.Camera camera;
    [Token(Token = "0x400141B")]
    [FieldOffset(Offset = "0x38")]
    private RectTransform textBoxRectTransform;
    [Token(Token = "0x400141C")]
    [FieldOffset(Offset = "0x40")]
    private int currentlyActiveLinkedElement;
    [Token(Token = "0x400141F")]
    public static Action<string, Vector2> A_OpenTooltip;
    [Token(Token = "0x4001420")]
    public static Action<string> A_CloseTooltip;
    [Token(Token = "0x4001421")]
    [FieldOffset(Offset = "0x44")]
    private float readyTime;
    [Token(Token = "0x4001422")]
    [FieldOffset(Offset = "0x48")]
    private Vector3 lastPos;
    [Token(Token = "0x4001423")]
    [FieldOffset(Offset = "0x54")]
    private bool hasVisibleMouse;

    [Token(Token = "0x14000006")]
    public static event ToolTipsText.HoverOnLinkEvent OnHoverOnLinkEvent
    {
      [Token(Token = "0x600154C"), Address(RVA = "0x3C0730", Offset = "0x3BF330", Length = "0xB4")] add
      {
      }
      [Token(Token = "0x600154D"), Address(RVA = "0x3C08B0", Offset = "0x3BF4B0", Length = "0xB4")] remove
      {
      }
    }

    [Token(Token = "0x14000007")]
    public static event ToolTipsText.CloseTooltipEvent OnCloseTooltipEvent
    {
      [Token(Token = "0x600154E"), Address(RVA = "0x3C0670", Offset = "0x3BF270", Length = "0xB8")] add
      {
      }
      [Token(Token = "0x600154F"), Address(RVA = "0x3C07F0", Offset = "0x3BF3F0", Length = "0xB8")] remove
      {
      }
    }

    [Token(Token = "0x6001550")]
    [Address(RVA = "0x3BFDB0", Offset = "0x3BE9B0", Length = "0xF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001551")]
    [Address(RVA = "0x3C05C0", Offset = "0x3BF1C0", Length = "0x23")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6001552")]
    [Address(RVA = "0x3C05F0", Offset = "0x3BF1F0", Length = "0x6B")]
    private void Update()
    {
    }

    [Token(Token = "0x6001553")]
    [Address(RVA = "0x3BFEB0", Offset = "0x3BEAB0", Length = "0x38A")]
    private void CheckForLinkAtMousePosition()
    {
    }

    [Token(Token = "0x6001554")]
    [Address(RVA = "0x3C0240", Offset = "0x3BEE40", Length = "0x2C0")]
    private Vector3 GetLinkPosition(TMP_LinkInfo linkInfo, float verticalOffset = 10f) => new Vector3();

    [Token(Token = "0x6001555")]
    [Address(RVA = "0x3C0510", Offset = "0x3BF110", Length = "0xAC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6001556")]
    [Address(RVA = "0x3C0660", Offset = "0x3BF260", Length = "0xE")]
    public ToolTipsText()
    {
    }

    [Token(Token = "0x20002EF")]
    public delegate void HoverOnLinkEvent(string keyword, Vector3 mousePos);

    [Token(Token = "0x20002F0")]
    public delegate void CloseTooltipEvent();
  }
}
