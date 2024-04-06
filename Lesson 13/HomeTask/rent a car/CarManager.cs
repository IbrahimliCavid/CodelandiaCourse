using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car
{
    public class CarManager
    {
        List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
