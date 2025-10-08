// Decompiled with JetBrains decompiler
// Type: EnemyInformationUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000126")]
public class EnemyInformationUi : MonoBehaviour
{
  [Token(Token = "0x40008B1")]
  [FieldOffset(Offset = "0x20")]
  public GameObject parent;
  [Token(Token = "0x40008B2")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_enemies;
  [Token(Token = "0x40008B3")]
  [FieldOffset(Offset = "0x30")]
  public RawImage i_enemies;
  [Token(Token = "0x40008B4")]
  [FieldOffset(Offset = "0x38")]
  public ScalingEntry scalingEntryHp;
  [Token(Token = "0x40008B5")]
  [FieldOffset(Offset = "0x40")]
  public ScalingEntry scalingEntryDmg;
  [Token(Token = "0x40008B6")]
  [FieldOffset(Offset = "0x48")]
  public ScalingEntry scalingEntrySpeed;
  [Token(Token = "0x40008B7")]
  [FieldOffset(Offset = "0x50")]
  private float updateInterval;
  [Token(Token = "0x40008B8")]
  [FieldOffset(Offset = "0x54")]
  private float nextUpdateTime;

  [Token(Token = "0x6000757")]
  [Address(RVA = "0x4B5BD0", Offset = "0x4B47D0", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000758")]
  [Address(RVA = "0x4B6210", Offset = "0x4B4E10", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000759")]
  [Address(RVA = "0x4B6530", Offset = "0x4B5130", Length = "0x7")]
  private void Start()
  {
  }

  [Token(Token = "0x600075A")]
  [Address(RVA = "0x4B6360", Offset = "0x4B4F60", Length = "0x57")]
  private void OnSettingUpdate(string name, object oldVal, object newVal)
  {
  }

  [Token(Token = "0x600075B")]
  [Address(RVA = "0x4B63C0", Offset = "0x4B4FC0", Length = "0x164")]
  private void Refresh()
  {
  }

  [Token(Token = "0x600075C")]
  [Address(RVA = "0x4B5D20", Offset = "0x4B4920", Length = "0x4EF")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x600075D")]
  [Address(RVA = "0x4B6540", Offset = "0x4B5140", Length = "0xE")]
  public EnemyInformationUi()
  {
  }
}
