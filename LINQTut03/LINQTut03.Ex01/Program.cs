
using LINQTut03.Shared;
using System.Linq;

var employees = Repository.LoadEmployees();
var femaleWithFnameStartsWithS01 = employees.
    Filter(x => x.Gender == "female" && x.FirstName!.ToLowerInvariant().StartsWith("s"));
femaleWithFnameStartsWithS01.Print("female With Fname Starts With S / Fillter");

var femaleWithFnameStartsWithS02 = employees.
    Where(x => x.Gender == "female" && x.FirstName!.ToLowerInvariant().StartsWith("s"));
femaleWithFnameStartsWithS02.Print("female With Fname Starts With S / Where");

Console.ReadKey();