var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "..", "8input2015.txt"));
int solution = 0;

var lines = File.ReadAllLines(fileName);

foreach (var line in lines)
{
    int lineLength = line.Length;

    int stringLength = lineLength - 2;

    for(int i = 0; i < line.Length - 1; ++i){
        if(line[i] == '\\'){
            if(line[i+1] == '\\' || line[i+1] == '\"'){
                --stringLength;
                ++i;
            } else if (line[i+1] == 'x'){
                stringLength -= 3;
                i += 3;
            }
        }
    }
    solution += lineLength - stringLength;
}

Console.WriteLine(solution);