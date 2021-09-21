using ClickerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGameUI
{
    class ProgramUI
    {
        private GameMethods _gameMethods = new GameMethods();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {

            bool isRunning = true;
            while (isRunning)
            {
                if (_gameMethods.TotalCash() >= 100 && _gameMethods.TotalCash() <= 125)
                {
                    _gameMethods.EmergencyResponse1();
                }
                if (_gameMethods.TotalCash() >= 1000 && _gameMethods.TotalCash() <= 2000)
                {
                    _gameMethods.EmergencyResponse2();
                }
                if (_gameMethods.TotalCash() >= 3000 && _gameMethods.TotalCash() <= 3500)
                {
                    _gameMethods.EmergencyResponse3();
                }
                if (_gameMethods.TotalCash() >= 10000)
                {
                    _gameMethods.SellAndRetire();
                    isRunning = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("||CANDY TYPHOON||       Money in your Bank:$" + _gameMethods.TotalCash() + "\n" +
                             "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                             "How to make money:               \n" +
                             "\n\tSPACEBAR: SELL CANDY for $" + _gameMethods.Value() + " each\n" +
                             "\n\t\t---OR---\n\n" +
                             "\t1. Pay $20 - Upgrade your Candy Stand! Your selling Candy Price increases by $4 / item.\n" +
                             "\t2. Pay $50 - You switch to King Size bars. Bigger candy bars mean more money!\n" +
                             "\t\t\tYour selling Candy Price increases by 2x!!\n" +
                             "\t3. Pay $100 - You buy a neon sign for the window. More customers shop.\n" +
                             "\t4. Pay $500 - You buy an add on the billboard down the street.\n" +
                             "\t5. Leave game \n" +
                             "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    string userResponse = Console.ReadLine();

                    switch (userResponse)
                    {
                        case " ":
                            _gameMethods.Sell();
                            break;
                        case "1":
                            _gameMethods.Upgrade1();
                            Console.ReadLine();
                            break;
                        case "2":
                            _gameMethods.Upgrade2();
                            Console.ReadLine();
                            break;
                        case "3":
                            _gameMethods.Upgrade3();
                            Console.ReadLine();
                            break;
                        case "4":
                            _gameMethods.Upgrade4();
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Clear();
                            isRunning = false;
                            break;
                        default:
                            _gameMethods.SellAndRetire();
                            Console.ReadLine();
                            break;
                    }

                }
            }
        }
    }
}
