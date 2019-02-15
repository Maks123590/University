namespace Task6
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    using Task6.Units;
    using Task6.Weapons;

    public class Program
    {
        private static void Main(string[] args)
        {
            var units = Assembly.GetAssembly(typeof(Program)).GetTypes().Where(type => type.IsSubclassOf(typeof(Unit)))
                .Select(unitType => (Unit)Activator.CreateInstance(unitType)).ToArray();

            var weapons = Assembly.GetAssembly(typeof(Program)).GetTypes().Where(type => type.GetInterface(typeof(IWeapon).FullName) != null)
                .Select(unitType => (IWeapon)Activator.CreateInstance(unitType)).ToArray();

            var random = new Random();

            while (true)
            {
                var unit = units[random.Next(units.Length)];

                unit.SetWeapon(weapons[random.Next(weapons.Length)]);

                Console.WriteLine(unit.Fight(units[random.Next(units.Length)]));

                Task.Delay(3000).Wait();
            }
        }
    }
}
