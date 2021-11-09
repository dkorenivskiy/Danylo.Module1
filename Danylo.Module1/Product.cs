using System;
using System.Collections.Generic;
using System.Text;

namespace Danylo.Module1
{
    class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public Product(int id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public void Add(int quantity)
        {
            Quantity += quantity;
        }

        public void Remove(int quantity)
        {
            Quantity -= quantity;
        }

        public void Show()
        {
            Console.WriteLine($"{Id}\t{Name}\t{Quantity}");
        }
    }
}
