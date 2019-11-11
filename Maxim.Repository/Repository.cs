using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maxim.Model;

namespace Maxim.Repository
{
    public class Repository : IRepository
    {
        private readonly List<Car> _cars;
        public Repository()
        {

            // SINCE I DON'T HAVE DATA FROM DATABASE, I MADE 5 CARS FOR TEST THE RESULT

           _cars = new List<Car>
                {
                    new Car{ Make="Honda",Model = "CRV",Color = "Green", Year = 2016, Price = 23845,TCCRating = 8, HwyMPG = 33 },
                    new Car{ Make="Ford",Model = "Escape",Color = "Red", Year = 2017, Price = 23590,TCCRating = 7.8, HwyMPG = 32 },
                    new Car{ Make="Hyundai",Model = "Sante Fe",Color = "Grey", Year = 2016, Price = 24950,TCCRating = 8, HwyMPG = 27 },
                    new Car{ Make="Mazda",Model = "CX-5",Color = "Red", Year = 2017, Price = 21795,TCCRating = 8, HwyMPG = 35 },
                    new Car{ Make="Subaru",Model = "Forester",Color = "Blue", Year = 2016, Price = 22395,TCCRating = 8.4, HwyMPG = 32 }
                };
        }

        public double AvgByYear(int totalM , int totalG)
        {
            return totalM / totalG;
        }

        public Car BestValueCar()
        {
            return _cars.OrderBy(c => c.Price).OrderByDescending(c => c.TCCRating).FirstOrDefault();
        }

        public double FuelConsumption(double distance, string model)
        {
            var car = _cars.Where(c => c.Model == model).SingleOrDefault();
            return (double)(car.HwyMPG * distance);

        }

        public Car GetRandomCar()
        {
            var rnd = new Random();
            var car = _cars.OrderBy(x => rnd.Next()).FirstOrDefault();
            return car;
        }

        public Car NewestByOrder()
        {
            return _cars.OrderByDescending(c => c.Year).FirstOrDefault();
        }

        public IEnumerable<Car> OrderByAlpha()
        {
            return _cars.OrderBy(c => c.Make).ToList();
        }

        public IEnumerable<Car> OrderByPrice()
        {
            return _cars.OrderBy(c => c.Price).ToList();
        }
    }
}
