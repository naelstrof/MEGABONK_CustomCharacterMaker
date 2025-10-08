// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Managers.IconManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemyDebuffs;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Managers
{
  [Token(Token = "0x2000357")]
  public class IconManager : MonoBehaviour
  {
    [Token(Token = "0x40016D1")]
    [FieldOffset(Offset = "0x20")]
    public Texture poisonIcon;
    [Token(Token = "0x40016D2")]
    [FieldOffset(Offset = "0x28")]
    public Texture burnIcon;
    [Token(Token = "0x40016D3")]
    [FieldOffset(Offset = "0x30")]
    public Texture thornsIcon;
    [Token(Token = "0x40016D4")]
    [FieldOffset(Offset = "0x38")]
    public Texture echoIcon;
    [Token(Token = "0x40016D5")]
    [FieldOffset(Offset = "0x40")]
    public Texture bloodmarkIcon;
    [Token(Token = "0x40016D6")]
    [FieldOffset(Offset = "0x48")]
    public Texture zapIcon;
    [Token(Token = "0x40016D7")]
    [FieldOffset(Offset = "0x50")]
    public Texture questionMark;
    [Token(Token = "0x40016D8")]
    [FieldOffset(Offset = "0x58")]
    public Texture[] rankIcons;
    [Token(Token = "0x40016D9")]
    [FieldOffset(Offset = "0x60")]
    public Texture rankFrameIcon;
    [Token(Token = "0x40016DA")]
    public static IconManager Instance;

    [Token(Token = "0x60017C2")]
    [Address(RVA = "0x3CCAF0", Offset = "0x3CB6F0", Length = "0xD3")]
    private void Awake()
    {
    }

    [Token(Token = "0x60017C3")]
    [Address(RVA = "0x3CCBD0", Offset = "0x3CB7D0", Length = "0x30")]
    public Texture GetDebuffIcon(EDebuff debuff) => (Texture) null;

    [Token(Token = "0x60017C4")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public IconManager()
    {
    }
  }
}
