// Decompiled with JetBrains decompiler
// Type: ObjectiveUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.HUD;
using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x200013B")]
public class ObjectiveUi : MonoBehaviour
{
  [Token(Token = "0x4000934")]
  [FieldOffset(Offset = "0x20")]
  public GameObject objectivePrefab;
  [Token(Token = "0x4000935")]
  [FieldOffset(Offset = "0x28")]
  private ObjectivePrefabUi currentObjective;
  [Token(Token = "0x4000936")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource a_new;
  [Token(Token = "0x4000937")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource a_complete;

  [Token(Token = "0x60007E1")]
  [Address(RVA = "0x4C07A0", Offset = "0x4BF3A0", Length = "0x31C")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007E2")]
  [Address(RVA = "0x4C0D10", Offset = "0x4BF910", Length = "0x31C")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60007E3")]
  [Address(RVA = "0x4C1110", Offset = "0x4BFD10", Length = "0x99")]
  private void Start()
  {
  }

  [Token(Token = "0x60007E4")]
  [Address(RVA = "0x4C0BC0", Offset = "0x4BF7C0", Length = "0x5D")]
  private void FirstObjective()
  {
  }

  [Token(Token = "0x60007E5")]
  [Address(RVA = "0x4C0B60", Offset = "0x4BF760", Length = "0x5D")]
  private void FinalBossObjective()
  {
  }

  [Token(Token = "0x60007E6")]
  [Address(RVA = "0x4C05C0", Offset = "0x4BF1C0", Length = "0x131")]
  public void AddObjective(string objective, bool canComplete)
  {
  }

  [Token(Token = "0x60007E7")]
  [Address(RVA = "0x4C0AC0", Offset = "0x4BF6C0", Length = "0x96")]
  public void CompleteCurrentObjective()
  {
  }

  [Token(Token = "0x60007E8")]
  [Address(RVA = "0x4C0700", Offset = "0x4BF300", Length = "0x96")]
  private IEnumerator AnimateObjective(string objective, bool canComplete) => (IEnumerator) null;

  [Token(Token = "0x60007E9")]
  [Address(RVA = "0x4C0CB0", Offset = "0x4BF8B0", Length = "0x5D")]
  private void OnBossSpawned()
  {
  }

  [Token(Token = "0x60007EA")]
  [Address(RVA = "0x4C0C20", Offset = "0x4BF820", Length = "0x8A")]
  private void OnBossDefeated(bool isOpeningPortal)
  {
  }

  [Token(Token = "0x60007EB")]
  [Address(RVA = "0x4C1030", Offset = "0x4BFC30", Length = "0xD0")]
  private void OnStageBossDied()
  {
  }

  [Token(Token = "0x60007EC")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ObjectiveUi()
  {
  }
}
