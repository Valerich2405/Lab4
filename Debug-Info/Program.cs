using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Debug_Info
{
    public class Goods
    {
        private string producer;
        private int price;
        private int amount;

        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public Goods(string Producer, int Price, int Amount)
        {
            producer = Producer;
            price = Price;
            amount = Amount;
        }
    }

    public class Bread : Goods
    {
        public Bread(string producer, int price, int amount) : base(producer, price, amount)
        { 

        }
    }

    public class Eggs : Goods
    {
        public Eggs(string producer, int price, int amount) : base(producer, price, amount) 
        {

        }
    }

    public class Milk : Goods
    {
        public Milk(string producer, int price, int amount) : base(producer, price, amount)
        { 

        }
    }

    public class List<T> where T : Goods
    {
        public void DebugInfo(T goods)
        {
            Console.WriteLine($"Class: {goods}");
            Console.WriteLine($"Properties:");
            Console.WriteLine($"Producer of goods: {goods.Producer}. Price: {goods.Price}. Amount: {goods.Amount}");
            Console.WriteLine();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Bread bread = new Bread("Kyivbread", 20, 300);
            Eggs eggs = new Eggs("Kyivagro", 60, 100);
            Milk milk = new Milk("Galicia", 30, 50); 
            List<Goods> goods = new List<Goods>();
          
            goods.DebugInfo(bread);
            goods.DebugInfo(eggs);
            goods.DebugInfo(milk);
        }
    }
}
