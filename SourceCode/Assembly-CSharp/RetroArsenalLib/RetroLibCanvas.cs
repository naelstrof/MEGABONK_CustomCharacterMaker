// Decompiled with JetBrains decompiler
// Type: RetroArsenalLib.RetroLibCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace RetroArsenalLib
{
  [Token(Token = "0x2000457")]
  public class RetroLibCanvas : MonoBehaviour
  {
    [Token(Token = "0x4001C85")]
    public static RetroLibCanvas GlobalAccess;
    [Token(Token = "0x4001C86")]
    [FieldOffset(Offset = "0x20")]
    public bool MouseOverButton;
    [Token(Token = "0x4001C87")]
    [FieldOffset(Offset = "0x28")]
    public Text PENameText;
    [Token(Token = "0x4001C88")]
    [FieldOffset(Offset = "0x30")]
    public Text ToolTipText;
    [Token(Token = "0x4001C89")]
    [FieldOffset(Offset = "0x38")]
    private RaycastHit rayHit;

    [Token(Token = "0x6001F59")]
    [Address(RVA = "0x4515B0", Offset = "0x4501B0", Length = "0x51")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001F5A")]
    [Address(RVA = "0x4519E0", Offset = "0x4505E0", Length = "0xC1")]
    private void Start()
    {
    }

    [Token(Token = "0x6001F5B")]
    [Address(RVA = "0x451BD0", Offset = "0x4507D0", Length = "0x179")]
    private void Update()
    {
    }

    [Token(Token = "0x6001F5C")]
    [Address(RVA = "0x451B40", Offset = "0x450740", Length = "0x8C")]
    public void UpdateToolTip(string toolTipText)
    {
    }

    [Token(Token = "0x6001F5D")]
    [Address(RVA = "0x451610", Offset = "0x450210", Length = "0x8F")]
    public void ClearToolTip()
    {
    }

    [Token(Token = "0x6001F5E")]
    [Address(RVA = "0x4517A0", Offset = "0x4503A0", Length = "0x100")]
    private void SelectPreviousPE()
    {
    }

    [Token(Token = "0x6001F5F")]
    [Address(RVA = "0x4516A0", Offset = "0x4502A0", Length = "0xFB")]
    private void SelectNextPE()
    {
    }

    [Token(Token = "0x6001F60")]
    [Address(RVA = "0x4518B0", Offset = "0x4504B0", Length = "0x12E")]
    private void SpawnCurrentParticleEffect()
    {
    }

    [Token(Token = "0x6001F61")]
    [Address(RVA = "0x451AB0", Offset = "0x4506B0", Length = "0x8D")]
    public void UIButtonClick(string buttonTypeClicked)
    {
    }

    [Token(Token = "0x6001F62")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public RetroLibCanvas()
    {
    }
  }
}
