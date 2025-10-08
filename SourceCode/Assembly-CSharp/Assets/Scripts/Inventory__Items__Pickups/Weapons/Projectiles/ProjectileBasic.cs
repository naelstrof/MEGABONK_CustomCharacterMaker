// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles.ProjectileBasic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
{
  [Token(Token = "0x2000373")]
  public class ProjectileBasic : ProjectileBase
  {
    [Token(Token = "0x4001777")]
    [FieldOffset(Offset = "0x68")]
    protected GameObject currentTarget;

    [Token(Token = "0x60018B1")]
    [Address(RVA = "0x3F2B70", Offset = "0x3F1770", Length = "0x41F")]
    protected override bool TryInit(int projectileIndex) => false;

    [Token(Token = "0x60018B2")]
    [Address(RVA = "0x3F2700", Offset = "0x3F1300", Length = "0x29C")]
    protected override void FindMovementDirection()
    {
    }

    [Token(Token = "0x60018B3")]
    [Address(RVA = "0x3F29A0", Offset = "0x3F15A0", Length = "0x31")]
    protected override Vector3 GetMovementDirection() => new Vector3();

    [Token(Token = "0x60018B4")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void MyFixedUpdate()
    {
    }

    [Token(Token = "0x60018B5")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void MyUpdate()
    {
    }

    [Token(Token = "0x60018B6")]
    [Address(RVA = "0x3F29E0", Offset = "0x3F15E0", Length = "0x106")]
    private void OnCollisionEnter(Collision collision)
    {
    }

    [Token(Token = "0x60018B7")]
    [Address(RVA = "0x3F2AF0", Offset = "0x3F16F0", Length = "0x72")]
    private void OnTriggerEnter(Collider collider)
    {
    }

    [Token(Token = "0x60018B8")]
    [Address(RVA = "0x3F26F0", Offset = "0x3F12F0", Length = "0xE")]
    public ProjectileBasic()
    {
    }
  }
}
