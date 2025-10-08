// Decompiled with JetBrains decompiler
// Type: VectorExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000019")]
public class VectorExtensions : MonoBehaviour
{
  [Token(Token = "0x60000BF")]
  [Address(RVA = "0x351850", Offset = "0x350450", Length = "0x167")]
  public static UnityEngine.Vector3 XZVector(UnityEngine.Vector3 v) => new UnityEngine.Vector3();

  [Token(Token = "0x60000C0")]
  [Address(RVA = "0x351830", Offset = "0x350430", Length = "0x12")]
  public static UnityEngine.Vector2 XZVector2(UnityEngine.Vector3 v) => new UnityEngine.Vector2();

  [Token(Token = "0x60000C1")]
  [Address(RVA = "0x3517F0", Offset = "0x3503F0", Length = "0x32")]
  public static System.Numerics.Vector3 UnityToNet(UnityEngine.Vector3 vec) => new System.Numerics.Vector3();

  [Token(Token = "0x60000C2")]
  [Address(RVA = "0x3517D0", Offset = "0x3503D0", Length = "0x14")]
  public static UnityEngine.Vector3 NetToUnity(System.Numerics.Vector3 vec) => new UnityEngine.Vector3();

  [Token(Token = "0x60000C3")]
  [Address(RVA = "0x351760", Offset = "0x350360", Length = "0x66")]
  public static UnityEngine.Vector3 ClampVector(UnityEngine.Vector3 vec, float min, float max) => new UnityEngine.Vector3();

  [Token(Token = "0x60000C4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public VectorExtensions()
  {
  }
}
