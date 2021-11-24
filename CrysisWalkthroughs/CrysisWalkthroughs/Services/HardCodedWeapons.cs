using CrysisWalkthroughs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrysisWalkthroughs.Services
{
    public class HardCodedWeapons : IWeaponDataSample
    {
        static List<WeaponModel> weapons = new List<WeaponModel>();

        public List<WeaponModel> GetAllWeapons()
        {
            if (weapons.Count < 19)
            {

                weapons.Add(new WeaponModel { Id = 0, Name = "Pistol", Description = "The Pistol in Crysis is a sidearm developed by the BBauer company. It appears to be very popular, as both the KPA and US forces have adopted it.The Pistol can be found in the hands of combat - unready enemies and enemies that have no time to reload their primary weapons. It can be dual-wielded." });
                weapons.Add(new WeaponModel { Id = 1, Name = "AY69", Description = "The AY-69 Micro Machine Gun is a subcompact weapon designed and used by the KPA.Like the Pistol, it can be dual-wielded, wherein the left gun is fired by holding down the left mouse button or trigger and the right gun is fired by holding down the right mouse button or trigger." });
                weapons.Add(new WeaponModel { Id = 2, Name = "SCAR", Description = "The Superior Combat Assault Rifle, or SCAR, is the primary assault rifle for United States Marine Corps and the US Army Special Forces of 2020." });
                weapons.Add(new WeaponModel { Id = 3, Name = "FY71", Description = "The FY71 is the primary weapon for KPA infantry and is the backbone of the NK military." });
                weapons.Add(new WeaponModel { Id = 4, Name = "Shotgun", Description = "The XM2014 is a military-grade combat shotgun issued to soldiers for CQC, including dense jungles and urban warfare." });
                weapons.Add(new WeaponModel { Id = 5, Name = "SMG", Description = "Used by the KPA. Primarily intended as a personal defense and close-quarters weapon; its large 50-round magazine and close-range power range make it the ideal PDW/CQC weapon." });
                weapons.Add(new WeaponModel { Id = 6, Name = "Precision Rifle", Description = "The DSG1 Precision Rifle is the KPA's sniper rifle." });
                weapons.Add(new WeaponModel { Id = 7, Name = "Gauss Rifle", Description = "The GK8 Gauss Gun is a new weapon designed by the United States. Unlike other weapons, it fires slugs of high-density alloys, such as tungsten carbide and depleted uranium, at velocities up to eight times the speed of sound." });
                weapons.Add(new WeaponModel { Id = 8, Name = "Minigun", Description = "The Hurricane Minigun is a devastating weapon that is highly effective against both light infantry, alien infantry and Nanosuit soldiers. The weapon has a high-capacity 500-round drum magazine, allowing for a continuous stream of suppressive fire." });
                weapons.Add(new WeaponModel { Id = 9, Name = "Alien Gun", Description = "The MOAC extracts water vapor from the surrounding air, freezes it, and then fires the resultant shards of ice." });
                weapons.Add(new WeaponModel { Id = 10, Name = "Rocket Launcher", Description = "The LAW is a disposable compact missile launcher used by both the KPA and US Marines. Preloaded with 3 rockets, it incorporates a laser aiming and guidance system that enables the user to directly control the path of the projectile." });
                weapons.Add(new WeaponModel { Id = 11, Name = "Grenade Launcher", Description = "The FGL-40 Automatic Grenade Launcher is a powerful support weapon which can rapidly launch grenades." });
                weapons.Add(new WeaponModel { Id = 12, Name = "C4", Description = "Composition-C4 is an explosive which consists of two parts; the explosive and a remote detonator. The explosive can be attached to walls and has enough power to put a tank out of commission." });
                weapons.Add(new WeaponModel { Id = 13, Name = "Claymore Mine", Description = "The Claymore is an anti-personnel mine used by the KPA. It explodes when an enemy comes within range and they are typically triggered by infrared or motion sensors." });
                weapons.Add(new WeaponModel { Id = 14, Name = "Mine", Description = "The Anti-Tank mine is an explosive device used by the KPA. A single mine is powerful enough to cripple or severely damage a tank." });
                weapons.Add(new WeaponModel { Id = 15, Name = "Grenade", Description = "The M17 Fragmentation Grenade is an explosive device which deals high damage to infantry but low damage to vehicles." });
                weapons.Add(new WeaponModel { Id = 16, Name = "EMP Grenade", Description = "The Nano Disruptor or Electro-Magnetic Pulse Grenade is an advanced electronic grenade which emits a small electro-magnetic pulse upon detonation that disables any electronic devices nearby." });
                weapons.Add(new WeaponModel { Id = 17, Name = "Flashbang", Description = "Upon detonation, the grenade will temporarily blind and deafen anyone within its effective radius, effectively burning an image into their vision, causing disorientation." });
                weapons.Add(new WeaponModel { Id = 18, Name = "Smoke Grenade", Description = "The Smoke Grenade is primarily used to mask the player's movements, as well as blocking enemies' sight, as they will typically stop firing if a Smoke Grenade explodes right in front of them." });
                weapons.Add(new WeaponModel { Id = 19, Name = "Fists", Description = "When used in strength mode they can one shot kpa soldiers and destroy enviroment objects." });
            }
            return weapons;
        }

        public WeaponModel GetWeaponById(int Id)
        {
            WeaponModel weapon = new WeaponModel();
          
            weapon = weapons[Id];
            return weapon;
        }
    }
}
