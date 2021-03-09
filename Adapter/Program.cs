using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Console.WriteLine(inventory.GetWeapon(WeaponType.Longsword).Fight());
            Console.WriteLine(inventory.GetWeapon(WeaponType.MiddleswordClassAdapter).Fight());

            var lasersword = inventory.GetWeapon(WeaponType.Lasersword) as IGlowable;
            Console.WriteLine(lasersword.Glow());
        }
    }
}
