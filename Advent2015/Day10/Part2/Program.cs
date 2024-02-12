string input = "1113222113";

for (int i = 0; i < 50; ++i)
{
    string temp = "";

    for (int j = 0; j < input.Length; ++j)
    {
        int amount = 1;
        string value = Convert.ToString(input[j]);

        if (j < input.Length - 1)
        {
            while (input[j] == input[j + 1])
            {
                ++amount;
                ++j;
            }

        }
        temp += amount + value;
    }
    input = temp;
    Console.WriteLine(i);
}

Console.WriteLine(input.Length);