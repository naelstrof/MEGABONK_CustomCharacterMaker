// Decompiled with JetBrains decompiler
// Type: ReturnToPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Pool;

[Token(Token = "0x2000104")]
public class ReturnToPool : MonoBehaviour
{
  [Token(Token = "0x40007FB")]
  [FieldOffset(Offset = "0x20")]
  private float timeout;
  [Token(Token = "0x40007FC")]
  [FieldOffset(Offset = "0x24")]
  private float returnTime;
  [Token(Token = "0x40007FD")]
  [FieldOffset(Offset = "0x28")]
  public ObjectPool<GameObject> pool;

  [Token(Token = "0x60006C7")]
  [Address(RVA = "0x4C1DF0", Offset = "0x4C09F0", Length = "0xAA")]
  public void SetTime(float timeout, ObjectPool<GameObject> pool)
  {
  }

  [Token(Token = "0x60006C8")]
  [Address(RVA = "0x4C1D90", Offset = "0x4C0990", Length = "0x60")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60006C9")]
  [Address(RVA = "0x4C1EA0", Offset = "0x4C0AA0", Length = "0x1D5")]
  private void Update()
  {
  }

  [Token(Token = "0x60006CA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ReturnToPool()
  {
  }
}
