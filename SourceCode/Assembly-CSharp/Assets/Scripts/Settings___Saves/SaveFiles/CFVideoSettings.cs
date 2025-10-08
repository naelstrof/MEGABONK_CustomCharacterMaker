// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.SaveFiles.CFVideoSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Settings___Saves.SaveFiles
{
  [Token(Token = "0x2000319")]
  public class CFVideoSettings : CFSettings
  {
    [Token(Token = "0x4001510")]
    [FieldOffset(Offset = "0x10")]
    public int resolution;
    [Token(Token = "0x4001511")]
    [FieldOffset(Offset = "0x14")]
    public int target_monitor;
    [Token(Token = "0x4001512")]
    [FieldOffset(Offset = "0x18")]
    public int fullscreen_mode;
    [Token(Token = "0x4001513")]
    [FieldOffset(Offset = "0x1C")]
    public int vsync;
    [Token(Token = "0x4001514")]
    [FieldOffset(Offset = "0x20")]
    public float fps_limit;
    [Token(Token = "0x4001515")]
    [FieldOffset(Offset = "0x24")]
    public float fov;
    [Token(Token = "0x4001516")]
    [FieldOffset(Offset = "0x28")]
    public float camera_distance;
    [Token(Token = "0x4001517")]
    [FieldOffset(Offset = "0x2C")]
    public int grass_quality;
    [Token(Token = "0x4001518")]
    [FieldOffset(Offset = "0x30")]
    public int shadow_quality;
    [Token(Token = "0x4001519")]
    [FieldOffset(Offset = "0x34")]
    public int shadow_resolution;
    [Token(Token = "0x400151A")]
    [FieldOffset(Offset = "0x38")]
    public int anti_aliasing;
    [Token(Token = "0x400151B")]
    [FieldOffset(Offset = "0x3C")]
    public int soft_particles;
    [Token(Token = "0x400151C")]
    [FieldOffset(Offset = "0x40")]
    public int bloom;
    [Token(Token = "0x400151D")]
    [FieldOffset(Offset = "0x44")]
    public int motion_blur;
    [Token(Token = "0x400151E")]
    [FieldOffset(Offset = "0x48")]
    public int ambient_occlusion;

    [Token(Token = "0x6001629")]
    [Address(RVA = "0x3A37F0", Offset = "0x3A23F0", Length = "0x1E3")]
    public List<SettingHeader> GetHeaders() => (List<SettingHeader>) null;

    [Token(Token = "0x600162A")]
    [Address(RVA = "0x3A39E0", Offset = "0x3A25E0", Length = "0x4D")]
    public CFVideoSettings()
    {
    }
  }
}
