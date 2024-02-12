var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "3input2015.txt"));

int yAxis = 0;
int xAxis = 0;

List<int> xValues = new List<int>();
List<int> yValues = new List<int>();

xValues.Add(0);
yValues.Add(0);



var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{

    foreach (char direction in line)
    {

        bool newHouse = true;

        if (direction == '>')
        {
            ++xAxis;
        }
        else if (direction == '<')
        {
            --xAxis;
        }
        else if (direction == '^')
        {
            ++yAxis;
        }
        else if (direction == 'v')
        {
            --yAxis;
        }

        for (int i = 0; i < xValues.Count; ++i){
            if(xAxis == xValues[i] && yAxis == yValues[i]){
                newHouse = false;
            }
        }
        if (newHouse){
            xValues.Add(xAxis);
            yValues.Add(yAxis);
        }
    }
}

Console.WriteLine(xValues.Count);