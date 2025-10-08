// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Items.ItemProjectiles.ItemProjectileOrb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Items.ItemProjectiles
{
  [Token(Token = "0x2000398")]
  public class ItemProjectileOrb : ItemProjectile
  {
    [Token(Token = "0x4001858")]
    [FieldOffset(Offset = "0xA8")]
    private float startTime;
    [Token(Token = "0x4001859")]
    [FieldOffset(Offset = "0xAC")]
    private float hoverTime;
    [Token(Token = "0x400185A")]
    [FieldOffset(Offset = "0xB0")]
    private float offsetTime;
    [Token(Token = "0x400185B")]
    [FieldOffset(Offset = "0xB4")]
    private float spinSpeed;
    [Token(Token = "0x400185C")]
    [FieldOffset(Offset = "0xB8")]
    private float currentAngle;
    [Token(Token = "0x400185D")]
    [FieldOffset(Offset = "0xBC")]
    private float moveTimer;
    [Token(Token = "0x400185E")]
    [FieldOffset(Offset = "0xC0")]
    private Vector3 offset;
    [Token(Token = "0x400185F")]
    [FieldOffset(Offset = "0xD0")]
    private Transform orbitTarget;
    [Token(Token = "0x4001860")]
    [FieldOffset(Offset = "0xD8")]
    private Vector3 defaultScale;
    [Token(Token = "0x4001861")]
    [FieldOffset(Offset = "0xE4")]
    private bool fired;
    [Token(Token = "0x4001862")]
    [FieldOffset(Offset = "0xE8")]
    public GameObject fireSfx;
    [Token(Token = "0x4001863")]
    [FieldOffset(Offset = "0xF0")]
    private Vector3 movementDirection;

    [Token(Token = "0x6001975")]
    [Address(RVA = "0x417B70", Offset = "0x416770", Length = "0x2C4")]
    protected override void Init()
    {
    }

    [Token(Token = "0x6001976")]
    [Address(RVA = "0x4177D0", Offset = "0x4163D0", Length = "0x391")]
    private void FireOrb()
    {
    }

    [Token(Token = "0x6001977")]
    [Address(RVA = "0x418250", Offset = "0x416E50", Length = "0xA9")]
    protected override void Step()
    {
    }

    [Token(Token = "0x6001978")]
    [Address(RVA = "0x3458C0", Offset = "0x3444C0", Length = "0x19")]
    protected override Vector3 GetMovementDirection() => new Vector3();

    [Token(Token = "0x6001979")]
    [Address(RVA = "0x417ED0", Offset = "0x416AD0", Length = "0x375")]
    protected void StepHoverMovement()
    {
    }

    [Token(Token = "0x600197A")]
    [Address(RVA = "0x417E40", Offset = "0x416A40", Length = "0x86")]
    protected override void ProjectileDone()
    {
    }

    [Token(Token = "0x600197B")]
    [Address(RVA = "0x418300", Offset = "0x416F00", Length = "0xB4")]
    public ItemProjectileOrb()
    {
    }
  }
}
