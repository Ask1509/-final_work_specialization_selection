string [] startingArray = new string[] {"hello", "2", "world", ":-)"};
string[] resultArray = new string [0];

foreach (var item in startingArray)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref resultArray, resultArray.Length + 1);
    resultArray [resultArray.Length-1] = item;
    }
}

Console.WriteLine($"[{String.Join("; ", resultArray)}]");
