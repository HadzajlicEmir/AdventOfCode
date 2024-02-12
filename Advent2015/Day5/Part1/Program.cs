var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "5input2015.txt"));

var lines = File.ReadAllLines(fileName);

int solution = 0;

foreach (var line in lines)
{
    bool isNice = false;
    int numberOfVowels = 0;
    bool hasDouble = false;

    for (int i = 0; i < line.Length; ++i)
    {
        if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u')
        {
            ++numberOfVowels;
        }
        if (i != line.Length - 1)
        {
            if (line[i] == line[i + 1])
            {
                hasDouble = true;
            }
        }
    }

    if (hasDouble && numberOfVowels >= 3)
    {
        isNice = true;
    }

    if (line.Contains("ab") || line.Contains("cd") || line.Contains("pq") || line.Contains("xy"))
    {
        isNice = false;
    }
    if (isNice)
    {
        ++solution;
    }
}

Console.WriteLine(solution);