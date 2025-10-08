// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.HUD.ObjectivePrefabUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.HUD
{
  [Token(Token = "0x20002FF")]
  public class ObjectivePrefabUi : MonoBehaviour
  {
    [Token(Token = "0x400145E")]
    [FieldOffset(Offset = "0x20")]
    public GameObject checkBox;
    [Token(Token = "0x400145F")]
    [FieldOffset(Offset = "0x28")]
    public GameObject checkMark;
    [Token(Token = "0x4001460")]
    [FieldOffset(Offset = "0x30")]
    public TextMeshProUGUI t_objective;
    [Token(Token = "0x4001461")]
    [FieldOffset(Offset = "0x38")]
    public LayoutGroup content;
    [Token(Token = "0x4001462")]
    [FieldOffset(Offset = "0x40")]
    public TextSizer textSizer;
    [Token(Token = "0x4001463")]
    [FieldOffset(Offset = "0x48")]
    public RawImage overlay;
    [Token(Token = "0x4001464")]
    [FieldOffset(Offset = "0x50")]
    private float padding;
    [Token(Token = "0x4001465")]
    [FieldOffset(Offset = "0x54")]
    private int paddingWidth;
    [Token(Token = "0x4001466")]
    [FieldOffset(Offset = "0x58")]
    private float slideTime;
    [Token(Token = "0x4001467")]
    [FieldOffset(Offset = "0x5C")]
    private float timer;
    [Token(Token = "0x4001468")]
    [FieldOffset(Offset = "0x60")]
    private bool completed;
    [Token(Token = "0x4001469")]
    [FieldOffset(Offset = "0x64")]
    private Color completedColor;

    [Token(Token = "0x60015A6")]
    [Address(RVA = "0x3B2C90", Offset = "0x3B1890", Length = "0x116")]
    public void Set(string t, bool showCheckmark)
    {
    }

    [Token(Token = "0x60015A7")]
    [Address(RVA = "0x3B2DB0", Offset = "0x3B19B0", Length = "0x73D")]
    private void Update()
    {
    }

    [Token(Token = "0x60015A8")]
    [Address(RVA = "0x3B2A70", Offset = "0x3B1670", Length = "0x212")]
    private void Rebuild()
    {
    }

    [Token(Token = "0x60015A9")]
    [Address(RVA = "0x3B2990", Offset = "0x3B1590", Length = "0xD5")]
    public void Complete()
    {
    }

    [Token(Token = "0x60015AA")]
    [Address(RVA = "0x3B34F0", Offset = "0x3B20F0", Length = "0x70")]
    public ObjectivePrefabUi()
    {
    }
  }
}
