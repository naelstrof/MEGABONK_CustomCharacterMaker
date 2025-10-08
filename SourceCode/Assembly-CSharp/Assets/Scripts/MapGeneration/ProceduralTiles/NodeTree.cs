// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.MapGeneration.ProceduralTiles.NodeTree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MapGeneration.ProceduralTiles
{
  [Token(Token = "0x2000349")]
  public class NodeTree
  {
    [Token(Token = "0x40016AD")]
    [FieldOffset(Offset = "0x28")]
    public int height;
    [Token(Token = "0x40016AE")]
    [FieldOffset(Offset = "0x2C")]
    public int yDir;

    [field: Token(Token = "0x40016AA")]
    [field: FieldOffset(Offset = "0x10")]
    [Token(Token = "0x1700037E")]
    public Vector2Int position { [Token(Token = "0x6001786"), Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")] get; [Token(Token = "0x6001787"), Address(RVA = "0x3D5210", Offset = "0x3D3E10", Length = "0x5")] private set; }

    [field: Token(Token = "0x40016AB")]
    [field: FieldOffset(Offset = "0x18")]
    [Token(Token = "0x1700037F")]
    public NodeTree parent { [Token(Token = "0x6001788"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get; [Token(Token = "0x6001789"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] private set; }

    [field: Token(Token = "0x40016AC")]
    [field: FieldOffset(Offset = "0x20")]
    [Token(Token = "0x17000380")]
    public List<NodeTree> children { [Token(Token = "0x600178A"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get; [Token(Token = "0x600178B"), Address(RVA = "0x359A30", Offset = "0x358630", Length = "0xD")] private set; }

    [Token(Token = "0x600178C")]
    [Address(RVA = "0x3D5170", Offset = "0x3D3D70", Length = "0x9B")]
    public NodeTree(Vector2Int position, NodeTree parent)
    {
    }

    [Token(Token = "0x600178D")]
    [Address(RVA = "0x3D4DC0", Offset = "0x3D39C0", Length = "0x3A2")]
    public override string ToString() => (string) null;
  }
}
