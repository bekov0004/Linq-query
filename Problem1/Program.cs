int[] numbers = { 1, 5, 8, 12, 15, 20 };
var query = (
    from n in numbers
    where n > 10
    select n).ToList();
Console.Write(string.Join(" ",query));
