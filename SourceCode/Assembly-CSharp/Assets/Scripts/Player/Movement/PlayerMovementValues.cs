// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Player.Movement.PlayerMovementValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Player.Movement
{
  [Token(Token = "0x200044D")]
  public class PlayerMovementValues
  {
    [Token(Token = "0x4001BCE")]
    private const float defaultMoveSpeed = 2700f;
    [Token(Token = "0x4001BCF")]
    private const float defaultSwimSpeed = 10f;
    [Token(Token = "0x4001BD0")]
    public const float defaultMaxSpeed = 10f;
    [Token(Token = "0x4001BD1")]
    private const float defaultSlideForce = 200f;
    [Token(Token = "0x4001BD2")]
    private const float defaultAirDeceleration = 0.003f;
    [Token(Token = "0x4001BD3")]
    private const float defaultExtraGravity = 11f;
    [Token(Token = "0x4001BDA")]
    [FieldOffset(Offset = "0x28")]
    private bool inited;
    [Token(Token = "0x4001BDB")]
    [FieldOffset(Offset = "0x2C")]
    private ECharacter currentCharacter;
    [Token(Token = "0x4001BDC")]
    [FieldOffset(Offset = "0x30")]
    private float counterMovement;

    [field: Token(Token = "0x4001BD4")]
    [field: FieldOffset(Offset = "0x10")]
    [Token(Token = "0x17000392")]
    public float moveSpeed { [Token(Token = "0x6001EAF"), Address(RVA = "0x44F9C0", Offset = "0x44E5C0", Length = "0x6")] get; [Token(Token = "0x6001EB0"), Address(RVA = "0x44F9D0", Offset = "0x44E5D0", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001BD5")]
    [field: FieldOffset(Offset = "0x14")]
    [Token(Token = "0x17000393")]
    public float maxRunSpeed { [Token(Token = "0x6001EB1"), Address(RVA = "0x3933A0", Offset = "0x391FA0", Length = "0x6")] get; [Token(Token = "0x6001EB2"), Address(RVA = "0x393400", Offset = "0x392000", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001BD6")]
    [field: FieldOffset(Offset = "0x18")]
    [Token(Token = "0x17000394")]
    public float airDeceleration { [Token(Token = "0x6001EB3"), Address(RVA = "0x393390", Offset = "0x391F90", Length = "0x6")] get; [Token(Token = "0x6001EB4"), Address(RVA = "0x3933F0", Offset = "0x391FF0", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001BD7")]
    [field: FieldOffset(Offset = "0x1C")]
    [Token(Token = "0x17000395")]
    public float slideForce { [Token(Token = "0x6001EB5"), Address(RVA = "0x393330", Offset = "0x391F30", Length = "0x6")] get; [Token(Token = "0x6001EB6"), Address(RVA = "0x3933B0", Offset = "0x391FB0", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001BD8")]
    [field: FieldOffset(Offset = "0x20")]
    [Token(Token = "0x17000396")]
    public float extraGravity { [Token(Token = "0x6001EB7"), Address(RVA = "0x393340", Offset = "0x391F40", Length = "0x6")] get; [Token(Token = "0x6001EB8"), Address(RVA = "0x3933C0", Offset = "0x391FC0", Length = "0x6")] private set; }

    [field: Token(Token = "0x4001BD9")]
    [field: FieldOffset(Offset = "0x24")]
    [Token(Token = "0x17000397")]
    public float swimSpeed { [Token(Token = "0x6001EB9"), Address(RVA = "0x393410", Offset = "0x392010", Length = "0x6")] get; [Token(Token = "0x6001EBA"), Address(RVA = "0x393480", Offset = "0x392080", Length = "0x6")] private set; }

    [Token(Token = "0x6001EBB")]
    [Address(RVA = "0x44F950", Offset = "0x44E550", Length = "0x42")]
    private void Init(Rigidbody rb)
    {
    }

    [Token(Token = "0x6001EBC")]
    [Address(RVA = "0x44F660", Offset = "0x44E260", Length = "0x140")]
    public void CreateMovement(Rigidbody rb, ECharacter character)
    {
    }

    [Token(Token = "0x6001EBD")]
    [Address(RVA = "0x44F7D0", Offset = "0x44E3D0", Length = "0x25")]
    private static float GetCounterMovementMultiplier(ECharacter character) => 0.0f;

    [Token(Token = "0x6001EBE")]
    [Address(RVA = "0x44F890", Offset = "0x44E490", Length = "0x9")]
    private static float GetMoveSpeedMultiplier(ECharacter character) => 0.0f;

    [Token(Token = "0x6001EBF")]
    [Address(RVA = "0x44F7B0", Offset = "0x44E3B0", Length = "0x19")]
    public float GetCounterMovementMultiplier(FrictionModifier.EFrictionSurface surface) => 0.0f;

    [Token(Token = "0x6001EC0")]
    [Address(RVA = "0x44F910", Offset = "0x44E510", Length = "0x32")]
    public static float GetSlowdownMultiplier(
      FrictionModifier.EFrictionSurface surface,
      ECharacter character)
    {
      return 0.0f;
    }

    [Token(Token = "0x6001EC1")]
    [Address(RVA = "0x44F8A0", Offset = "0x44E4A0", Length = "0x6E")]
    public float GetMoveSpeed(FrictionModifier.EFrictionSurface surface, bool grounded) => 0.0f;

    [Token(Token = "0x6001EC2")]
    [Address(RVA = "0x44F800", Offset = "0x44E400", Length = "0x58")]
    public float GetGravity(Rigidbody rb, ECharacter character) => 0.0f;

    [Token(Token = "0x6001EC3")]
    [Address(RVA = "0x44F860", Offset = "0x44E460", Length = "0x26")]
    public float GetMaxSpeed() => 0.0f;

    [Token(Token = "0x6001EC4")]
    [Address(RVA = "0x44F9A0", Offset = "0x44E5A0", Length = "0x1C")]
    public PlayerMovementValues()
    {
    }
  }
}
