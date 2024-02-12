var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "1input2015.txt"));
int floor = 0;
int counter = 0;
var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{

    foreach (char elem in line)
    {
        ++counter;
        if (elem == '(')
        {
            ++floor;
        }
        else if (elem == ')')
        {
            --floor;
            if (floor == -1)
            {
                Console.WriteLine(counter);
            }
        }
    }
}

