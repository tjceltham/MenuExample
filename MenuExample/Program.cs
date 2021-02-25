using System;

namespace MenuExample
{

  //  RPG inventory problem:
  
  //Write a program that will hold the inventory a player has in an RPG game.The player has the following actions: 
    //pick(adds an item to the inventory) - e.g. pick axe
    //drop(removes the last item added to the inventory) - e.g drop
    //pull(outputs a random item from the inventory) - e.g. pull 
    //search(outputs all the items in the inventory).   e.g search

    class Program
    {
        // Global variables can be accessed by all methods
        static string[] inventory = new string[10];
        static int numberOfItemsInInventory = 0;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string response = "";

            do
            {
                Console.WriteLine("Type in your command - pick, drop, pull search");
                Console.WriteLine("1 - Pick");
                Console.WriteLine("2 - Drop");
                Console.WriteLine("3 - Pull");
                Console.WriteLine("4 - Pick");
                Console.WriteLine("5 - End");

                response = Console.ReadLine();

                if (response == "1")
                {
                    pick();
                }
                if (response == "2")
                {
                    drop();
                }
                if (response == "3")
                {
                    pull();
                }
                if (response == "4")
                {
                    search();
                }


            } while (response != "5");
        }

        static void pick()
        {
            // ask user what to pick up and add it to the first free position in the inventory
            // add one to elements in inventory counter
        }

        static void drop()
        {
            // remove the last element added to the inventory.
            // take one from the inventory count

        }

        static void pull()
        {
            // generate a ranom number between 0 and amount of items in inventory -1
            // Print out the elemrnt at this random index to the screen

        }

        static void search()
        {
            // Iterate around the inventory from 0 to number of items in the inventory, printing each element to the console
        }

    }
}
