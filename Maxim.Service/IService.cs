using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maxim.Model;

namespace Maxim.Service
{
    public interface IService
    {
        Car GetNewest();
        IEnumerable<Car> GetByAlpha();
        IEnumerable<Car> GetByPrice();
        Car BestValue();
        Car RandomCar();
        double FuelConsum(double distance, string model);
        double AvgByYear(int totalM, int totalG);
    }
}
