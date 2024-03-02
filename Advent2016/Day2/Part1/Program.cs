var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "2input2016.txt"));

var lines = File.ReadAllLines(fileName);

int xAxis = 1;
int yAxis = 1;

int[,] keypad = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };

string password = "";

foreach (var line in lines)
{
    foreach (char instruction in line)
    {
        if (instruction == 'U')
        {
            if (yAxis > 0)
            {
                --yAxis;
            }
        }
        else if (instruction == 'D')
        {
            if (yAxis < 2)
            {
                ++yAxis;

            }
        }
        else if (instruction == 'L')
        {   
            if(xAxis > 0){
            --xAxis;
            }
        }
        else if (instruction == 'R')
        {   
            if(xAxis < 2){
            ++xAxis;
            }
        }
    }
    password += keypad[xAxis, yAxis];
}

Console.WriteLine(password);