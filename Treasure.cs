/**
 * @author Jacob Santillanes
 * 
 * @description randomly generates treasure based on creature level, type, and number of creatures
 * 
 * @todo
 *  -add higher level creatures 
 *  -add hoard encountes 
 *  -add magic item tables
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();/*creates a random number*/
            int die = rnd.Next(1, 101);
            String line;
            int cp = 0;
            int sp = 0;
            int ep = 0;
            int gp = 0;
            int pp = 0;
            int num_dice;
            int dice_type;



                //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("individual_1_4.txt");

                
            for (int i = 0; i < die -1; i++)
            {
                //Read the next line
                line = sr.ReadLine();
            }

            line = sr.ReadLine();
            Console.WriteLine(line);

     
            string[] words = line.Split(' ');
            string[] rolls;

            if (string.Compare(words[0], "0")  != 0)
            {
                rolls = words[0].Split('d');
                num_dice = Int32.Parse(rolls[0]);
                dice_type = Int32.Parse(rolls[1]);

                for(int j = 0; j < num_dice; j++)
                {
                    cp += rnd.Next(1, dice_type + 1);
                }
            }

            if (string.Compare(words[1], "0") != 0)
            {
                rolls = words[1].Split('d');
                num_dice = Int32.Parse(rolls[0]);
                dice_type = Int32.Parse(rolls[1]);

                for (int j = 0; j < num_dice; j++)
                {
                    sp += rnd.Next(1, dice_type + 1);
                }
            }

            if (string.Compare(words[2], "0") != 0)
            {
                rolls = words[2].Split('d');
                num_dice = Int32.Parse(rolls[0]);
                dice_type = Int32.Parse(rolls[1]);

                for (int j = 0; j < num_dice; j++)
                {
                    ep += rnd.Next(1, dice_type + 1);
                }
            }

            if (string.Compare(words[3], "0") != 0)
            {
                rolls = words[3].Split('d');
                num_dice = Int32.Parse(rolls[0]);
                dice_type = Int32.Parse(rolls[1]);

                for (int j = 0; j < num_dice; j++)
                {
                    gp += rnd.Next(1, dice_type + 1);
                }
            }

            if (string.Compare(words[4], "0") != 0)
            {
                rolls = words[4].Split('d');
                num_dice = Int32.Parse(rolls[0]);
                dice_type = Int32.Parse(rolls[1]);

                for (int j = 0; j < num_dice; j++)
                {
                    pp += rnd.Next(1, dice_type + 1);
                }
            }
            //close the file
            sr.Close();


            Console.WriteLine("cp = "+ cp);
            Console.WriteLine("sp = " + sp);
            Console.WriteLine("ep = " + ep);
            Console.WriteLine("gp = " + gp);
            Console.WriteLine("pp = " + pp);


            Console.ReadKey();
        }
    }
}
