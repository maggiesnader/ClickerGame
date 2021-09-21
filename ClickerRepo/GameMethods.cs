using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerRepo
{
    public class GameMethods
    {
        private GameData _gameData = new GameData(0, 1, 20, 50);

        public int TotalCash()
        {
            return _gameData.Cash;
        }

        public int Value()
        {
            return _gameData.Value;
        }

        public int Minus20()
        {
            return _gameData.Min;
        }

        public int Minus50()
        {
            return _gameData.Min2;
        }
        public int Sell()
        {
            _gameData.Cash += _gameData.Value;
            Console.WriteLine("You sold one bar for $" + Value() + "\n" +
                "Your cash: $" + TotalCash() + "\n" +
                "Press any key to continue:\n");
            Console.ReadKey();
            return _gameData.Cash;
        }

        public int NewValue1()
        {

            return _gameData.Value = 5;
        }

        public int NewValue2()
        {

            return _gameData.Value = 10;
        }

        public int Sub1()
        {
            _gameData.Cash = TotalCash() - Minus20();
            return _gameData.Cash;
        }

        public int Sub2()
        {
            _gameData.Cash = TotalCash() - Minus50();
            return _gameData.Cash;
        }


        //UPGRADES
        public void Upgrade1()
        {
            if (TotalCash() < 20)
            {
                Console.WriteLine("You do not have enough cash!");
            }
            else
            {
                Console.WriteLine("Purchase Complete!\n" +
                    "Press enter to continue:");
                NewValue1();
                Sub1();
            }
        }

        public void Upgrade2()
        {
            if (TotalCash() < 50)
            {
                Console.WriteLine("You do not have enough cash!");
            }
            else
            {
                Console.WriteLine("Purchase Complete!\n" +
                    "Press enter to continue:");
                NewValue2();
                Sub2();
            }
        }

        public void Upgrade3()
        {
            if (TotalCash() < 100)
            {
                Console.WriteLine("You do not have enough cash!");
            }
            else
            {
                Console.WriteLine("Purchase Complete!\n" +
                    "The sign worked well. You make $500.\n" +
                    "Press enter to continue:");
                _gameData.Cash = TotalCash() - 100 + 500;
            }
        }

        public void Upgrade4()
        {
            if (TotalCash() < 500)
            {
                Console.WriteLine("You do not have enough cash!");
            }
            else
            {
                Console.WriteLine("Purchase Complete!\n" +
                    "The billboard worked well. You make $1000.\n" +
                    "Press enter to continue:");
                _gameData.Cash = TotalCash() - 500 + 1000;
            }
        }



        //EMERGENCIES
        //emergencyResponse1
        public int LocalDepot()
        {
            _gameData.Cash = TotalCash() + 300;
            Console.WriteLine("\nCandy is on sale today at the Depot! You make $300 profit.\n" +
                          "You now have $" + TotalCash() + ".\n" +
                          "Press enter to continue.");
            Console.ReadLine();
            return _gameData.Cash;
        }

        public int OnlineOrder()
        {
            _gameData.Cash = TotalCash() - 100;
            Console.WriteLine("\nThe candy you ordered was expired. You cannot sell it and you loose $100.\n" +
                            "You now have $" + TotalCash() + ".\n" +
                            "Press enter to continue. ");
            Console.ReadLine();
            return _gameData.Cash;
        }

        public void EmergencyResponse1()
        {
            Console.Clear();
            Console.WriteLine("Uh oh, your normal distributor is out of Candy! You have to purchase from somewhere else.\n" +
                    "Choose an option (enter: 1 or 2)\n" +
                    "1. You decide to drive to the local depot downtown.\n" +
                    "2. You find an online dealer with cheap prices that can ship same day.\n\n");
            string emergencyResponse1 = Console.ReadLine();

            switch (emergencyResponse1)
            {
                case "1":
                    LocalDepot();
                    break;
                case "2":
                    OnlineOrder();
                    break;
                default:
                    Console.WriteLine("Not a valid answer, Try Again!");
                    Console.ReadLine();
                    break;

            }
        }

        //emergencyResponse2
        public void EmergencyResponse2()
        {
            Console.Clear();
            Console.WriteLine("Hurry! There is a leak in the roof! Your inventory is getting ruined.\n" +
                    "Choose an option (enter: 1 or 2)\n" +
                    "1. You decide to move the inventory to a dry place, get a bucket, and call a repair-man in the morning.\n" +
                    "2. You stay up all night trying to fix the leak.\n\n");
            string emergencyResponse2 = Console.ReadLine();

            switch (emergencyResponse2)
            {
                case "1":
                    Bucket();
                    break;
                case "2":
                    NoSleep();
                    break;
                default:
                    Console.WriteLine("Not a valid answer, Try Again!");
                    Console.ReadLine();
                    break;

            }
        }

        public int Bucket()
        {
            _gameData.Cash = TotalCash() - 500;
            Console.WriteLine("\nThe storm continued to get worse and your shop flooded. You lost most of your inventory.\n" +
                          "You now have $" + TotalCash() + ".\n" +
                          "Press enter to continue.");
            Console.ReadLine();
            return _gameData.Cash;
        }

        public int NoSleep()
        {
            _gameData.Cash = TotalCash() + 500;
            Console.WriteLine("\nThe storm continued to get worse and flooded most of the other shops in the neighborhood.\n" +
                "Since you stayed up to keep an eye on things, you were able to save most of your inventory\n" +
                "You make $500 the next day because youre the only shop on the block open.\n" +
                          "You now have $" + TotalCash() + ".\n" +
                          "Press enter to continue.");
            Console.ReadLine();
            return _gameData.Cash;
        }

        //emergencyResponse3

        public void EmergencyResponse3()
        {
            Console.Clear();
            Console.WriteLine("Uh oh! On your way to the Shop this morning, your car got a flat!\n" +
                    "Choose an option (enter: 1 or 2)\n" +
                    "1. You decide to head straight to the Tire Shop around the corner to get it checked out.\n" +
                    "2. You decide to park the car and come back for it later. Got to get to work!\n\n");
            string emergencyResponse3 = Console.ReadLine();

            switch (emergencyResponse3)
            {
                case "1":
                    FixTire();
                    break;
                case "2":
                    SkipWork();
                    break;
                default:
                    Console.WriteLine("Not a valid answer, Try Again!");
                    Console.ReadLine();
                    break;

            }
        }

        public int FixTire()
        {
            _gameData.Cash = TotalCash();
            Console.WriteLine("\nGood thing you went in to get the tire fixed. You had a construction bolt stuck in the rim.\n" +
                "You caught it just in time to save the wheel.\n" +
                "The shop was quick and you were able to get back to the Candy Shop midday.\n" +
                "You end up staying a few extra hours and breaking even for the day.\n" +
                          "You still have $" + TotalCash() + ".\n" +
                          "Press enter to continue.");
            Console.ReadLine();
            return _gameData.Cash;
        }

        public int SkipWork()
        {
            _gameData.Cash = TotalCash() - 2000;
            Console.WriteLine("\nYou get to your car after work and the tire is COMPLETELY flat.\n" +
                "You decide to drive it to the Tire Shop on empty.\n" +
                "The mechanic tells you that you have damaged the entire wheel and it needs to be replaced. \n" +
                "You also bent your axel driving on a flat.\n" +
                "You owe the shop $2000 in repairs." +
                          "You now have $" + TotalCash() + ".\n" +
                          "Press enter to continue.");
            Console.ReadLine();
            return _gameData.Cash;
        }

        //sell shop
        public void SellAndRetire()
        {
            if (TotalCash() >= 10000)
            {
                Console.Clear();
                Console.WriteLine("Congratulations! You have caught the attention of an investor!\n" +
                    "They would like to purchase your candy shop for $1,000,000\n" +
                        "You're able to Retire!\n\n" +
                        "GAME OVER!");
                Console.ReadLine();

            }
        }
    }
}
