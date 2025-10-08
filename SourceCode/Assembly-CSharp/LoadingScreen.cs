// Decompiled with JetBrains decompiler
// Type: LoadingScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001A8")]
public class LoadingScreen : MonoBehaviour
{
  [Token(Token = "0x4000BF9")]
  [FieldOffset(Offset = "0x20")]
  private string sceneName;
  [Token(Token = "0x4000BFA")]
  [FieldOffset(Offset = "0x28")]
  private string finalMapName;
  [Token(Token = "0x4000BFB")]
  [FieldOffset(Offset = "0x30")]
  public Transform loadingBar;
  [Token(Token = "0x4000BFC")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_loading;

  [Token(Token = "0x6000AB1")]
  [Address(RVA = "0x4F3720", Offset = "0x4F2320", Length = "0xFC")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AB2")]
  [Address(RVA = "0x4F36B0", Offset = "0x4F22B0", Length = "0x67")]
  private IEnumerator LoadSceneAsync() => (IEnumerator) null;

  [Token(Token = "0x6000AB3")]
  [Address(RVA = "0x4F3820", Offset = "0x4F2420", Length = "0x76")]
  public LoadingScreen()
  {
  }
}
