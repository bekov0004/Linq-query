string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

var query = (
    from w in words
    orderby w.Length descending 
    select w).ToList();
Console.WriteLine(string.Join(",",query));
