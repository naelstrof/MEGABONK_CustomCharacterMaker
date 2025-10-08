// Decompiled with JetBrains decompiler
// Type: CharacterPrefabUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

[Token(Token = "0x2000188")]
public class CharacterPrefabUI : SelectionButton
{
  [Token(Token = "0x4000B48")]
  public static Action<CharacterData> A_CharacterSelected;
  [Token(Token = "0x4000B49")]
  public static Action<CharacterPrefabUI> A_CharacterClicked;
  [Token(Token = "0x4000B4A")]
  [FieldOffset(Offset = "0x48")]
  public CharacterData characterData;

  [Token(Token = "0x60009E0")]
  [Address(RVA = "0x4EBDE0", Offset = "0x4EA9E0", Length = "0x98")]
  public void SetCharacter(CharacterData data)
  {
  }

  [Token(Token = "0x60009E1")]
  [Address(RVA = "0x4EBC90", Offset = "0x4EA890", Length = "0x8A")]
  protected void OnCharacterSelected(CharacterData data)
  {
  }

  [Token(Token = "0x60009E2")]
  [Address(RVA = "0x4EBB60", Offset = "0x4EA760", Length = "0x121")]
  protected override void Init()
  {
  }

  [Token(Token = "0x60009E3")]
  [Address(RVA = "0x4EBA30", Offset = "0x4EA630", Length = "0x121")]
  protected override void Cleanup()
  {
  }

  [Token(Token = "0x60009E4")]
  [Address(RVA = "0x4EBD20", Offset = "0x4EA920", Length = "0x56")]
  protected override void OnClicked()
  {
  }

  [Token(Token = "0x60009E5")]
  [Address(RVA = "0x4EBD80", Offset = "0x4EA980", Length = "0x56")]
  protected override void OnSelectedCharacter()
  {
  }

  [Token(Token = "0x60009E6")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public CharacterPrefabUI()
  {
  }
}
