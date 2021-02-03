using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data {
    public class DbObjects {
        public static void Initial(AppDbContent content) {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.Car.AddRange(
                    new Car{
                        Name="Tesla Model S",
                        ShortDescription="Быстрый атомобиль",
                        LongDescription="Красивый, быстрый и очень тихий автомобмль компаниии тесла",
                        Img="/img/Tesla-Model-S.jpg",
                        Price=45000,
                        IsFavourite=true,
                        Available=true,
                        Category= Categories["Электромобили"]
                    },
                    new Car{
                        Name="Ford Fiesta",
                        ShortDescription="Тихий и спокойный",
                        LongDescription="Удобный автомобиль для городской жизни",
                        Img="/img/ford.jpg",
                        Price=11000,
                        IsFavourite=false,
                        Available=true,
                        Category= Categories["Классические автомобили"]
                    },
                    new Car{
                        Name="BMW M3",
                        ShortDescription="Дерзкий и стильный",
                        LongDescription="Удобный автомобиль для городской жизни",
                        Img="/img/bmw1000.jpg",
                        Price=65000,
                        IsFavourite=true,
                        Available=true,
                        Category= Categories["Классические автомобили"]
                    },
                    new Car{
                        Name="Mercedes C Class",
                        ShortDescription="Уютный и большой",
                        LongDescription="Удобный автомобиль для городской жизни",
                        Img="/img/mers.jpg",
                        Price=40000,
                        IsFavourite=false,
                        Available=false,
                        Category= Categories["Классические автомобили"]
                    },
                    new Car{
                        Name="Citroen Xantia",
                        ShortDescription="Зверь",
                        LongDescription="Не имеет аналогов",
                        Img="/img/xantia.jpg",
                        Price=1000,
                        IsFavourite=true,
                        Available=true,
                        Category= Categories["Классические автомобили"]
                    }
                   );
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category{CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                        new Category{CategoryName = "Классические автомобили", Description = "Машины с двигателем внутреннего сгораниия"}
                    };
                    category = new Dictionary<String, Category>();
                    foreach (Category el in list) {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
