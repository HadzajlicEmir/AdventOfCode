var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "1input2016.txt"));

int directionFaced = 0;
int xAxis = 0;
int yAxis = 0;

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{
    string[] directions = line.Split(", ");
    int moveAmount = 0;

    foreach (string direction in directions)
    {
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

        if(directionFaced == 0){
            yAxis += moveAmount;
        } else if(directionFaced == 1){
            xAxis += moveAmount;
        } else if(directionFaced == 2){
            yAxis -= moveAmount;
        } else{
            xAxis -= moveAmount;
        }
    }
}

Console.WriteLine(Math.Abs(xAxis) + Math.Abs(yAxis));