// Decompiled with JetBrains decompiler
// Type: StatContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000190")]
public class StatContainer : MonoBehaviour
{
  [Token(Token = "0x4000B70")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_stat;
  [Token(Token = "0x4000B71")]
  [FieldOffset(Offset = "0x28")]
  public RawImage bar;
  [Token(Token = "0x4000B72")]
  [FieldOffset(Offset = "0x30")]
  private float value;

  [Token(Token = "0x6000A24")]
  [Address(RVA = "0x4FD320", Offset = "0x4FBF20", Length = "0x100")]
  public void SetStat(EStatCategory statCategory, float value)
  {
  }

  [Token(Token = "0x6000A25")]
  [Address(RVA = "0x4FD430", Offset = "0x4FC030", Length = "0x11E")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A26")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public StatContainer()
  {
  }
}
