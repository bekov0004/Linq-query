string[] names = { "Alice", "Anny", "Amy", "Dave", "Alex" };

var query = (
    from n in names
    where n.ToUpper().StartsWith("A") & n.ToUpper().EndsWith("A")
    select n).ToList();

Console.WriteLine(string.Join(",",query));
