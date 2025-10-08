// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroSceneSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x2000464")]
  public class RetroSceneSelect : MonoBehaviour
  {
    [Token(Token = "0x4001CED")]
    [FieldOffset(Offset = "0x20")]
    private bool GUIHide01;
    [Token(Token = "0x4001CEE")]
    [FieldOffset(Offset = "0x21")]
    private bool GUIHide02;
    [Token(Token = "0x4001CEF")]
    [FieldOffset(Offset = "0x22")]
    private bool GUIHide03;

    [Token(Token = "0x6001FA7")]
    [Address(RVA = "0x459620", Offset = "0x458220", Length = "0x53")]
    public void CBLoadSceneBeams()
    {
    }

    [Token(Token = "0x6001FA8")]
    [Address(RVA = "0x459680", Offset = "0x458280", Length = "0x53")]
    public void CBLoadSceneEmojis()
    {
    }

    [Token(Token = "0x6001FA9")]
    [Address(RVA = "0x4596E0", Offset = "0x4582E0", Length = "0x53")]
    public void CBLoadSceneExplosions()
    {
    }

    [Token(Token = "0x6001FAA")]
    [Address(RVA = "0x459740", Offset = "0x458340", Length = "0x53")]
    public void CBLoadSceneLibrary()
    {
    }

    [Token(Token = "0x6001FAB")]
    [Address(RVA = "0x4597A0", Offset = "0x4583A0", Length = "0x53")]
    public void CBLoadSceneLoot()
    {
    }

    [Token(Token = "0x6001FAC")]
    [Address(RVA = "0x459800", Offset = "0x458400", Length = "0x53")]
    public void CBLoadSceneMissiles()
    {
    }

    [Token(Token = "0x6001FAD")]
    [Address(RVA = "0x459860", Offset = "0x458460", Length = "0x53")]
    public void CBLoadScenePowerups()
    {
    }

    [Token(Token = "0x6001FAE")]
    [Address(RVA = "0x4599C0", Offset = "0x4585C0", Length = "0xA6")]
    private void Update()
    {
    }

    [Token(Token = "0x6001FAF")]
    [Address(RVA = "0x4598C0", Offset = "0x4584C0", Length = "0xF3")]
    private void CheckKeyCode(KeyCode keyCode, ref bool guiHide, string canvasName)
    {
    }

    [Token(Token = "0x6001FB0")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public RetroSceneSelect()
    {
    }
  }
}
