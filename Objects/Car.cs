using System;
using System.Collections.Generic;

namespace CarDealership.Objects
{
    public class Car
    {
        private string _makeModel;
        private int _price;
        private int _miles;
        private static List<Car> _instances = new List<Car> {};

        public Car(string carMakeModel, int carPrice, int carMiles)
        {
            _makeModel = carMakeModel;
            _price = carPrice;
            _miles = carMiles;
        }

        public void SetModel(string carMakeModel)
        {
            _makeModel = carMakeModel;
        }

        public string GetModel()
        {
            return _makeModel;
        }

        public void SetPrice(int carPrice)
        {
            _price = carPrice;
        }

        public int GetPrice()
        {
            return _price;
        }

        public void SetMiles(int carMiles)
        {
            _miles = carMiles;
        }

        public int GetMiles()
        {
            return _miles;
        }

        public void PrintInfo()
        {
            Console.WriteLine("The car you selected is a " + _makeModel + ".");
            Console.WriteLine("Its price is $" + _price + ".");
            Console.WriteLine("It has " + _miles + " miles on it.");
        }

        public void Save()
        {
            _instances.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }

//     public class Program
//     {
//         public static void Main()
//         {
//             Car porsche = new Car("2014 Porsche 911", 114991, 7864);
//
//             Car ford = new Car("2011 Ford F450", 55995, 55995);
//
//             Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
//
//             Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);
//
//             List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//
//             Console.WriteLine("Enter maximum price: ");
//             string stringMaxPrice = Console.ReadLine();
//             int maxPrice = int.Parse(stringMaxPrice);
//
//             Console.WriteLine("Enter maximum mileage: ");
//             int maxMileage = int.Parse(Console.ReadLine());
//
//             List<Car> CarsMatchingSearch = new List<Car>();
//
//             foreach (Car automobile in Cars)
//             {
//                 if (automobile.GetPrice() <= maxPrice && automobile.GetMiles() <= maxMileage)
//                 {
//                     CarsMatchingSearch.Add(automobile);
//                 }
//             }
//
//             if (CarsMatchingSearch.Count > 0) {
//                 foreach (Car automobile in CarsMatchingSearch)
//                 {
//                     automobile.PrintInfo();
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("There are no cars matching your requirements.");
//             }
//         }
//     }
}
