using CAExceptions;


var delivery = new Delivery
{ Id = 1, CustomerName = "Abdulrhman H.", Address = "Cairo" };
var service = new DeliveryService();
service.Start(delivery);
Console.WriteLine(delivery);

Console.ReadKey();

