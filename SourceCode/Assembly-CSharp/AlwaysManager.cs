// Decompiled with JetBrains decompiler
// Type: AlwaysManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;


#nullable enable
[Token(Token = "0x20000CD")]
public class AlwaysManager : MonoBehaviour
{
  [Token(Token = "0x4000698")]
  [FieldOffset(Offset = "0x20")]
  public 
  #nullable disable
  DataManager dataManager;
  [Token(Token = "0x4000699")]
  [FieldOffset(Offset = "0x28")]
  public SteamManager steamManager;
  [Token(Token = "0x400069A")]
  [FieldOffset(Offset = "0x30")]
  public GameObject rewiredManager;
  [Token(Token = "0x400069B")]
  [FieldOffset(Offset = "0x38")]
  public GameObject eventSystem;
  [Token(Token = "0x400069C")]
  [FieldOffset(Offset = "0x40")]
  public AlwaysUi alwaysUi;
  [Token(Token = "0x400069D")]
  public static AlwaysManager Instance;
  [Token(Token = "0x400069E")]
  [FieldOffset(Offset = "0x48")]
  public Material playerMaterialPreset;

  [Token(Token = "0x6000591")]
  [Address(RVA = "0x491660", Offset = "0x490260", Length = "0x429")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000592")]
  [Address(RVA = "0x491C50", Offset = "0x490850", Length = "0x40")]
  private void Start()
  {
  }

  [Token(Token = "0x6000593")]
  [Address(RVA = "0x491C90", Offset = "0x490890", Length = "0x118")]
  private void Update()
  {
  }

  [Token(Token = "0x6000594")]
  [Address(RVA = "0x491A90", Offset = "0x490690", Length = "0x68")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000595")]
  [Address(RVA = "0x491B00", Offset = "0x490700", Length = "0x14B")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000596")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AlwaysManager()
  {
  }
}
