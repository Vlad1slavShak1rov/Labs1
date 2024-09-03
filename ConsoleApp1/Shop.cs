using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Product
    {
        public virtual double Price{get;set;}
        public abstract void GetInformation();

    }

    public class Toy: Product
    {
        string _type = "";
        double dicount = 0;
        double TotalPrice;
        public Toy(double price, string type)
        {
            _type = type;
            Price = price;
            TotalPrice = CalculatedDiscount(price, _type);
        }

        private double CalculatedDiscount(double price, string type)
        {
            switch(type.ToLower())
            {
                case "музыкальные":
                    dicount = 0.2;
                    return price * dicount;
                case "спортивные":
                    dicount = 0.15;
                    return price * dicount;
                case "развивающие":
                    dicount = 0.3;
                    return price * dicount;
                default:
                    return price;
            }
        }
        public override void GetInformation()
        {
            Console.WriteLine($"Тип игрушки: {_type}\nЦена ${Price}" +
                $"\nСкидка: {dicount*100}%\nИтоговая стоимость: ${TotalPrice}");
        }
    }

    public class Meat : Product
    {
        string _type = "";
        double dicount = 0;
        double TotalPrice;
        public Meat(double price, string type)
        {
            _type = type;
            Price = price;
            TotalPrice = CalculatedDiscount(price, _type);
        }

        private double CalculatedDiscount(double price, string type)
        {
            switch (type.ToLower())
            {
                case "баранина":
                    dicount = 0.2;
                    return price * dicount;
                case "свинина":
                    dicount = 0.15;
                    return price * dicount;
                case "говядина":
                    dicount = 0.3;
                    return price * dicount;
                default:
                    return price;
            }
        }
        public override void GetInformation()
        {
            Console.WriteLine($"Тип мяса: {_type}\nЦена ${Price}" +
                $"\nСкидка: {dicount * 100}%\nИтоговая стоимость: ${TotalPrice}");
        }
    }

    public class Drink : Product
    {
        string _type = "";
        double dicount = 0;
        double TotalPrice;
        public Drink(double price, string type)
        {
            _type = type;
            Price = price;
            TotalPrice = CalculatedDiscount(price, _type);
        }
        private double CalculatedDiscount(double price, string type)
        {
            switch (type.ToLower())
            {
                case "алкогольные":
                    dicount = 0.2;
                    return price * dicount;
                case "безалкогольные":
                    dicount = 0.15;
                    return price * dicount;
                case "сильногазированные":
                    dicount = 0.3;
                    return price * dicount;
                default:
                    return price;
            }
        }
        public override void GetInformation()
        {
            Console.WriteLine($"Тип напитка: {_type}\nЦена ${Price}" +
                $"\nСкидка: {dicount * 100}%\nИтоговая стоимость: ${TotalPrice}");
        }
    }
    public class Clothes : Product
    {
        string _size = "";
        double dicount = 0;
        double TotalPrice;

        public Clothes(double price, string size)
        {
            _size = size;
            Price = price;
            TotalPrice = CalculatedDiscount(price, _size);
        }
        private double CalculatedDiscount(double price, string type)
        {
            switch (type.ToLower())
            {
                case "m":
                    dicount = 0.2;
                    return price * dicount;
                case "s":
                    dicount = 0.15;
                    return price * dicount;
                case "xl":
                    dicount = 0.3;
                    return price * dicount;
                default:
                    return price;
            }
        }
        public override void GetInformation()
        {
            Console.WriteLine($"Размер: {_size}\nЦена ${Price}" +
                $"\nСкидка: {dicount * 100}%\nИтоговая стоимость: ${TotalPrice}");
        }
    }
}
