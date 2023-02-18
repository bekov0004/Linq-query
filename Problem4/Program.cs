int[] numbers = { 5, 8, 12, 15, 20, 25, 30 };

var query =(
    from n in numbers
    orderby n descending 
    select n).Take(3).ToList();
    
Console.WriteLine(String.Join(",",query));  