using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DM_Assistant
{
    /**
     * First Menu, it asks to create a new game or load game
     * 
     * @todo load game
     **/
    class Menu
    {
        /**
         * Checks that user input is correct
         * @param input 
         **/
        static int Check(string input) {

           
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

        static void Main(string[] args)
        {
            int e = 1;
            string input = null;
            Console.WriteLine("Welcome to The DM Assistant App\n");
            while (e == 1)
            {

                Console.Write("1. New Game\n2. Load Game\n");
                Console.Write("\nEnter number or exit: ");
                input = Console.ReadLine();
                input = input.Replace(" ", string.Empty);
                e = Check(input);
               
            }

            if (e == 2)
            {
                System.Environment.Exit(0);
            }

            if (input.Equals("1"))
            {
                Game game = new Game();
                Console.WriteLine();
                game.Main();
            }
            else
            {
                Game game = new Game();         //need to make the load feature
                game.Main();
            }
            
           
            Console.ReadLine();
        }
    }
}
