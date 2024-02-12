var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "..", "23input2015.txt"));

int i = 0;
ulong a = 1;
int b = 0;

var lines = File.ReadAllLines(fileName);


while (i < lines.Length)
{
    string[] instruction = lines[i].Split(" ");

    if (instruction[0] == "inc")
    {
        if (instruction[1] == "a")
        {
            ++a;
        }
        else
        {
            ++b;
        }
        ++i;
    }
    else if (instruction[0] == "tpl")
    {
        a *= 3;
        ++i;
    }
    else if (instruction[0] == "hlf")
    {
        a /= 2;
        ++i;
    }
    else if (instruction[0] == "jmp")
    {
        i += int.Parse(instruction[1]);
    }
    else if (instruction[0] == "jio")
    {
        if (a == 1)
        {
            i += int.Parse(instruction[2]);
        }
        else
        {
            ++i;
        }
    }
    else if (instruction[0] == "jie")
    {
        if (a % 2 == 0)
        {
            i += int.Parse(instruction[2]);
        }
        else
        {
            ++i;
        }
    }
}

Console.WriteLine(b);