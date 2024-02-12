var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "6input2015.txt"));
int solution = 0;

byte[,] lights = new byte[1000, 1000];

for (int i = 0; i < lights.GetLength(0); i++)
{
    for (int j = 0; j < lights.GetLength(1); j++)
    {
        lights[i, j] = 0;
    }
}

void turnOn(int fromX, int toX, int fromY, int toY)
{
    for (int i = fromX; i <= toX; ++i)
    {
        for (int j = fromY; j <= toY; ++j)
        {
            ++lights[i, j];
        }
    }
}
void turnOff(int fromX, int toX, int fromY, int toY)
{
    for (int i = fromX; i <= toX; ++i)
    {
        for (int j = fromY; j <= toY; ++j)
        {
            if (lights[i, j] > 0)
            {
                --lights[i, j];
            }
        }
    }
}

void toggle(int fromX, int toX, int fromY, int toY)
{
    for (int i = fromX; i <= toX; ++i)
    {
        for (int j = fromY; j <= toY; ++j)
        {
            lights[i, j] += 2;
        }
    }
}

var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{
    string[] words = line.Split(" ");

    if (words[0] == "toggle")
    {
        string[] from = words[1].Split(",");
        string[] to = words[3].Split(",");

        toggle(Convert.ToInt32(from[0]), Convert.ToInt32(to[0]), Convert.ToInt32(from[1]), Convert.ToInt32(to[1]));
    }
    else if (words[1] == "off")
    {
        string[] from = words[2].Split(",");
        string[] to = words[4].Split(",");

        turnOff(Convert.ToInt32(from[0]), Convert.ToInt32(to[0]), Convert.ToInt32(from[1]), Convert.ToInt32(to[1]));

    }
    else
    {
        string[] from = words[2].Split(",");
        string[] to = words[4].Split(",");

        turnOn(Convert.ToInt32(from[0]), Convert.ToInt32(to[0]), Convert.ToInt32(from[1]), Convert.ToInt32(to[1]));
    }

}

for (int i = 0; i < lights.GetLength(0); i++)
{
    for (int j = 0; j < lights.GetLength(1); j++)
    {
        solution += lights[i, j];
    }
}

Console.WriteLine(solution);