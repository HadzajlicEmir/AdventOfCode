var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "1input2016.txt"));

int directionFaced = 0;
int xAxis = 0;
int yAxis = 0;

List<Location> visitedLocations = new List<Location>();

visitedLocations.Add(new Location(0, 0));

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{
    string[] directions = line.Split(", ");
    int moveAmount = 0;

    foreach (string direction in directions)
    {
        bool locationVisited = false;
        if (direction[0] == 'L')
        {
            --directionFaced;
            if (directionFaced == -1)
            {
                directionFaced = 3;
            }
        }
        else
        {
            ++directionFaced;
            if (directionFaced == 4)
            {
                directionFaced = 0;
            }
        }
        moveAmount = Int32.Parse(direction.Substring(1));

        for (int i = moveAmount; i > 0; --i)
        {
            if (directionFaced == 0)
            {
                ++yAxis;
            }
            else if (directionFaced == 1)
            {
                ++xAxis;
            }
            else if (directionFaced == 2)
            {
                --yAxis;
            }
            else
            {
                --xAxis;
            }
            foreach (Location location in visitedLocations)
            {
                if (location.xAxis == xAxis && location.yAxis == yAxis)
                {
                    locationVisited = true;
                }
            }
            if (locationVisited)
            {
                Console.WriteLine(Math.Abs(xAxis) + Math.Abs(yAxis));
                return;
            }
            else
            {
                visitedLocations.Add(new Location(xAxis, yAxis));
            }
        }
    }
}

public class Location(int x, int y)
{
    public int xAxis = x;
    public int yAxis = y;
}