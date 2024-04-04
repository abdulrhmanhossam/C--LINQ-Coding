namespace CAInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoader v = new Caterpiller("Caterpiller", "Zux", 2020);
            v.Load();

            Console.ReadKey();
        }
       
    }

  
    abstract class Vehicle
    {
        protected string? brand;
        protected string? name;
        protected int year;

        protected Vehicle(string? brand, string? name, int year)
        {
            this.brand = brand;
            this.name = name;
            this.year = year;
        }
    }

    interface IDrivable
    {
        void Move();
        void Stop();
    }
    interface ILoader
    {
        void Load();
        void Unload();
    }

    class Honda : Vehicle, IDrivable
    {
        public Honda(string? brand, string? name, int year): base(brand, name, year)
        {

        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }

    class Caterpiller : Vehicle, ILoader, IDrivable
    {
        public Caterpiller(string? brand, string? name, int year): base(brand, name, year)
        {

        }

        public void Load()
        {
            Console.WriteLine("Loading");
        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }

        public void Unload()
        {
            Console.WriteLine("Unloading");
        }
    }
}