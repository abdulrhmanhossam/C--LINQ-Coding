namespace CAEnum02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex01
            //// 0b_0000_0001 + 0b_0000_0010 => 0b_0000_0011 = weakDays01
            //WeakDays weakDays01 = WeakDays.Saturday | WeakDays.Sunday;
            //Console.WriteLine(weakDays01);

            //// 0b_0100_0000 + 0b_0000_0001 => 0b_0100_0001 = weakEnd
            //WeakDays weakEnd = WeakDays.Friday | WeakDays.Saturday ;
            //Console.WriteLine(weakEnd);

            //Console.WriteLine((int)0b_0100_0001);
            #endregion 

            WeakDays weakDays01 = WeakDays.Saturday | WeakDays.Sunday | WeakDays.Monday;
            WeakDays weakDays02 = WeakDays.Saturday | WeakDays.Tuesday | WeakDays.Friday;
            Console.WriteLine(weakDays01 & weakDays02); // Get Common Flags

            Console.WriteLine("-------------------------");

            WeakDays fridayFlag = weakDays02 & WeakDays.Friday;
            bool isFriday = (weakDays02 & WeakDays.Friday) == WeakDays.Friday;
            Console.WriteLine($"is friday: {isFriday}");
            Console.WriteLine($"friday Flag: {fridayFlag}");

            Console.WriteLine("-------------------------");

            WeakDays wednesdayFlag = weakDays02 & WeakDays.Wednesday;
            bool isWednesday = (weakDays02 & WeakDays.Wednesday) == WeakDays.Wednesday;
            Console.WriteLine($"is friday: {isWednesday}");
            Console.WriteLine($"friday Flag: {wednesdayFlag}"); // return UNKOWN

            Console.ReadKey();
        }

        [Flags]
        enum WeakDays: byte
        {
            UNKOWN =        0b_0000_0000, //0
            Saturday =      0b_0000_0001, //1
            Sunday =        0b_0000_0010, //2
            Monday =        0b_0000_0100, //4
            Tuesday =       0b_0000_1000, //8
            Wednesday =     0b_0001_0000, //16 
            Thursday =      0b_0010_0000, //32
            Friday =        0b_0100_0000, //64
        }
    }
}
