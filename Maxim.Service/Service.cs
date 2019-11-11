using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maxim.Model;
using Maxim.Repository;

namespace Maxim.Service
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        // all I need is a formula for average MPG per year with data provided

        public double AvgByYear(int totalM, int totalG)
        {
            return totalM / totalG;
        }

        public Car BestValue()
        {
            return _repository.BestValueCar();
        }

        public double FuelConsum(double distance,string model)
        {
            return _repository.FuelConsumption(distance, model);

        }

        public IEnumerable<Car> GetByAlpha()
        {
            return _repository.OrderByAlpha();

        }

        public IEnumerable<Car> GetByPrice()
        {
            return _repository.OrderByPrice();
        }

        public Car GetNewest()
        {
            return _repository.NewestByOrder();
        }

        public Car RandomCar()
        {
            return _repository.GetRandomCar();
        }
    }
}
