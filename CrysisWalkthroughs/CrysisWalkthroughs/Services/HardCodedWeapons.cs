using CrysisWalkthroughs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrysisWalkthroughs.Services
{
    public class HardCodedWeapons : IWeaponDataSample
    {
        static Dictionary<string, WeaponModel> weapons = new Dictionary<string, WeaponModel>();
        static Dictionary<string, WeaponModel> filteredWeapons = new Dictionary<string, WeaponModel>();

        public Dictionary<string, WeaponModel> GetAllWeapons()
        {
            if (weapons.Count < 19)
            {
                weapons.Add("Pistol", new WeaponModel(0, "Pistol", "The Pistol in Crysis is a sidearm developed by the BBauer company. It appears to be very popular, as both the KPA and US forces have adopted it.The Pistol can be found in the hands of combat - unready enemies and enemies that have no time to reload their primary weapons. It can be dual-wielded.", new Dictionary<string, List<string>> { ["Barrel"] = new List<string> { "Silencer" }, ["Side"] = new List<string> { "Flashlight", "Laser Pointer" } }));
                weapons.Add("AY69", new WeaponModel(1, "AY69", "The AY-69 Micro Machine Gun is a subcompact weapon designed and used by the KPA. Like the Pistol, it can be dual-wielded, wherein the left gun is fired by holding down the left mouse button or trigger and the right gun is fired by holding down the right mouse button or trigger.", new Dictionary<string, List<string>> { ["Barrel"] = new List<string> { "Silencer" }, ["Side"] = new List<string> { "Flashlight", "Laser Pointer" } }));
                weapons.Add("SCAR", new WeaponModel(2, "SCAR", "The Superior Combat Assault Rifle, or SCAR, is the primary assault rifle for United States Marine Corps and the US Army Special Forces of 2020.", new Dictionary<string, List<string>> { ["Barrel"] = new List<string> { "Silencer" }, ["Side"] = new List<string> { "Flashlight", "Laser Pointer" }, ["Rail"] = new List<string> { "Grenade Launcher", "Tactical Attachment" }, ["Sight"] = new List<string> { "Reflex Sight", "Assault Scope", "Sniper Scope" } }));
                weapons.Add("FY71", new WeaponModel(3, "FY71", "The FY71 is the primary weapon for KPA infantry and is the backbone of the NK military.", new Dictionary<string, List<string>> { ["Barrel"] = new List<string> { "Silencer" }, ["Side"] = new List<string> { "Flashlight", "Laser Pointer" }, ["Rail"] = new List<string> { "Grenade Launcher", "Tactical Attachment" }, ["Sight"] = new List<string> { "Reflex Sight", "Assault Scope", "Sniper Scope" }, ["Ammo"] = new List<string> { "Incendiary Ammo" } }));
                weapons.Add("Shotgun", new WeaponModel(4, "Shotgun", "The XM2014 is a military-grade combat shotgun issued to soldiers for CQC, including dense jungles and urban warfare.", new Dictionary<string, List<string>> { ["Side"] = new List<string> { "Flashlight", "Laser Pointer" }, ["Sight"] = new List<string> { "Reflex Sight", "Assault Scope", "Sniper Scope" } }));
                weapons.Add("SMG", new WeaponModel(5, "SMG", "Used by the KPA. Primarily intended as a personal defense and close-quarters weapon; its large 50-round magazine and close-range power range make it the ideal PDW/CQC weapon.", new Dictionary<string, List<string>> { ["Barrel"] = new List<string> { "Silencer" }, ["Side"] = new List<string> { "Flashlight", "Laser Pointer" }, ["Sight"] = new List<string> { "Reflex Sight", "Assault Scope", "Sniper Scope" } }));
                weapons.Add("Precision Rifle", new WeaponModel(6, "Precision Rifle", "The DSG1 Precision Rifle is the KPA's sniper rifle.", new Dictionary<string, List<string>> { ["Side"] = new List<string> { "Flashlight", "Laser Pointer" }, ["Sight"] = new List<string> { "Reflex Sight", "Assault Scope", "Sniper Scope" } }));
                weapons.Add("Gauss Rifle", new WeaponModel(7, "Gauss Rifle", "The GK8 Gauss Gun is a new weapon designed by the United States. Unlike other weapons, it fires slugs of high-density alloys, such as tungsten carbide and depleted uranium, at velocities up to eight times the speed of sound.", new Dictionary<string, List<string>> { ["Side"] = new List<string> { "Flashlight", "Laser Pointer" }, ["Sight"] = new List<string> { "Reflex Sight", "Assault Scope", "Sniper Scope" } }));
                weapons.Add("Minigun", new WeaponModel(8, "Minigun", "The Hurricane Minigun is a devastating weapon that is highly effective against both light infantry, alien infantry and Nanosuit soldiers. The weapon has a high-capacity 500-round drum magazine, allowing for a continuous stream of suppressive fire.", new Dictionary<string, List<string>> { ["Side"] = new List<string> { "Flashlight", "Laser Pointer" } }));
                weapons.Add("Alien Gun", new WeaponModel(9, "Alien Gun", "The MOAC extracts water vapor from the surrounding air, freezes it, and then fires the resultant shards of ice.", new Dictionary<string, List<string>> { ["Side"] = new List<string> { "Flashlight", "Laser Pointer" } }));
                weapons.Add("Rocket Launcher", new WeaponModel(10, "Rocket Launcher", "The LAW is a disposable compact missile launcher used by both the KPA and US Marines. Preloaded with 3 rockets, it incorporates a laser aiming and guidance system that enables the user to directly control the path of the projectile.", null));
                weapons.Add("Grenade Launcher", new WeaponModel(11, "Grenade Launcher", "The FGL-40 Automatic Grenade Launcher is a powerful support weapon which can rapidly launch grenades.", new Dictionary<string, List<string>> { ["Side"] = new List<string> { "Flashlight" }, ["Ammo"] = new List<string> { "EMP Grenades" } }));
                weapons.Add("C4", new WeaponModel(12, "C4", "Composition-C4 is an explosive which consists of two parts; the explosive and a remote detonator. The explosive can be attached to walls and has enough power to put a tank out of commission.", null));
                weapons.Add("Claymore Mine", new WeaponModel(13, "Claymore Mine", "The Claymore is an anti-personnel mine used by the KPA. It explodes when an enemy comes within range and they are typically triggered by infrared or motion sensors.", null));
                weapons.Add("Mine", new WeaponModel(14, "Mine", "The Anti-Tank mine is an explosive device used by the KPA. A single mine is powerful enough to cripple or severely damage a tank.", null));
                weapons.Add("Grenade", new WeaponModel(15, "Grenade", "The M17 Fragmentation Grenade is an explosive device which deals high damage to infantry but low damage to vehicles.", null));
                weapons.Add("EMP Grenade", new WeaponModel(16, "EMP Grenade", "The Nano Disruptor or Electro-Magnetic Pulse Grenade is an advanced electronic grenade which emits a small electro-magnetic pulse upon detonation that disables any electronic devices nearby.", null));
                weapons.Add("Flashbang", new WeaponModel(17, "Flashbang", "Upon detonation, the grenade will temporarily blind and deafen anyone within its effective radius, effectively burning an image into their vision, causing disorientation.", null));
                weapons.Add("Smoke Grenade", new WeaponModel(18, "Smoke Grenade", "The Smoke Grenade is primarily used to mask the player's movements, as well as blocking enemies' sight, as they will typically stop firing if a Smoke Grenade explodes right in front of them.", null));
                weapons.Add("Fists", new WeaponModel(19, "Fists", "When used in strength mode they can one shot kpa soldiers and destroy enviroment objects.", null));
            }
            return weapons;
        }


        public WeaponModel GetWeaponById(int Id)
        {
            throw new NotImplementedException();
        }
        public WeaponModel GetWeaponByName(string Name)
        {
            WeaponModel weapon = new WeaponModel();
            weapons.TryGetValue(Name, out weapon);
            return weapon;
        }
        public Dictionary<string, WeaponModel> GetAllWeaponsWithAttachment(string attachmentName)
        {
            filteredWeapons = new Dictionary<string, WeaponModel>();
            ////attachmentName = "Silencer";
            //foreach (var weapon in weapons)
            //{
            //    foreach (var attachment in weapon.Value.AttachmentsAsList)
            //    {
            //        if (attachment == attachmentName)
            //        {
            //            filteredWeapons.Add(weapon.Key, weapon.Value);
            //            break;
            //        }
            //    }
            //}
            filteredWeapons = weapons.Where(x => x.Value.AttachmentsAsList.Contains(attachmentName)).ToDictionary(x => x.Key, x => x.Value);
            return filteredWeapons;
        }
    }
}
