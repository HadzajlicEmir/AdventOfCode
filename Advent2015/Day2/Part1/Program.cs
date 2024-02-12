var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "2input2015.txt"));

int solution = 0;


var lines = File.ReadAllLines(fileName);

foreach (var line in lines){

    string[] dimensions = line.Split("x");
    int side1 = Convert.ToInt32(dimensions[0]) * Convert.ToInt32(dimensions[1]);
    int side2 = Convert.ToInt32(dimensions[0]) * Convert.ToInt32(dimensions[2]);
    int side3 = Convert.ToInt32(dimensions[1]) * Convert.ToInt32(dimensions[2]);

    int thisPaper = 2 * side1 + 2 * side2 + 2 * side3 + Math.Min(Math.Min(side1, side2), side3);
    solution += thisPaper;

}

Console.WriteLine(solution);