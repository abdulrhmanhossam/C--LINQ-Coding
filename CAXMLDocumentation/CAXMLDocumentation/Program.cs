
do
{
    Console.Write("First Name: ");
    var fName = Console.ReadLine();

    Console.Write("Last Name: ");
    var lName = Console.ReadLine();

    Console.Write("Hire Date: ");
    DateTime? hireDate = null;
    if (DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
    {
        hireDate = hDate;
    }
    
    var empId = Generator.GenerateId(fName!, lName!, hireDate);
    var randomPassword = Generator.GenerateRandomPassword(8);

    Console.WriteLine($"{{\n Id: {empId},\n FName: {fName}," +
        $"\n LName: {lName},\n Hire Date: {hireDate},\n Password: {randomPassword}\n }}");
    Console.WriteLine(randomPassword);

} while (1 == 1);


/// <include file="Generator.xml" path='doc/members[@name="generator"]/Generator/*'/>
public class Generator
{
    public static int LastIdSequence { get; private set; } = 1;

    /// <include file="Generator.xml" path='doc/members[@name="generator"]/GenerateId/*'/>
    public static string GenerateId(string fName, string lName, DateTime? hireDate)
    {
        if (fName is null)
            throw new InvalidOperationException($"{nameof(fName)} can not be null");

        if (lName is null)
            throw new InvalidOperationException($"{nameof(lName)} can not be null");

        if (hireDate is null)
        {
            hireDate = DateTime.Now;
        }
        else
        {
            if (hireDate.Value.Date < DateTime.Now.Date)
                throw new InvalidOperationException($"{nameof(hireDate)} can not be in the past");
        }

        var yy = hireDate.Value.ToString("yy");
        var mm = hireDate.Value.ToString("MM");
        var dd = hireDate.Value.ToString("dd");

        var code = $"{lName.ToUpper()[0]}{fName.ToUpper()[0]}" +
            $" {yy} {mm} {dd} {(LastIdSequence++).ToString().PadLeft(2, '0')}";

        return code;
    }

    public static string GenerateRandomPassword(int length)
    {
        const string ValidScope = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMOPQRSTUVWXYZ0123456789";
        var result = "";
        Random rnd = new Random();

        while (0 < length--)
        {
            result += (ValidScope[rnd.Next(ValidScope.Length)]);
        }
        return result;
    }
}
