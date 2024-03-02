var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "3input2016.txt"));

var lines = File.ReadAllLines(fileName);

int counter = 0;


foreach (var line in lines)
{

    string[] dimensions = line.Trim().Split("  ");
    
    int[] sides = new int[3];

    string[] ugh = new string[5];

    Int32.TryParse(dimensions[0], out sides[0]);
    Int32.TryParse(dimensions[1], out sides[1]);
    Int32.TryParse(dimensions[2], out sides[2]);

    Array.Sort(sides);


    if ((sides[0] + sides[1]) > sides[2])
    {
        ++counter;
    }

}

Console.WriteLine(counter);