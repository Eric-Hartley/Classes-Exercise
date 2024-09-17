namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "335i", 2015);
            car.DisplayProperties(car.Make, car.Model, car.Year);
               
        }
    }
}
