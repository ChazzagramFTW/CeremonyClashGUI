using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonGameGUI
{
    internal class Player
    {

        //Protected visibility modifier used to allow methods to be used only within the Player class and parented classes.
        protected string Name;
        protected int Health = 0;
        protected string Attack1;
        protected int Attack1Damage = 0;
        protected string Attack2;
        protected int Attack2Damage = 0;
        protected int SpecialAttackDamage = 0;

        // Public visibility modifier is used here to allow the methods to be used anywhere.
        // Set value procedures are used to more easily set certain values shared with multiple objects without needing to re-write the code.
        public void setValues(string name, int health, string attack1, int attack1Damage, string attack2, int attack2Damage)
        {
            Name = name; Health = health; Attack1 = attack1; Attack1Damage = attack1Damage; Attack2 = attack2; Attack2Damage = attack2Damage;
        }

        public void setHealth(int healthTaken)
        {
            Health = Health - healthTaken;
        }

        // Get value function which takes the object and returns the defined variables.
        public string getName() { return Name; }
        public int getHealth() { return Health; }
        public string getAttack1() { return Attack1; }
        public int getAttack1Damage() { return Attack1Damage; }
        public string getAttack2() { return Attack2; }
        public int getAttack2Damage() { return Attack2Damage; }

        //ATTACKS
        // Each attack has its own function to shorten the code each time an attack is carried out.
        public int Attack(int number)
        {
            int playerDamage = 0;
            Random rnd = new Random();
            playerDamage = rnd.Next(0, Attack1Damage);
            return playerDamage;
        }

        public int Attack(string number)
        {
            int playerDamage = 0;
            Random rnd = new Random();
            playerDamage = rnd.Next(0, Attack2Damage);
            return playerDamage;
        }
    }

    // Class Rival is a child class to the Player class which means it carries all the functions and variables within the Player class as well as it's own.
    internal class Rival : Player {
        // Rival attacks are used to make the Rival class independant and cannot be accessed by the Player class.

        // Overloading is used here with setValues as it is the same Function used but with different classes, rival class includes a special attack damage identifier.
        public void setValues(string name, int health, string attack1, int attack1Damage, string attack2, int attack2Damage, int specialAttackDamage)
        {
            Name = name; Health = health; Attack1 = attack1; Attack1Damage = attack1Damage; Attack2 = attack2; Attack2Damage = attack2Damage; SpecialAttackDamage = specialAttackDamage;
        }
        public int specialAttack()
        {
            int playerDamage = 0;
            Random rnd = new Random();
            playerDamage = rnd.Next(0, SpecialAttackDamage);
            return playerDamage;
        }
    }
}
