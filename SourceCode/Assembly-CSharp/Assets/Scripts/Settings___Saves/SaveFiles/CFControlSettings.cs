// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.CFControlSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Settings___Saves.SaveFiles
{
  [Token(Token = "0x2000316")]
  public class CFControlSettings : CFSettings
  {
    [Token(Token = "0x40014E1")]
    [FieldOffset(Offset = "0x10")]
    public float sensitivity;
    [Token(Token = "0x40014E2")]
    [FieldOffset(Offset = "0x14")]
    public float look_smoothing;
    [Token(Token = "0x40014E3")]
    [FieldOffset(Offset = "0x18")]
    public float controller_sensitivity;
    [Token(Token = "0x40014E4")]
    [FieldOffset(Offset = "0x1C")]
    public int inverted_horizontal_axis;
    [Token(Token = "0x40014E5")]
    [FieldOffset(Offset = "0x20")]
    public int inverted_vertical_axis;
    [Token(Token = "0x40014E6")]
    [FieldOffset(Offset = "0x24")]
    public int hold_crouch;
    [Token(Token = "0x40014E7")]
    [FieldOffset(Offset = "0x28")]
    public int hold_aim;
    [Token(Token = "0x40014E8")]
    [FieldOffset(Offset = "0x2C")]
    public int rotate_camera_with_arrow_keys;
    [Token(Token = "0x40014E9")]
    [FieldOffset(Offset = "0x30")]
    public int select_upgrades_with_number_keys;
    [Token(Token = "0x40014EA")]
    [FieldOffset(Offset = "0x38")]
    public string keyboard_move_forward;
    [Token(Token = "0x40014EB")]
    [FieldOffset(Offset = "0x40")]
    public string keyboard_move_backward;
    [Token(Token = "0x40014EC")]
    [FieldOffset(Offset = "0x48")]
    public string keyboard_move_left;
    [Token(Token = "0x40014ED")]
    [FieldOffset(Offset = "0x50")]
    public string keyboard_move_right;
    [Token(Token = "0x40014EE")]
    [FieldOffset(Offset = "0x58")]
    public string keyboard_jump;
    [Token(Token = "0x40014EF")]
    [FieldOffset(Offset = "0x60")]
    public string keyboard_interact;
    [Token(Token = "0x40014F0")]
    [FieldOffset(Offset = "0x68")]
    public string keyboard_slide;
    [Token(Token = "0x40014F1")]
    [FieldOffset(Offset = "0x70")]
    public string keyboard_aim;
    [Token(Token = "0x40014F2")]
    [FieldOffset(Offset = "0x78")]
    public string keyboard_quick_reset;
    [Token(Token = "0x40014F3")]
    [FieldOffset(Offset = "0x80")]
    public int controller;
    [Token(Token = "0x40014F4")]
    [FieldOffset(Offset = "0x84")]
    public float controller_vibration;
    [Token(Token = "0x40014F5")]
    [FieldOffset(Offset = "0x88")]
    public string controller_jump;
    [Token(Token = "0x40014F6")]
    [FieldOffset(Offset = "0x90")]
    public string controller_interact;
    [Token(Token = "0x40014F7")]
    [FieldOffset(Offset = "0x98")]
    public string controller_slide;
    [Token(Token = "0x40014F8")]
    [FieldOffset(Offset = "0xA0")]
    public string controller_aim;
    [Token(Token = "0x40014F9")]
    [FieldOffset(Offset = "0xA8")]
    public string controller_quick_reset;
    [Token(Token = "0x40014FA")]
    [FieldOffset(Offset = "0xB0")]
    public int pause_on_controller_disconnect;

    [Token(Token = "0x6001624")]
    [Address(RVA = "0x3A2F80", Offset = "0x3A1B80", Length = "0x329")]
    public List<SettingHeader> GetHeaders() => (List<SettingHeader>) null;

    [Token(Token = "0x6001625")]
    [Address(RVA = "0x3A32B0", Offset = "0x3A1EB0", Length = "0x24B")]
    public CFControlSettings()
    {
    }
  }
}
