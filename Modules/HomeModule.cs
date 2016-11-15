using Nancy;
using CarDealership.Objects;
using System;
using System.Collections.Generic;

namespace CarDealership
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.cshtml"];
            Get["/add-new-car"] = _ => View["add_new_car.cshtml"];
            Get["/search-cars"] = _ => View["search_cars.cshtml"];
            Get["/view-all"] = _ => {
                List<Car> allCars = Car.GetAll();
                return View["view_all_cars.cshtml", allCars];
            };
            Post["/view-searched"] = _ => {
                int searchPrice = int.Parse(Request.Form["search-price"]);
                int searchMileage = int.Parse(Request.Form["search-mileage"]);
                List<Car> allCars = Car.GetAll();
                List<Car> searchedCars = new List<Car> {};

                foreach(Car thing in allCars)
                {
                    if(thing.GetPrice() <= searchPrice && thing.GetMiles() <= searchMileage)
                    {
                        searchedCars.Add(thing);
                    }
                }
                return View["view_searched_cars.cshtml", searchedCars];
            };
            Post["/car-added"] = _ => {
                string carMake = Request.Form["car-make"];
                int carPrice = int.Parse(Request.Form["car-price"]);
                int carMiles = int.Parse(Request.Form["car-mileage"]);
                Car newCar = new Car(carMake, carPrice, carMiles);
                newCar.Save();
                return View["car_added.cshtml", newCar];
            };
            Post["/cars-cleared"] = _ => {
                Car.ClearAll();
                return View["cars_cleared.cshtml"];
            };
        }
    }
}
