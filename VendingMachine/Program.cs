using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {

        static void Main(string[] args)
        {
            int moneyPool = 0;
            Product[] items = { new Kex(), new Marabou(), new Pepsi(), new Ball(), new CheeseSandwitch() };
            List<Product> cart = new List<Product>();


            Console.WriteLine("Welcoeme. Buy something by pressing keys:");
            while (true)
            {
                Console.WriteLine("\n1-Insert Money. \n2-Buy Products. \n3-Bought Products. \n4-Withdraw.");


                int[] money = { 1, 5, 10, 20, 50, 100, 200, 500, 1000 };

                int option = Convert.ToInt32(Console.ReadLine());


                if (option == 1)
                {

                    while (true)
                    {
                        Console.WriteLine("Deposit  (1, 5, 10, 20, 50, 100, 200, 500 eller 1000 kr).");

                        int input = Convert.ToInt32(Console.ReadLine());

                        if (money.Contains(input))
                        {

                            moneyPool = moneyPool + input;

                            Console.WriteLine("Deposited amount: " + moneyPool);
                            Console.WriteLine("Press 0 to go back and choose product or ");
                        }
                        else if (input == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please! Insert valid currency.");
                        }

                    }
                }
                

                else if (option == 2)
                {

                    while (true)
                    {


                        Console.WriteLine("Total: " + moneyPool + " kr. \n Choose Product: \n 1: Kex - 10kr \n 2: Marabou - 15kr \n 3: Pepsi - 20kr \n 4: Ball - 45kr \n 5: Cheese Sandwitch - 25\n. Press 0 to return. ");
                        string choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            Console.WriteLine("How many? ");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            int KexPrice = items[0].GetPrice();
                            int total = KexPrice * amount;
                            if (moneyPool >= total)
                            {
                                moneyPool = moneyPool - total;
                                for (int i = 0; i < amount; i++)
                                {
                                    cart.Add(items[0]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough money to buy, please deposit money or buy somethign cheaper.");
                            }
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine("How many? ");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            int MarabouPrice = items[1].GetPrice();
                            int total = MarabouPrice * amount;
                            if (moneyPool >= total)
                            {
                                moneyPool = moneyPool - total;
                                for (int i = 0; i < amount; i++)
                                {
                                    cart.Add(items[1]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You dont have enough money to buy, please deposit money or buy somethign cheaper.");
                            }
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("How many? ");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            int PepsiPrice = items[2].GetPrice();
                            int total = PepsiPrice * amount;
                            if (moneyPool >= total)
                            {
                                moneyPool = moneyPool - total;
                                for (int i = 0; i < amount; i++)
                                {
                                    cart.Add(items[2]);
                                }
                            }
                        }

                        else if (choice == "4")
                        {
                            Console.WriteLine("How many? ");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            int BallPrice = items[3].GetPrice();
                            int total = BallPrice * amount;
                            if (moneyPool >= total)
                            {
                                moneyPool = moneyPool - total;
                                for (int i = 0; i < amount; i++)
                                {
                                    cart.Add(items[3]);
                                }
                            }
                        }

                        //

                        else if (choice == "5")
                        {
                            Console.WriteLine("How many? ");
                            int amount = Convert.ToInt32(Console.ReadLine());

                            int CheeseSandwitchPrice = items[4].GetPrice();
                            int total = CheeseSandwitchPrice * amount;
                            if (moneyPool >= total)
                            {
                                moneyPool = moneyPool - total;
                                for (int i = 0; i < amount; i++)
                                {
                                    cart.Add(items[4]);
                                }
                            }
                        }
                        //
                        else if (choice == "0")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose something else from list.\n");
                        }
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("This is in your inventory: \n");

                    foreach (Product product in cart)
                        Console.WriteLine(product.GetName());

                    while (true)
                    {

                        Console.WriteLine("\nAlternative you can choose:\n 1 - Kex. \n 2 - Marabou. \n 3 - Ball. \n 0 - Return to the menu.");

                        int Use = Convert.ToInt32(Console.ReadLine());


                        if (Use == 1 && cart.Contains(items[0]))
                        {
                            cart.Remove(items[0]);
                            Console.WriteLine("You bought a Kex.");
                            foreach (Product product in cart)
                                Console.WriteLine(product.GetName());
                        }
                        else if (Use == 2 && cart.Contains(items[1]))
                        {
                            cart.Remove(items[1]);
                            Console.WriteLine("You bought a Marabou.");

                            foreach (Product product in cart)
                                Console.WriteLine(product.GetName());
                        }
                        else if (Use == 3 && cart.Contains(items[2]))
                        {
                            cart.Remove(items[2]);
                            Console.WriteLine("You bought a Pepsi.");

                            foreach (Product product in cart)
                                Console.WriteLine(product.GetName());
                        }
                        else if (Use == 4 && cart.Contains(items[3]))
                        {
                            cart.Remove(items[3]);
                            Console.WriteLine("You bought a Ball.");

                            foreach (Product product in cart)
                                Console.WriteLine(product.GetName());
                        }
                        else if (Use == 5 && cart.Contains(items[4]))
                        {
                            cart.Remove(items[4]);
                            Console.WriteLine("You bought a CheeseSandwitch.");

                            foreach (Product product in cart)
                                Console.WriteLine(product.GetName());
                        }
                        else if (Use == 0)
                        {
                            break;
                        }
                        else if (Use > 3)
                        {
                            Console.WriteLine("Select some other alternative.");
                        }
                        else
                        {
                            Console.WriteLine("This product is not in your inventory");
                        }
                    }

                }
                else if (option == 4)
                {
                    Console.WriteLine("You " + moneyPool + " kr left in Vending Machine. Want to withdraw? [Y/N]");

                    string GetChange = Console.ReadLine();
                    List<int> Change = new List<int>();

                    if (GetChange.ToUpper() == "Y")
                    {
                        while (moneyPool > 0)
                        {
                            if (moneyPool >= 1000)
                            {
                                moneyPool = moneyPool - 1000;
                                Change.Add(1000);
                            }
                            else if (moneyPool >= 500)
                            {
                                moneyPool = moneyPool - 500;
                                Change.Add(500);
                            }
                            else if (moneyPool >= 200)
                            {
                                moneyPool = moneyPool - 200;
                                Change.Add(200);
                            }
                            else if (moneyPool >= 100)
                            {
                                moneyPool = moneyPool - 100;
                                Change.Add(100);
                            }
                            else if (moneyPool >= 50)
                            {
                                moneyPool = moneyPool - 50;
                                Change.Add(50);
                            }
                            else if (moneyPool >= 20)
                            {
                                moneyPool = moneyPool - 20;
                                Change.Add(20);
                            }
                            else if (moneyPool >= 10)
                            {
                                moneyPool = moneyPool - 10;
                                Change.Add(10);
                            }
                            else if (moneyPool >= 5)
                            {
                                moneyPool = moneyPool - 5;
                                Change.Add(5);
                            }
                            else if (moneyPool >= 1)
                            {
                                moneyPool = moneyPool - 1;
                                Change.Add(1);
                            }
                        }
                        Console.WriteLine("You will get back:");
                        for (int i = 0; i < Change.Count; i++)
                        {
                            Console.WriteLine(Change[i] + " kr");
                        }
                    }
                    else if (GetChange.ToUpper() == "N")
                    {

                    }
                    else
                    {
                        Console.WriteLine("You need to choice Y or N.");

                    }

                }
            }
        }
    }
}
