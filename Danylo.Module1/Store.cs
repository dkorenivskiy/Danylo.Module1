using System;
using System.Collections.Generic;
using System.Text;

namespace Danylo.Module1
{
    class Store
    {
        private Product[] _products = new Product[5];
        private int _quantity = 0;

        public void Add(string name, int quantity)
        {
            var id = Find(name);

            if (id == -1)
            {
                if (_quantity < 5)
                {
                    _products[_quantity] = new Product(_quantity, name, quantity);
                    _quantity++;
                }
                else
                {
                    Console.WriteLine("Store is full");
                }
            }
            else
            {
                _products[id].Add(quantity);
            }
        }

        public void Remove(string name, int quantity)
        {
            var id = Find(name);

            if (id == -1)
            {
                Console.WriteLine("Item is not found in store.");
            }
            else
            {
                if (_products[id].Quantity < quantity)
                {
                    Console.WriteLine("Invalid operation.");
                }
                else
                {
                    _products[id].Remove(quantity);
                }
            }
        }

        public void Show()
        {
            //TODO: check MSDN to fromat output string
            Console.WriteLine("Id\tName\tQuntity");

            foreach (var product in _products)
            {
                product.Show();
            }
        }

        private int Find(string name)
        {
            for(var i = 0; i < _products.Length; ++i)
            {
                if (_products[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return i;
            }

            return -1;
        }
    }
}
