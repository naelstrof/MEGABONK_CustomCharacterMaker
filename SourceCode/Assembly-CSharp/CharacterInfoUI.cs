// Decompiled with JetBrains decompiler
// Type: CharacterInfoUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000185")]
public class CharacterInfoUI : MonoBehaviour
{
  [Token(Token = "0x4000B28")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000B29")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000B2A")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_weaponName;
  [Token(Token = "0x4000B2B")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_weaponDesc;
  [Token(Token = "0x4000B2C")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_passiveName;
  [Token(Token = "0x4000B2D")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_passiveDesc;
  [Token(Token = "0x4000B2E")]
  [FieldOffset(Offset = "0x50")]
  public RawImage i_weapon;
  [Token(Token = "0x4000B2F")]
  [FieldOffset(Offset = "0x58")]
  public RawImage i_passive;
  [Token(Token = "0x4000B30")]
  [FieldOffset(Offset = "0x60")]
  public SkinSelection skinSelection;
  [Token(Token = "0x4000B31")]
  [FieldOffset(Offset = "0x68")]
  public RequirementsContainer reqContainer;
  [Header("Ranks and runs")]
  [Token(Token = "0x4000B32")]
  [FieldOffset(Offset = "0x70")]
  public TextMeshProUGUI t_rank;
  [Token(Token = "0x4000B33")]
  [FieldOffset(Offset = "0x78")]
  public TextMeshProUGUI t_runs;
  [Token(Token = "0x4000B34")]
  [FieldOffset(Offset = "0x80")]
  public RawImage i_rankFrame;
  [Token(Token = "0x4000B35")]
  [FieldOffset(Offset = "0x88")]
  public RawImage i_rankIcon;
  [Token(Token = "0x4000B36")]
  [FieldOffset(Offset = "0x90")]
  public RawImage progressBar;
  [Token(Token = "0x4000B37")]
  [FieldOffset(Offset = "0x98")]
  public RawImage i_character;
  [Token(Token = "0x4000B38")]
  [FieldOffset(Offset = "0xA0")]
  public RawImage i_runs;
  [Token(Token = "0x4000B39")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject star;

  [Token(Token = "0x60009CA")]
  [Address(RVA = "0x4CD110", Offset = "0x4CBD10", Length = "0x128")]
  private void Awake()
  {
  }

  [Token(Token = "0x60009CB")]
  [Address(RVA = "0x4CDF70", Offset = "0x4CCB70", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60009CC")]
  [Address(RVA = "0x4CD240", Offset = "0x4CBE40", Length = "0xD25")]
  private void OnCharacterSelected(MyButtonCharacter btn)
  {
  }

  [Token(Token = "0x60009CD")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CharacterInfoUI()
  {
  }
}
