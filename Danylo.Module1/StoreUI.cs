using System;
using System.Collections.Generic;
using System.Text;

namespace Danylo.Module1
{
    class StoreUI
    {
        private Store _store;

        public StoreUI(Store store)
        {
            _store = store;
        }

        public void Run()
        {
            string choice;
            

            do
            {
                Console.WriteLine("1 - display items in store");
                Console.WriteLine("2 - add to store");
                Console.WriteLine("3 - remove from store");
                Console.WriteLine("exit - display items in store");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _store.Show();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Enter the name of new item");
                        string newNameAdd = Console.ReadLine();
                        Console.WriteLine("Enter quantity of item");
                        int quantityAdd = Convert.ToInt32(Console.ReadLine());

                        _store.Add(newNameAdd, quantityAdd);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Enter the name of new item");
                        string newNameRemove = Console.ReadLine();
                        Console.WriteLine("Enter quantity of item");
                        int quantityRemove = Convert.ToInt32(Console.ReadLine());

                        _store.Remove(newNameRemove, quantityRemove);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("Wrong Key! Please try again");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            } while (choice != "exit");
        }
    }
}
