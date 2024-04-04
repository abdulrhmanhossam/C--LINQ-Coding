
var temps = new List<Tempreture>();

Random rnd = new Random();

for(var i =0; i < 100; i++)
{
    temps.Add( new Tempreture(rnd.Next(-30, 50)));  
}

temps.Sort();
foreach (var item in temps)
{
    Console.WriteLine(item.Value);
}

Console.ReadKey();

class Tempreture: IComparable
{
    private int _value;
    public Tempreture(int value)
    {
        _value = value;
    }
    public int Value => _value;

    public int CompareTo(object? obj)
    {
        if (obj is null)
            return 1;
        var temp = obj as Tempreture;
        if (temp is null)
            throw new ArgumentException("Object is not a Tempreture");
        return temp._value.CompareTo(temp.Value);
    }
}


/*
using System.Collections;

var ints = new FiveIntegers(1, 2, 3, 4, 5);

foreach (var i in ints)
{
    Console.WriteLine(i);
}

Console.ReadKey();
class FiveIntegers : IEnumerable
{
    private int[] _values;
    public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
    {
        _values = new[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in _values)
        {
            yield return item;
        }
    }
}
*/ //IEnumerable

/*
    class Enumerator: IEnumerator
    {
        private int _currentIndex = -1;
        private FiveIntegers _integers;
        public Enumerator(FiveIntegers integers)
        {
            _integers = integers;
        }

        public object Current
        {
            get
            {
                if (_currentIndex == -1)
                    throw new InvalidOperationException("Enumeration not started");
                if(_currentIndex == _integers._values.Length)
                    throw new InvalidOperationException("Enumeration has Ended");
                return _integers._values[_currentIndex];
            }
        }

        public bool MoveNext()
        {
            if (_currentIndex >= _integers._values.Length - 1)
                return false;
            return ++_currentIndex < _integers._values.Length;
        }

        public void Reset()
        {
           _currentIndex = -1;
        }
    }
 }
*/  //implmantion of  Enumerator we can replace it by yield

/*

Employee e1 = new Employee 
{ Id = 100, Name = "Abdulrhman H.", Salary = 1000, Department = "IT" };

Employee e2 = new Employee
{ Id = 100, Name = "Abdulrhman H.", Salary = 1000, Department = "IT" };


Console.WriteLine(e1 == e2); 
Console.WriteLine(e1.Equals(e2));
Console.WriteLine(7.GetHashCode());

Console.ReadKey();


class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Salary { get; set; }
    public string? Department {  get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Employee))
            return false;
        var emp = obj as Employee;
        return this.Id == emp!.Id && this.Name == emp.Name &&
            this.Salary == emp.Salary && this.Department == emp.Department;
    }

    public override int GetHashCode()
    {
        int hash = 13;
        hash = (hash * 7) + Id.GetHashCode();
        hash = (hash * 7) + Name!.GetHashCode();
        hash = (hash * 7) + Salary.GetHashCode();
        hash = (hash * 7) + Department!.GetHashCode();
        return hash;
    }
    public static bool operator == (Employee lhs, Employee rhs) => lhs.Equals(rhs);
    public static bool operator != (Employee lhs, Employee rhs) => !lhs.Equals(rhs);
}
*/ //GetHashCode And Equals Methods
