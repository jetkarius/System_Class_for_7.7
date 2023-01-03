using System;

namespace System_Class_for_7._7
{

    class User
    {
        public string Name;
        public string LastName;
    }

    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {

    }

    class PickPointDelivery : Delivery
    {

    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public int Number;
        public string Description;
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        Product[] Products { get; set; }
    }

    abstract class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    class Food : Product
    {
        public string Type { get; set; }
        public int Quantity { get; set; }
    }

    class Vegetables : Food
    {

    }

    class Fruits : Food
    {

    }

    class Seafood : Food
    {

    }

    class Phone : Product
    {
        public string Brand;
        public string Model;
        public string Color;
    }
}
