using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "CustomWeaponSO", menuName = "ScriptableObjects/CustomWeaponSO")]
public class CustomWeaponSO : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public Texture2D icon;
    [Tooltip("Prefab that's the weapon attack. THIS IS NOT THE PROJECTILE, BUT AN OBJECT WITH THE *WeaponAttack* script")]
    public GameObject WeaponAttackPrefab;

    [Header("Upgrade Options")]
    [Tooltip("List of possible upgrade options on levelup. Defaults are the Fireball staff's upgrade options.")]
    public List<StatModifier> UpgradeOptions = new List<StatModifier>()
    {
        new(){ stat = EStat.DamageMultiplier, modifyType = EStatModifyType.Flat, modification = 2.5f },
        new(){ stat = EStat.ProjectileSpeedMultiplier, modifyType = EStatModifyType.Addition, modification = 0.2f },
        new(){ stat = EStat.Projectiles, modifyType = EStatModifyType.Flat, modification = 1f },
        new(){ stat = EStat.SizeMultiplier, modifyType = EStatModifyType.Addition, modification = 0.16f },
    };
    

    [Header("Stats")] 
    [Tooltip("Delay between attacks")]
    public float AttackSpeed = 1f; 
    [Tooltip("Base Damage. Also known as DamageMultiplier")]
    public float BaseDamage = 10f; //DamageMultiplier
    
    [Tooltip("Knockback scaling Multiplier")]
    public float KnockbackMultiplier = 1f;
    [Tooltip("Size scaling Multiplier")]
    public float SizeMultiplier = 1f;
    [Tooltip("Base Projectile Bounces")] 
    public float ProjectileBounces = 0f;
    [Tooltip("Base Projectiles")] 
    public float Projectiles = 1f;
    [Tooltip("Duration scaling Multiplier")]
    public float DurationMultiplier = 1f;
    [Tooltip("Projectile Speed Multiplier")]
    public float ProjectileSpeedMultiplier = 1f;
    [Tooltip("Base Crit Chance (1= 100%)")]
    public float CritChance = 0; 
    [Tooltip("Additional Crit Damage (0 is the default 200% damage on crit, 1 is 300% damage on crit)")]
    public float AdditionalCritDamage = 0; //CritDamage
    
    [Header("Additional Base Stat Modifications")]
    public List<BaseStat> additionalStats = new List<BaseStat>()
    {
    };

    //If you are wondering why not just create the list of stats in the first place?
    //It is because these stats are REQUIRED, so hardcoding them as values makes it harder for people to screw up
    public List<BaseStat> GetStatList()
    {
        List<BaseStat> stats = new List<BaseStat>();
        stats.Add(new BaseStat(){ Stat = EStat.AttackSpeed, Value = AttackSpeed });
        stats.Add(new BaseStat(){ Stat = EStat.DamageMultiplier, Value = BaseDamage });
        stats.Add(new BaseStat(){ Stat = EStat.KnockbackMultiplier, Value = KnockbackMultiplier });
        stats.Add(new BaseStat(){ Stat = EStat.SizeMultiplier, Value = SizeMultiplier });
        stats.Add(new BaseStat(){ Stat = EStat.ProjectileBounces, Value = ProjectileBounces });
        stats.Add(new BaseStat(){ Stat = EStat.Projectiles, Value = Projectiles });
        stats.Add(new BaseStat(){ Stat = EStat.DurationMultiplier, Value = DurationMultiplier });
        stats.Add(new BaseStat(){ Stat = EStat.ProjectileSpeedMultiplier, Value = ProjectileSpeedMultiplier });
        stats.Add(new BaseStat(){ Stat = EStat.CritChance, Value = CritChance });
        stats.Add(new BaseStat(){ Stat = EStat.CritDamage, Value = AdditionalCritDamage });
        stats.AddRange(additionalStats);
        return stats;
    }
    
#if UNITY_EDITOR
    public JObject toJSON()
    {
        //var weaponPath = AssetDatabase.GetAssetPath(this);
        var iconPath = AssetDatabase.GetAssetPath(icon);
        var weaponAttackPath = AssetDatabase.GetAssetPath(WeaponAttackPrefab);
        
        var stats = GetStatList();
        return JObject.FromObject(new
        {
            //weaponPath,
            weaponName,
            weaponDescription,
            UpgradeOptions,
            stats,
            iconPath,
            weaponAttackPath
        });
    }
    
    public string[] getAssetNameList()
    {
        List<string> list = new List<string>();
        list.Add(AssetDatabase.GetAssetPath(this));
        list.Add(AssetDatabase.GetAssetPath(icon));
        list.Add(AssetDatabase.GetAssetPath(WeaponAttackPrefab));
        
        return list.ToArray();
    }
#endif
    
}

[Serializable]
public struct BaseStat
{
    public EStat Stat;
    public float Value;
}