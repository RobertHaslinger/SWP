using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Swords;

namespace Adapter
{
    public class Inventory
    {
        private Dictionary<WeaponType, IFightable> _weapons = new Dictionary<WeaponType, IFightable>();

        public Inventory()
        {
            _weapons.Add(WeaponType.Longsword, new Longsword());
            _weapons.Add(WeaponType.Lasersword, new Lasersword());
            _weapons.Add(WeaponType.MiddleswordClassAdapter, new MiddleswordClassAdapter());
            _weapons.Add(WeaponType.MiddleswordObjectAdapter, new MiddleswordObjectAdapter(new Middlesword()));
        }

        public IFightable GetWeapon(WeaponType weaponType)
        {
            return _weapons[weaponType];
        }
    }
}
