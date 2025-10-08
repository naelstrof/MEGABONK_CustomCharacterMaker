// Decompiled with JetBrains decompiler
// Type: CharacterDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000199")]
public class CharacterDisplay : MonoBehaviour
{
  [Token(Token = "0x4000BAD")]
  [FieldOffset(Offset = "0x20")]
  public PlayerRenderer playerRenderer;
  [Token(Token = "0x4000BAE")]
  [FieldOffset(Offset = "0x28")]
  public LayerMask layerMask;
  [Token(Token = "0x4000BAF")]
  [FieldOffset(Offset = "0x30")]
  private CharacterData currentCharacter;
  [Token(Token = "0x4000BB0")]
  [FieldOffset(Offset = "0x38")]
  public Material lockedMaterial;
  [Token(Token = "0x4000BB1")]
  [FieldOffset(Offset = "0x40")]
  private bool usingNonOwnedSkin;

  [Token(Token = "0x6000A50")]
  [Address(RVA = "0x4E9DC0", Offset = "0x4E89C0", Length = "0x4E3")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A51")]
  [Address(RVA = "0x4E9430", Offset = "0x4E8030", Length = "0x22E")]
  private void OnCharacterSelected(CharacterData characterData)
  {
  }

  [Token(Token = "0x6000A52")]
  [Address(RVA = "0x4E9660", Offset = "0x4E8260", Length = "0x21")]
  private void OnCharacterSelected(MyButtonCharacter btn)
  {
  }

  [Token(Token = "0x6000A53")]
  [Address(RVA = "0x4E9CF0", Offset = "0x4E88F0", Length = "0xCE")]
  private void OnSkinSelected(SkinContainer skinContainer)
  {
  }

  [Token(Token = "0x6000A54")]
  [Address(RVA = "0x4E9B80", Offset = "0x4E8780", Length = "0x166")]
  private void OnMapSelectionEnabled()
  {
  }

  [Token(Token = "0x6000A55")]
  [Address(RVA = "0x4E9690", Offset = "0x4E8290", Length = "0x4E3")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A56")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CharacterDisplay()
  {
  }
}
