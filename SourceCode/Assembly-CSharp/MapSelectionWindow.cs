// Decompiled with JetBrains decompiler
// Type: MapSelectionWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B6")]
public class MapSelectionWindow : MonoBehaviour
{
  [Token(Token = "0x4000C80")]
  [FieldOffset(Offset = "0x20")]
  public GameObject mapEntryPrefab;
  [Token(Token = "0x4000C81")]
  [FieldOffset(Offset = "0x28")]
  public SelectionGroupToggleSingle selectionGroup;

  [Token(Token = "0x6000B1A")]
  [Address(RVA = "0x4F8630", Offset = "0x4F7230", Length = "0x57A")]
  public void InitButtons()
  {
  }

  [Token(Token = "0x6000B1B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapSelectionWindow()
  {
  }
}
