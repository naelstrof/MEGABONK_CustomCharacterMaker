// Decompiled with JetBrains decompiler
// Type: Rewired.Data.UserDataStore_File
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Data
{
  [Token(Token = "0x2000246")]
  public class UserDataStore_File : UserDataStore_KeyValue
  {
    [Token(Token = "0x4001103")]
    private static readonly string thisScriptName;
    [Token(Token = "0x4001104")]
    private const string logPrefix = "Rewired: ";
    [Token(Token = "0x4001105")]
    private const string defaultExtensionText = ".json";
    [Token(Token = "0x4001106")]
    private const string defaultExtensionBinary = ".bin";
    [Token(Token = "0x4001107")]
    private const string defaultFileName = "RewiredSaveData.json";
    [Tooltip("The data file name. Changing this will make saved data already stored with the old file name no longer accessible.")]
    [SerializeField]
    [Token(Token = "0x4001108")]
    [FieldOffset(Offset = "0x58")]
    private string _fileName;
    [Tooltip("Determines if the file should be stored as binary or text. Changing this will make saved data already stored no longer accessible.")]
    [SerializeField]
    [Token(Token = "0x4001109")]
    [FieldOffset(Offset = "0x60")]
    private UserDataStore_File.DataFormat _dataFormat;
    [Token(Token = "0x400110A")]
    [FieldOffset(Offset = "0x68")]
    [NonSerialized]
    private string __directory;
    [Token(Token = "0x400110B")]
    [FieldOffset(Offset = "0x70")]
    [NonSerialized]
    private UserDataStore_File.DataStore _dataStore;
    [Token(Token = "0x400110C")]
    [FieldOffset(Offset = "0x78")]
    [NonSerialized]
    private UserDataStore_File.IDataHandler __dataHandler;
    [Token(Token = "0x400110D")]
    [FieldOffset(Offset = "0x80")]
    [NonSerialized]
    private bool _initialized;

    [Token(Token = "0x17000280")]
    public string directory
    {
      [Token(Token = "0x600106E"), Address(RVA = "0x534B20", Offset = "0x533720", Length = "0x80")] get => (string) null;
      [Token(Token = "0x600106F"), Address(RVA = "0x534C00", Offset = "0x533800", Length = "0x34")] set
      {
      }
    }

    [Token(Token = "0x17000281")]
    public string fileName
    {
      [Token(Token = "0x6001070"), Address(RVA = "0x3992E0", Offset = "0x397EE0", Length = "0x5")] get => (string) null;
      [Token(Token = "0x6001071"), Address(RVA = "0x534C40", Offset = "0x533840", Length = "0x34")] set
      {
      }
    }

    [Token(Token = "0x17000282")]
    public UserDataStore_File.DataFormat dataFormat
    {
      [Token(Token = "0x6001072"), Address(RVA = "0x5347D0", Offset = "0x5333D0", Length = "0x4")] get => new UserDataStore_File.DataFormat();
      [Token(Token = "0x6001073"), Address(RVA = "0x534BA0", Offset = "0x5337A0", Length = "0x14")] set
      {
      }
    }

    [Token(Token = "0x17000283")]
    protected UserDataStore_File.IDataHandler dataHandler
    {
      [Token(Token = "0x6001074"), Address(RVA = "0x534960", Offset = "0x533560", Length = "0x1B5")] get => (UserDataStore_File.IDataHandler) null;
      [Token(Token = "0x6001075"), Address(RVA = "0x534BC0", Offset = "0x5337C0", Length = "0x34")] set
      {
      }
    }

    [Token(Token = "0x17000284")]
    protected override UserDataStore_KeyValue.IDataStore dataStore
    {
      [Token(Token = "0x6001076"), Address(RVA = "0x529580", Offset = "0x528180", Length = "0x5")] get => (UserDataStore_KeyValue.IDataStore) null;
    }

    [Token(Token = "0x6001077")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void SetInitialValues()
    {
    }

    [Token(Token = "0x6001078")]
    [Address(RVA = "0x534710", Offset = "0x533310", Length = "0xBE")]
    protected override void OnInitialize()
    {
    }

    [Token(Token = "0x6001079")]
    [Address(RVA = "0x5343D0", Offset = "0x532FD0", Length = "0x33D")]
    private void OnDataSourceChanged()
    {
    }

    [Token(Token = "0x600107A")]
    [Address(RVA = "0x534890", Offset = "0x533490", Length = "0xCD")]
    public UserDataStore_File()
    {
    }

    [Token(Token = "0x600107B")]
    [Address(RVA = "0x5347E0", Offset = "0x5333E0", Length = "0xA1")]
    static UserDataStore_File()
    {
    }

    [Token(Token = "0x2000247")]
    private sealed class DataStore : UserDataStore_KeyValue.IDataStore
    {
      [Token(Token = "0x400110E")]
      [FieldOffset(Offset = "0x10")]
      private Dictionary<string, object> _data;
      [Token(Token = "0x400110F")]
      [FieldOffset(Offset = "0x18")]
      private readonly string _absFilePath;
      [Token(Token = "0x4001110")]
      [FieldOffset(Offset = "0x20")]
      private UserDataStore_File.IDataHandler _dataHandler;

      [Token(Token = "0x600107D")]
      [Address(RVA = "0x521100", Offset = "0x51FD00", Length = "0x13A")]
      public DataStore(
        string fileName,
        string absDirectory,
        UserDataStore_File.IDataHandler dataHandler)
      {
      }

      [Token(Token = "0x600107E")]
      [Address(RVA = "0x521060", Offset = "0x51FC60", Length = "0x94")]
      public bool TryGetValue(string key, out object value)
      {
        value = (object) null;
        return false;
      }

      [Token(Token = "0x600107F")]
      [Address(RVA = "0x520FD0", Offset = "0x51FBD0", Length = "0x86")]
      public bool SetValue(string key, object value) => false;

      [Token(Token = "0x6001080")]
      [Address(RVA = "0x520EC0", Offset = "0x51FAC0", Length = "0x10D")]
      public bool Save() => false;

      [Token(Token = "0x6001081")]
      [Address(RVA = "0x520D10", Offset = "0x51F910", Length = "0x1AA")]
      public bool Load() => false;

      [Token(Token = "0x6001082")]
      [Address(RVA = "0x520BD0", Offset = "0x51F7D0", Length = "0x132")]
      public bool Clear() => false;
    }

    [Token(Token = "0x2000248")]
    private sealed class LocalFileDataHandler : UserDataStore_File.IDataHandler
    {
      [Token(Token = "0x4001111")]
      [FieldOffset(Offset = "0x10")]
      private readonly Func<UserDataStore_File.DataFormat> _dataFormatDelegate;
      [Token(Token = "0x4001112")]
      [FieldOffset(Offset = "0x18")]
      private readonly UserDataStore_File.Codec _codec;

      [Token(Token = "0x6001083")]
      [Address(RVA = "0x5294A0", Offset = "0x5280A0", Length = "0xD8")]
      public LocalFileDataHandler(
        Func<UserDataStore_File.DataFormat> dataFormatDelegate,
        UserDataStore_File.Codec codec)
      {
      }

      [Token(Token = "0x6001084")]
      [Address(RVA = "0x529190", Offset = "0x527D90", Length = "0x17C")]
      public bool Load(string absoluteFilePath, out string data)
      {
        data = (string) null;
        return false;
      }

      [Token(Token = "0x6001085")]
      [Address(RVA = "0x529310", Offset = "0x527F10", Length = "0x180")]
      public bool Save(string absoluteFilePath, string data) => false;

      [Token(Token = "0x6001086")]
      [Address(RVA = "0x529120", Offset = "0x527D20", Length = "0x6B")]
      public bool Clear(string absoluteFilePath) => false;
    }

    [Token(Token = "0x2000249")]
    private abstract class Codec
    {
      [Token(Token = "0x6001087")]
      public abstract byte[] Encode(string @string);

      [Token(Token = "0x6001088")]
      public abstract string Decode(byte[] data);

      [Token(Token = "0x6001089")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      protected Codec()
      {
      }
    }

    [Token(Token = "0x200024A")]
    private sealed class UTF8Text : UserDataStore_File.Codec
    {
      [Token(Token = "0x600108A")]
      [Address(RVA = "0x533880", Offset = "0x532480", Length = "0x39")]
      public override byte[] Encode(string @string) => (byte[]) null;

      [Token(Token = "0x600108B")]
      [Address(RVA = "0x533840", Offset = "0x532440", Length = "0x39")]
      public override string Decode(byte[] data) => (string) null;

      [Token(Token = "0x600108C")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      public UTF8Text()
      {
      }
    }

    [Token(Token = "0x200024B")]
    private sealed class CLZF2 : UserDataStore_File.Codec
    {
      [Token(Token = "0x4001113")]
      [FieldOffset(Offset = "0x10")]
      private readonly Rewired.Utils.Libraries.CLZF2.CLZF2 _cLZF2;

      [Token(Token = "0x600108D")]
      [Address(RVA = "0x51CBD0", Offset = "0x51B7D0", Length = "0x66")]
      public CLZF2()
      {
      }

      [Token(Token = "0x600108E")]
      [Address(RVA = "0x51CB70", Offset = "0x51B770", Length = "0x59")]
      public override byte[] Encode(string @string) => (byte[]) null;

      [Token(Token = "0x600108F")]
      [Address(RVA = "0x51CB00", Offset = "0x51B700", Length = "0x66")]
      public override string Decode(byte[] data) => (string) null;
    }

    [Token(Token = "0x200024C")]
    public interface IDataHandler
    {
      [Token(Token = "0x6001090")]
      bool Load(string absoluteFilePath, out string data);

      [Token(Token = "0x6001091")]
      bool Save(string absoluteFilePath, string data);

      [Token(Token = "0x6001092")]
      bool Clear(string absoluteFilePath);
    }

    [Token(Token = "0x200024D")]
    public enum DataFormat
    {
      [Token(Token = "0x4001115")] Text,
      [Token(Token = "0x4001116")] Binary,
    }
  }
}
