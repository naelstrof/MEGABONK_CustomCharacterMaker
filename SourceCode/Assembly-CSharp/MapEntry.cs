// Decompiled with JetBrains decompiler
// Type: MapEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

[Token(Token = "0x20001B5")]
public class MapEntry : MonoBehaviour
{
  [Token(Token = "0x4000C79")]
  [FieldOffset(Offset = "0x20")]
  public RawImage mapIcon;
  [Token(Token = "0x4000C7A")]
  [FieldOffset(Offset = "0x28")]
  public GameObject locked;
  [Token(Token = "0x4000C7B")]
  [FieldOffset(Offset = "0x30")]
  public GameObject notificationIcon;
  [Token(Token = "0x4000C7C")]
  [FieldOffset(Offset = "0x38")]
  public SelectionGroupToggleSingleButton buttonScript;
  [Token(Token = "0x4000C7D")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI t_description;
  [Token(Token = "0x4000C7E")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_name;

  [field: Token(Token = "0x4000C7F")]
  [field: FieldOffset(Offset = "0x50")]
  [Token(Token = "0x17000068")]
  public MapData mapData { [Token(Token = "0x6000B12"), Address(RVA = "0x36CC90", Offset = "0x36B890", Length = "0x5")] get; [Token(Token = "0x6000B13"), Address(RVA = "0x36CCC0", Offset = "0x36B8C0", Length = "0xD")] private set; }

  [Token(Token = "0x6000B14")]
  [Address(RVA = "0x4F6220", Offset = "0x4F4E20", Length = "0x172")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000B15")]
  [Address(RVA = "0x4F63A0", Offset = "0x4F4FA0", Length = "0x172")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B16")]
  [Address(RVA = "0x4F6520", Offset = "0x4F5120", Length = "0xC")]
  private void OnLocaleChanged(Locale obj)
  {
  }

  [Token(Token = "0x6000B17")]
  [Address(RVA = "0x4F6530", Offset = "0x4F5130", Length = "0x136")]
  private void OnMapSelected(SelectionGroupToggleSingleButton arg1, MapData arg2)
  {
  }

  [Token(Token = "0x6000B18")]
  [Address(RVA = "0x4F6670", Offset = "0x4F5270", Length = "0x333")]
  public void Set(MapData mapData)
  {
  }

  [Token(Token = "0x6000B19")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapEntry()
  {
  }
}
