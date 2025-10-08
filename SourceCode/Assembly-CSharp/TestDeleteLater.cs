// Decompiled with JetBrains decompiler
// Type: TestDeleteLater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000229")]
public class TestDeleteLater : MonoBehaviour
{
  [Token(Token = "0x4000F32")]
  [FieldOffset(Offset = "0x20")]
  private Rigidbody[] rbs;
  [Token(Token = "0x4000F33")]
  [FieldOffset(Offset = "0x28")]
  public GameObject ragdoll;
  [Token(Token = "0x4000F34")]
  [FieldOffset(Offset = "0x30")]
  public GameObject torso;

  [Token(Token = "0x6000E13")]
  [Address(RVA = "0x530460", Offset = "0x52F060", Length = "0x46D")]
  private void MakeRagdoll()
  {
  }

  [Token(Token = "0x6000E14")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000E15")]
  [Address(RVA = "0x530410", Offset = "0x52F010", Length = "0x4B")]
  public void HoverboardFlying()
  {
  }

  [Token(Token = "0x6000E16")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TestDeleteLater()
  {
  }

  [Token(Token = "0x200022A")]
  public class Hoverboard
  {
    [Token(Token = "0x6000E17")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public void Do()
    {
    }

    [Token(Token = "0x6000E18")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public Hoverboard()
    {
    }
  }
}
