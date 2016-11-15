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
            Get["/"] = _ => View["add_new_car.cshtml"];
            Get["/view-all"] = _ => {
                List<Car> allCars = Car.GetAll();
                return View["view_all_cars.cshtml", allCars];
            };
            Post["/car-added"] = _ => {
                string carMake = Request.Form["car-make"];
                int carPrice =  int.Parse(Request.Form["car-price"]);
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
