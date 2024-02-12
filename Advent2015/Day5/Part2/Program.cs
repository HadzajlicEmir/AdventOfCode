var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "5input2015.txt"));

var lines = File.ReadAllLines(fileName);

int solution = 0;

foreach (string line in lines)
{
    bool hasDouble = false;
    bool hasPair = false;

    for (int i = 0; i < line.Length; ++i)
    {
        if (i < line.Length - 1)
        {   
            string pair = Convert.ToString(line[i]) + Convert.ToString(line[i+1]);
            if (line.Substring(i + 2).Contains(pair))
            {
                hasPair = true;
            }
        }

        if (i < line.Length - 2)
        {
            if (line[i] == line[i + 2])
            {
                hasDouble = true;
            }
        }
    }
    if(hasDouble && hasPair){
        ++solution;
    }
}

Console.WriteLine(solution);