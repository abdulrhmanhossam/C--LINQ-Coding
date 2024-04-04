using System;


namespace CAExceptions
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery) 
        {
            try 
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Deliver Fails due to {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKONWN;
            }
            finally
            {
                Console.WriteLine("End");
            }
            
        }
        private void Process(Delivery delivery) 
        {
            FakeIt("Processing");
            if(random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("unable to process the item");
            }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;  
        }
        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("parcel is damaged during the loading");
            }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery delivery)
        {
            FakeIt("On Its Way");
            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("356 some another street", "Accident !!!");
            }
            delivery.DeliveryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");
            delivery.DeliveryStatus = DeliveryStatus.DELIVERED;
        }

        private void FakeIt(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine(".");
        }
    }

}
