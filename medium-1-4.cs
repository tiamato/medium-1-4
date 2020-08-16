using System;

namespace Wombat
{
    public abstract class Creature
    {
        public int Health { get; private set; }

        protected Creature(int health)
        {
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= CalculateDamage(damage);

            if (Health <= 0)
            {
                Console.WriteLine("Я умер");
            }
        }

        protected abstract int CalculateDamage(int damage);
    }

    public class Wombat : Creature
    {
        public int Armor;

        public Wombat(int health, int armor) : base(health)
        {
            Armor = armor;
        }

        protected override int CalculateDamage(int damage)
        {
            return damage - Armor;
        }
    }

    public class Human : Creature
    {
        public int Agility;

        public Human(int health, int agility) : base(health)
        {
            Agility = agility;
        }

        protected override int CalculateDamage(int damage)
        {
            return damage / Agility;
        }
    }
}
