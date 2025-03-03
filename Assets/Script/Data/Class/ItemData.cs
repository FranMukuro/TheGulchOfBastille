﻿using System.Collections;
using System.Collections.Generic;
using System;

public class ItemData
{
    public enum Weapon{
        Iron_Sword,
        Claymore,
        Dragon_Slayer_Sword,
        Wood_Bow,
        Elf_Bow,
        Long_Bow,
        Apprentice_Stick,
        Master_Stick,
        Sunlight_Stick,
        Count,
    };
    public enum Wearable{
        Moonstone_Ring,
        Fools_Gold_Pendant,
        Sun_Protection_Stone,
        Amber_Ring,
        Drawf_Ring,
        Sunstone_Ring,
        Coldblue_Ring,
        Magic_Pendant,
        Belials_Magic_Compass,
        Goye_Ring,
        Count
    };
    public enum Consumable{
        Uilos_Candy,
        Uilos_Potion,
        Uilos_Cake,
        Holy_Sun_Water,
        Uilos_Pedal,
        Uilos_Flower,
        Uilos_Stick,
        Uilos_Bunch,
        Neon_Potion,
        Count,
    };
    public enum KeyItem{
        Dash_Stone,
        Double_Jump_Stone,
        Wall_Jump_Stone,
        Royal_Pass,
        Count,
    };

    [Serializable]
    public struct WeaponRuntimeData{
        public Weapon weapon;
        public int level;
        public WeaponRuntimeData(Weapon weapon, int level){
            this.weapon = weapon;
            this.level = level;
        }
        
    };

    [Serializable]
    public struct WearableRuntimeData{
        public Wearable wearable;
        public WearableRuntimeData(Wearable wearable){
            this.wearable = wearable;
        }
    };

    [Serializable]
    public struct ConsumableRuntimeData{
        public Consumable consumable;
        public int count;
        public ConsumableRuntimeData(Consumable consumable, int count){
            this.consumable = consumable;
            this.count = count;
        }
    };

