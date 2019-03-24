using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    public class Monster
    {
        private int id;
        private int hp;
        private int lvl;
        private string name;
        private int[] effects; /*16 total effects. Effectively bool array of 0 or 1 values, however effect Exhaustion has 6 levels thus need number 0-6 to represent*/
        private string image; /*IDK how to do images yet so yeah but this will be for monster image, currently lets assume its a path to an image*/

        /**
         * Default Constructor returns empty object
         * return empty monster
         */
        public Monster Create()
        {
            var monster = new Monster();
            monster.effects = new int[16];
            return monster;
        }

        /**
         * This Constructor does most of the heavy lifting assigning values to members
         * @param parameters an array of the values to be used in creating the monster.
         * return the initialized monster
         */
        public Monster Create(string[] parameters)
        {
            var monster = Create();
            monster.name = parameters[1];
            if(!int.TryParse(parameters[2], out monster.hp))
            {
                /*Failed to parse hp*/
                /*Try die roll*/
            }
            if(!int.TryParse(parameters[3], out monster.lvl))
            {
                /*Failed to parse level string*/
            }
            if(!int.TryParse(parameters[4], out monster.init))
            {
                /*Failed to parse initiative*/
                /*Try Die roll-- if no success then fail*/
            }

            /*Set effects based on parameters[5]*/
            string[] effec = parameters[5].Split('/');
            if(effec.Length() != 16)
            {
                /*Malformed Effect string*/
            }
            for (int i = 0; i < 16; i++)
            {
                if (!int.TryParse(effec[i], out monster.effects[i]))
                {
                    /*Failed to effect string*/
                }
            }

            return monster;
        }
        

        /*
         * let's devise a format for which a monster can be created from a line in a save file
         * Semi colon separation for parsing (Subject to change)
         * "type;name;hp;lvl;init;name;effects"
         * ex: "M;Goblin;2D6;3;1D20;{effectList}"
         * "M;Goblin;15;3;12;{effectlist}"
         * 
         * effectlist format (16 total effects):
         * forward slash separation for parsing (Subject to change)
         * 0/1/0/0/0/0/0/0/0/0/0/0/0/1/0/6
         * 0's and 1's for on and off style effects;  0-6 for Exhaustion effect (last element)
        */

        /**
         * Creates monster from a string of the above specified format
         * @param input the string to be parsed into parameters
         * return the new monster
         */
        public Monster Create(string input)
        {
            /*Confirm input is for monster*/
            string[] parameters = input.Split(';');
            if (!parameters[1].Equals("M"))
            {
                /*Input is not a monster*/
                return null;
            }
            if(parameters.Length() != 6)
            {
                /*Malformed Monster string*/
                return null;
            }

            /*parse name hp, lvl, init, and effects*/
            var monster = Create(parameters);



            return monster;
        }

        /**
         * Determines if monster is dead
         * return true if hp is 0 or less. false otherwise
         */
        public bool isDead()
        {
            if(this.hp <= 0)
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
            /*Compute xp*/
            return xp;
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

        public string getName()
        {
            return name;
        }

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public int getHp()
        {
            return hp;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }
        public void setLvl(int lvl)
        {
            this.lvl = lvl;
        }

        public int getLvl()
        {
            return lvl;
        }

        public void setEffect(int effect, int value)
        {
            effects[effect] = value;
        }

        public int[] getEffects()
        {
            return effects;
        }
    }
}
