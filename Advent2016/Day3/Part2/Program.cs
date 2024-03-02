var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "3input2016.txt"));

var lines = File.ReadAllLines(fileName);

List<Rows> triangles = new List<Rows>();

int counter = 0;

foreach (var line in lines)
{
    string line2 = line.Replace("    ", "  ");
    string[] dimensions = line2.Trim().Split("  ");

    int[] sides = new int[3];

    Int32.TryParse(dimensions[0].Trim(), out sides[0]);
    Int32.TryParse(dimensions[1].Trim(), out sides[1]);
    Int32.TryParse(dimensions[2].Trim(), out sides[2]);

    triangles.Add(new Rows(sides[0], sides[1], sides[2]));
}

for (int i = 0; i < triangles.Count;)
{
    int[] sides = new int[3];

    sides[0] = triangles[i].a;
    sides[1] = triangles[i + 1].a;
    sides[2] = triangles[i + 2].a;

    Array.Sort(sides);

    if ((sides[0] + sides[1]) > sides[2])
    {
        ++counter;
    }

    sides[0] = triangles[i].b;
    sides[1] = triangles[i + 1].b;
    sides[2] = triangles[i + 2].b;

    Array.Sort(sides);

    if ((sides[0] + sides[1]) > sides[2])
    {
        ++counter;
    }

    sides[0] = triangles[i].c;
    sides[1] = triangles[i + 1].c;
    sides[2] = triangles[i + 2].c;

    Array.Sort(sides);

    if ((sides[0] + sides[1]) > sides[2])
    {
        ++counter;
    }

    i += 3;
}

Console.WriteLine(counter);

public class Rows(int x, int y, int z)
{
    public int a = x;
    public int b = y;
    public int c = z;
}