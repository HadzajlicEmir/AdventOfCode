var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "14input2015.txt"));

int winnerDistance = 0;

var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{
    string[] parsed = line.Split(" ");

    int speed = int.Parse(parsed[3]);
    int time = int.Parse(parsed[6]);
    int rest = int.Parse(parsed[13]);
    int distance = 0;

    for (int i = 0; i < 2503;)
    {
        if (time + i < 2503)
        {
            distance += speed * time;
        }
        else
        {
            distance += speed * (2503 - i);
        }
        i += rest + time;
    }
    if (distance > winnerDistance)
    {
        winnerDistance = distance;
    }

}

Console.WriteLine(winnerDistance);