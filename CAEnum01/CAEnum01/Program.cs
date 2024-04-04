namespace CAEnum01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (var color in Enum.GetNames(typeof(Color)))
            //{
            //    Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(Color), color)}");
            //}


            //string colorName = "Blue";
            //Color color = (Color)Enum.Parse(typeof(Color), colorName, true);
            //Console.WriteLine($"{color} = {(int)color}");


            Console.WriteLine("Please Select An Option");
            Console.WriteLine("[1] Change Background Color\t\t[2] Change Foreground Color");
            string selectOption = Console.ReadLine()!; // 1

            foreach(var color in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.WriteLine(color);
            }
            Console.Write("Please Write Color Name");
            string colorName = Console.ReadLine()!;

            var selectColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);

            if(selectOption == "1")
                Console.BackgroundColor = selectColor;
            else if(selectOption == "2")
                Console.ForegroundColor = selectColor;
            else
                Console.WriteLine("Invalid Option !");
            Console.ReadKey();
        }

        enum Gender
        {
            Male,
            Female
        }

        enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Magenta,
            Brown
        }
    }
}
