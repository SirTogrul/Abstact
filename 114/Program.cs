namespace _114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[2];
            vehicles[0] = new Car(2002, "mazda","rx7",259) ;
            vehicles[0].Color = "orange";
            vehicles[1] = new Bus(2020, 40);
            vehicles[1].Color = "red";
             foreach (var vehicle in vehicles)
        {
            vehicle.ShowInfo();
        }
        }
    }
abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; }

        public Vehicle(int year)
        {
            Year = year;
        }

        public abstract void ShowInfo();
    }

    class Car : Vehicle
    {
        private string brand;
        private string model;
        private int maxSpeed;

        public string Brand { get; set; }
      

        public string Model { get; set; }
        

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if(value > 0)
                {
                    maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("yalan soyleme gozlerime bak");
                }
            }
            
        }

        public Car(int year, string brand, string model, int maxSpeed) : base(year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car: {Year} {Color} {Brand} {Model}, Max Speed: {MaxSpeed} km/s");
        }
    }

    class Bus : Vehicle
    {
        private int passengerCount;

        public int PassengerCount
        {
            get { return passengerCount; }
            set
            {
                if(value > 0)
                {
                    passengerCount = value;
                }
                else
                {
                    Console.WriteLine("yalan deme dolana qeder minecekler");
                }
            }
        }

        public Bus(int year, int passengerCount) : base(year)
        {
            PassengerCount = passengerCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Bus: {Year} {Color}, Passenger Count: {PassengerCount}");
        }
    }

}