// Decompiled with JetBrains decompiler
// Type: CharacterMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000186")]
public class CharacterMenu : Window
{
  [Token(Token = "0x4000B3A")]
  [FieldOffset(Offset = "0x50")]
  public BackEscape windowBackEscape;
  [Token(Token = "0x4000B3B")]
  public static ECharacter selectedCharacter;
  [Token(Token = "0x4000B3C")]
  [FieldOffset(Offset = "0x58")]
  public Transform characterGridParent;
  [Token(Token = "0x4000B3D")]
  [FieldOffset(Offset = "0x60")]
  public GameObject characterPrefabUi;
  [Token(Token = "0x4000B3E")]
  [FieldOffset(Offset = "0x68")]
  public MyButton b_confirm;
  [Token(Token = "0x4000B3F")]
  [FieldOffset(Offset = "0x70")]
  public MyButton b_purchase;
  [Token(Token = "0x4000B40")]
  [FieldOffset(Offset = "0x78")]
  public MyButton b_back;
  [Token(Token = "0x4000B41")]
  [FieldOffset(Offset = "0x80")]
  private List<MyButtonCharacter> characterButtons;
  [Token(Token = "0x4000B42")]
  [FieldOffset(Offset = "0x88")]
  public SkinSelection skinSelection;
  [Token(Token = "0x4000B43")]
  [FieldOffset(Offset = "0x90")]
  private MyButtonCharacter selectedButton;
  [Token(Token = "0x4000B44")]
  [FieldOffset(Offset = "0x98")]
  public MainMenu mainMenu;
  [Token(Token = "0x4000B45")]
  [FieldOffset(Offset = "0xA0")]
  public UnlocksUi shopUi;

  [Token(Token = "0x60009CE")]
  [Address(RVA = "0x4EA540", Offset = "0x4E9140", Length = "0x1F")]
  public new void FocusWindow()
  {
  }

  [Token(Token = "0x60009CF")]
  [Address(RVA = "0x4EA2B0", Offset = "0x4E8EB0", Length = "0x1F")]
  private new void Awake()
  {
  }

  [Token(Token = "0x60009D0")]
  [Address(RVA = "0x4EA960", Offset = "0x4E9560", Length = "0x8C")]
  private new void OnEnable()
  {
  }

  [Token(Token = "0x60009D1")]
  [Address(RVA = "0x4EB020", Offset = "0x4E9C20", Length = "0x920")]
  private void TryInit()
  {
  }

  [Token(Token = "0x60009D2")]
  [Address(RVA = "0x4EAD60", Offset = "0x4E9960", Length = "0x2B2")]
  private void SetupButtonNavigation()
  {
  }

  [Token(Token = "0x60009D3")]
  [Address(RVA = "0x4EA9F0", Offset = "0x4E95F0", Length = "0x36D")]
  private void OnSelectCharacter(MyButtonCharacter characterButton)
  {
  }

  [Token(Token = "0x60009D4")]
  [Address(RVA = "0x4EA370", Offset = "0x4E8F70", Length = "0xA1")]
  private void DisableNavigationStatWindow()
  {
  }

  [Token(Token = "0x60009D5")]
  [Address(RVA = "0x4EA420", Offset = "0x4E9020", Length = "0x117")]
  private void EnableNavigationStatWindow()
  {
  }

  [Token(Token = "0x60009D6")]
  [Address(RVA = "0x4EA560", Offset = "0x4E9160", Length = "0x198")]
  private void OnConfirmCharacter(MyButtonCharacter characterButton)
  {
  }

  [Token(Token = "0x60009D7")]
  [Address(RVA = "0x4EA2D0", Offset = "0x4E8ED0", Length = "0x9E")]
  public void BuyCharacter()
  {
  }

  [Token(Token = "0x60009D8")]
  [Address(RVA = "0x4EB950", Offset = "0x4EA550", Length = "0x88")]
  private void Update()
  {
  }

  [Token(Token = "0x60009D9")]
  [Address(RVA = "0x4EA930", Offset = "0x4E9530", Length = "0x29")]
  private new void OnDisable()
  {
  }

  [Token(Token = "0x60009DA")]
  [Address(RVA = "0x4EA700", Offset = "0x4E9300", Length = "0x220")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x60009DB")]
  [Address(RVA = "0x4EBA20", Offset = "0x4EA620", Length = "0x7")]
  public CharacterMenu()
  {
  }

  [Token(Token = "0x60009DC")]
  [Address(RVA = "0x4EB9E0", Offset = "0x4EA5E0", Length = "0x39")]
  static CharacterMenu()
  {
  }
}
