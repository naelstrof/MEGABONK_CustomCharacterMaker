// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.CFGameSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Settings___Saves.SaveFiles
{
  [Token(Token = "0x2000317")]
  [Serializable]
  public class CFGameSettings : CFSettings
  {
    [Token(Token = "0x40014FB")]
    [FieldOffset(Offset = "0x10")]
    public int camera_shake;
    [Token(Token = "0x40014FC")]
    [FieldOffset(Offset = "0x14")]
    public float input_delay;
    [Token(Token = "0x40014FD")]
    [FieldOffset(Offset = "0x18")]
    public int enemy_targeting_mode;
    [Token(Token = "0x40014FE")]
    [FieldOffset(Offset = "0x1C")]
    public float random_enemy_targeting;
    [Token(Token = "0x40014FF")]
    [FieldOffset(Offset = "0x20")]
    public int language;
    [Token(Token = "0x4001500")]
    [FieldOffset(Offset = "0x24")]
    public int show_tips;
    [Token(Token = "0x4001501")]
    [FieldOffset(Offset = "0x28")]
    public float minimap_size;
    [Token(Token = "0x4001502")]
    [FieldOffset(Offset = "0x2C")]
    public int minimap_rotation;
    [Token(Token = "0x4001503")]
    [FieldOffset(Offset = "0x30")]
    public int hp_bar_color;
    [Token(Token = "0x4001504")]
    [FieldOffset(Offset = "0x34")]
    public float crosshair_height;
    [Token(Token = "0x4001505")]
    [FieldOffset(Offset = "0x38")]
    public float crosshair_size;
    [Token(Token = "0x4001506")]
    [FieldOffset(Offset = "0x3C")]
    public float crosshair_alpha;
    [Token(Token = "0x4001507")]
    [FieldOffset(Offset = "0x40")]
    public int hide_leaderboards;
    [Token(Token = "0x4001508")]
    [FieldOffset(Offset = "0x44")]
    public int upload_score_to_leaderboard;
    [Token(Token = "0x4001509")]
    [FieldOffset(Offset = "0x48")]
    public int quick_reset;
    [Token(Token = "0x400150A")]
    [FieldOffset(Offset = "0x4C")]
    public int debug_fps;
    [Token(Token = "0x400150B")]
    [FieldOffset(Offset = "0x50")]
    public int debug_speed;
    [Token(Token = "0x400150C")]
    [FieldOffset(Offset = "0x54")]
    public int debug_ram;
    [Token(Token = "0x400150D")]
    [FieldOffset(Offset = "0x58")]
    public int debug_enemy_scaling;
    [Token(Token = "0x400150E")]
    [FieldOffset(Offset = "0x5C")]
    public int pege_mode;
    [Token(Token = "0x400150F")]
    [FieldOffset(Offset = "0x60")]
    public int unlock_all;

    [Token(Token = "0x6001626")]
    [Address(RVA = "0x3A3500", Offset = "0x3A2100", Length = "0x286")]
    public List<SettingHeader> GetHeaders() => (List<SettingHeader>) null;

    [Token(Token = "0x6001627")]
    [Address(RVA = "0x3A3790", Offset = "0x3A2390", Length = "0x54")]
    public CFGameSettings()
    {
    }
  }
}
