var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "input2.txt"));
int solution = 0;

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{   
    int blueHigh = 0;
    int redHigh = 0;
    int greenHigh = 0;
    string line2 = line.Substring(line.IndexOf(":") + 1);
    string[] games = line2.Split(';');
    foreach (string game in games)
    {   
        
        string[] pulls = game.Split(',');

        for (int i = 0; i < pulls.Length; ++i)
        {
            pulls[i] = pulls[i].Trim();
        }

        foreach (var idk in pulls)
        {
            string[] idks = idk.Split(" ");
            //Console.WriteLine(idk);
            if (int.Parse(idks[0]) > greenHigh && idks[1] == "green")
            {
                greenHigh = int.Parse(idks[0]);
            }
            else if (Int32.Parse(idks[0]) > redHigh && idks[1] == "red")
            {
                redHigh = Int32.Parse(idks[0]);
            }
            else if (Int32.Parse(idks[0]) > blueHigh && idks[1] == "blue")
            {
                blueHigh = Int32.Parse(idks[0]);
            }
        }
    }
    solution += (redHigh * greenHigh * blueHigh);
}

Console.WriteLine(solution);