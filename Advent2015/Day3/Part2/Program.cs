var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "3input2015.txt"));

int yAxisSanta = 0;
int xAxisSanta = 0;

int xAxisRobot = 0;
int yAxisRobot = 0;

bool santaMoves = true;

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

        if (santaMoves)
        {

            if (direction == '>')
            {
                ++xAxisSanta;
            }
            else if (direction == '<')
            {
                --xAxisSanta;
            }
            else if (direction == '^')
            {
                ++yAxisSanta;
            }
            else if (direction == 'v')
            {
                --yAxisSanta;
            }

            for (int i = 0; i < xValues.Count; ++i)
            {
                if (xAxisSanta == xValues[i] && yAxisSanta == yValues[i])
                {
                    newHouse = false;
                }
            }
            if (newHouse)
            {
                xValues.Add(xAxisSanta);
                yValues.Add(yAxisSanta);
            }
        }
        else
        {
            if (direction == '>')
            {
                ++xAxisRobot;
            }
            else if (direction == '<')
            {
                --xAxisRobot;
            }
            else if (direction == '^')
            {
                ++yAxisRobot;
            }
            else if (direction == 'v')
            {
                --yAxisRobot;
            }

            for (int i = 0; i < xValues.Count; ++i)
            {
                if (xAxisRobot == xValues[i] && yAxisRobot == yValues[i])
                {
                    newHouse = false;
                }
            }
            if (newHouse)
            {
                xValues.Add(xAxisRobot);
                yValues.Add(yAxisRobot);
            }

        }
        santaMoves = !santaMoves;
    }
}

Console.WriteLine(xValues.Count);