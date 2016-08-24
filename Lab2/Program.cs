using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome ! What is your name?(enter your name):   ");
            Console.ReadLine();
            Console.WriteLine("Would you like to play a game(enter \"yes\" \"or\"): ");
            String game_decision = Console.ReadLine();
            if (game_decision == "yes")
            {

                Console.WriteLine("Excellant!you are walking across a field and you encounter  a fire -breathing dragon! /n what would you do? (enter\" face the beast \"or \"run away\")");
                String face_or_run = Console.ReadLine();
                if (face_or_run == "face the beast")
                {

                    Console.WriteLine("You appraoch the Dragon.You see that he has _heads.(enter \"1 \"or \"2\" or\" 3\"");
                    String options = Console.ReadLine();
                    int option = int.Parse(options);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("It is not a 3 headed Dragon. It has one head");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("It is not a 3 headed Dragon. It has two heads");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine(" No one has ever faced a 3- headed dragon before! Choose your weapon  enter");
                            Console.WriteLine("slingshot or sword or bow and arrow");
                            string arm = Console.ReadLine();


                            switch (arm)
                            {

                                case "slingshot":
                                    Console.WriteLine("You have slingshot");
                                    break;

                                case "sword":
                                    Console.WriteLine("You have sword");
                                    break;
                                case "bow and arrow":
                                    Console.WriteLine("Arnmed with bow and arrow , you approach the dragon. You can feel its fiery breath as you get closer.It stares at you with its _ eyes.(enter\" red\" or \"blue\")");
                                    string eye_color = Console.ReadLine();
                                    if (eye_color == "red")
                                    {
                                        Console.WriteLine("Oh thank goodness ! Red -eyed dragons are friendly .You pet it and become friends.");
                                        Console.WriteLine("you name the dragon");
                                        String name = Console.ReadLine();
                                        Console.WriteLine(name + " and Toothless live happily ever after");


                                    }
                                    break;
                                default:
                                    Console.WriteLine("hi");
                                    break;



                            }
                            break;
                        default:
                            Console.WriteLine("hi");
                            break;

                    }
                }

                else
                {
                    Console.WriteLine("You run away from game");
                }
            }
            else
            {
                Console.WriteLine("you are not selected the game");
            }


        }
    }
}
