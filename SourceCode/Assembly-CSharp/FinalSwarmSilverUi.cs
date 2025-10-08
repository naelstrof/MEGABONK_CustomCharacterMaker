// Decompiled with JetBrains decompiler
// Type: FinalSwarmSilverUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200012B")]
public class FinalSwarmSilverUi : MonoBehaviour
{
  [Token(Token = "0x40008CE")]
  [FieldOffset(Offset = "0x20")]
  public Transform coin;
  [Token(Token = "0x40008CF")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_silverMultiplier;
  [Token(Token = "0x40008D0")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_difficulty;
  [Token(Token = "0x40008D1")]
  [FieldOffset(Offset = "0x38")]
  public RawImage progressBar;
  [Token(Token = "0x40008D2")]
  [FieldOffset(Offset = "0x40")]
  public Image outlineGlow;
  [Token(Token = "0x40008D3")]
  [FieldOffset(Offset = "0x48")]
  private Material outlineGlowMat;
  [Token(Token = "0x40008D4")]
  [FieldOffset(Offset = "0x50")]
  private string modifierName;
  [Token(Token = "0x40008D5")]
  [FieldOffset(Offset = "0x58")]
  public GameObject contentParent;
  [Token(Token = "0x40008D6")]
  [FieldOffset(Offset = "0x60")]
  private float maxTime;
  [Token(Token = "0x40008D7")]
  [FieldOffset(Offset = "0x64")]
  private float maxMultiplier;
  [Token(Token = "0x40008D8")]
  [FieldOffset(Offset = "0x68")]
  private float lastMultiplier;
  [Token(Token = "0x40008D9")]
  [FieldOffset(Offset = "0x6C")]
  private float nextCheckTime;
  [Token(Token = "0x40008DA")]
  [FieldOffset(Offset = "0x70")]
  private float checkInterval;
  [Token(Token = "0x40008DB")]
  [FieldOffset(Offset = "0x78")]
  public Gradient colorGradient;
  [Token(Token = "0x40008DC")]
  [FieldOffset(Offset = "0x80")]
  public float testTime;

  [Token(Token = "0x6000777")]
  [Address(RVA = "0x4B6AF0", Offset = "0x4B56F0", Length = "0x27C")]
  private void Start()
  {
  }

  [Token(Token = "0x6000778")]
  [Address(RVA = "0x4B6740", Offset = "0x4B5340", Length = "0x245")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000779")]
  [Address(RVA = "0x4B6A30", Offset = "0x4B5630", Length = "0xB1")]
  private void RemoveSilverMultiplier()
  {
  }

  [Token(Token = "0x600077A")]
  [Address(RVA = "0x4B6990", Offset = "0x4B5590", Length = "0x8A")]
  private void OnFinalSwarmStarted()
  {
  }

  [Token(Token = "0x600077B")]
  [Address(RVA = "0x4B7360", Offset = "0x4B5F60", Length = "0x305")]
  private void Update()
  {
  }

  [Token(Token = "0x600077C")]
  [Address(RVA = "0x4B6D70", Offset = "0x4B5970", Length = "0x5EA")]
  private void UpdateMultiplier()
  {
  }

  [Token(Token = "0x600077D")]
  [Address(RVA = "0x4B6550", Offset = "0x4B5150", Length = "0x33")]
  private Color GetColor(float lerpValue) => new Color();

  [Token(Token = "0x600077E")]
  [Address(RVA = "0x4B6670", Offset = "0x4B5270", Length = "0x50")]
  private float GetSwarmTime() => 0.0f;

  [Token(Token = "0x600077F")]
  [Address(RVA = "0x4B66C0", Offset = "0x4B52C0", Length = "0x7C")]
  private float GetTimerLerp() => 0.0f;

  [Token(Token = "0x6000780")]
  [Address(RVA = "0x4B6590", Offset = "0x4B5190", Length = "0xDD")]
  private string GetDifficultyText(float lerpValue) => (string) null;

  [Token(Token = "0x6000781")]
  [Address(RVA = "0x4B6A20", Offset = "0x4B5620", Length = "0x7")]
  private void OnPlayerInventoryInitialized(PlayerInventory pInv)
  {
  }

  [Token(Token = "0x6000782")]
  [Address(RVA = "0x4B7670", Offset = "0x4B6270", Length = "0x64")]
  public FinalSwarmSilverUi()
  {
  }
}
