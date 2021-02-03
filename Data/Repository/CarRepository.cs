using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository {
    public class CarRepository : IAllCars {

        private readonly AppDbContent appDbContent;
        public CarRepository(AppDbContent appDbContent) {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Car> Cars => appDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDbContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => appDbContent.Car.FirstOrDefault(p => p.Id == carId);
    }
}
