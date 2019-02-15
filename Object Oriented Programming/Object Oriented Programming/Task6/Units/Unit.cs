namespace Task6.Units
{
    using System;

    using Task6.Weapons;

    public abstract class Unit
    {
        protected Unit(string name)
        {
            this.Name = name;
        }

        protected string Name { get; }

        protected IWeapon Weapon { get; private set; }

        public string Fight(Unit target)
        {
            return $"{this.Name} {this.Weapon.UseWeapon()} {target.Name}";
        }

        public void SetWeapon(IWeapon weapon)
        {
            this.Weapon = weapon;
        }
    }
}