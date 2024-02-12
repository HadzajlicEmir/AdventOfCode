var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "12input2015.txt"));
int solution = 0;

var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{
    for (int i = 1; i < line.Length; ++i)
    {
        char[] value = new char[3];
        bool negative = false;
        int intValue = 0;
        if (Char.IsDigit(line[i]))
        {
            if (line[i - 1] == '-')
            {
                negative = true;
            }
            value[0] = line[i++];
            if (Char.IsDigit(line[i]))
            {
                value[1] = line[i++];
                if (Char.IsDigit(line[i]))
                {
                    value[2] = line[i];
                }
            }
            intValue = int.Parse(string.Join("", value));
            if (negative)
            {
                solution -= intValue;
            }
            else
            {
                solution += intValue;
            }
        }
    }
}

Console.WriteLine(solution);