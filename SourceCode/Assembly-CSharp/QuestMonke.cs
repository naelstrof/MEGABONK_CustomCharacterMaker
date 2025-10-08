// Decompiled with JetBrains decompiler
// Type: QuestMonke
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000080")]
public class QuestMonke : MonoBehaviour
{
  [Token(Token = "0x40003E7")]
  [FieldOffset(Offset = "0x20")]
  public Animator animator;
  [Token(Token = "0x40003E8")]
  [FieldOffset(Offset = "0x28")]
  public Rigidbody rb;
  [Token(Token = "0x40003E9")]
  [FieldOffset(Offset = "0x30")]
  private Vector3 runDir;
  [Token(Token = "0x40003EA")]
  [FieldOffset(Offset = "0x3C")]
  private float speed;
  [Token(Token = "0x40003EB")]
  [FieldOffset(Offset = "0x40")]
  public GameObject dissapearFx;
  [Token(Token = "0x40003EC")]
  [FieldOffset(Offset = "0x48")]
  private float aliveTime;
  [Token(Token = "0x40003ED")]
  [FieldOffset(Offset = "0x4C")]
  private float deadTime;
  [Token(Token = "0x40003EE")]
  [FieldOffset(Offset = "0x50")]
  private bool isWalking;
  [Token(Token = "0x40003EF")]
  [FieldOffset(Offset = "0x54")]
  private Vector3 savedVelocity;
  [Token(Token = "0x40003F0")]
  [FieldOffset(Offset = "0x60")]
  private float stopMusicAtTime;
  [Token(Token = "0x40003F1")]
  [FieldOffset(Offset = "0x64")]
  private bool isClimbingWall;
  [Token(Token = "0x40003F2")]
  [FieldOffset(Offset = "0x68")]
  private float climbSpeed;

  [Token(Token = "0x600031E")]
  [Address(RVA = "0x46B930", Offset = "0x46A530", Length = "0xDF")]
  private void Start()
  {
  }

  [Token(Token = "0x600031F")]
  [Address(RVA = "0x46B8E0", Offset = "0x46A4E0", Length = "0x46")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000320")]
  [Address(RVA = "0x46BC30", Offset = "0x46A830", Length = "0xB2")]
  private void Update()
  {
  }

  [Token(Token = "0x6000321")]
  [Address(RVA = "0x46AF70", Offset = "0x469B70", Length = "0x967")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000322")]
  [Address(RVA = "0x46BA10", Offset = "0x46A610", Length = "0x219")]
  private void TryClimb()
  {
  }

  [Token(Token = "0x6000323")]
  [Address(RVA = "0x46ADF0", Offset = "0x4699F0", Length = "0xD9")]
  private void CheckDead()
  {
  }

  [Token(Token = "0x6000324")]
  [Address(RVA = "0x46AED0", Offset = "0x469AD0", Length = "0x90")]
  private void Die()
  {
  }

  [Token(Token = "0x6000325")]
  [Address(RVA = "0x46BCF0", Offset = "0x46A8F0", Length = "0x1C")]
  public QuestMonke()
  {
  }
}