    [Serializable]
    public struct KeyItemRuntimeData{
        public KeyItem keyItem;
        public KeyItemRuntimeData(KeyItem keyItem){
            this.keyItem = keyItem;
        }
    };

    

public static Dictionary<int , string> WeaponDescription = new Dictionary<int, string>(){
    {(int)Weapon.Iron_Sword, "A slightly rusty\n sword, maintaining\n basic functionality."},
    {(int)Weapon.Claymore, "Strong hold for a\n warrior, contains\n unimaginable possibilities."},
    {(int)Weapon.Dragon_Slayer_Sword, "The most powerful weapon\n forged by the legendary\n drawf master."},
    {(int)Weapon.Wood_Bow, "A basic long\n ranged weapon."},
    {(int)Weapon.Elf_Bow, "Swifness as the name\n indicates, made by\n an experienced Elf hunter."},
    {(int)Weapon.Long_Bow, "Incomparable long ranged\n weapon, as deadly as\n the realm of assassination."},
    {(int)Weapon.Apprentice_Stick, "A simple designed magic\n stick, used by Belial\n for teaching."},
    {(int)Weapon.Master_Stick, "Advanced magic tool,\n should be used with care."},
    {(int)Weapon.Sunlight_Stick, "Unprecendented magic\n stick, with potential\n to defeat the Abyss."},
};

public static Dictionary<int, string> WearableDescription = new Dictionary<int, string>(){
    {(int)Wearable.Moonstone_Ring, "Reduce hp capacity,\n increase Rotten bar capacity."},
    {(int)Wearable.Fools_Gold_Pendant, "Automatically collect uilos."},
    {(int)Wearable.Sun_Protection_Stone, "Reduce rotten point got."},
    {(int)Wearable.Amber_Ring, "Slightly increase hp."},
    {(int)Wearable.Drawf_Ring, "increase uilos output\n from dead enemy."},
    {(int)Wearable.Sunstone_Ring, "Reduce rotten bar,\n increase hp."},
    {(int)Wearable.Coldblue_Ring, "Reduce attack cooldown."},
    {(int)Wearable.Magic_Pendant, "Increase attack power."},
    {(int)Wearable.Belials_Magic_Compass, "Teleport to last lit\n little sun\n or to the Gulch."},
    {(int)Wearable.Goye_Ring, "Extend roll distance."},
};

public static Dictionary<int, string> ConsumableDescription = new Dictionary<int, string>(){
    {(int)Consumable.Uilos_Candy, "Restore little hp."},
    {(int)Consumable.Uilos_Potion, "Restore large amount of hp."},
    {(int)Consumable.Uilos_Cake, "Fully restore hp."},
    {(int)Consumable.Holy_Sun_Water, "Reduce rotten points\n by 20 percent."},
    {(int)Consumable.Uilos_Pedal, "Gain a little\n uilos."},
    {(int)Consumable.Uilos_Flower, "Gain large amount\n of uilos."},
    {(int)Consumable.Uilos_Stick, "Gain great amout\n of uilos."},
    {(int)Consumable.Uilos_Bunch, "Gain huge amount\n of uilos"},
    {(int)Consumable.Neon_Potion, "Increase speed but\n alter Alf color randomly."},
};

public static Dictionary<int, string> KeyItemDescription = new Dictionary<int, string>(){
    {(int)KeyItem.Dash_Stone, "a powerful stone carved\n with shape, can be\n used in the Sun Tower."},
    {(int)KeyItem.Double_Jump_Stone, "a powerful stone carved\n with shape, can be\n used in the Sun Tower."},
    {(int)KeyItem.Wall_Jump_Stone, "a powerful stone carved\n with shape, can be\n used in the Sun Tower."},
    {(int)KeyItem.Royal_Pass, "Used to open the\n gate protected by\n the dragon"},
};

public static Dictionary<int, WeaponData> weaponData = new Dictionary<int, WeaponData>(){
    {(int)Weapon.Iron_Sword, new WeaponData(new int[3]{5,7,9}, true, false, true)},
    {(int)Weapon.Claymore, new WeaponData(new int[3]{10,12,14}, true, false, true)},
    {(int)Weapon.Dragon_Slayer_Sword, new WeaponData(new int[3]{15,17,19}, true, false, true)},
    {(int)Weapon.Wood_Bow, new WeaponData(new int[3]{8,10,12}, false, true, false)},
    {(int)Weapon.Elf_Bow, new WeaponData(new int[3]{10,12,14}, false, true, false)},
    {(int)Weapon.Long_Bow, new WeaponData(new int[3]{15,17,19}, true, false, true)},
    {(int)Weapon.Apprentice_Stick, new WeaponData(new int[3]{5,7,9}, false, true, false)},
    {(int)Weapon.Master_Stick, new WeaponData(new int[3]{8,10,12}, false, true, false)},
    {(int)Weapon.Sunlight_Stick, new WeaponData(new int[3]{15,17,19}, false ,true, false)},
};

    public struct WeaponData{
        int[] Attack;
        bool IsMelee;
        bool IsRange;
        bool CanParry;
        public WeaponData(int[] attack, bool isMelee, bool isRange, bool canParry){
            this.Attack = attack;
            this.IsMelee = isMelee;
            this.IsRange = isRange;
            this.CanParry = canParry;
        }
    };

    public static PlayerLevelUpData[] playerLevelUpData = {
        new PlayerLevelUpData(1,60,5,20),
        new PlayerLevelUpData(2,70,7,25),
        new PlayerLevelUpData(3,80,9,30),
        new PlayerLevelUpData(4,90,11,35),
        new PlayerLevelUpData(5,100,13,40),
        new PlayerLevelUpData(6,105, 15, 43),
        new PlayerLevelUpData(7, 110, 17, 46),
        new PlayerLevelUpData(8,115, 18, 48),
        new PlayerLevelUpData(9, 120, 19, 49),
        new PlayerLevelUpData(10, 125, 20, 50),
    };

    public struct PlayerLevelUpData{
        public int level;
        /// <Summary>
        /// Hit point
        /// </Summary>
        public int HP;
        /// <Summary>
        /// Attack point
        /// </Summary>
        int AP;
        /// <Summary>
        /// Decay point
        /// </Summary>
        int DP;

        public PlayerLevelUpData(int level, int hp, int ap, int dp){
            this.level = level;
            this.HP = hp;
            this.AP = ap;
            this.DP = dp;
        }
    };
}
