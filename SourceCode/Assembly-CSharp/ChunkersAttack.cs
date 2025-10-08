// Decompiled with JetBrains decompiler
// Type: ChunkersAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.ConstantAttacks;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;

[Token(Token = "0x2000050")]
public class ChunkersAttack : ConstantAttack
{
  [Token(Token = "0x4000294")]
  [FieldOffset(Offset = "0x28")]
  public RandomSfx regenSfx;
  [Token(Token = "0x4000295")]
  [FieldOffset(Offset = "0x30")]
  public RotatingProjectiles rotatingProjectiles;
  [Token(Token = "0x4000296")]
  [FieldOffset(Offset = "0x38")]
  private int currentAmount;
  [Token(Token = "0x4000297")]
  [FieldOffset(Offset = "0x3C")]
  private float shieldReadyAtTime;
  [Token(Token = "0x4000298")]
  [FieldOffset(Offset = "0x40")]
  private float rotationSpeed;
  [Token(Token = "0x4000299")]
  [FieldOffset(Offset = "0x44")]
  private float cooldown;
  [Token(Token = "0x400029A")]
  [FieldOffset(Offset = "0x48")]
  private float minCooldown;
  [Token(Token = "0x400029B")]
  [FieldOffset(Offset = "0x4C")]
  private float duration;
  [Token(Token = "0x400029C")]
  [FieldOffset(Offset = "0x50")]
  private int amount;
  [Token(Token = "0x400029D")]
  [FieldOffset(Offset = "0x54")]
  private float startTime;
  [Token(Token = "0x400029E")]
  [FieldOffset(Offset = "0x58")]
  private float stopTime;
  [Token(Token = "0x400029F")]
  [FieldOffset(Offset = "0x5C")]
  private float nextStartTime;
  [Token(Token = "0x40002A0")]
  [FieldOffset(Offset = "0x60")]
  private bool isAttacking;

  [Token(Token = "0x600021D")]
  [Address(RVA = "0x357400", Offset = "0x356000", Length = "0x2D8")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600021E")]
  [Address(RVA = "0x3571B0", Offset = "0x355DB0", Length = "0x6F")]
  private void FindNewTimes()
  {
  }

  [Token(Token = "0x600021F")]
  [Address(RVA = "0x357D10", Offset = "0x356910", Length = "0x115")]
  public void StartAttack()
  {
  }

  [Token(Token = "0x6000220")]
  [Address(RVA = "0x357E30", Offset = "0x356A30", Length = "0x2C")]
  public void StopAttack()
  {
  }

  [Token(Token = "0x6000221")]
  [Address(RVA = "0x357220", Offset = "0x355E20", Length = "0x1C6")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000222")]
  [Address(RVA = "0x3573F0", Offset = "0x355FF0", Length = "0x4")]
  public override float GetAuraRotationSpeed() => 0.0f;

  [Token(Token = "0x6000223")]
  [Address(RVA = "0x3579E0", Offset = "0x3565E0", Length = "0x3B")]
  protected override void OnWeaponStatUpdate(EStat stat, EWeapon weapon)
  {
  }

  [Token(Token = "0x6000224")]
  [Address(RVA = "0x3576E0", Offset = "0x3562E0", Length = "0x2C")]
  protected override void OnStatUpdate(EStat stat)
  {
  }

  [Token(Token = "0x6000225")]
  [Address(RVA = "0x357AC0", Offset = "0x3566C0", Length = "0x72")]
  private void SetDuration()
  {
  }

  [Token(Token = "0x6000226")]
  [Address(RVA = "0x357BA0", Offset = "0x3567A0", Length = "0x71")]
  private void SetProjectiles()
  {
  }

  [Token(Token = "0x6000227")]
  [Address(RVA = "0x357C20", Offset = "0x356820", Length = "0xEA")]
  private void SetSize()
  {
  }

  [Token(Token = "0x6000228")]
  [Address(RVA = "0x357B40", Offset = "0x356740", Length = "0x5F")]
  private void SetProjectileSpeed()
  {
  }

  [Token(Token = "0x6000229")]
  [Address(RVA = "0x357A20", Offset = "0x356620", Length = "0x92")]
  private void SetCooldown()
  {
  }

  [Token(Token = "0x600022A")]
  [Address(RVA = "0x357E60", Offset = "0x356A60", Length = "0x7")]
  public ChunkersAttack()
  {
  }
}
