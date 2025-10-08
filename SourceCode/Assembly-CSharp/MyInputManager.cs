// Decompiled with JetBrains decompiler
// Type: MyInputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired;
using System;
using UnityEngine;

[Token(Token = "0x2000089")]
public class MyInputManager : MonoBehaviour
{
  [Token(Token = "0x4000464")]
  [FieldOffset(Offset = "0x20")]
  public UserDataStore_FileCustom userDataStore;
  [Token(Token = "0x4000466")]
  private static Player player;
  [Token(Token = "0x4000467")]
  public static Action<Controller> A_SetCurrentController;
  [Token(Token = "0x4000468")]
  private static double mouseLastActiveTime;

  [field: Token(Token = "0x4000465")]
  [Token(Token = "0x1700001C")]
  public static Controller currentController { [Token(Token = "0x6000369"), Address(RVA = "0x46AC20", Offset = "0x469820", Length = "0x36")] get; [Token(Token = "0x600036A"), Address(RVA = "0x46AC60", Offset = "0x469860", Length = "0x51")] private set; }

  [Token(Token = "0x600036B")]
  [Address(RVA = "0x46A1F0", Offset = "0x468DF0", Length = "0x177")]
  private void Awake()
  {
  }

  [Token(Token = "0x600036C")]
  [Address(RVA = "0x46A910", Offset = "0x469510", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600036D")]
  [Address(RVA = "0x46AA50", Offset = "0x469650", Length = "0x3D")]
  private void OnSavesLoaded()
  {
  }

  [Token(Token = "0x600036E")]
  [Address(RVA = "0x46AB60", Offset = "0x469760", Length = "0xB6")]
  private void Update()
  {
  }

  [Token(Token = "0x600036F")]
  [Address(RVA = "0x46A860", Offset = "0x469460", Length = "0xA4")]
  public static bool IsUsingController() => false;

  [Token(Token = "0x6000370")]
  [Address(RVA = "0x46A370", Offset = "0x468F70", Length = "0x262")]
  private void CheckCurrentController()
  {
  }

  [Token(Token = "0x6000371")]
  [Address(RVA = "0x46A710", Offset = "0x469310", Length = "0x140")]
  public static Player GetPlayer() => (Player) null;

  [Token(Token = "0x6000372")]
  [Address(RVA = "0x46A6B0", Offset = "0x4692B0", Length = "0x50")]
  public static Controller GetLastActiveController() => (Controller) null;

  [Token(Token = "0x6000373")]
  [Address(RVA = "0x46A670", Offset = "0x469270", Length = "0x3F")]
  public static bool GetButton(string action) => false;

  [Token(Token = "0x6000374")]
  [Address(RVA = "0x46A630", Offset = "0x469230", Length = "0x3F")]
  public static bool GetButtonDown(string action) => false;

  [Token(Token = "0x6000375")]
  [Address(RVA = "0x46A5E0", Offset = "0x4691E0", Length = "0x42")]
  public static float GetAxis(string action) => 0.0f;

  [Token(Token = "0x6000376")]
  [Address(RVA = "0x46AA90", Offset = "0x469690", Length = "0xC6")]
  private void SetController(Controller c)
  {
  }

  [Token(Token = "0x6000377")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MyInputManager()
  {
  }
}
