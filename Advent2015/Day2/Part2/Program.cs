var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "2input2015.txt"));

int solution = 0;


var lines = File.ReadAllLines(fileName);

foreach (var line in lines){

    string[] dimensions = line.Split("x");

    int[] sides = new int[3];

    sides[0] = Convert.ToInt32(dimensions[0]);
    sides[1] = Convert.ToInt32(dimensions[1]);
    sides[2] = Convert.ToInt32(dimensions[2]);

    Array.Sort(sides);

    int thisRibbon = sides[0] * 2 + sides[1] * 2 + sides[0] * sides[1] * sides[2];
    solution += thisRibbon;

}

Console.WriteLine(solution);