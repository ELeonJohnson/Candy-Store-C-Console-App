using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace candyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Variables Used
            string userName = "";
            string userBuyOrWork = "";
            string chocolate = "chocolate bar";
            string caramel = "caramel candy";
            string sucker = "sucker";
            string candyCorn = "candy corn";
            string mint = "pepermint";
            string exitOption = "";
            int usersMoney = 20;
            int chocolatePrice = 5;
            int caramelPrice = 4;
            int suckerPrice = 3;
            int candyCornPrice = 2;
            int mintPrice = 1;
            int usersCandyBuy = 0;
            int usersJobChoice = 0;
            



           
                //Introduction To The App, Asking For User's Name
                Console.WriteLine("Welcome to the Candy Corner.");
                Console.WriteLine("What's you name?");
                userName = Console.ReadLine();

            do
            {
                

                //Displaying Users Money And Option To Buy
                Console.WriteLine($"Well {userName}, you have ${usersMoney}.");
                Console.WriteLine("Would you like to buy something or make some pocket change?");
                Console.WriteLine("I could use the extra help around the store.");
                Console.WriteLine("Type 'buy' or 'work'");
                userBuyOrWork = Console.ReadLine();



                if (userBuyOrWork.ToLower() == "buy")
                {
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine($"1. {chocolate} - ${chocolatePrice}");
                    Console.WriteLine($"2. {caramel} - ${caramelPrice}");
                    Console.WriteLine($"3. {sucker} - ${suckerPrice}");
                    Console.WriteLine($"4. {candyCorn} - ${candyCornPrice}");
                    Console.WriteLine($"5. {mint} - ${mintPrice}");
                    usersCandyBuy = Convert.ToInt32(Console.ReadLine());

                    switch (usersCandyBuy)
                    {
                        case 1:
                            usersMoney = usersMoney - chocolatePrice;
                            Console.WriteLine($"Thanks for buying our best seller, a {chocolate}.");
                            Console.WriteLine($"You have ${usersMoney} left.");
                            break;
                        case 2:
                            usersMoney = usersMoney - caramelPrice;
                            Console.WriteLine($"Thanks for buying some {caramel}.");
                            Console.WriteLine($"You have ${usersMoney} left.");
                            break;
                        case 3:
                            usersMoney = usersMoney - suckerPrice;
                            Console.WriteLine($"Thanks for buying a {sucker}");
                            Console.WriteLine($"You have ${usersMoney} left.");
                            break;
                        case 4:
                            usersMoney = usersMoney - candyCornPrice;
                            Console.WriteLine($"Thanks for buying some {candyCorn}, they rarely sell.");
                            Console.WriteLine($"You have ${usersMoney} left.");
                            break;
                        case 5:
                            usersMoney = usersMoney - mintPrice;
                            Console.WriteLine($"Thanks for a {mint}.");
                            Console.WriteLine($"You have ${usersMoney} left.");
                            break;
                    }


                }
                   
                

                else if (userBuyOrWork.ToLower() == "work")
                {
                    Console.WriteLine($"Appreciate the help, {userName}.");
                    Console.WriteLine("1. Sweep");
                    Console.WriteLine("2. Take Trash Out");
                    Console.WriteLine("3. Clean Tables");
                    Console.WriteLine("4. Restock Shelves");
                    Console.WriteLine("5. Run Register");
                    usersJobChoice = Convert.ToInt32(Console.ReadLine());

                    switch (usersJobChoice)
                    {
                        case 1:
                            usersMoney++;
                            Console.WriteLine($"Thanks for sweeping, you now have ${usersMoney}.");
                            break;
                        case 2:
                            usersMoney += 2;
                            Console.WriteLine($"Thanks for taking out the trash, you now have ${usersMoney}.");
                            break;
                        case 3:
                            usersMoney += 3;
                            Console.WriteLine($"Thanks for cleaning the tables, you now have ${usersMoney}.");
                            break;
                        case 4:
                            usersMoney += 4;
                            Console.WriteLine($"Thanks for restocking the shelves, you now have ${usersMoney}.");
                            break;
                        case 5:
                            usersMoney += 5;
                            Console.WriteLine($"Thanks for running the register, you now have ${usersMoney}.");
                            break;
                    }
                }
                Console.WriteLine("Run Again? Type [y/n]");
                exitOption = Console.ReadLine().ToLower();
                if (exitOption == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                }
            } while (exitOption != "n");

            

            



        }
    }
}
