using System.Collections;


/*
var people = new Any<Person>();
people.Add(new Person("Ali", "G"));
people.Add(new Person("Reem", "M"));
people.DisplayList();
Console.WriteLine(people.Count);
Console.WriteLine(people.IsEmpty);
*/


var people = new List<Person>();  //Generic Collection at .NET
people.Add(new Person("Ali", "G"));
people.Add(new Person("Reem", "M"));

foreach (var item in people)
{
    Console.WriteLine(item);
}

Console.WriteLine(people.Count);
Console.WriteLine(people.Count == 0);

Console.ReadKey();


class Person
{
    private string? _fName; 
    private string? _lName;

    public Person(string fName, string lName)
    {
        this._fName = fName;
        this._lName = lName; 
    }
    public override string ToString()
    {
        return $"FName: {_fName} " +
               $"LName:{_lName}";
    }
}

//Generic class

class Any<T> where T : class // where can make constrain on Generic
{
    private T[]? _items;

    public void Add(T item)
    {
        if (_items is null)
        {
            _items = new T[] { item };
        }
        else
        {
            var length = _items.Length;
            var dest = new T[length + 1];
            for (int i = 0; i < length; i++)
            {
                dest[i] = _items[i];
            }
            dest[dest.Length - 1] = item;
            _items = dest;
        }
    }
    public void RemoveAt(int position)
    {
        if (position < 0 || position > _items!.Length - 1)
            return;

        var index = 0;
        var dest = new T[_items.Length - 1];
        for (int i = 0; i < _items.Length; i++)
        {
            if (position == i)
                continue;
            dest[index++] = _items[i];
        }
        _items = dest;
    }

    public bool IsEmpty => _items is null || _items.Length == 0;
    public int Count => _items is null ? 0 : _items.Length;

    public void DisplayList()
    {
        Console.Write("[");
        for (int i = 0; i < _items!.Length; i++)
        {
            Console.Write(_items[i]);
            if (i < _items!.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}


//Method Generics
/*
{
    // Generic Method
    public void Print<T>(T value)
    {
        Console.WriteLine($"Data Type: {typeof(T)}");
        Console.WriteLine($"Value: {value}");
    }
}
*/
