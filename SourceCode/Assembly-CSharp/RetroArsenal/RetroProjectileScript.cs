// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroProjectileScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x2000462")]
  public class RetroProjectileScript : MonoBehaviour
  {
    [Token(Token = "0x4001CE1")]
    [FieldOffset(Offset = "0x20")]
    public GameObject impactParticle;
    [Token(Token = "0x4001CE2")]
    [FieldOffset(Offset = "0x28")]
    public GameObject projectileParticle;
    [Token(Token = "0x4001CE3")]
    [FieldOffset(Offset = "0x30")]
    public GameObject muzzleParticle;
    [Token(Token = "0x4001CE4")]
    [FieldOffset(Offset = "0x38")]
    public GameObject[] trailParticles;
    [Header("Adjust if not using Sphere Collider")]
    [Token(Token = "0x4001CE5")]
    [FieldOffset(Offset = "0x40")]
    public float colliderRadius;
    [Range(0.0f, 1f)]
    [Token(Token = "0x4001CE6")]
    [FieldOffset(Offset = "0x44")]
    public float collideOffset;
    [Token(Token = "0x4001CE7")]
    [FieldOffset(Offset = "0x48")]
    private Rigidbody rb;
    [Token(Token = "0x4001CE8")]
    [FieldOffset(Offset = "0x50")]
    private Transform myTransform;
    [Token(Token = "0x4001CE9")]
    [FieldOffset(Offset = "0x58")]
    private SphereCollider sphereCollider;
    [Token(Token = "0x4001CEA")]
    [FieldOffset(Offset = "0x60")]
    private float destroyTimer;
    [Token(Token = "0x4001CEB")]
    [FieldOffset(Offset = "0x64")]
    private bool destroyed;

    [Token(Token = "0x6001F9F")]
    [Address(RVA = "0x459100", Offset = "0x457D00", Length = "0x246")]
    private void Start()
    {
    }

    [Token(Token = "0x6001FA0")]
    [Address(RVA = "0x458690", Offset = "0x457290", Length = "0x7EA")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x6001FA1")]
    [Address(RVA = "0x4583F0", Offset = "0x456FF0", Length = "0x29F")]
    private void DestroyMissile()
    {
    }

    [Token(Token = "0x6001FA2")]
    [Address(RVA = "0x458E80", Offset = "0x457A80", Length = "0x274")]
    private void RotateTowardsDirection()
    {
    }

    [Token(Token = "0x6001FA3")]
    [Address(RVA = "0x459350", Offset = "0x457F50", Length = "0x15")]
    public RetroProjectileScript()
    {
    }
  }
}
