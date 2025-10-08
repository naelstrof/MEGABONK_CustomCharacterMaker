// Decompiled with JetBrains decompiler
// Type: Funfact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000197")]
public class Funfact : MonoBehaviour
{
  [Token(Token = "0x4000BAA")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_text;
  [Token(Token = "0x4000BAB")]
  [FieldOffset(Offset = "0x28")]
  private string[] facts;

  [Token(Token = "0x6000A47")]
  [Address(RVA = "0x4ECD20", Offset = "0x4EB920", Length = "0x5F")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A48")]
  [Address(RVA = "0x4ECCE0", Offset = "0x4EB8E0", Length = "0x39")]
  private string GetRandomFact() => (string) null;

  [Token(Token = "0x6000A49")]
  [Address(RVA = "0x4ECD80", Offset = "0x4EB980", Length = "0x1D2")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A4A")]
  [Address(RVA = "0x4ECF60", Offset = "0x4EBB60", Length = "0x535")]
  public Funfact()
  {
  }
}
