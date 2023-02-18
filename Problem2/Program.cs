int[] numbers = { 1, 5, 8, 12, 15, 20 };
var sumOdd = (
    from n in numbers
    where n % 2 != 0
    select n).Sum();
Console.WriteLine(sumOdd);
