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
            int id = -1;
            if (_products[0] != null)
                id = Find(name);

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
                Console.WriteLine("Element with this name is already exist. Your entered quantity is added to existed item");
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
            if(_products[0] == null)
            {
                Console.WriteLine("Store is empty");
                return;
            }

            //TODO: check MSDN to fromat output string
            Console.WriteLine("{0, 10}, {1, 10}, {2, 10}", "Id", "Name", "Quntity");

            foreach (var product in _products)
            {
                if (product != null)
                    product.Show();
                else
                    return;
            }
        }

        private int Find(string name)
        {
            for(var i = 0; i < _products.Length; ++i)
            {
                if (_products[i] != null)
                {
                    if (_products[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        return i;
                }
                else
                {
                    return -1;
                }    
            }

            return -1;
        }
    }
}
