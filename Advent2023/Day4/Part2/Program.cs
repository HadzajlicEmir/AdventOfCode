var fileName = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "input4.txt"));
int solution = 0;
int counter = 0;

var lines = File.ReadAllLines(fileName);
int[] numberOfCards = new int[lines.Length];
Array.Fill(numberOfCards, 1);

foreach(var line in lines){
string line2 = line.Substring(line.IndexOf(":") + 1);
int numberOfMatches = 0;

string[] tickets = line2.Split("|");

for(int i = 0; i < 2; ++i){
    tickets[i] = tickets[i].Trim();
}

string[] numbers1 = tickets[0].Split(" ");
string[] numbers2 = tickets[1].Split(" ");


for(int i = 0; i < numbers1.Length; ++i){
    numbers1[i] = numbers1[i].Trim();
    for(int j = 0; j < numbers2.Length; ++j){
        numbers2[j] = numbers2[j].Trim();
        if(numbers1[i] != "" && numbers2[j] != "" && numbers1[i].Trim() == numbers2[j].Trim()){
            ++numberOfMatches;
        }
    }
}
for(int i = 1; i <= numberOfMatches; ++i){
    numberOfCards[counter + i] += numberOfCards[counter];
}
  ++counter;
}

foreach(var item in numberOfCards){
    solution += item;
}

Console.WriteLine(solution);