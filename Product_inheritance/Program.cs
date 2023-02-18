using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Base_product_inheritance
{

    class Base_product
    {
        public double price { get; set; }
        public double weight { get; set; }
        public static double all_price { get; set; }
        public static double finish_price = 0;

        public DateTime dateYear;
        DateTime date2 = DateTime.Now;

        public int date_time(DateTime dateYear)
        {
            int resultYear = (int)(dateYear - date2).TotalDays;
            return resultYear;
        }
               
        public static void price_all_product()
        {
            WriteLine($"{"The amount of your purchases ="} {finish_price} {"$"}");
        }
        public Base_product(double price, double weight)
        {
            this.price = price;
            this.weight = weight;
        }
        public double All_price()
        {
            all_price = weight * price;
            finish_price += all_price;
            return all_price;
        }
        public override string ToString()
        {
            return $"{weight} {"kg"} {"price per kilogram ="} {price} {"$"}";
        }
    }

    class Bulk_products : Base_product
    {
        public int nutritional_value { get; set; }
        public Bulk_products(int nutritional_value, double price, double weight) : base(price, weight)
        {
            this.nutritional_value = nutritional_value;
        }
        public override string ToString()
        {
            return $"{nutritional_value} {"calories"} {base.ToString()}";
        }
    }

    class Fruits_vegetables : Base_product
    {
        public string color { get; set; }

        public Fruits_vegetables(string color, double price, double weight) : base(price, weight)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return $"{color} {"color"} {base.ToString()}";
        }
    }

    class Pasta : Bulk_products
    {
        public string name { get; set; }
        public Pasta(string name, double price, double weight, int nutritional_value) : base(nutritional_value, price, weight)
        {
            this.name = name;
        }
        public override string ToString()
        {
            dateYear = new DateTime(2023, 07, 6);
            if (date_time(dateYear) > 0)
                return $" {"Pasta"} {name} {base.ToString()} {"price your product ="} {All_price()} {"$"} {"the item will expire in"} {date_time(dateYear)} {"days"} ";
            else
                return "The goods are expired";
        }
    }

    class Rice : Bulk_products
    {
        public string name { get; set; }
        public Rice(string name, double price, double weight, int nutritional_value) : base(nutritional_value, price, weight)
        {
            this.name = name;
        }
        public override string ToString()
        {
            dateYear = new DateTime(2023, 04, 20);
            if (date_time(dateYear) > 0)
                return $" {"Rice"} {name} {base.ToString()} {"price your product ="} {All_price()} {"$"} {"the item will expire in"} {date_time(dateYear)} {"days"} ";
            else
                return "The goods are expired";
        }
    }

    class Apple : Fruits_vegetables
    {
        public string name { get; set; }
        public Apple(string name, double price, double weight, string color) : base(color, price, weight)
        {
            this.name = name;
        }
        public override string ToString()
        {
            dateYear = new DateTime(2023, 04, 6);
            if (date_time(dateYear) > 0)
                return $" {"Apple"} {name} {base.ToString()} {"price your product ="} {All_price()} {"$"} { "the item will expire in"} {date_time(dateYear)} {"days"} ";
            else
                return "The goods are expired";
        }
    }

    class Orange : Fruits_vegetables
    {
        public string name { get; set; }
        public Orange(string name, double price, double weight, string color) : base(color, price, weight)
        {
            this.name = name;
        }
        public override string ToString()
        {
            dateYear = new DateTime(2022, 04, 6);
            if (date_time(dateYear) > 0)
                return $" {"Orange"} {name} {base.ToString()} {"price your product ="} {All_price()} {"$"} {"the item will expire in"} {date_time(dateYear)} {"days"} ";
            else
                return "The goods are expired";
        }
    }

    class Tomato : Fruits_vegetables
    {
        public string name { get; set; }
        
        public Tomato(string name, double price, double weight, string color) : base(color, price, weight)
        {
            this.name = name;
        }

        public override string ToString()
        {
            dateYear = new DateTime(2023, 03, 6);
            if (date_time(dateYear) > 0)
                return $" {"Tomato"} {name} {base.ToString()} {"price your product ="} {All_price()} {"$"} {"the item will expire in"} {date_time(dateYear)} {"days"} ";
            else
                return "The goods are expired";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base_product tomat = new Tomato("cherry", 1.55, 15, "red");
            Base_product apple = new Apple("golden", 0.75, 3, "green");
            Base_product oran = new Orange("sukkari", 2.15, 5, "yellow");
            Base_product ric = new Rice("brown", 2.75, 5, 111);
            Base_product pasta = new Pasta("capellini", 1.68, 2, 371);

            Base_product[] array = { tomat, apple, oran, ric, pasta };
            foreach (var item in array)
            {
                WriteLine(item);
                WriteLine("---------------------------------------------------------------------------------------------------------------------");
            }
            Base_product.price_all_product();

        }
    }
}
