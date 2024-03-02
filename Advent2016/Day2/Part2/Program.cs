var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "2input2016.txt"));

var lines = File.ReadAllLines(fileName);

int xAxis = 0;
int yAxis = 2;

string[,] keypad = { { "0", "0", "5", "0", "0" }, { "0", "2", "6", "A", "0", }, { "1", "3", "7", "B", "D" }, { "0", "4", "8", "C", "0" }, { "0", "0", "9", "0", "0" } };

string password = "";

foreach (var line in lines)
{
    foreach (char instruction in line)
    {
        if (instruction == 'U')
        {
            if ((yAxis > 0 && xAxis == 2) || ((xAxis == 1 || xAxis == 3) && yAxis > 1))
            {
                --yAxis;
            }
        }
        else if (instruction == 'D')
        {
            if ((yAxis < 4 && xAxis == 2) || ((xAxis == 1 || xAxis == 3) && yAxis < 3))
            {
                ++yAxis;
            }
        }
        else if (instruction == 'L')
        {
            if ((xAxis > 0 && yAxis == 2) || ((yAxis == 1 || yAxis == 3) && xAxis > 1))
            {
                --xAxis;
            }
        }
        else if (instruction == 'R')
        {
            if ((xAxis < 4 && yAxis == 2) || ((yAxis == 1 || yAxis == 3) && xAxis < 3))
            {
                ++xAxis;
            }
        }
    }
    password += keypad[xAxis, yAxis];
}

Console.WriteLine(password);