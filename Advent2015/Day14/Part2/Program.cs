var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "14input2015.txt"));

List<Reindeer> allReindeer = new List<Reindeer>();

int solution = 0;

var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{
    string[] parsed = line.Split(" ");

    int speed = int.Parse(parsed[3]);
    int time = int.Parse(parsed[6]);
    int rest = int.Parse(parsed[13]);
    int[] distancePerSecond = new int[2503];

    for (int i = 0; i < 2503; ++i)
    {
        distancePerSecond[i] = calcDistance(i, time, speed, rest);
    }

    allReindeer.Add(new Reindeer(parsed[0], speed, time, distancePerSecond, 0));
}

for (int i = 1; i < 2503; ++i)
{
    int maxDistance = allReindeer[0]._distancePerSecond[i];
    for (int j = 1; j < allReindeer.Count; ++j)
    {
        if (allReindeer[j]._distancePerSecond[i] > maxDistance)
        {
            maxDistance = allReindeer[j]._distancePerSecond[i];
        }
    }
    for (int j = 0; j < allReindeer.Count; ++j)
    {
        if (allReindeer[j]._distancePerSecond[i] == maxDistance)
        {
            ++allReindeer[j]._points;
        }
    }
}

for (int i = 0; i < allReindeer.Count; ++i)
{
    if (allReindeer[i]._points > solution)
    {
        solution = allReindeer[i]._points;
    }
}

Console.WriteLine(solution);

int calcDistance(int n, int time, int speed, int rest)
{
    int distance = 0;
    for (int i = 0; i < n;)
    {
        if (time + i < n)
        {
            distance += speed * time;
        }
        else
        {
            distance += speed * (n - i);
        }
        i += rest + time;
    }
    return distance;
}

public class Reindeer(string name, int speed, int time, int[] distancePerSecond, int points)
{
    public string _name = name;
    int _speed = speed;
    int _time = time;
    public int[] _distancePerSecond = distancePerSecond;
    public int _points = points;
}