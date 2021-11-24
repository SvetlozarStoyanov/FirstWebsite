using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrysisWalkthroughs.Models;

namespace CrysisWalkthroughs.Services
{
    public interface IWeaponDataSample
    {
        List<WeaponModel> GetAllWeapons();
        WeaponModel GetWeaponById(int Id);

    }
}
