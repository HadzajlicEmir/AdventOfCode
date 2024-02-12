var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "advent.txt"));
var counter = 0;

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{
    var firstNumber = line.First(Char.IsDigit);
    var lastNumber = line.Last(Char.IsDigit);

    var combinedNumber = firstNumber.ToString() + lastNumber.ToString();

    counter += int.Parse(combinedNumber);

}

Console.WriteLine(counter);