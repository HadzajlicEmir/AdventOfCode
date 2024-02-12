var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "advent.txt"));
var counter = 0;

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{
    var cleanLine = line
        .Replace("one", "o1e")
        .Replace("two", "t2o")
        .Replace("three", "t3e")
        .Replace("four", "f4r")
        .Replace("five", "f5e")
        .Replace("six", "s6x")
        .Replace("seven", "s7n")
        .Replace("eight", "e8t")
        .Replace("nine", "n9e");

    var firstNumber = cleanLine.First(Char.IsDigit);
    var lastNumber = cleanLine.Last(Char.IsDigit);

    var combinedNumber = firstNumber.ToString() + lastNumber.ToString();

    counter += int.Parse(combinedNumber);
}

Console.WriteLine(counter);