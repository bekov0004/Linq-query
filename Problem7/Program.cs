List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 20 },
    new Person { Name = "Bob", Age = 30 },
    new Person { Name = "Charlie", Age = 20 },
    new Person { Name = "Dave", Age = 30 },
    new Person { Name = "Eve", Age = 20 }
};

var query = (from p in people
    group p by p.Age
    into g
    select g).ToList();
foreach (var q in query)
{
    Console.WriteLine($"Age: {q.Key}");
    foreach (var b in q)
    {
        Console.WriteLine($"     {b.Name}");
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}