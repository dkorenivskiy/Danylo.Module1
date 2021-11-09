using System;

namespace Danylo.Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var store = new Store();
            var ui = new StoreUI(store);

            ui.Run();
        }
    }
}
