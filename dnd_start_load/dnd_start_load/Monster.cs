using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_start_load
{
    public class Monster : Character
    {
        private int hp;
        private string name;
        private bool isdead;
        private string image; /*IDK how to do images yet so yeah but this will be for monster image, currently let's assume its a path to an image*/

        /**
         * Default Constructor returns empty object
         * return empty monster
         */
        public Monster()
        {
            this.name = "";
            this.init = 0;
            this.hp = 0;
            this.image = "";
            this.isdead = false;
        }

        public Monster(string name, string init, string hp) //No image constructor
        {
            this.name = name;
            if (!Int32.TryParse(init, out this.init))
            {
                //DIE ROLL
            }
            if (!Int32.TryParse(hp, out this.hp))
            {
                //DIE ROLL
            }
            this.image = "";
        }

        public Monster(string name, string init, string hp, string img)
        {
            this.name = name;
            if (!Int32.TryParse(init, out this.init))
            {
                //DIE ROLL
            }
            if (!Int32.TryParse(hp, out this.hp))
            {
                //DIE ROLL
            }
            this.image = img;
        }

        /**
         * Determines if monster is dead
         * return true if hp is 0 or less. false otherwise
         */
        public bool isDead()
        {
            if (this.hp <= 0)
            {
                return true;
            }
            return false;
        }

        /**
         * Computes Xp gain for monster
         * return Xp gained by defeating monster
         */
        public int getXp()
        {
            int xp = 0;
            /*Compute xp-- This is based on level and the Xp gain is non-linear. Need to do something with Array indexing*/
            return xp;
        }

        /**
         * Updates the hp of a monster and checks if it has died.
         * @param hpChange the amount to modify the hp stat by. Negative if damage has been taken, positive if hp has been gained.
         * return the return value of isDead() after updating hp.
         */
        public bool updateHealth(int hpChange)
        {
            this.hp += hpChange;
            return isDead();
        }

        /**
         * Revives a monster to a certain hp-- can be modified in future to apply effects if required
         * @param hp the hp to revive the monster to.
         */
        public void revive(int hp)
        {
            setHp(hp);
        }

        /***************************Getters / Setters***********************************************/

        public void setName(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public string getimg()
        {
            return this.image;
        }

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public int getHp()
        {
            return hp;
        }


        public override int getinit()
        {
            return this.init;
        }
    }
}
