// Decompiled with JetBrains decompiler
// Type: MapPrefabUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20001B2")]
public class MapPrefabUi : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
  [Token(Token = "0x4000C60")]
  [FieldOffset(Offset = "0x20")]
  public RawImage i_map;
  [Token(Token = "0x4000C61")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_name;
  [Token(Token = "0x4000C62")]
  [FieldOffset(Offset = "0x30")]
  private MapData mapData;
  [Token(Token = "0x4000C63")]
  public static Action<MapData> A_SelectMap;

  [Token(Token = "0x6000AFB")]
  [Address(RVA = "0x4F75E0", Offset = "0x4F61E0", Length = "0x7C")]
  public void SetMap(MapData mapData)
  {
  }

  [Token(Token = "0x6000AFC")]
  [Address(RVA = "0x4F7580", Offset = "0x4F6180", Length = "0x56")]
  public void OnSelect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000AFD")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapPrefabUi()
  {
  }
}
