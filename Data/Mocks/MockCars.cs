using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks {
    public class MockCars : IAllCars {
        private readonly ICarsCategory _categoryCars = new MockCategory(); 
        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car{
                        Name="Tesla Model S",
                        ShortDescription="Быстрый атомобиль",
                        LongDescription="Красивый, быстрый и очень тихий автомобмль компаниии тесла",
                        Img="/img/Tesla-Model-S.jpg",
                        Price=45000,
                        IsFavourite=true, 
                        Available=true, 
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car{
                        Name="Ford Fiesta",
                        ShortDescription="Тихий и спокойный",
                        LongDescription="Удобный автомобиль для городской жизни",
                        Img="/img/ford.jpg",
                        Price=11000,
                        IsFavourite=false,
                        Available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car{
                        Name="BMW M3",
                        ShortDescription="Дерзкий и стильный",
                        LongDescription="Удобный автомобиль для городской жизни",
                        Img="/img/bmw1000.jpg",
                        Price=65000,
                        IsFavourite=true,
                        Available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car{
                        Name="Mercedes C Class",
                        ShortDescription="Уютный и большой",
                        LongDescription="Удобный автомобиль для городской жизни",
                        Img="/img/mers.jpg",
                        Price=40000,
                        IsFavourite=false,
                        Available=false,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car{
                        Name="Citroen Xantia",
                        ShortDescription="Зверь",
                        LongDescription="Не имеет аналогов",
                        Img="/img/xantia.jpg",
                        Price=1000,
                        IsFavourite=true,
                        Available=true,
                        Category=_categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int carId) {
            throw new NotImplementedException();
        }
    }
}
