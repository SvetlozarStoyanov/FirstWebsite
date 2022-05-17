using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrysisWalkthroughs.Models;

namespace CrysisWalkthroughs.Services
{
    public interface IWeaponDataSample
    {
        Dictionary<string,WeaponModel> GetAllWeapons();
        WeaponModel GetWeaponById(int Id);
        WeaponModel GetWeaponByName(string Name);
        Dictionary<string, WeaponModel> GetAllWeaponsWithAttachment(string attachmentName);
    }
}
