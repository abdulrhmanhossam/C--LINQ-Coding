namespace ITIDemo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting Bulit in Value Type

            //int x = 50;
            //long y;

            /////y = x;
            /////Implicit Casting
            /////Int64 = Int32
            /////safe casting


            //y = long.MaxValue;

            //x = (int) y;
            /////Int32 = Int64
            /////Unsafe casting
            /////Explicit Casting

            //// CLR will throw overFlowException
            //checked
            //{
            //    x = (int)y;
            //}

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion

            #region Boxing UnBoxing
            //int x = 5;
            // Object o = new Object();
            //o = x;
            //Console.WriteLine(o);
            //Boxing 

            //int x = 5;
            //Object o = new Object();
            //x = (int) o;

            //Console.WriteLine(x);
            //UnBoxing
            #endregion

             


        }
    }

    //struct Temp
    //{

    //}
}
