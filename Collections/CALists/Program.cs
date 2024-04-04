
namespace CALists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var egypt = new Country { ISOCode = "EGY", Name = "Egypt" };
            var jordan = new Country { ISOCode = "JOR", Name = "Jordan" };
            var iraq = new Country { ISOCode = "IRQ", Name = "Iraq" };

            Country[] countriesArray = [egypt, jordan, iraq];
            // Constructor
            //List<Country> countries = new List<Country>();
            //List<Country> countries = new List<Country>(3); take capacity
            List<Country> countries = new List<Country>(countriesArray); 
            

            //Method
            countries.Add(new Country { ISOCode = "BRA", Name = "Brasile" });
            //countries.AddRange(countriesArray);
            countries.Insert(1, new Country { ISOCode = "FRA", Name = "France" });
            Print(countries);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            countries.RemoveAt(4);
            countries.RemoveAll(x => x.Name!.EndsWith("ce"));
            Print(countries);
             
            Console.ReadKey();
        }

        static void Print(List<Country> countries)
        {
            foreach (var c in countries)
            {
                Console.WriteLine(c);
            }
            // Properties
            Console.WriteLine($"Count: {countries.Count}");
            Console.WriteLine($"Capacity: {countries.Capacity}");
        }
    }
 
    class Country
    {
        public string? ISOCode { get; set; }
        public string? Name { get; set; }
        public override string ToString()
        {
            return $"{Name} ({ISOCode})";
        }
    }
}
