using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Product
    {   
        private string _name;
        private decimal _price;
        private int _quantity;
        public Product(string name, decimal price, int quantity) {
            _name = name;
            _price = price; 
            _quantity = quantity;
        }
        public string Name { get => _name; set { if (string.IsNullOrEmpty(value)) throw new Exception("Invalid"); _name = value; } }
        public decimal Price { get => _price; set { if (value<=0) throw new Exception("Invalid price"); _price = value; } }
        public int Quantity => _quantity;
        public decimal TotalValue => _price * _quantity;
        public void Restock(int amount)
        {   if (amount < 0) throw new Exception("Invalid amount");
            _quantity += amount;
        }
        public void Sell(int amount)
        {
            if (amount < 0) throw new Exception("Invalid amount");
            if (_quantity < amount) return;
            _quantity -= amount;
        }
        public string GetInfo()
        {
            string info = "Товар: " + _name + ", Ціна: " + _price + ", Кількість: " + _quantity + ", Загальна вартість: " + TotalValue;
            return info;

        }
    }
}
