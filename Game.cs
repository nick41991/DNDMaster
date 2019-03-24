using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant
{
    /**
     * This is the menu of the game, it will show the current players, add or delete players,
     * make battles, load, save, etc.
     * 
     * @todo load game, save game, battle
     **/
    class Game
    {
        private List<Player> players;
        private List<string> monsters;

        public Game()
        {
            setPlayers(new List<Player>());
        }

        public Game(Player file)
        {
            setPlayers(new List<Player>());
            //Load(file);
        }

        /**public void Load(Player file)
        {
            addPlayer(file);   
        }**/

        /**
         * Add player to the menu
         * @param name
         **/
        public void addPlayer(string name)
        {
            
            this.players.Add(new Player(name));
        }

        /**
         * Add player during a battle with all values
         * @param name, init, effect
         **/
        public void addPlayeringame(string name, int init, string effect)
        {

            this.players.Add(new Player(name, init, effect));
        }

        /**
         * Adds monster to the battle 
         * @todo implement monster class
         **/
        public void addMonster(string name)
        {
            this.monsters.Add(name);
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


        public List<Player> getPlayers()
        {
            return this.players;
        }

        public List<string> getMonsters()
        {
            return this.monsters;
        }

        public void setPlayers(List<Player> players)
        {
            this.players = players;
        }

        public void setMonster(List<string> monsters)
        {
            this.monsters = monsters;
        }

        /**
         * Checks user input is correct
         * @param input
         **/
        static int Check(string input)
        {

            input = input.Replace(" ", string.Empty);
            //Console.WriteLine("{0}", input);

            if (input.Equals("1") | input.Equals("2"))
                return 0;
            else if (input.Equals("exit") | input.Equals("Exit"))
                return 2;
            else
            {
                Console.WriteLine("\n{0} is not a choice. Try Again\n", input);
                return 1;
            }

        }

        public void Main()
        {
            string input = null;
            string name = null;
            int er = 0;
            while (true)
            {
                Console.WriteLine("Game Menu\n");
                Console.WriteLine("Current Players:");
                foreach (var player in players)
                {
                    Console.WriteLine(player.getName());
                }
                Console.WriteLine("\n1. Add Player");
                Console.WriteLine("2. Remove Player\n");
                Console.Write("\nEnter number or exit: ");
                input = Console.ReadLine();
                er = Check(input);
                if (er == 1)
                    continue;
                else if (er == 2)
                    break;
                Console.WriteLine();
                switch(Convert.ToInt32(input))
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("Enter name of player to add or exit: ");
                            name = Console.ReadLine();
                            name = name.Trim();

                            if (name.Equals("exit"))
                            {
                                Console.WriteLine();
                                break;
                            }
                            
                            addPlayer(name);
                            Console.WriteLine();
                        }
                       
                        break;

                    case 2:
                        while (true)
                        {
                            Console.Write("Enter name of player to delete or exit: ");
                            name = Console.ReadLine();
                            name = name.Trim();
                            if (name.Equals("exit"))
                            {
                                Console.WriteLine();
                                break;
                            }
                            deletePlayer(name);
                            Console.WriteLine();
                        }
                        break;
                }
            }
            

        }
    }
}
