namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type type01 = DateTime.Now.GetType(); // at runtime
            //Type type02 = typeof(DateTime); // at compile time
            //Console.WriteLine($"Full Name {type01.FullName}"); // NameSpace.Type Name
            //Console.WriteLine($"Namespace {type01.Namespace}"); // NameSpace
            //Console.WriteLine($"Name Type {type01.Name}"); // Name Type 
            //Console.WriteLine($"BaseType  {type01.BaseType}"); //BaseType
            //Console.WriteLine($"Is Public {type01.IsPublic}");
            //Console.WriteLine($"Assembly  {type01.Assembly}"); // Assembly

            //Type type03 = typeof(int[,]);
            //Console.WriteLine($"type03 Type: {type03.Name}");

            //var type04 = typeof(int);
            //var interfaces = type04.GetInterfaces();
            //for (int i = 0; i < interfaces.Length; i++)
            //    Console.WriteLine(interfaces[i]);

            //int i = (int)Activator.CreateInstance(typeof(int))!;
            //i = 3;
            //Console.WriteLine(i);

            //DateTime dateTime = (DateTime)Activator.
            //    CreateInstance(typeof(DateTime), 2021, 01, 01)!;
            //Console.WriteLine(dateTime);

            Console.Write("Enemy: ");
            do
            {
                var input = "Reflection." + Console.ReadLine();
                object? obj = null;
                try
                {
                    var enemy = Activator.
                        CreateInstance(typeof(Program).Assembly.GetName().Name!, input!);
                    obj = enemy!.Unwrap();
                }
                catch 
                {
                    
                }
                switch (obj)
                {
                    case Goon g:
                        Console.WriteLine(g);
                        break;
                    case Agar a:
                        Console.WriteLine(a);
                        break;
                    case Pixa p:
                        Console.WriteLine(p);
                        break;
                    default:
                        Console.WriteLine("UnKnown Enemy");
                        break;
                }

            } while (true);


            Console.ReadKey();
        }
    }
    public class Goon
    {
        public override string ToString()
        {
            return $"{{ Speed: {20},  HitPower: {13}, Strength: {7} }}";
        }
    }
    public class Agar
    {
        public override string ToString()
        {
            return $"{{ Speed: {23},  HitPower: {11}, Strength: {12} }}";
        }
    }
    public class Pixa
    {
        public override string ToString()
        {
            return $"{{ Speed: {25},  HitPower: {10}, Strength: {9} }}";
        }
    }
}
