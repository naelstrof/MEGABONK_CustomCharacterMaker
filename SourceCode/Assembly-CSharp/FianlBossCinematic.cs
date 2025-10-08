// Decompiled with JetBrains decompiler
// Type: FianlBossCinematic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using MilkShake;
using System.Collections;
using UnityEngine;

[Token(Token = "0x200006E")]
public class FianlBossCinematic : MonoBehaviour
{
  [Token(Token = "0x400035A")]
  [FieldOffset(Offset = "0x20")]
  public bool skipIntro;
  [Token(Token = "0x400035B")]
  [FieldOffset(Offset = "0x28")]
  public MapGenerationFinalBoss mapGeneration;
  [Token(Token = "0x400035C")]
  [FieldOffset(Offset = "0x30")]
  public Transform cameraCircling;
  [Token(Token = "0x400035D")]
  [FieldOffset(Offset = "0x38")]
  public Camera cameraCirclingCamera;
  [Token(Token = "0x400035E")]
  [FieldOffset(Offset = "0x40")]
  public FinalFightController finalFightController;
  [Token(Token = "0x400035F")]
  [FieldOffset(Offset = "0x48")]
  public GameObject meteor;
  [Token(Token = "0x4000360")]
  [FieldOffset(Offset = "0x50")]
  public ShakePreset impactShake;
  [Token(Token = "0x4000361")]
  [FieldOffset(Offset = "0x58")]
  public Shaker shaker;
  [Token(Token = "0x4000362")]
  [FieldOffset(Offset = "0x60")]
  private float cameraRotationSpeed;
  [Token(Token = "0x4000363")]
  [FieldOffset(Offset = "0x64")]
  private float fovSpeed;
  [Token(Token = "0x4000364")]
  [FieldOffset(Offset = "0x68")]
  private float desiredFov;
  [Token(Token = "0x4000365")]
  [FieldOffset(Offset = "0x70")]
  private Transform target;
  [Token(Token = "0x4000366")]
  [FieldOffset(Offset = "0x78")]
  public GameObject finalPortal;

  [Token(Token = "0x60002BE")]
  [Address(RVA = "0x4634D0", Offset = "0x4620D0", Length = "0x184")]
  public void Start()
  {
  }

  [Token(Token = "0x60002BF")]
  [Address(RVA = "0x463320", Offset = "0x461F20", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60002C0")]
  [Address(RVA = "0x463280", Offset = "0x461E80", Length = "0x67")]
  private IEnumerator AnimateCinematic() => (IEnumerator) null;

  [Token(Token = "0x60002C1")]
  [Address(RVA = "0x4632F0", Offset = "0x461EF0", Length = "0x28")]
  public void Impact()
  {
  }

  [Token(Token = "0x60002C2")]
  [Address(RVA = "0x463450", Offset = "0x462050", Length = "0x44")]
  private void OnStageBossDied(bool idk)
  {
  }

  [Token(Token = "0x60002C3")]
  [Address(RVA = "0x4634A0", Offset = "0x4620A0", Length = "0x20")]
  private void SpawnPortal()
  {
  }

  [Token(Token = "0x60002C4")]
  [Address(RVA = "0x463660", Offset = "0x462260", Length = "0x378")]
  private void Update()
  {
  }

  [Token(Token = "0x60002C5")]
  [Address(RVA = "0x4639E0", Offset = "0x4625E0", Length = "0x19")]
  public FianlBossCinematic()
  {
  }
}
