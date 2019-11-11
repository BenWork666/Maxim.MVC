using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maxim.Model;

namespace Maxim.Repository
{
    public interface IRepository
    {
        Car NewestByOrder();
        IEnumerable<Car> OrderByAlpha();
        IEnumerable<Car> OrderByPrice();

        // here we define the best value with lower price and higher TCC rating
        Car BestValueCar();
        double FuelConsumption(double distance, string model);
        Car GetRandomCar();

        //the last question kind of missing infos, it actually the same way I build these.
        // the only thing I need is the special function for calculating the result.
        double AvgByYear(int totalM, int totalG);

        

    }
}
