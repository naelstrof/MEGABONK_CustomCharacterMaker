// Decompiled with JetBrains decompiler
// Type: Rewired.Data.UserDataStore_PlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Rewired.Data
{
  [Token(Token = "0x200025B")]
  public class UserDataStore_PlayerPrefs : UserDataStore
  {
    [Token(Token = "0x4001144")]
    private const string thisScriptName = "UserDataStore_PlayerPrefs";
    [Token(Token = "0x4001145")]
    private const string logPrefix = "Rewired: ";
    [Token(Token = "0x4001146")]
    private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";
    [Token(Token = "0x4001147")]
    private const int controllerMapPPKeyVersion_original = 0;
    [Token(Token = "0x4001148")]
    private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;
    [Token(Token = "0x4001149")]
    private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;
    [Token(Token = "0x400114A")]
    private const int controllerMapPPKeyVersion_includeFormatVersion = 2;
    [Token(Token = "0x400114B")]
    private const int controllerMapPPKeyVersion = 2;
    [Token(Token = "0x400114C")]
    private const int controllerElementByRoleMapPPKeyVersion = 0;
    [Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
    [SerializeField]
    [Token(Token = "0x400114D")]
    [FieldOffset(Offset = "0x20")]
    private bool isEnabled;
    [Tooltip("Should saved data be loaded on start?")]
    [SerializeField]
    [Token(Token = "0x400114E")]
    [FieldOffset(Offset = "0x21")]
    private bool loadDataOnStart;
    [Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
    [SerializeField]
    [Token(Token = "0x400114F")]
    [FieldOffset(Offset = "0x22")]
    private bool loadJoystickAssignments;
    [Tooltip("Should Player Keyboard assignments be saved and loaded?")]
    [SerializeField]
    [Token(Token = "0x4001150")]
    [FieldOffset(Offset = "0x23")]
    private bool loadKeyboardAssignments;
    [Tooltip("Should Player Mouse assignments be saved and loaded?")]
    [SerializeField]
    [Token(Token = "0x4001151")]
    [FieldOffset(Offset = "0x24")]
    private bool loadMouseAssignments;
    [Tooltip("How should Action mapping data be saved?\n\nBy Controller: Data is stored per-controller. Action mappings apply only to the specific controller for which it was saved.\n\nBy Controller Element Role: Data is stored per-element on the controller if the controller element has a known role. Action mappings are mirrored on controller elements with the same role on all other controllers for the Player. Example: When saving Action mappings for a gamepad, element on all gamepads that have the same roles will inherit the mappings. This allows you to remap once for all compatible gamepads simultaneously, for example. This can extend beyond just gamepads, however. For example: On a console platform, a racing wheel with A, B, X, Y, D-Pad etc. elements will also reflect the same Action mappings if the gamepad is remapped. Action mappings for any controller elements that do not have known roles will be saved per-controller. Warning: Do not use this mode if you need to allow a Player to save different mappings for multiple controllers of the same type such as gamepads. (This option currently works best for gamepads and only miminally for other controller types.)")]
    [SerializeField]
    [Token(Token = "0x4001152")]
    [FieldOffset(Offset = "0x28")]
    private UserDataStore_PlayerPrefs.ActionMappingSaveMode _actionMappingSaveMode;
    [Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
    [SerializeField]
    [Token(Token = "0x4001153")]
    [FieldOffset(Offset = "0x30")]
    private string playerPrefsKeyPrefix;
    [Token(Token = "0x4001154")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    private bool allowImpreciseJoystickAssignmentMatching;
    [Token(Token = "0x4001155")]
    [FieldOffset(Offset = "0x39")]
    [NonSerialized]
    private bool deferredJoystickAssignmentLoadPending;
    [Token(Token = "0x4001156")]
    [FieldOffset(Offset = "0x3A")]
    [NonSerialized]
    private bool wasJoystickEverDetected;
    [Token(Token = "0x4001157")]
    [FieldOffset(Offset = "0x40")]
    [NonSerialized]
    private List<int> __allActionIds;
    [Token(Token = "0x4001158")]
    [FieldOffset(Offset = "0x48")]
    [NonSerialized]
    private string __allActionIdsString;
    [Token(Token = "0x4001159")]
    [FieldOffset(Offset = "0x50")]
    [NonSerialized]
    private readonly StringBuilder _sb;
    [Token(Token = "0x400115A")]
    [FieldOffset(Offset = "0x58")]
    [NonSerialized]
    private Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> _tempElementByRoleMaps;
    [Token(Token = "0x400115B")]
    [FieldOffset(Offset = "0x60")]
    [NonSerialized]
    private Dictionary<string, bool> _tempElementByRoleMapsEnabled;

    [Token(Token = "0x17000293")]
    public bool IsEnabled
    {
      [Token(Token = "0x6001113"), Address(RVA = "0x36EB80", Offset = "0x36D780", Length = "0x5")] get => false;
      [Token(Token = "0x6001114"), Address(RVA = "0x386410", Offset = "0x385010", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000294")]
    public bool LoadDataOnStart
    {
      [Token(Token = "0x6001115"), Address(RVA = "0x385F50", Offset = "0x384B50", Length = "0x5")] get => false;
      [Token(Token = "0x6001116"), Address(RVA = "0x386420", Offset = "0x385020", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000295")]
    public bool LoadJoystickAssignments
    {
      [Token(Token = "0x6001117"), Address(RVA = "0x385F60", Offset = "0x384B60", Length = "0x5")] get => false;
      [Token(Token = "0x6001118"), Address(RVA = "0x386430", Offset = "0x385030", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000296")]
    public bool LoadKeyboardAssignments
    {
      [Token(Token = "0x6001119"), Address(RVA = "0x385F70", Offset = "0x384B70", Length = "0x5")] get => false;
      [Token(Token = "0x600111A"), Address(RVA = "0x386440", Offset = "0x385040", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000297")]
    public bool LoadMouseAssignments
    {
      [Token(Token = "0x600111B"), Address(RVA = "0x385F80", Offset = "0x384B80", Length = "0x5")] get => false;
      [Token(Token = "0x600111C"), Address(RVA = "0x386450", Offset = "0x385050", Length = "0x138")] set
      {
      }
    }

    [Token(Token = "0x17000298")]
    public UserDataStore_PlayerPrefs.ActionMappingSaveMode actionMappingSaveMode
    {
      [Token(Token = "0x600111D"), Address(RVA = "0x36C770", Offset = "0x36B370", Length = "0x4")] get => new UserDataStore_PlayerPrefs.ActionMappingSaveMode();
      [Token(Token = "0x600111E"), Address(RVA = "0x36C7A0", Offset = "0x36B3A0", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000299")]
    public string PlayerPrefsKeyPrefix
    {
      [Token(Token = "0x600111F"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get => (string) null;
      [Token(Token = "0x6001120"), Address(RVA = "0x370A90", Offset = "0x36F690", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x1700029A")]
    private string playerPrefsKey_controllerAssignments
    {
      [Token(Token = "0x6001121"), Address(RVA = "0x3863C0", Offset = "0x384FC0", Length = "0x50")] get => (string) null;
    }

    [Token(Token = "0x1700029B")]
    private bool loadControllerAssignments
    {
      [Token(Token = "0x6001122"), Address(RVA = "0x3863A0", Offset = "0x384FA0", Length = "0x14")] get => false;
    }

    [Token(Token = "0x1700029C")]
    private List<int> allActionIds
    {
      [Token(Token = "0x6001123"), Address(RVA = "0x3860F0", Offset = "0x384CF0", Length = "0x2AA")] get => (List<int>) null;
    }

    [Token(Token = "0x1700029D")]
    private string allActionIdsString
    {
      [Token(Token = "0x6001124"), Address(RVA = "0x385F90", Offset = "0x384B90", Length = "0x153")] get => (string) null;
    }

    [Token(Token = "0x6001125")]
    [Address(RVA = "0x385AB0", Offset = "0x3846B0", Length = "0x72")]
    public override void Save()
    {
    }

    [Token(Token = "0x6001126")]
    [Address(RVA = "0x384020", Offset = "0x382C20", Length = "0xC4")]
    public override void SaveControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
    }

    [Token(Token = "0x6001127")]
    [Address(RVA = "0x3840F0", Offset = "0x382CF0", Length = "0xA3")]
    public override void SaveControllerData(ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x6001128")]
    [Address(RVA = "0x3859C0", Offset = "0x3845C0", Length = "0xED")]
    public override void SavePlayerData(int playerId)
    {
    }

    [Token(Token = "0x6001129")]
    [Address(RVA = "0x385250", Offset = "0x383E50", Length = "0x165")]
    public override void SaveInputBehavior(int playerId, int behaviorId)
    {
    }

    [Token(Token = "0x600112A")]
    [Address(RVA = "0x383000", Offset = "0x381C00", Length = "0x72")]
    public override void Load()
    {
    }

    [Token(Token = "0x600112B")]
    [Address(RVA = "0x37FCC0", Offset = "0x37E8C0", Length = "0xC3")]
    public override void LoadControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
    }

    [Token(Token = "0x600112C")]
    [Address(RVA = "0x37FC20", Offset = "0x37E820", Length = "0x9D")]
    public override void LoadControllerData(ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x600112D")]
    [Address(RVA = "0x382F20", Offset = "0x381B20", Length = "0xD5")]
    public override void LoadPlayerData(int playerId)
    {
    }

    [Token(Token = "0x600112E")]
    [Address(RVA = "0x381150", Offset = "0x37FD50", Length = "0x1AC")]
    public override void LoadInputBehavior(int playerId, int behaviorId)
    {
    }

    [Token(Token = "0x600112F")]
    [Address(RVA = "0x3833B0", Offset = "0x381FB0", Length = "0x9D")]
    protected override void OnInitialize()
    {
    }

    [Token(Token = "0x6001130")]
    [Address(RVA = "0x383080", Offset = "0x381C80", Length = "0xD0")]
    protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
    {
    }

    [Token(Token = "0x6001131")]
    [Address(RVA = "0x383380", Offset = "0x381F80", Length = "0x2E")]
    protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
    {
    }

    [Token(Token = "0x6001132")]
    [Address(RVA = "0x383160", Offset = "0x381D60", Length = "0x20")]
    protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
    {
    }

    [Token(Token = "0x6001133")]
    [Address(RVA = "0x384BF0", Offset = "0x3837F0", Length = "0x91")]
    public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x6001134")]
    [Address(RVA = "0x37FF00", Offset = "0x37EB00", Length = "0xCE")]
    public override ControllerMap LoadControllerMap(
      int playerId,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (ControllerMap) null;
    }

    [Token(Token = "0x6001135")]
    [Address(RVA = "0x37F7D0", Offset = "0x37E3D0", Length = "0x1FF")]
    private int LoadAll() => 0;

    [Token(Token = "0x6001136")]
    [Address(RVA = "0x382EA0", Offset = "0x381AA0", Length = "0x76")]
    private int LoadPlayerDataNow(int playerId) => 0;

    [Token(Token = "0x6001137")]
    [Address(RVA = "0x382BF0", Offset = "0x3817F0", Length = "0x2AD")]
    private int LoadPlayerDataNow(Player player) => 0;

    [Token(Token = "0x6001138")]
    [Address(RVA = "0x37F590", Offset = "0x37E190", Length = "0x23C")]
    private int LoadAllJoystickCalibrationData() => 0;

    [Token(Token = "0x6001139")]
    [Address(RVA = "0x3825A0", Offset = "0x3811A0", Length = "0x73")]
    private int LoadJoystickCalibrationData(Joystick joystick) => 0;

    [Token(Token = "0x600113A")]
    [Address(RVA = "0x3824C0", Offset = "0x3810C0", Length = "0xD7")]
    private int LoadJoystickCalibrationData(int joystickId) => 0;

    [Token(Token = "0x600113B")]
    [Address(RVA = "0x382620", Offset = "0x381220", Length = "0x246")]
    private int LoadJoystickData(int joystickId) => 0;

    [Token(Token = "0x600113C")]
    [Address(RVA = "0x37FB80", Offset = "0x37E780", Length = "0x73")]
    private int LoadControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      return 0;
    }

    [Token(Token = "0x600113D")]
    [Address(RVA = "0x37FC00", Offset = "0x37E800", Length = "0x15")]
    private int LoadControllerDataNow(ControllerType controllerType, int controllerId) => 0;

    [Token(Token = "0x600113E")]
    [Address(RVA = "0x3802A0", Offset = "0x37EEA0", Length = "0xC9D")]
    private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) => 0;

    [Token(Token = "0x600113F")]
    [Address(RVA = "0x37FFD0", Offset = "0x37EBD0", Length = "0x2C1")]
    private ControllerMap LoadControllerMap(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (ControllerMap) null;
    }

    [Token(Token = "0x6001140")]
    [Address(RVA = "0x37FD90", Offset = "0x37E990", Length = "0x160")]
    private bool LoadControllerElementMapByRole(
      Player player,
      Controller controller,
      string role,
      int mapCategoryId,
      int layoutId,
      Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> elementByRoleMaps)
    {
      return false;
    }

    [Token(Token = "0x6001141")]
    [Address(RVA = "0x381300", Offset = "0x37FF00", Length = "0x2D6")]
    private int LoadInputBehaviors(int playerId) => 0;

    [Token(Token = "0x6001142")]
    [Address(RVA = "0x380F40", Offset = "0x37FB40", Length = "0x158")]
    private int LoadInputBehaviorNow(int playerId, int behaviorId) => 0;

    [Token(Token = "0x6001143")]
    [Address(RVA = "0x3810A0", Offset = "0x37FCA0", Length = "0xB0")]
    private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => 0;

    [Token(Token = "0x6001144")]
    [Address(RVA = "0x37FB10", Offset = "0x37E710", Length = "0x67")]
    private bool LoadControllerAssignmentsNow() => false;

    [Token(Token = "0x6001145")]
    [Address(RVA = "0x382870", Offset = "0x381470", Length = "0x37C")]
    private bool LoadKeyboardAndMouseAssignmentsNow(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
    {
      return false;
    }

    [Token(Token = "0x6001146")]
    [Address(RVA = "0x381650", Offset = "0x380250", Length = "0xE66")]
    private bool LoadJoystickAssignmentsNow(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
    {
      return false;
    }

    [Token(Token = "0x6001147")]
    [Address(RVA = "0x37F9D0", Offset = "0x37E5D0", Length = "0x138")]
    private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData() => (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null;

    [Token(Token = "0x6001148")]
    [Address(RVA = "0x3815E0", Offset = "0x3801E0", Length = "0x67")]
    private IEnumerator LoadJoystickAssignmentsDeferred() => (IEnumerator) null;

    [Token(Token = "0x6001149")]
    [Address(RVA = "0x383710", Offset = "0x382310", Length = "0x320")]
    private void SaveAll()
    {
    }

    [Token(Token = "0x600114A")]
    [Address(RVA = "0x385930", Offset = "0x384530", Length = "0x8E")]
    private void SavePlayerDataNow(int playerId)
    {
    }

    [Token(Token = "0x600114B")]
    [Address(RVA = "0x3857E0", Offset = "0x3843E0", Length = "0x14B")]
    private void SavePlayerDataNow(Player player)
    {
    }

    [Token(Token = "0x600114C")]
    [Address(RVA = "0x3834E0", Offset = "0x3820E0", Length = "0x220")]
    private void SaveAllJoystickCalibrationData()
    {
    }

    [Token(Token = "0x600114D")]
    [Address(RVA = "0x385470", Offset = "0x384070", Length = "0xBC")]
    private void SaveJoystickCalibrationData(int joystickId)
    {
    }

    [Token(Token = "0x600114E")]
    [Address(RVA = "0x385530", Offset = "0x384130", Length = "0x70")]
    private void SaveJoystickCalibrationData(Joystick joystick)
    {
    }

    [Token(Token = "0x600114F")]
    [Address(RVA = "0x3855B0", Offset = "0x3841B0", Length = "0x225")]
    private void SaveJoystickData(int joystickId)
    {
    }

    [Token(Token = "0x6001150")]
    [Address(RVA = "0x383F90", Offset = "0x382B90", Length = "0x55")]
    private void SaveControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
    }

    [Token(Token = "0x6001151")]
    [Address(RVA = "0x383FF0", Offset = "0x382BF0", Length = "0x21")]
    private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x6001152")]
    [Address(RVA = "0x384F10", Offset = "0x383B10", Length = "0x1E7")]
    private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
    {
    }

    [Token(Token = "0x6001153")]
    [Address(RVA = "0x384C90", Offset = "0x383890", Length = "0x272")]
    private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x6001154")]
    [Address(RVA = "0x384B30", Offset = "0x383730", Length = "0xB2")]
    private void SaveControllerMap(Player player, ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x6001155")]
    [Address(RVA = "0x384870", Offset = "0x383470", Length = "0x2B2")]
    private void SaveControllerMapByController(Player player, ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x6001156")]
    [Address(RVA = "0x3841A0", Offset = "0x382DA0", Length = "0x6C9")]
    private void SaveControllerMapByControllerElementRole(
      Player player,
      Controller controller,
      ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x6001157")]
    [Address(RVA = "0x37D1E0", Offset = "0x37BDE0", Length = "0x251")]
    private bool AddControllerElementByRoleMapEntry(
      Player player,
      Controller controller,
      ActionElementMap elementMap,
      ref Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> maps)
    {
      return false;
    }

    [Token(Token = "0x6001158")]
    [Address(RVA = "0x3853C0", Offset = "0x383FC0", Length = "0xAA")]
    private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
    {
    }

    [Token(Token = "0x6001159")]
    [Address(RVA = "0x385150", Offset = "0x383D50", Length = "0xF9")]
    private void SaveInputBehaviorNow(int playerId, int behaviorId)
    {
    }

    [Token(Token = "0x600115A")]
    [Address(RVA = "0x385100", Offset = "0x383D00", Length = "0x49")]
    private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
    {
    }

    [Token(Token = "0x600115B")]
    [Address(RVA = "0x383A40", Offset = "0x382640", Length = "0x541")]
    private bool SaveControllerAssignments() => false;

    [Token(Token = "0x600115C")]
    [Address(RVA = "0x37E2F0", Offset = "0x37CEF0", Length = "0xC3")]
    private bool ControllerAssignmentSaveDataExists() => false;

    [Token(Token = "0x600115D")]
    [Address(RVA = "0x37EA70", Offset = "0x37D670", Length = "0x176")]
    private string GetControllerMapPlayerPrefsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return (string) null;
    }

    [Token(Token = "0x600115E")]
    [Address(RVA = "0x37E550", Offset = "0x37D150", Length = "0x1DA")]
    private string GetControllerElementByRoleMapPlayerPrefsKey(
      Player player,
      string elementRole,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return (string) null;
    }

    [Token(Token = "0x600115F")]
    [Address(RVA = "0x37F380", Offset = "0x37DF80", Length = "0x1B5")]
    private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick) => (string) null;

    [Token(Token = "0x6001160")]
    [Address(RVA = "0x37E730", Offset = "0x37D330", Length = "0x176")]
    private string GetControllerMapKnownActionIdsPlayerPrefsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return (string) null;
    }

    [Token(Token = "0x6001161")]
    [Address(RVA = "0x37F1E0", Offset = "0x37DDE0", Length = "0x141")]
    private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) => (string) null;

    [Token(Token = "0x6001162")]
    [Address(RVA = "0x37D9F0", Offset = "0x37C5F0", Length = "0x1A")]
    private static void AppendBaseKey(StringBuilder sb, string playerPrefsKeyPrefix)
    {
    }

    [Token(Token = "0x6001163")]
    [Address(RVA = "0x37E280", Offset = "0x37CE80", Length = "0x6F")]
    private static void AppendPlayerKey(StringBuilder sb, Player player)
    {
    }

    [Token(Token = "0x6001164")]
    [Address(RVA = "0x37DF20", Offset = "0x37CB20", Length = "0xBA")]
    private static void AppendControllerMapKey(
      StringBuilder sb,
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
    }

    [Token(Token = "0x6001165")]
    [Address(RVA = "0x37DFE0", Offset = "0x37CBE0", Length = "0xBA")]
    private static void AppendControllerMapKnownActionIdsKey(
      StringBuilder sb,
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
    }

    [Token(Token = "0x6001166")]
    [Address(RVA = "0x37DB30", Offset = "0x37C730", Length = "0x3E0")]
    private static void AppendControllerMapKeyCommonSuffix(
      StringBuilder sb,
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
    }

    [Token(Token = "0x6001167")]
    [Address(RVA = "0x37DA10", Offset = "0x37C610", Length = "0x11F")]
    private static void AppendControllerElementByRoleMapKey(
      StringBuilder sb,
      string elementRole,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
    }

    [Token(Token = "0x6001168")]
    [Address(RVA = "0x37E120", Offset = "0x37CD20", Length = "0x155")]
    private static void AppendJoystickCalibrationMapKey(StringBuilder sb, Joystick joystick)
    {
    }

    [Token(Token = "0x6001169")]
    [Address(RVA = "0x37E0A0", Offset = "0x37CCA0", Length = "0x7C")]
    private static void AppendInputBehaviorKey(StringBuilder sb, int inputBehaviorId)
    {
    }

    [Token(Token = "0x600116A")]
    [Address(RVA = "0x37ED20", Offset = "0x37D920", Length = "0xBD")]
    private string GetControllerMapXml(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (string) null;
    }

    [Token(Token = "0x600116B")]
    [Address(RVA = "0x37E8B0", Offset = "0x37D4B0", Length = "0x1B4")]
    private List<int> GetControllerMapKnownActionIds(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x600116C")]
    [Address(RVA = "0x37F540", Offset = "0x37E140", Length = "0x45")]
    private string GetJoystickCalibrationMapXml(Joystick joystick) => (string) null;

    [Token(Token = "0x600116D")]
    [Address(RVA = "0x37F330", Offset = "0x37DF30", Length = "0x45")]
    private string GetInputBehaviorXml(Player player, int id) => (string) null;

    [Token(Token = "0x600116E")]
    [Address(RVA = "0x37D440", Offset = "0x37C040", Length = "0x5A7")]
    private void AddDefaultMappingsForNewActions(
      ControllerIdentifier controllerIdentifier,
      ControllerMap controllerMap,
      List<int> knownActionIds)
    {
    }

    [Token(Token = "0x600116F")]
    [Address(RVA = "0x37E3C0", Offset = "0x37CFC0", Length = "0x189")]
    private Joystick FindJoystickPrecise(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
    {
      return (Joystick) null;
    }

    [Token(Token = "0x6001170")]
    [Address(RVA = "0x385BF0", Offset = "0x3847F0", Length = "0x2B7")]
    private bool TryFindJoysticksImprecise(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo,
      out List<Joystick> matches)
    {
      matches = (List<Joystick>) null;
      return false;
    }

    [Token(Token = "0x6001171")]
    [Address(RVA = "0x37EDE0", Offset = "0x37D9E0", Length = "0x3FA")]
    private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) => 0;

    [Token(Token = "0x6001172")]
    [Address(RVA = "0x383450", Offset = "0x382050", Length = "0x89")]
    private void RefreshLayoutManager(int playerId)
    {
    }

    [Token(Token = "0x6001173")]
    [Address(RVA = "0x383180", Offset = "0x381D80", Length = "0x1F3")]
    private void OnControllerMapsSaved(Player player)
    {
    }

    [Token(Token = "0x6001174")]
    [Address(RVA = "0x37EBF0", Offset = "0x37D7F0", Length = "0x12C")]
    private static System.Type GetControllerMapType(ControllerType controllerType) => (System.Type) null;

    [Token(Token = "0x6001175")]
    [Address(RVA = "0x385B30", Offset = "0x384730", Length = "0xBA")]
    private static int SortOldestToNewest(ControllerMapSaveData a, ControllerMapSaveData b) => 0;

    [Token(Token = "0x6001176")]
    [Address(RVA = "0x385EB0", Offset = "0x384AB0", Length = "0x9C")]
    public UserDataStore_PlayerPrefs()
    {
    }

    [Token(Token = "0x200025C")]
    private class ControllerAssignmentSaveInfo
    {
      [Token(Token = "0x400115C")]
      [FieldOffset(Offset = "0x10")]
      public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;

      [Token(Token = "0x1700029E")]
      public int playerCount
      {
        [Token(Token = "0x6001177"), Address(RVA = "0x36AF80", Offset = "0x369B80", Length = "0x12")] get => 0;
      }

      [Token(Token = "0x6001178")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      public ControllerAssignmentSaveInfo()
      {
      }

      [Token(Token = "0x6001179")]
      [Address(RVA = "0x36AE60", Offset = "0x369A60", Length = "0x115")]
      public ControllerAssignmentSaveInfo(int playerCount)
      {
      }

      [Token(Token = "0x600117A")]
      [Address(RVA = "0x36ACE0", Offset = "0x3698E0", Length = "0x5A")]
      public int IndexOfPlayer(int playerId) => 0;

      [Token(Token = "0x600117B")]
      [Address(RVA = "0x36AC80", Offset = "0x369880", Length = "0x5F")]
      public bool ContainsPlayer(int playerId) => false;

      [Token(Token = "0x200025D")]
      public class PlayerInfo
      {
        [Token(Token = "0x400115D")]
        [FieldOffset(Offset = "0x10")]
        public int id;
        [Token(Token = "0x400115E")]
        [FieldOffset(Offset = "0x14")]
        public bool hasKeyboard;
        [Token(Token = "0x400115F")]
        [FieldOffset(Offset = "0x15")]
        public bool hasMouse;
        [Token(Token = "0x4001160")]
        [FieldOffset(Offset = "0x18")]
        public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;

        [Token(Token = "0x1700029F")]
        public int joystickCount
        {
          [Token(Token = "0x600117C"), Address(RVA = "0x370FC0", Offset = "0x36FBC0", Length = "0x12")] get => 0;
        }

        [Token(Token = "0x600117D")]
        [Address(RVA = "0x370F60", Offset = "0x36FB60", Length = "0x5A")]
        public int IndexOfJoystick(int joystickId) => 0;

        [Token(Token = "0x600117E")]
        [Address(RVA = "0x370F00", Offset = "0x36FB00", Length = "0x5F")]
        public bool ContainsJoystick(int joystickId) => false;

        [Token(Token = "0x600117F")]
        [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
        public PlayerInfo()
        {
        }
      }

      [Token(Token = "0x200025E")]
      public class JoystickInfo
      {
        [Token(Token = "0x4001161")]
        [FieldOffset(Offset = "0x10")]
        public Guid instanceGuid;
        [Token(Token = "0x4001162")]
        [FieldOffset(Offset = "0x20")]
        public string hardwareIdentifier;
        [Token(Token = "0x4001163")]
        [FieldOffset(Offset = "0x28")]
        public int id;

        [Token(Token = "0x6001180")]
        [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
        public JoystickInfo()
        {
        }
      }
    }

    [Token(Token = "0x200025F")]
    private class JoystickAssignmentHistoryInfo
    {
      [Token(Token = "0x4001164")]
      [FieldOffset(Offset = "0x10")]
      public readonly Joystick joystick;
      [Token(Token = "0x4001165")]
      [FieldOffset(Offset = "0x18")]
      public readonly int oldJoystickId;

      [Token(Token = "0x6001181")]
      [Address(RVA = "0x370080", Offset = "0x36EC80", Length = "0x8F")]
      public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
      {
      }
    }

    [Token(Token = "0x2000260")]
    [Serializable]
    private class ControllerElementByRoleMap
    {
      [DoNotSerialize]
      [Token(Token = "0x4001166")]
      [FieldOffset(Offset = "0x10")]
      public string role;
      [Token(Token = "0x4001167")]
      [FieldOffset(Offset = "0x18")]
      public List<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry> data;

      [Preserve]
      [Token(Token = "0x6001182")]
      [Address(RVA = "0x36B750", Offset = "0x36A350", Length = "0x77")]
      public ControllerElementByRoleMap()
      {
      }

      [Token(Token = "0x6001183")]
      [Address(RVA = "0x36B0A0", Offset = "0x369CA0", Length = "0xF0")]
      public void Add(ActionElementMap elementMap)
      {
      }

      [Token(Token = "0x6001184")]
      [Address(RVA = "0x36B2D0", Offset = "0x369ED0", Length = "0x1F2")]
      public override string ToString() => (string) null;

      [Token(Token = "0x6001185")]
      [Address(RVA = "0x36B2C0", Offset = "0x369EC0", Length = "0x7")]
      public string ToJson() => (string) null;

      [Token(Token = "0x6001186")]
      [Address(RVA = "0x36B230", Offset = "0x369E30", Length = "0x82")]
      public static UserDataStore_PlayerPrefs.ControllerElementByRoleMap FromJson(
        string role,
        string json)
      {
        return (UserDataStore_PlayerPrefs.ControllerElementByRoleMap) null;
      }

      [Token(Token = "0x2000261")]
      [Serializable]
      public struct Entry
      {
        [Token(Token = "0x4001168")]
        [FieldOffset(Offset = "0x0")]
        public int actionId;
        [Token(Token = "0x4001169")]
        [FieldOffset(Offset = "0x4")]
        public ControllerElementType elementType;
        [Token(Token = "0x400116A")]
        [FieldOffset(Offset = "0x8")]
        public AxisRange axisRange;
        [Token(Token = "0x400116B")]
        [FieldOffset(Offset = "0xC")]
        public bool invert;
        [Token(Token = "0x400116C")]
        [FieldOffset(Offset = "0x10")]
        public Pole axisContribution;

        [Token(Token = "0x6001187")]
        [Address(RVA = "0x36DB60", Offset = "0x36C760", Length = "0x1B5")]
        public bool TryGetElementAssignment(
          ControllerType controllerType,
          Controller.Element targetElement,
          out ElementAssignment assignment)
        {
          assignment = new ElementAssignment();
          return false;
        }

        [Token(Token = "0x6001188")]
        [Address(RVA = "0x36D7E0", Offset = "0x36C3E0", Length = "0x1B9")]
        public override string ToString() => (string) null;
      }
    }

    [Token(Token = "0x2000262")]
    public enum ActionMappingSaveMode
    {
      [Token(Token = "0x400116E")] ByController,
      [Token(Token = "0x400116F")] ByControllerElementRole,
    }
  }
}
