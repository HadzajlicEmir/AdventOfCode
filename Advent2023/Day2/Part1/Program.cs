var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "input2.txt"));
var counter = 1;
var solution = 0;


//12 red, 13 green, 14 blue

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{
    string line2 = line.Substring(line.IndexOf(":") + 1);
    string[] games = line2.Split(';');
    bool valid = true;
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
            if (int.Parse(idks[0]) > 14)
            {
                valid = false;
            }
            else if (Int32.Parse(idks[0]) == 13 && idks[1] == "red")
            {
                valid = false;
            }
            else if (Int32.Parse(idks[0]) == 14 && idks[1] != "blue")
            {
                valid = false;
            }
           
        }
    
    }
    if (valid == true){
        solution += counter;
    }
    ++counter;
}

Console.WriteLine(solution);