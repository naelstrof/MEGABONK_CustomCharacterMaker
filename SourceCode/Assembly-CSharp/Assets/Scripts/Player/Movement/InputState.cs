// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Player.Movement.InputState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Player.Movement
{
  [Token(Token = "0x200044C")]
  public struct InputState
  {
    [Token(Token = "0x4001BC7")]
    [FieldOffset(Offset = "0x0")]
    public float moveHorizontal;
    [Token(Token = "0x4001BC8")]
    [FieldOffset(Offset = "0x4")]
    public float moveVertical;
    [Token(Token = "0x4001BC9")]
    [FieldOffset(Offset = "0x8")]
    public float rotationHorizontal;
    [Token(Token = "0x4001BCA")]
    [FieldOffset(Offset = "0xC")]
    public float rotationVertical;
    [Token(Token = "0x4001BCB")]
    [FieldOffset(Offset = "0x10")]
    public bool jumping;
    [Token(Token = "0x4001BCC")]
    [FieldOffset(Offset = "0x11")]
    public bool crouching;
    [Token(Token = "0x4001BCD")]
    [FieldOffset(Offset = "0x12")]
    public bool holdingJump;

    [Token(Token = "0x6001EAE")]
    [Address(RVA = "0x448A70", Offset = "0x447670", Length = "0x32")]
    public InputState(
      float mH,
      float mV,
      float rH,
      float rV,
      bool ju,
      bool cr,
      bool holdingJump)
    {
      this.moveHorizontal = 0.0f;
      this.moveVertical = 0.0f;
      this.rotationHorizontal = 0.0f;
      this.rotationVertical = 0.0f;
      this.jumping = false;
      this.crouching = false;
      this.holdingJump = false;
    }
  }
}
