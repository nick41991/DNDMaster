using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_start_load
{
    /**
     * This is the menu of the game, it will show the current players, add or delete players,
     * make battles, load, save, etc.
     * 
     * @todo load game, save game, battle
     **/
    public class Game
    {
        public List<Player> players;
        public List<Monster> monsters;

        public Game()
        {
            setPlayers(new List<Player>());
            setMonster(new List<Monster>());
        }

        /*
        public Game(Player file)
        {
            setPlayers(new List<Player>());
            //Load(file);
        }
        */

        /**public void Load(Player file)
        {
            addPlayer(file);   
        }**/

        /**
         * Add player to the menu
         * @param name
         
        public void addPlayer(string name)
        {
            this.players.Add(new Player(name));
        }

        /**
         * Add player during a battle with all values
         * @param name, init
         **/
        public void addPlayer(string name, string init)
        {
            this.players.Add(new Player(name, init));
        }
        
        public void addMonster(Monster monster)
        {
            int i = 0;
            int c = 1;
            for (i = 0; i < monsters.Count; i++)
            {
                if (monsters[i].getName().Equals(monster.getName()))      //checks that a monster exists with a specific name
                {
                    var newName = monster.getName() + c;

                    monster.setName(newName);
                    c++;
                    i = 0;
                }
            }
            this.monsters.Add(monster);
        }

        /**
         * Deletes player from menu
         * @param name
         **/
        public void deletePlayer(string name)
        {
            int i = 0;
            for (i = 0; i < players.Count; i++)
            {
                if (players[i].getName().Equals(name))      //checks that a player exists with a specific name
                {
                    this.players.RemoveAt(i);
                    return;
                }

            }

            Console.WriteLine("\n{0} is not a player", name);
        }

        public void deleteMonster(string name)
        {
            int i = 0;
            for (i = 0; i < monsters.Count; i++)
            {
                if (monsters[i].getName().Equals(name))      //checks that a monster exists with a specific name
                {
                    this.monsters.RemoveAt(i);
                    return;
                }

            }
        }

        public List<Player> getPlayers()
        {
            return this.players;
        }

        public List<Monster> getMonsters()
        {
            return this.monsters;
        }

        public void setPlayers(List<Player> players)
        {
            this.players = players;
        }

        public void setMonster(List<Monster> monsters)
        {
            this.monsters = monsters;
        }

        public List<Character> generateTurnOrder()
        {
            List<Character> characters = new List<Character>();
            foreach(Player p in players)
            {
                characters.Add(p);
            }
            foreach(Monster m in monsters)
            {
                if(!m.isdead)
                characters.Add(m);
            }
            characters = characters.OrderByDescending(c => c.init).ToList();
            return characters;
        }

    }
}
