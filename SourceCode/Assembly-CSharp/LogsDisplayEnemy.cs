// Decompiled with JetBrains decompiler
// Type: LogsDisplayEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001AA")]
public class LogsDisplayEnemy : MonoBehaviour
{
  [Token(Token = "0x4000C04")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_enemyName;
  [Token(Token = "0x4000C05")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_enemyDescription;
  [Token(Token = "0x4000C06")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_enemyStats;
  [Token(Token = "0x4000C07")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_enemyMaps;
  [Token(Token = "0x4000C08")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_killsCounter;
  [Token(Token = "0x4000C09")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_challengeCounter;
  [Token(Token = "0x4000C0A")]
  [FieldOffset(Offset = "0x50")]
  public TextMeshProUGUI t_reward;
  [Token(Token = "0x4000C0B")]
  [FieldOffset(Offset = "0x58")]
  public RawImage enemyRenderer;
  [Token(Token = "0x4000C0C")]
  [FieldOffset(Offset = "0x60")]
  public RawImage barProgress;
  [Token(Token = "0x4000C0D")]
  [FieldOffset(Offset = "0x68")]
  public RawImage i_rewardCoin;
  [Token(Token = "0x4000C0E")]
  [FieldOffset(Offset = "0x70")]
  public List<RawImage> challengeProgress;
  [Token(Token = "0x4000C0F")]
  [FieldOffset(Offset = "0x78")]
  public Color dotColorIncomplete;
  [Token(Token = "0x4000C10")]
  [FieldOffset(Offset = "0x88")]
  public Color dotColorComplete;
  [Token(Token = "0x4000C11")]
  [FieldOffset(Offset = "0x98")]
  public Material rainbow;
  [Token(Token = "0x4000C12")]
  [FieldOffset(Offset = "0xA0")]
  public Texture unknownTexture;
  [Token(Token = "0x4000C13")]
  [FieldOffset(Offset = "0xA8")]
  public Texture renderTexture;
  [Token(Token = "0x4000C14")]
  [FieldOffset(Offset = "0xB0")]
  private EEnemy eEnemy;

  [Token(Token = "0x6000ABA")]
  [Address(RVA = "0x4F38A0", Offset = "0x4F24A0", Length = "0x217")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000ABB")]
  [Address(RVA = "0x4F3AD0", Offset = "0x4F26D0", Length = "0x217")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000ABC")]
  [Address(RVA = "0x4F3AC0", Offset = "0x4F26C0", Length = "0xE")]
  private void OnClaimedReward()
  {
  }

  [Token(Token = "0x6000ABD")]
  [Address(RVA = "0x4F3CF0", Offset = "0x4F28F0", Length = "0x70F")]
  public void SetEnemy(EEnemy eEnemy)
  {
  }

  [Token(Token = "0x6000ABE")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LogsDisplayEnemy()
  {
  }
}
