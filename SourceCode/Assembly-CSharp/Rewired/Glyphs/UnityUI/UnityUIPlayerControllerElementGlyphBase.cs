// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIPlayerControllerElementGlyphBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Glyphs.UnityUI
{
  [Token(Token = "0x200028F")]
  public abstract class UnityUIPlayerControllerElementGlyphBase : UnityUIControllerElementGlyphBase
  {
    [Tooltip("Optional reference to an object that defines options. If blank, the global default options will be used.")]
    [SerializeField]
    [Token(Token = "0x40011F5")]
    [FieldOffset(Offset = "0x48")]
    private ControllerElementGlyphSelectorOptionsSOBase _options;
    [Tooltip("The range of the Action for which to show glyphs / text. This determines whether to show the glyph for an axis-type Action (ex: Move Horizontal), or the positive/negative pole of an Action (ex: Move Right). For button-type Actions, Full and Positive are equivalent.")]
    [SerializeField]
    [Token(Token = "0x40011F6")]
    [FieldOffset(Offset = "0x50")]
    private AxisRange _actionRange;
    [Tooltip("Optional parent Transform of the first group of instantiated glyph / text objects. If an axis-type Action is bound to multiple elements, the glyphs bound to the negative pole of the Action will be instantiated under this Transform. This allows you to separate negative and positive groups in order to stack glyph groups horizontally or vertically, for example. If an Action is only bound to one element, the glyph will be instantiated under this transform. If blank, objects will be created as children of this object's Transform.")]
    [SerializeField]
    [Token(Token = "0x40011F7")]
    [FieldOffset(Offset = "0x58")]
    private Transform _group1;
    [Tooltip("Optional parent Transform of the second group of instantiated glyph / text objects. If an axis-type Action is bound to multiple elements, the glyphs bound to the positive pole of the Action will be instantiated under this Transform. This allows you to separate negative and positive groups in order to stack glyph groups horizontally or vertically, for example. If an Action is only bound to one element, the glyph will be instantiated under group1 instead. If blank, objects will be created as children of either group1 if set or the object's Transform.")]
    [SerializeField]
    [Token(Token = "0x40011F8")]
    [FieldOffset(Offset = "0x60")]
    private Transform _group2;
    [Token(Token = "0x40011F9")]
    [FieldOffset(Offset = "0x68")]
    [NonSerialized]
    private List<ActionElementMap> _tempAems;
    [Token(Token = "0x40011FA")]
    [FieldOffset(Offset = "0x70")]
    [NonSerialized]
    private List<ActionElementMap> _tempCombinedElementAems;
    [Token(Token = "0x40011FB")]
    [FieldOffset(Offset = "0x78")]
    [NonSerialized]
    private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _group1Objects;
    [Token(Token = "0x40011FC")]
    [FieldOffset(Offset = "0x80")]
    [NonSerialized]
    private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _group2Objects;

    [Token(Token = "0x17000304")]
    public virtual ControllerElementGlyphSelectorOptionsSOBase options
    {
      [Token(Token = "0x600130A"), Address(RVA = "0x345C40", Offset = "0x344840", Length = "0x5")] get => (ControllerElementGlyphSelectorOptionsSOBase) null;
      [Token(Token = "0x600130B"), Address(RVA = "0x3993F0", Offset = "0x397FF0", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x17000305")]
    public abstract int playerId { [Token(Token = "0x600130C")] get; [Token(Token = "0x600130D")] set; }

    [Token(Token = "0x17000306")]
    public abstract int actionId { [Token(Token = "0x600130E")] get; [Token(Token = "0x600130F")] set; }

    [Token(Token = "0x17000307")]
    public virtual AxisRange actionRange
    {
      [Token(Token = "0x6001310"), Address(RVA = "0x3992D0", Offset = "0x397ED0", Length = "0x4")] get => new AxisRange();
      [Token(Token = "0x6001311"), Address(RVA = "0x399380", Offset = "0x397F80", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000308")]
    public virtual Transform group1
    {
      [Token(Token = "0x6001312"), Address(RVA = "0x3992E0", Offset = "0x397EE0", Length = "0x5")] get => (Transform) null;
      [Token(Token = "0x6001313"), Address(RVA = "0x399390", Offset = "0x397F90", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x17000309")]
    public virtual Transform group2
    {
      [Token(Token = "0x6001314"), Address(RVA = "0x3992F0", Offset = "0x397EF0", Length = "0x5")] get => (Transform) null;
      [Token(Token = "0x6001315"), Address(RVA = "0x3993C0", Offset = "0x397FC0", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x1700030A")]
    protected virtual bool isMousePrioritizedOverKeyboard
    {
      [Token(Token = "0x6001316"), Address(RVA = "0x399300", Offset = "0x397F00", Length = "0x7B")] get => false;
    }

    [Token(Token = "0x6001317")]
    [Address(RVA = "0x398F70", Offset = "0x397B70", Length = "0x52")]
    protected virtual bool TryGetControllerTypeOrder(int index, out ControllerType controllerType)
    {
      controllerType = new ControllerType();
      return false;
    }

    [Token(Token = "0x6001318")]
    [Address(RVA = "0x398FD0", Offset = "0x397BD0", Length = "0x1D7")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6001319")]
    [Address(RVA = "0x3984F0", Offset = "0x3970F0", Length = "0x90")]
    protected override void ClearObjects()
    {
    }

    [Token(Token = "0x600131A")]
    [Address(RVA = "0x398B30", Offset = "0x397730", Length = "0x83")]
    protected virtual bool ShowBinding(ActionElementMap actionElementMap) => false;

    [Token(Token = "0x600131B")]
    [Address(RVA = "0x398D80", Offset = "0x397980", Length = "0x1EC")]
    protected virtual bool ShowSplitAxisBindings(
      ActionElementMap negativeAem,
      ActionElementMap positiveAem)
    {
      return false;
    }

    [Token(Token = "0x600131C")]
    [Address(RVA = "0x398590", Offset = "0x397190", Length = "0xFE")]
    protected override void EvaluateObjectVisibility()
    {
    }

    [Token(Token = "0x600131D")]
    [Address(RVA = "0x398BC0", Offset = "0x3977C0", Length = "0x1B4")]
    protected virtual int ShowGlyphsOrText(
      IList<ActionElementMap> bindings,
      Transform parent,
      List<ControllerElementGlyphBase.GlyphOrTextObject> objects)
    {
      return 0;
    }

    [Token(Token = "0x600131E")]
    [Address(RVA = "0x3989D0", Offset = "0x3975D0", Length = "0x15D")]
    protected override void Hide()
    {
    }

    [Token(Token = "0x600131F")]
    [Address(RVA = "0x398690", Offset = "0x397290", Length = "0x195")]
    protected virtual Transform GetObjectGroupTransform(int groupIndex) => (Transform) null;

    [Token(Token = "0x6001320")]
    [Address(RVA = "0x398830", Offset = "0x397430", Length = "0x197")]
    protected virtual ControllerElementGlyphSelectorOptions GetOptionsOrDefault() => (ControllerElementGlyphSelectorOptions) null;

    [Token(Token = "0x6001321")]
    [Address(RVA = "0x3991B0", Offset = "0x397DB0", Length = "0x11F")]
    protected UnityUIPlayerControllerElementGlyphBase()
    {
    }
  }
}
